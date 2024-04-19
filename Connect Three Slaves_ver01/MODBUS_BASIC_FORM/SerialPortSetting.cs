using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MODBUS_BASIC_FORM
{
    public partial class SerialPortSetting : Form
    {
        bool formFirstOpen = true; //폼을 처음 열었는지 확인하는 flag
        public delegate void FormSendDataHandler(string SF_port, int SF_baud_rate, int SF_data_bit, bool SF_serialPort_setting); //delegate 선언
        public event FormSendDataHandler SettingFormSendEvent; //Form Send Event 정의
        public SerialPortSetting()
        {
            InitializeComponent();  
        }

        // 연결가능한 시리얼포트 목록을 검색해서 반영
        public void GetSerialPorts(ComboBox combobox)
        {
            string[] port = SerialPort.GetPortNames();
            combobox.Items.Clear();

            foreach (string portName in port)
            {
                combobox.Items.Add(portName);
            }
        }

        private void SerialPortSetting_Load(object sender, EventArgs e)
        {
            try
            {
                if (!formFirstOpen)
                { return; }

                GetSerialPorts(comboBox);

                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
                baudRateBox.SelectedIndex = 1;
                dataBitsBox.SelectedIndex = 0;
                stopBitBox.SelectedIndex = 0;
                parityBox.SelectedIndex = 0;

                formFirstOpen = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void portConnect_Click(object sender, EventArgs e) // 포트 적용 클릭 이벤트
            {
            try
            {
                string port = comboBox.Text;
                int baud_rate = Convert.ToInt32(baudRateBox.Text);
                int data_bit = Convert.ToInt32(dataBitsBox.Text);
                bool serialPort_setting = true;

                SettingFormSendEvent?.Invoke(port, baud_rate, data_bit, serialPort_setting);
                Close();
            }
            catch
            {
                MessageBox.Show("입력 값 오류.", "알림");
            }
        }

        private void portFormClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
