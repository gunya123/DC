using System;
using System.Collections;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace remake_project2
{
    public partial class Form1 : Form
    {
        Crc16 c1 = new Crc16(); //crc 클래스 객체
        ArrayList arrSerialbuff = new ArrayList(); // 수신용 List 버퍼 선언
        SerialPort sp = new SerialPort(); // 시리얼 포트 객체
        bool serialPort_setting = false; //포트 세팅 적용을 알리는 flag
        bool serialOpenCheck = false; //포트 Open 상태 flag
        byte[] writeCRC = new byte[1024]; //TX crc 버퍼
        byte[] data = new byte[255];
        //port setting
        string port; //포트 이름
        int baud_rate;
        int data_bit;

        int bytesToRead = 1; // 1개씩 바이트를 읽어오도록 시킨다.

        static string txBuf = null;
        bool allowSavingFile = false; //파일 저장 On/Off flag
        bool logOn = true; // 로그창에 데이터 표시를 제어한다.
        bool flag = false; // RX의 while문을 제어한다.
        float result_V;
        string[] resultValue = new string[5];
        string fileName; //엑셀 저장 파일 이름
        int saveDataCnt = 0; //엑셀에 저장한 데이터 행 카운트
        int saveDataSettingNum = 10000; //한 파일 당 최대 저장 행 개수

        int cnt = 0; // RX를 신호를 위한 cnt를 초기화
        bool interuptOn = false;
        bool wideModeOn = false;
        string excelFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Voltage_Data");

        public Form1()
        {
            InitializeComponent();
            this.comboBox_port.DropDown += new System.EventHandler(comboBox_portDropDownEvent); // 콤보 박스가 드롭다운 되도록 해주는 이벤트

            rxTextBox.ScrollBars = ScrollBars.Vertical;
            rxTextBox.TextChanged += TextBox_TextChanged;

            Controls.Add(rxTextBox);

            try
            {
                DirectoryInfo di = new DirectoryInfo(excelFolderPath);
                if (!di.Exists)
                {
                    di.Create();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Make-Excel");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // 텍스트가 변경될 때마다 스크롤을 맨 아래로 이동
            rxTextBox.SelectionStart = rxTextBox.Text.Length;
            rxTextBox.ScrollToCaret();
        }

        //
        // 시리얼 포트 열기 
        //
        private void button6_Click_1(object sender, EventArgs e)
        {

            if (comboBox_port.Text == null)
            {
                MessageBox.Show("포트를 선택해 주세요");
            }

            else if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBox_port.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8; // 우리가 총 8개의 비트를 보내기 때문에 8로 지정.
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //이것이 꼭 필요하다

                serialPort1.Open();  //시리얼포트 열기
                pictureBox1.Image = Properties.Resources.GreenLED_;
                start_engine();
                timer1.Start();
                Save_File();
                saveTimer.Start();
                label_status.Text = "포트가 열렸습니다";
                comboBox_port.Enabled = false;  //COM포트설정 콤보박스 비활성화
            }

            else //시리얼포트가 열려 있으면
            {
                label_status.Text = "포트가 이미 열려 있습니다.";
            }
        }

        //
        // 시리얼 포트 닫기
        //
        private void button7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)  //시리얼포트가 열려 있으면
            {
                timer1.Stop();
                serialPort1.Close();  //시리얼포트 닫기

                label_status.Text = "포트가 닫혔습니다.";
                comboBox_port.Enabled = true;  //COM포트설정 콤보박스 활성화
                pictureBox1.Image = Properties.Resources.GrayLED;

            }
            else  //시리얼포트가 닫혀 있으면
            {
                label_status.Text = "포트가 이미 닫혀 있습니다.";
            }
        }


        //
        // 시리얼포트 데이터+CRC 송신
        //
        private void SerialPort_Write(byte[] writeBuffer) //SerialPort 송신 함수
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    writeCRC = c1.crc16(writeBuffer, 6); //CRC 계산
                    serialPort1.Write(writeBuffer, 0, 6); //데이터 전송
                    serialPort1.Write(writeCRC, 0, 2); //CRC 전송

                    DisplayPacket(writeBuffer);
                    DisplayPacket(writeCRC);

                    if (logOn == true)
                    {
                        rxTextBox.Text += "Tx : " + txBuf.Remove(txBuf.Length - 6) + Environment.NewLine; // $"{DateTime.Now:yy.MM.dd_HH:mm:ss tt}" + 
                    }

                    txBuf = null;
                }
                else
                {
                    MessageBox.Show("포트가 닫혀있습니다.");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("d");
            }
        }

        public void comboBox_portDropDownEvent(object sender, EventArgs e)
        {
            this.comboBox_port.Items.Clear();
            string[] serial_list = SerialPort.GetPortNames();

            if (this.comboBox_port.Items.Count > 0)
            {
                this.comboBox_port.SelectedIndex = 0;
            }

            foreach (string name in serial_list)
            {
                this.comboBox_port.Items.Add(name);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) //SerialPort Thread 와 메인 Thread 충돌 회피를 위한 Invoke 함수
        {
            try
            {
                // 시리얼 포트에서 데이터를 읽어올 버퍼
                byte[] _SPbuffer = new byte[bytesToRead]; // 1칸짜리 바이트를 만든다.
                flag = true;
                while (flag)
                {


                    // 시리얼 포트에서 데이터 읽기
                    int bytesRead = serialPort1.Read(_SPbuffer, 0, bytesToRead); // 1칸짜리 바이트에 읽은 데이터를 순서대로 집어넣는다.
                                                                                 // byteRead는 읽었다면 1이라 표시 된다.

                    
                    // 읽은 데이터를 배열에 추가
                    data[cnt] = _SPbuffer[0];
                    cnt++;
                    textBox5.Text = cnt.ToString();
                    // 패킷 조건 확인
                    if (data[1] == 0x03 && cnt == 15)
                    {
                        float[] result_V = new float[5];

                        // 03 패킷의 처리
                        byte[] truncatedArray = data.Take(cnt).ToArray();
                        for( int i = 0; i < 5; i++)
                        {
                            result_V[i] = (data[2*i+3] << 8) | data[2*i+4];
                        }
                        resultValue[0] = (result_V[0] / 1000.0f).ToString();
                        resultValue[1] = (result_V[1] + 1.0f).ToString();
                        resultValue[2] = (result_V[2] / 1000.0f).ToString();
                        resultValue[3] = (result_V[3] + 1.0f).ToString();
                        resultValue[4] = result_V[4].ToString();
                        
                        textBox6.Text = resultValue[2];
                        textBox7.Text = resultValue[3];
                        if (textBox1.Text != resultValue[1])
                        {
                            pictureBox2.Image = Properties.Resources.RedLED;
                        }
                        else
                        {
                            pictureBox2.Image = Properties.Resources.GreenLED_;
                        }

                        if (textBox2.Text != resultValue[2])
                        {
                            pictureBox3.Image = Properties.Resources.RedLED;
                        }
                        else
                        {
                            pictureBox3.Image = Properties.Resources.GreenLED_;
                        }

                        if (textBox3.Text != resultValue[3])
                        {
                            pictureBox4.Image = Properties.Resources.RedLED;
                        }
                        else
                        {
                            pictureBox4.Image = Properties.Resources.GreenLED_;
                        }

                        if (textBox4.Text != resultValue[4])
                        {
                            pictureBox5.Image = Properties.Resources.RedLED;
                        }
                        else
                        {
                            pictureBox5.Image = Properties.Resources.GreenLED_;
                        }
                        
                        resultVolBox.Text = resultValue[0];
                        ProcessPacket(truncatedArray);
                        cnt = 0;  // 카운트 초기화
                        flag = false;
                    }

                    else if (data[1] == 0x06 && cnt == 8)
                    {
                        // 06 패킷의 처리
                        byte[] truncatedArray = data.Take(cnt).ToArray();
                        ProcessPacket(truncatedArray);
                        cnt = 0;  // 카운트 초기화
                        flag = false;
                    }

                    else
                    {
                        if (cnt > 15)
                        {
                            byte[] data = new byte[255];
                            cnt = 0;
                            flag = false;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // 수신에러 발생시      
                // ArrayList를 클리어한다.         
                //arrSerialbuff.Clear();

                //예외를 던지고 종료     
                Console.WriteLine(ex);

            }

            if (InvokeRequired)
            {
                Invoke(new EventHandler(MySerialReceived));
            }

        }

        private void ProcessPacket(byte[] packet)
        {
            if (logOn == true)
            {
                string resultRx = BitConverter.ToString(packet).Replace("-", " ");
                rxTextBox.Text += "Rx : " + $"{resultRx}" + Environment.NewLine;// $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss tt}" + 
            }
        }

        private void MySerialReceived(object s, EventArgs e)
        {
        }

        //
        //   포트 상태 체크   
        //
        public bool IsOpened()
        {
            return sp.IsOpen;
        }

        //
        //  수신 개수 읽기    
        //
        public int RcvCnt()
        {
            return arrSerialbuff.Count;
        }


        //
        //  수신버퍼 클리어   
        //     

        public void RcvBuffClear()
        {
            arrSerialbuff.Clear();
        }


        //
        //    포트 닫기   
        //
        public void CloseSerialComm()
        {
            try
            {
                if (sp != null)
                    sp.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        // 포트 연결시 초기값 세팅
        //
        private void start_engine()
        {
            textBox1.Text = "1";
            textBox2.Text = "5";
            textBox3.Text = "1";
            textBox4.Text = "0";
        }



        static void DisplayPacket(byte[] packet)
        {
            foreach (byte b in packet)
            {
                txBuf += ($"{b:X2} "); // 띄어쓰기를 해줘야 예쁘게 출력됨 
            }
        }

        //
        // 타이머 동작 ( 지정된 주기마다 03번 신호를 보낸다)
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!interuptOn)
            {
                //sp.SendSerialComm(_sendBuf, 6);             
                SerialPort_Write(_sendBuf);
                Task.Delay(130);
            }

            else
            {

            }
        }

        //
        // 프로그램 사용자에게 보여줄 최종 출력값.
        //
        private void result()
        {
            resultVolBox.Text = result_V.ToString();
        }

        //
        // 03번으로 요청하는 데이터 패킷
        //
        byte[] _sendBuf =
        {
            0x01,
            0x03,
            0x00, 0x00,
            0x00, 0x05,
        };

        //
        // 06번으로 지시하는 데이터 패킷
        //
        byte[] _06buf =
        {
            0x01,
            0x06,
            0x00, 0x00,
            0x00, 0x0A
        };

        //
        // 측정값이 업데이트 되는 주기를 처리하는 함수
        //
        private void button1_Click(object sender, EventArgs e)
        {
            interuptOn = true;
            try
            {
                int buf = int.Parse(textBox1.Text) - 1;
                if (buf >= 0 && buf <= 4)
                {
                    _06buf[5] = (byte)buf;
                    _06buf[3] = 0x01;
                    _06buf[4] = 0x00;

                }
                else
                {
                    // 범위를 벗어난 경우에 대한 처리
                    MessageBox.Show("입력값은 1부터 5까지의 자연수 범위여야 합니다.");
                }
            }
            catch (FormatException)
            {
                // 형식이 올바르지 않은 경우에 대한 처리
                MessageBox.Show("숫자 형식이 아닙니다.");
            }

            SerialPort_Write(_06buf);
            Task.Delay(1000);
            interuptOn = false;
        }

        //
        // 작성받은 Ref.Voltage를 처리하는 함수
        //
        private void button2_Click(object sender, EventArgs e)
        {
            interuptOn = true;
            try
            {
                float preBuf = float.Parse(textBox2.Text) * 1000.0f;
                int buf = Convert.ToInt32(preBuf);
                if (buf >= 10 && buf <= 255)
                {
                    _06buf[5] = (byte)buf;
                    _06buf[3] = 0x02;
                    _06buf[4] = 0x00;
                }
                // 16비트로 두개의 패킷이 필요한 경우를 위한 조건
                else if (buf >= 256 && buf <= 5000)
                {
                    byte lowByte = (byte)(buf & 0xFF);         // 하위 8비트 (최하위 바이트)
                    byte highByte = (byte)((buf >> 8) & 0xFF);
                    _06buf[5] = lowByte;
                    _06buf[3] = 0x02;
                    _06buf[4] = highByte;
                }
                else
                {
                    // 범위를 벗어난 경우에 대한 처리
                    MessageBox.Show("입력값은 0.1V부터 5V까지 범위여야 합니다.");
                }
            }
            catch (FormatException)
            {
                // 형식이 올바르지 않은 경우에 대한 처리
                MessageBox.Show("숫자 형식이 아닙니다.");
            }

            SerialPort_Write(_06buf);
            Task.Delay(1000);
            interuptOn = false;
        }

        //
        // 작성받은 평균범위를 처리하는 함수
        //
        private void button3_Click(object sender, EventArgs e)
        {
            interuptOn = true;
            try
            {
                int buf = int.Parse(textBox3.Text) - 1;
                if (buf >= 0 && buf < 100)
                {
                    _06buf[5] = (byte)buf;
                    _06buf[3] = 0x03;
                    _06buf[4] = 0x00;
                }
                else
                {
                    // 범위를 벗어난 경우에 대한 처리
                    MessageBox.Show("입력값은 1부터 100까지의 자연수 범위여야 합니다.");
                }
            }
            catch (FormatException)
            {
                // 형식이 올바르지 않은 경우에 대한 처리
                MessageBox.Show("숫자 형식이 아닙니다.");
            }

            SerialPort_Write(_06buf);
            Task.Delay(1000);
            interuptOn = false;
        }
        //
        // 작성받은 캘리브레이션을 처리하는 함수
        //
        private void button4_Click(object sender, EventArgs e)
        {
            interuptOn = true;
            try
            {
                int buf = int.Parse(textBox4.Text);
                if (buf >= 0 && buf <= 10)
                {
                    _06buf[5] = (byte)buf;
                    _06buf[3] = 0x04;
                    _06buf[4] = 0x00;
                }
                else if (buf < 0 && buf >= -10)
                {
                    _06buf[5] = (byte)buf;
                    _06buf[3] = 0x04;
                    _06buf[4] = 0x01;
                }
                else
                {
                    // 범위를 벗어난 경우에 대한 처리
                    MessageBox.Show("입력값은 1부터 10까지의 정수 범위여야 합니다.");
                }
            }
            catch (FormatException)
            {
                // 형식이 올바르지 않은 경우에 대한 처리
                MessageBox.Show("숫자 형식이 아닙니다.");
            }

            SerialPort_Write(_06buf);
            Task.Delay(1000);
            interuptOn = false;
        }

        //
        // 윈도우 사이즈 조절 함수 - 버튼을 클릭하면 변화한다.
        //
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!wideModeOn)
            {
                this.Size = new System.Drawing.Size(750, 350);
                wideModeOn = true;
            }
            else
            {
                this.Size = new System.Drawing.Size(352, 266);
                wideModeOn = false;
            }
        }

        //
        // 엑셀 파일 생성 함수
        //
        private void Save_File() 
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            string fName = Path.Combine(excelFolderPath, $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss tt}.csv"); //경로 지정과 날짜, 시간으로 구성된 파일 이름 설정
            saveFile.FileName = fName;
            fileName = saveFile.FileName.ToString();

            StreamWriter sw = File.AppendText(fileName); //.csv 파일 생성
            sw.WriteLine($"TIME, Module Voltage, Ref.V, Calibration"); //첫번째 행 항목 지정  

            sw.Close();
            allowSavingFile = true;
        }

        //
        // 데이터를 엑셀에 저장시키는 함수 - 출력값, 캘리, Ref.V 및 시간을 저장한다.
        //
        private void Write_Data_Excel() 
        {
            String data_time = DateTime.Now.ToString("HH:mm:ss");

            if (saveDataCnt >= saveDataSettingNum) //지정한 행 초과 시 새로운 파일 생성
            {
                saveDataCnt = 0;
                allowSavingFile = false;
                Save_File();
            }
            try
            {
                StreamWriter sw = File.AppendText(fileName);
                sw.WriteLine($"{data_time}, {(resultVolBox.Text)}, {(textBox2.Text)}, {(textBox4.Text)}");
                sw.Close();
            }
            catch (Exception)
            {
            }

            saveDataCnt++;
        }

        //
        // 엑셀 저장을 위한 타이머. 1초마다 저장 실행한다.
        //
        private void saveTimer_Tick(object sender, EventArgs e)
        {
            if (allowSavingFile == true)
            {
                Write_Data_Excel();
            }
        }

        //
        // Log창 실행 기능
        //
        private void startBtn_Click(object sender, EventArgs e)
        {
            logOn = true;
        }

        //
        // Log창 중지 기능
        //
        private void exitBtn_Click(object sender, EventArgs e)
        {
            logOn = false;
        }

        //
        // Log창 데이터 지우기 기능
        //
        private void clearBtn_Click(object sender, EventArgs e)
        {
            rxTextBox.Clear();
        }

        //
        // Log창 내역 저장 기능
        //
        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*"; // $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss tt}.csv"
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 선택된 파일 경로
                string filePath = saveFileDialog1.FileName;

                // 텍스트 박스의 내용을 파일에 저장
                File.WriteAllText(filePath, rxTextBox.Text);

                MessageBox.Show("파일이 저장되었습니다.");
            }
        }


        //
        // 리셋 기능을 담당하는 함수(default값으로 변환된다)
        //
        private void resetBtn_Click_1(object sender, EventArgs e)
        {
            interuptOn = true;
            try
            {
                if (serialPort1.IsOpen)
                {
                    _06buf[5] = 0x00;
                    _06buf[3] = 0x05;
                    _06buf[4] = 0x00;
                }
            }
            catch (Exception)
            {
                // 형식이 올바르지 않은 경우에 대한 처리
                MessageBox.Show("Error");
            }

            SerialPort_Write(_06buf);
            Task.Delay(1000);
            interuptOn = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)intervalNumericUpDown.Value;
        }
       
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}