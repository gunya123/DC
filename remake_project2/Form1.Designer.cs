using System.IO.Ports;

namespace remake_project2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cycleTimeBtn = new System.Windows.Forms.Button();
            this.refV_Btn = new System.Windows.Forms.Button();
            this.aveRangeBtn = new System.Windows.Forms.Button();
            this.caliV_Btn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.spConectBtn = new System.Windows.Forms.Button();
            this.cycleTimeBox = new System.Windows.Forms.TextBox();
            this.refV_Box = new System.Windows.Forms.TextBox();
            this.aveRangeBox = new System.Windows.Forms.TextBox();
            this.caliV_Box = new System.Windows.Forms.TextBox();
            this.spBox = new System.Windows.Forms.ComboBox();
            this.label_status = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.spCutBtn = new System.Windows.Forms.Button();
            this.resultVolBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rxTextBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.포트설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cycleTimeBtn
            // 
            this.cycleTimeBtn.Location = new System.Drawing.Point(21, 82);
            this.cycleTimeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cycleTimeBtn.Name = "cycleTimeBtn";
            this.cycleTimeBtn.Size = new System.Drawing.Size(66, 20);
            this.cycleTimeBtn.TabIndex = 0;
            this.cycleTimeBtn.Text = "주기변경";
            this.cycleTimeBtn.UseVisualStyleBackColor = true;
            this.cycleTimeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // refV_Btn
            // 
            this.refV_Btn.Location = new System.Drawing.Point(20, 122);
            this.refV_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refV_Btn.Name = "refV_Btn";
            this.refV_Btn.Size = new System.Drawing.Size(66, 22);
            this.refV_Btn.TabIndex = 1;
            this.refV_Btn.Text = "Ref변경";
            this.refV_Btn.UseVisualStyleBackColor = true;
            this.refV_Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // aveRangeBtn
            // 
            this.aveRangeBtn.Location = new System.Drawing.Point(20, 166);
            this.aveRangeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aveRangeBtn.Name = "aveRangeBtn";
            this.aveRangeBtn.Size = new System.Drawing.Size(66, 22);
            this.aveRangeBtn.TabIndex = 2;
            this.aveRangeBtn.Text = "범위변경";
            this.aveRangeBtn.UseVisualStyleBackColor = true;
            this.aveRangeBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // caliV_Btn
            // 
            this.caliV_Btn.Location = new System.Drawing.Point(20, 208);
            this.caliV_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caliV_Btn.Name = "caliV_Btn";
            this.caliV_Btn.Size = new System.Drawing.Size(66, 21);
            this.caliV_Btn.TabIndex = 3;
            this.caliV_Btn.Text = "영점변경";
            this.caliV_Btn.UseVisualStyleBackColor = true;
            this.caliV_Btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(253, 130);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(66, 21);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "초기화";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click_1);
            // 
            // spConectBtn
            // 
            this.spConectBtn.Location = new System.Drawing.Point(182, 164);
            this.spConectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spConectBtn.Name = "spConectBtn";
            this.spConectBtn.Size = new System.Drawing.Size(66, 26);
            this.spConectBtn.TabIndex = 5;
            this.spConectBtn.Text = "포트연결";
            this.spConectBtn.UseVisualStyleBackColor = true;
            this.spConectBtn.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // cycleTimeBox
            // 
            this.cycleTimeBox.Location = new System.Drawing.Point(93, 82);
            this.cycleTimeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cycleTimeBox.Name = "cycleTimeBox";
            this.cycleTimeBox.Size = new System.Drawing.Size(43, 21);
            this.cycleTimeBox.TabIndex = 6;
            // 
            // refV_Box
            // 
            this.refV_Box.Location = new System.Drawing.Point(93, 122);
            this.refV_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refV_Box.Name = "refV_Box";
            this.refV_Box.Size = new System.Drawing.Size(43, 21);
            this.refV_Box.TabIndex = 7;
            // 
            // aveRangeBox
            // 
            this.aveRangeBox.Location = new System.Drawing.Point(93, 166);
            this.aveRangeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aveRangeBox.Name = "aveRangeBox";
            this.aveRangeBox.Size = new System.Drawing.Size(43, 21);
            this.aveRangeBox.TabIndex = 8;
            // 
            // caliV_Box
            // 
            this.caliV_Box.Location = new System.Drawing.Point(93, 208);
            this.caliV_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caliV_Box.Name = "caliV_Box";
            this.caliV_Box.Size = new System.Drawing.Size(43, 21);
            this.caliV_Box.TabIndex = 9;
            // 
            // spBox
            // 
            this.spBox.FormattingEnabled = true;
            this.spBox.Location = new System.Drawing.Point(182, 194);
            this.spBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spBox.Name = "spBox";
            this.spBox.Size = new System.Drawing.Size(123, 20);
            this.spBox.TabIndex = 10;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(204, 217);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(57, 12);
            this.label_status.TabIndex = 11;
            this.label_status.Text = "포트 상태";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // spCutBtn
            // 
            this.spCutBtn.Location = new System.Drawing.Point(253, 164);
            this.spCutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spCutBtn.Name = "spCutBtn";
            this.spCutBtn.Size = new System.Drawing.Size(66, 26);
            this.spCutBtn.TabIndex = 12;
            this.spCutBtn.Text = "연결해제";
            this.spCutBtn.UseVisualStyleBackColor = true;
            this.spCutBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // resultVolBox
            // 
            this.resultVolBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultVolBox.Location = new System.Drawing.Point(18, 24);
            this.resultVolBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultVolBox.Name = "resultVolBox";
            this.resultVolBox.ReadOnly = true;
            this.resultVolBox.Size = new System.Drawing.Size(76, 21);
            this.resultVolBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "log창";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rxTextBox
            // 
            this.rxTextBox.Location = new System.Drawing.Point(379, 41);
            this.rxTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rxTextBox.Multiline = true;
            this.rxTextBox.Name = "rxTextBox";
            this.rxTextBox.ReadOnly = true;
            this.rxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rxTextBox.Size = new System.Drawing.Size(340, 252);
            this.rxTextBox.TabIndex = 15;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(379, 10);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(66, 28);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "정지";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(450, 10);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(66, 28);
            this.startBtn.TabIndex = 17;
            this.startBtn.Text = "시작";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(521, 10);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(66, 28);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "지우기";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "초(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "개";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "mV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.resultVolBox);
            this.groupBox1.Location = new System.Drawing.Point(191, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 60);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현재 측정값";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "V";
            // 
            // saveTimer
            // 
            this.saveTimer.Interval = 1000;
            this.saveTimer.Tick += new System.EventHandler(this.saveTimer_Tick);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 263);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 21);
            this.textBox5.TabIndex = 24;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(653, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 28);
            this.button5.TabIndex = 25;
            this.button5.Text = "Log 저장";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(61, 263);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(43, 21);
            this.textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(109, 263);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(43, 21);
            this.textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(158, 263);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(43, 21);
            this.textBox8.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "cnt";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(220, 258);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 28);
            this.button8.TabIndex = 33;
            this.button8.Text = "타이머 변경";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.intervalNumericUpDown.Location = new System.Drawing.Point(309, 264);
            this.intervalNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.intervalNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.intervalNumericUpDown.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.intervalNumericUpDown.Name = "intervalNumericUpDown";
            this.intervalNumericUpDown.Size = new System.Drawing.Size(52, 21);
            this.intervalNumericUpDown.TabIndex = 34;
            this.intervalNumericUpDown.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일ToolStripMenuItem.Text = "파일(F)";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.종료ToolStripMenuItem.Text = "종료(X)";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.포트설정ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 포트설정ToolStripMenuItem
            // 
            this.포트설정ToolStripMenuItem.Name = "포트설정ToolStripMenuItem";
            this.포트설정ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.포트설정ToolStripMenuItem.Text = "포트 설정";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(93, 192);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(93, 152);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(93, 106);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(93, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 214);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox9.Location = new System.Drawing.Point(98, 34);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(76, 21);
            this.textBox9.TabIndex = 25;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 247);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.intervalNumericUpDown);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.rxTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.spCutBtn);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.spBox);
            this.Controls.Add(this.caliV_Box);
            this.Controls.Add(this.aveRangeBox);
            this.Controls.Add(this.refV_Box);
            this.Controls.Add(this.cycleTimeBox);
            this.Controls.Add(this.spConectBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.caliV_Btn);
            this.Controls.Add(this.aveRangeBtn);
            this.Controls.Add(this.refV_Btn);
            this.Controls.Add(this.cycleTimeBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cycleTimeBtn;
        private System.Windows.Forms.Button refV_Btn;
        private System.Windows.Forms.Button aveRangeBtn;
        private System.Windows.Forms.Button caliV_Btn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button spConectBtn;
        private System.Windows.Forms.TextBox cycleTimeBox;
        private System.Windows.Forms.TextBox refV_Box;
        private System.Windows.Forms.TextBox aveRangeBox;
        private System.Windows.Forms.TextBox caliV_Box;
        private System.Windows.Forms.ComboBox spBox;
        private System.Windows.Forms.Label label_status;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button spCutBtn;
        private System.Windows.Forms.TextBox resultVolBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button clearBtn;
        public System.Windows.Forms.TextBox rxTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer saveTimer;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 포트설정ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox9;
    }
}

