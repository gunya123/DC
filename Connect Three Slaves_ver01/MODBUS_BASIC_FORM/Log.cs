using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODBUS_BASIC_FORM
{
    public partial class Log : Form
    {
        public bool print_comLog = true; //ComLogForm 표기 On/Off flag
        public delegate void logText(bool print_comLog);
        public event logText logTextEvent;
        public Log()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color firstColor = System.Drawing.ColorTranslator.FromHtml("#141414");
            Color SecontColor = System.Drawing.ColorTranslator.FromHtml("#282828");
            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, firstColor, SecontColor, 45, false);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            print_comLog = true;
            logTextEvent?.Invoke(print_comLog);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            print_comLog = false;
            logTextEvent?.Invoke(print_comLog);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            form2LogBox.Clear();
        }
    }
}
