using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MODBUS_BASIC_FORM
{
    public partial class adress06 : Form
    {
        SerialPortSetting SP = new SerialPortSetting();
        Crc16 c1 = new Crc16(); //crc 클래스 객체
        Log logForm = new Log();
        static string txBuf = null;
        byte[] writeCRC = new byte[1024]; //TX crc 버퍼
        byte[] _SPbuffer = new byte[255];
        //port setting
        string port; //포트 이름
        int baud_rate;
        int data_bit;
        int count = 0;
        bool serialPort_setting = false; //포트 세팅 적용을 알리는 flag
        bool serialOpenCheck = false; //포트가 열렸는지 확인하는 flag
        bool flag = false; // RX의 while문을 제어한다.
        bool idle = true; // 대기상태인가?(아무것도 하고 있지 않는 상태)
        bool isTimerActive = false; // 응답대기 타이머가 돌고 있는가?
        bool flag03 = false;
        bool flag04 = false;
        bool flag06 = false;
        bool print_comLog = true;
        bool firstMakeView = false;

        static int start = 0;
        private DataGridView[] dataGridViews;
        private System.Windows.Forms.GroupBox[] groupBoxes; // 그룹박스 배열 선언

        int error = 0;
        int numReceviedData = 0;
        int waitCnt = 0;
        int cellCnt = 0;
        int cnt = 0; // RX를 신호를 위한 cnt를 초기화
        int cntRead = 0;
        int responseCnt = 0;
        int[] dataValue = new int[1024];
        int id = 1;
        int skipRange = 0;
        int maxValue = 0;
        int length = 15;
        int numOfColumn = 0;
        int quantity;
        int remainder = 0;
        int minRange = 0;
        int maxRange = 0;
        int changeValue = 0;
        int result;
        int slaveBuf = 0;
        int numOfslave = 1;
        int totalRange;

        //엑셀 관련 변수들.
        string fileName; //엑셀 저장 파일 이름
        int saveDataCnt = 0; //엑셀에 저장한 데이터 행 카운트
        int saveDataSettingNum = 10000; //한 파일 당 최대 저장 행 개수
        bool allowSavingFile = false; //파일 저장 On/Off flag
        string excelFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "3 kinds of slaveData");

        byte[] _send03Buf =
        {
            0x01,
            0x03,
            0x00, 0x00,
            0x00, 0x0A,
        };

        byte[] _send04Buf =
        {
            0x01,
            0x04,
            0x00, 0x00,
            0x00, 0x0A,
        };

        byte[] _send06Buf =
        {
            0x01,
            0x06,
            0x00, 0x01,
            0x00, 0xAA
        };

        // 03번 버퍼의 시작위치, 길이를 변경하는 함수
        private void buffer_changer(int length, int startPoint)
        {
            _send03Buf[3] = (byte)startPoint;
            _send03Buf[5] = (byte)length;
        }

        public adress06()
        {
            InitializeComponent();
            listView1.DoubleClick += listView1_DoubleClick;
            logForm.form2LogBox.TextChanged += logBox_TextChanged;

            // 엑셀을 저장할 새폴더를 만드는 함수
            try
            {
                DirectoryInfo di = new DirectoryInfo(excelFolderPath);
                if (!di.Exists)
                {
                    di.Create();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Make-Excel");
            }
        }

        //        for(int cnt = 0; cnt<numOfslave; cnt++)
        //                {
        //                    int start = 0;
        //        client.UnitIdentifier = (byte) (1 + cnt);
        //                    vals = client.ReadHoldingRegisters(0, 10); // (x, y) = x번 부터 시작해서, y개를 가져와라

        //                    // dataGridViews[cnt]의 각 행마다 어떤 작업을 할 것인가
        //                    foreach (DataGridViewRow row in dataGridViews[cnt].Rows)
        //                    {
        //                        row.Cells[dataGridViews[cnt].Columns.Count - 1].Value = vals[start];
        //                        start++;
        //                        if (start == 10)
        //                            break;
        //                    }
        //}


        // 변수들을 사용하기 좋게 1차 가공해서 계산해주는 함수.
        private void calculateAllVar()
        {
            minRange = start / length;
            maxRange = (start + quantity) / length;
            numOfColumn = (quantity - start) / length;
            remainder = (quantity + start) % length;
            maxValue = start + quantity;
            skipRange = start % length;
            changeValue = Convert.ToInt32(maxValueBox.Text);
            _send06Buf[3] = (byte)Convert.ToInt32(rowNum.Text);
        }
        // 에제 데이터
        /*
        private void examplePacket()
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                dataValue[i] = i;
            }
        }
        */

        private void logBox_TextChanged(object sender, EventArgs e)
        {
            // 텍스트가 변경될 때마다 스크롤을 맨 아래로 이동
            logForm.form2LogBox.SelectionStart = logForm.form2LogBox.Text.Length;
            logForm.form2LogBox.ScrollToCaret();
        }


        private void SerialPort_Write(byte[] writeBuffer, byte slaveId) //SerialPort 송신 함수
        {
            try
            {
                responseTimer.Start();
                
                writeBuffer[0] = slaveId;
                id = (int)slaveId;
                writeCRC = c1.crc16(writeBuffer, 6); //CRC 계산
                serialPort1.Write(writeBuffer, 0, 6); //데이터 전송
                serialPort1.Write(writeCRC, 0, 2); //CRC 전송

                DisplayPacket(writeBuffer);
                DisplayPacket(writeCRC);
                if (logForm.print_comLog)
                {
                    logForm.form2LogBox.Text += "Tx : " + txBuf.Remove(txBuf.Length - 6) + Environment.NewLine;
                }

                txBuf = null;
            }
            catch (Exception)
            {
                error_Messeage("쓰기 오류");
            }
        }

        static void DisplayPacket(byte[] packet)
        {
            foreach (byte b in packet)
            {
                txBuf += ($"{b:X2} "); // 띄어쓰기를 해줘야 예쁘게 출력됨 
            }
        }

        // 응답대기 타이머 함수
        private void responseTimer_Tick(object sender, EventArgs e)
        {
            responseCnt++;
            if (responseCnt >= 15)
            {
                error_Messeage("응답 시간 초과");
                responseCnt = 0;
                responseTimer.Stop();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) //SerialPort Thread 와 메인 Thread 충돌 회피를 위한 Invoke 함수
        {
            responseCnt = 0;
            //receiveBox.Text = "받기 시작";
            responseTimer.Stop();

            if (InvokeRequired)
            {
                Invoke(new EventHandler(MySerialReceived));
            }
        }

        //
        // 받은 데이터를 처리하는 곳 
        //
        private void MySerialReceived(object s, EventArgs e)
        {
            try
            {
                while (true)
                {
                    if (flag06)
                    {
                        cnt = 0;
                        numReceviedData = 0;
                        requestProcesser(8);
                        flag06 = false;
                        idle = true;
                        break;
                    }
                    else if (flag03)
                    {
                        cnt = 0;
                        numReceviedData = 0;
                        requestProcesser(25);
                        flag03 = false;
                        idle = true;
                        break;
                    }

                    else
                    {
                        error++;
                        errorBox.Text = error.ToString();
                        errorBoxCon.Text = "MyReceived 에러";
                        idle = true;
                        flag03 = false;
                        flag06 = false;
                        break;
                    }
                }

            }

            catch (Exception)
            {
                error_Messeage("받기 오류");
                idle = true;
            }

        }

        private void requestProcesser(int range)
        {
            while (true)
            {
                numReceviedData = numReceviedData + serialPort1.BytesToRead;
                serialPort1.Read(_SPbuffer, cnt, 1);
                cnt++;
                if (cnt > 1)
                {
                    if (_SPbuffer[1] == 0x03 || _SPbuffer[1] == 0x06)
                    {
                        if (cnt >= range)
                        {
                            numReceviedData = numReceviedData - range;
                            cnt = cnt - range;
                            if (flag03)
                            {
                                textBox_data_renew(range, _SPbuffer, id);
                            }
                            byte[] truncatedArray = _SPbuffer.Take(range).ToArray();
                            ProcessPacket(truncatedArray);
                            break;
                        }
                    }
                    else
                    {
                        if (flag03)
                        {
                            error_Messeage("03 Receive 에러");
                            int remove = serialPort1.BytesToRead;
                            serialPort1.Read(_SPbuffer, cnt, remove);
                            byte[] truncatedArray = _SPbuffer.Take(remove + 2).ToArray();
                            ProcessPacket(truncatedArray);
                            break;
                        }
                        else if (flag04)
                        {
                            error_Messeage("04 Receive 에러");
                            int remove = serialPort1.BytesToRead;
                            serialPort1.Read(_SPbuffer, cnt, remove);
                            byte[] truncatedArray = _SPbuffer.Take(remove + 2).ToArray();
                            ProcessPacket(truncatedArray);
                            break;
                        }
                        else
                        {
                            error_Messeage("06 Receive 에러");
                            int remove = serialPort1.BytesToRead;
                            serialPort1.Read(_SPbuffer, cnt, remove);
                            byte[] truncatedArray = _SPbuffer.Take(remove + 2).ToArray();
                            ProcessPacket(truncatedArray);
                            break;
                        }
                    }
                }
            }
        }

        private void textBox_data_renew(int textBoxNum, byte[] buffer, int slaveId) // 
        {
            switch (slaveId)
            {
                case 1:
                    listView1.Items.Clear();
                    for (cellCnt = 0; cellCnt < (textBoxNum - 5) / 2; cellCnt++)
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString((buffer[cellCnt * 2 + 3] << 8) + (buffer[cellCnt * 2 + 4]))); // 각 행의 첫 번째 열에 행 번호를 표시하는 문자열 생성
                        listView1.Items.Add(item); // 리스트뷰에 행 추가
                    }
                    break;
                case 2:
                    listView2.Items.Clear();
                    for (cellCnt = 0; cellCnt < (textBoxNum - 5) / 2; cellCnt++)
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString((buffer[cellCnt * 2 + 3] << 8) + (buffer[cellCnt * 2 + 4]))); // 각 행의 첫 번째 열에 행 번호를 표시하는 문자열 생성
                        listView2.Items.Add(item); // 리스트뷰에 행 추가
                    }
                    break;
                case 3:
                    listView3.Items.Clear();
                    for (cellCnt = 0; cellCnt < (textBoxNum - 5) / 2; cellCnt++)
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString((buffer[cellCnt * 2 + 3] << 8) + (buffer[cellCnt * 2 + 4]))); // 각 행의 첫 번째 열에 행 번호를 표시하는 문자열 생성
                        listView3.Items.Add(item); // 리스트뷰에 행 추가
                    }
                    break;

                default:
                    break;
            }


        }


        private void error_Messeage(string msg)
        {
            errorBoxCon.Text = msg;
            error++;
            errorBox.Text = error.ToString();
        }

        private void ProcessPacket(byte[] packet)
        {
            string resultRx = BitConverter.ToString(packet).Replace("-", " ");
            if (logForm.print_comLog)
            {
                logForm.form2LogBox.Text += "Rx : " + $"{resultRx}" + Environment.NewLine;
            }
        }

        private void packet06_changer(int data)
        {
            if (data > 255)
            {
                byte[] byteData = BitConverter.GetBytes(data);
                _send06Buf[4] = byteData[1];
                _send06Buf[5] = byteData[0];
            }
            else
            {
                _send06Buf[4] = 0x00;
                _send06Buf[5] = (byte)data;
            }
        }

        /*
    
        private void request04_Click(object sender, EventArgs e)
        {
            try
            {
                if (idle == true && serialPort1.IsOpen)
                {
                    idle = false;
                    flag04 = true;

                    SerialPort_Write(_send04Buf);
                }
                else if (!serialPort1.IsOpen)
                {
                    error_Messeage("시리얼 포트 닫힘");
                }

                else
                {
                    error_Messeage("대기 상태 아님");
                }
            }
            catch
            {
                error_Messeage("04 Send Error");
            }
        }
        */


        private void timer06Stop_Click(object sender, EventArgs e)
        {
            if (cntReadTimer.Enabled)
            {
                cntReadTimer.Stop();
            }
            else
            {
                cntReadTimer.Start();
            }
        }

        //응답 대기 타이머. 0.15초의 대기 시간을 가진다.
        private void timerWait_Tick(object sender, EventArgs e)
        {
            isTimerActive = true;
            if (waitCnt < 1)
            {
                waitCnt++;
            }
            else
            {
                waitCnt = 0;
                timerWait.Stop();
                isTimerActive = false;
            }
        }

        private void CF_FormSendEvent(bool CF_print_comLog) //ComLogForm Send Event
        {
            print_comLog = CF_print_comLog;
        }

        private void SF_FormSendEvent(string SF_port, int SF_baud_rate, int SF_data_bit, bool SF_serialPort_setting) //SerialSettingForm Send Event
        {
            port = SF_port;
            baud_rate = SF_baud_rate;
            data_bit = SF_data_bit;
            serialPort_setting = SF_serialPort_setting;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color firstColor = System.Drawing.ColorTranslator.FromHtml("#09203f");
            Color SecontColor = System.Drawing.ColorTranslator.FromHtml("#537895");
            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, firstColor, SecontColor, 45, false);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }

        //Log 파일 생성
        private void Log(string message)
        {
            try
            {
                string logFilePath = "log.txt";
                string logTime = DateTime.Now.ToString();
                string logMessage = $"{logTime} - {message}";

                using (StreamWriter sw = File.AppendText(logFilePath))
                {
                    sw.WriteLine(logMessage);
                }
            }
            catch
            {
            }
        }

        private void Show_MessageBox(string message, string caption) //스레드 사용하는 메세지 박스
        {
            Thread t = new Thread(() => MessageBox.Show(message, caption));
            t.Start();
        }

        private void Show_ErrorMessageBox(Exception ex) //스레드 사용하는 에러메세지 박스
        {
            Thread t = new Thread(() => MessageBox.Show(ex.Message));
            t.Start();
        }

        private void screen04_Click(object sender, EventArgs e)
        {

        }

        private void 로그확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logForm.logTextEvent += new Log.logText(CF_FormSendEvent);
            logForm.Show();
        }

        private void 포트설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SP.SettingFormSendEvent += new SerialPortSetting.FormSendDataHandler(SF_FormSendEvent);
            SP.StartPosition = FormStartPosition.Manual; SP.Location = new Point(60, 60);
            SP.ShowDialog();

            try
            {
                if (!serialPort_setting) //flag off 시 return
                { return; }

                if (SP.comboBox.Text == "") //잡은 포트 없을 시 return
                { return; }

                if (serialPort1.IsOpen) //포트가 열려있을 때 버튼 누르면 포트 닫기
                {
                    serialPort1.Close();
                    cntReadTimer.Stop();
                    serialOpenCheck = false;
                    //serialPort1.DataReceived -= new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                }
                else
                {
                    serialPort1.PortName = port; //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                    serialPort1.BaudRate = baud_rate;  //보레이트 변경이 필요하면 숫자 변경하기
                    serialPort1.DataBits = data_bit;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //Invoke한 데이터 Receive
                    serialPort1.Open();
                    cntReadTimer.Start();
                    Save_File();
                    saveExcelTimer.Start();
                    serialOpenCheck = true;

                    Show_MessageBox("설정값으로 포트 오픈.", "알림");
                }

                SP.portConnect.Text = serialPort1.IsOpen ? "포트 닫기" : "포트 연결"; //포트 상태에 따라 버튼 바꿈
                writeBox.Text = serialPort1.IsOpen ? "Connected" : "Disconnected";
                writeBox.ForeColor = serialPort1.IsOpen ? Color.Lime : Color.Red;
                SP.comboBox.Enabled = !serialPort1.IsOpen; //포트 닫혀 있을 때 포트 설정 변경 가능
                SP.baudRateBox.Enabled = !serialPort1.IsOpen;
                SP.dataBitsBox.Enabled = !serialPort1.IsOpen;
                SP.stopBitBox.Enabled = !serialPort1.IsOpen;
                SP.parityBox.Enabled = !serialPort1.IsOpen;
            }
            catch (Exception ex)
            {
                Show_ErrorMessageBox(ex);
            }
            finally
            {
                serialPort_setting = false;
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        //private void panel1_Paint_1(object sender, PaintEventArgs e)
        //{
        //    Color firstColor = System.Drawing.ColorTranslator.FromHtml("#09203f");
        //    Color SecontColor = System.Drawing.ColorTranslator.FromHtml("#537895");
        //    LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, firstColor, SecontColor, 45, false);
        //    e.Graphics.FillRectangle(br, this.ClientRectangle);
        //}

        private void adress06_Load(object sender, EventArgs e)
        {
            //DrawGridView();
            calculateAllVar();
        }


        private void quantityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 입력을 거부합니다.
            }

        }

        private void cntReadTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                flag03 = true;
                switch (cntRead)
                {
                    case 0:
                        SerialPort_Write(_send03Buf, 0x01);
                        cntRead++;
                        break;
                    case 1:
                        SerialPort_Write(_send03Buf, 0x02);
                        cntRead++;
                        break;
                    case 2:
                        SerialPort_Write(_send03Buf, 0x03);
                        cntRead = 0;
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isTimerActive)
                {
                    if (idle == true && serialPort1.IsOpen)
                    {
                        idle = false;
                        flag06 = true;
                        switch (slaveIdNum.Text)
                        {
                            case "1":
                                calculateAllVar();
                                packet06_changer(changeValue);
                                SerialPort_Write(_send06Buf, 0x01);
                                cntRead++;
                                break;
                            case "2":
                                calculateAllVar();
                                packet06_changer(changeValue);
                                SerialPort_Write(_send06Buf, 0x02);
                                cntRead++;
                                break;
                            case "3":
                                calculateAllVar();
                                packet06_changer(changeValue);
                                SerialPort_Write(_send06Buf, 0x03);
                                cntRead = 0;
                                break;
                            default:
                                error_Messeage("06 명령 오류");
                                idle = true;
                                break;
                        }
                    }
                    else if (!serialPort1.IsOpen)
                    {
                        error_Messeage("시리얼 포트 닫힘");
                    }

                    else
                    {
                        error_Messeage("대기 상태 아님");
                    }
                }
            }
            catch
            {
                error_Messeage("06 send Error");
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // 선택된 아이템의 처리 코드를 여기에 작성합니다.
                ListViewItem selectedItem = listView1.SelectedItems[0];
                MessageBox.Show("선택된 아이템: " + selectedItem.Text);
            }
        }

        private void saveExcelTimer_Tick(object sender, EventArgs e)
        {
            if (allowSavingFile == true)
            {
                Write_Data_Excel();
            }
        }

        private void Save_File() //엑셀 파일 생성 함수
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            string fName = Path.Combine(excelFolderPath, $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss tt}.csv"); //경로 지정과 날짜, 시간으로 구성된 파일 이름 설정
            saveFile.FileName = fName;
            fileName = saveFile.FileName.ToString();

            StreamWriter sw = File.AppendText(fileName); //.csv 파일 생성
            sw.WriteLine($"TIME, Slave No., data"); //첫번째 행 항목 지정  

            sw.Close();
            allowSavingFile = true;
        }

        private void Write_Data_Excel() //전압, 전류, 온도 데이터 엑셀에 작성 함수
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
                
                switch (count)
                {
                    case 0:
                        string result1 = "";
                        foreach (var input_items in listView1.Items)
                        {
                            result1 += string.Format("{0} ", input_items);
                        }
                        sw.WriteLine($"{data_time}, {"Slave 01"}, {result1}");
                        count++;
                        break;
                    case 1:
                        string result2 = "";
                        foreach (var input_items in listView2.Items)
                        {
                            result2 += string.Format("{0} ", input_items);
                        }
                        sw.WriteLine($"{data_time}, {"Slave 02"}, {result2}");
                        count++;
                        break;
                    case 2:
                        string result3 = "";
                        foreach (var input_items in listView3.Items)
                        {
                            result3 += string.Format("{0} ", input_items);
                        }
                        sw.WriteLine($"{data_time}, {"Slave 03"}, {result3}");
                        count = 0;
                        break;
                    default: 
                        break;
                }
               
                sw.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("엑셀 문제 있음");
            }

            saveDataCnt++;
        }
    }
}