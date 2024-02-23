using System;
using System.Collections;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace remake_project2
{
    public partial class Form1 : Form
    {
        Crc16 c1 = new Crc16(); //crc 클래스 객체
        ArrayList arrSerialbuff = new ArrayList(); // 수신용 List 버퍼 선언
        SerialPort sp = new SerialPort(); // 시리얼 포트 선언

        byte[] writeCRC = new byte[1024]; //TX crc 버퍼         
        byte[] buff = new byte[30];
        byte[] buff2 = new byte[30];

        string hexSt = null;
        static string txBuf = null;

        int ref_V;
        int aveRange;
        int cali_V;
        int cycleTime;
        int result_V;

        bool interuptOn = false;
        bool wideModeOn = false;

        public Form1()
        {
            InitializeComponent();
            this.comboBox_port.DropDown += new System.EventHandler(comboBox_portDropDownEvent); // 콤보 박스가 드롭다운 되도록 해주는 이벤트

        }
        private void comboBox_portDropDownEvent(object sender, EventArgs e)
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
                // 포트가 열린 상태인지 체크      
                if (serialPort1.IsOpen)
                {
                    // 데이터 수신 시 호출되는 이벤트 핸들러
                    int bytesToRead = serialPort1.BytesToRead;
                    // 수신된 데이터를 저장할 바이트 배열 생성
                    byte[] buffer = new byte[bytesToRead];
                    // 시리얼 포트에서 데이터를 읽어와 버퍼에 저장
                    
                    
                    if (bytesToRead > 0)
                    {
                        //  수신버퍼에서 버퍼의 지정된 인덱스 부터 개수 만큼 읽어 온다.   
                        serialPort1.Read(buffer, 0, bytesToRead);
                        
                        if (bytesToRead == 15)
                        {
                            for (int i = 0; i < 15; i++)
                            {
                                buff[i] = buffer[i];
                            }
                            result_V = (buff[3] << 8) | buff[4];
                            resultVolBox.Text = result_V.ToString();

                        }
                        else
                        {
                            Task.Delay(100);
                        }
                        
                    }
                    else
                    {

                    }
                }

                else
                {
                }
            }

            catch (Exception ex)
            {
                // 수신에러 발생시      
                // ArrayList를 클리어한다.         
                //arrSerialbuff.Clear();
                //예외를 던지고 종료     
                throw ex;

            }

            if (InvokeRequired)
            {
                Invoke(new EventHandler(MySerialReceived));
            }

        }


        private void MySerialReceived(object s, EventArgs e)
        {
        }



        //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH//   포트 상태 체크   //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
        public bool IsOpened()
        {
            return sp.IsOpen;
        }

        //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH//  수신 개수 읽기    //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
        public int RcvCnt()
        {
            return arrSerialbuff.Count;
        }
        //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH//  수신버퍼 클리어   //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH     

        public void RcvBuffClear()
        {
            arrSerialbuff.Clear();
        }

        //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH//    포트 닫기   //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
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

        private void start_engine()
        {
            textBox1.Text = "1";
            textBox2.Text = "5";
            textBox3.Text = "1";
            textBox4.Text = "0";
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
                start_engine();
                timer1.Start();

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
                    rxTextBox.Text += "Tx : " + txBuf.Remove(txBuf.Length - 6) + Environment.NewLine;
                    txBuf = null;
                    Task.Delay(100);
                }
                else
                {
                    MessageBox.Show("포트가 닫혀있습니다.");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
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
                result();
            }

            else
            {

            }
        }

        //
        // 프로그램 사용자에게 보여줄 최종 출력값들을 나타내는 함수.
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
            0x00, 0x05
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
            result();
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
                else if (buf >= 256 && buf <= 50000)
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
            result();
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
        // 리셋 기능을 담당하는 함수(default값으로 변환된다)
        //
        private void resetBtn_Click(object sender, EventArgs e)
        {
            interuptOn = true;
            try
            {
                if (serialPort1.IsOpen)
                {
                    _06buf[5] = 0x01;
                    _06buf[3] = 0x05;
                    _06buf[4] = 0x00;
                }
            }
            catch (FormatException)
            {
                // 형식이 올바르지 않은 경우에 대한 처리
                MessageBox.Show("Error");
            }

            SerialPort_Write(_06buf);
            Task.Delay(1000);
            interuptOn = false;
        }

        /*
        // 엑셀 저장 함수

        private void excel_process()
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true; // 엑셀 창 표시 여부

            // Workbook 열기 (기존 파일 열기)
            Excel.Workbook workbook = excelApp.Workbooks.Open(@"C:\Path\To\Your\yyyyMMdd.xlsx");

            // 현재 날짜를 기준으로 시트 이름 생성
            string sheetName = DateTime.Now.ToString("yyyyMMdd");

            // Workbook에 해당 이름의 시트가 없으면 새로 생성
            Excel.Worksheet sheet = null;
            try
            {
                sheet = workbook.Sheets[sheetName] as Excel.Worksheet;
            }
            catch (Exception)
            {
                sheet = workbook.Sheets.Add(Type.Missing, workbook.Sheets[workbook.Sheets.Count], 1, Excel.XlSheetType.xlWorksheet) as Excel.Worksheet;
                sheet.Name = sheetName;
            }

            // Rx, Tx 데이터를 시트에 추가
            AddDataToSheet(sheet, "Rx Data", "Tx Data");

            // Workbook 저장
            workbook.Save();

            // Workbook 닫기
            workbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();

            // COM 오브젝트 해제
            System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }



        static void AddDataToSheet(Excel.Worksheet sheet, string rxData, string txData)
        {
            // 데이터를 추가할 마지막 행 찾기
            int lastRow = sheet.Cells[sheet.Rows.Count, 1].End(Excel.XlDirection.xlUp).Row + 1;

            // 데이터 추가
            sheet.Cells[lastRow, 1] = DateTime.Now.ToString("HH:mm:ss");
            sheet.Cells[lastRow, 2] = rxData;
            sheet.Cells[lastRow, 3] = txData;
        }
        */


        /*
        static void Main()
        {
            // 엑셀 애플리케이션 시작
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true; // 엑셀 창 표시

            // 새 워크북 생성
            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = workbook.Worksheets[1];

            // 항목 작성
            worksheet.Cells[1, 1].Value = "날짜";
            worksheet.Cells[1, 2].Value = "시간";
            worksheet.Cells[1, 3].Value = "Tx";
            worksheet.Cells[1, 4].Value = "RX";

            // 데이터 작성 및 업데이트
            UpdateData(worksheet);

            // 엑셀 파일 저장
            string filePath = $"Data_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            workbook.SaveAs(Path.Combine(Directory.GetCurrentDirectory(), filePath));

            // 메모리 해제
            workbook.Close();
            excelApp.Quit();
        }

        static void UpdateData(Worksheet worksheet)
        {
            int row = 2; // 데이터 시작 행

            while (true)
            {
                // 현재 날짜 및 시간 데이터 가져오기
                DateTime now = DateTime.Now;
                string currentDate = now.ToString("yyyy-MM-dd");
                string currentTime = now.ToString("HH:mm:ss");

                // Tx 및 Rx 데이터 가져오기 (임의의 값으로 대체)
                string txData = "TxData";
                string rxData = "RxData";

                // 데이터 작성
                worksheet.Cells[row, 1].Value = currentDate;
                worksheet.Cells[row, 2].Value = currentTime;
                worksheet.Cells[row, 3].Value = txData;
                worksheet.Cells[row, 4].Value = rxData;

                // 1초 대기
                System.Threading.Thread.Sleep(1000);

                // 행 증가
                row++;
            }
        }
        */



        //
        // 윈도우 사이즈 조절 함수
        //
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!wideModeOn)
            {
                this.Size = new System.Drawing.Size(820, 350);
                wideModeOn = true;
            }
            else
            {
                this.Size = new System.Drawing.Size(352, 266);
                wideModeOn = false;
            }
        }

        private void rxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}