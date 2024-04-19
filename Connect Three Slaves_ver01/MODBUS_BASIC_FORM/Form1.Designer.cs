namespace MODBUS_BASIC_FORM
{
    partial class adress06
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.responseTimer = new System.Windows.Forms.Timer(this.components);
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.maxValueBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.포트설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorBoxCon = new System.Windows.Forms.TextBox();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.writeBox = new System.Windows.Forms.Label();
            this.slaveIdNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cntReadTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList_itemMargine = new System.Windows.Forms.ImageList(this.components);
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rowNum = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.saveExcelTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // responseTimer
            // 
            this.responseTimer.Tick += new System.EventHandler(this.responseTimer_Tick);
            // 
            // timerWait
            // 
            this.timerWait.Interval = 150;
            this.timerWait.Tick += new System.EventHandler(this.timerWait_Tick);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("나눔스퀘어_ac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(163, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 54);
            this.button2.TabIndex = 49;
            this.button2.Text = "적용하기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // maxValueBox
            // 
            this.maxValueBox.Location = new System.Drawing.Point(80, 91);
            this.maxValueBox.Name = "maxValueBox";
            this.maxValueBox.Size = new System.Drawing.Size(62, 22);
            this.maxValueBox.TabIndex = 46;
            this.maxValueBox.Text = "0";
            this.maxValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.로그확인ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 25);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.포트설정ToolStripMenuItem});
            this.설정ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 포트설정ToolStripMenuItem
            // 
            this.포트설정ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.포트설정ToolStripMenuItem.Name = "포트설정ToolStripMenuItem";
            this.포트설정ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.포트설정ToolStripMenuItem.Text = "포트 설정";
            this.포트설정ToolStripMenuItem.Click += new System.EventHandler(this.포트설정ToolStripMenuItem_Click);
            // 
            // 로그확인ToolStripMenuItem
            // 
            this.로그확인ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.로그확인ToolStripMenuItem.Name = "로그확인ToolStripMenuItem";
            this.로그확인ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.로그확인ToolStripMenuItem.Text = "로그 확인";
            this.로그확인ToolStripMenuItem.Click += new System.EventHandler(this.로그확인ToolStripMenuItem_Click);
            // 
            // errorBoxCon
            // 
            this.errorBoxCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.errorBoxCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBoxCon.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.errorBoxCon.ForeColor = System.Drawing.Color.Red;
            this.errorBoxCon.Location = new System.Drawing.Point(410, 81);
            this.errorBoxCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.errorBoxCon.Name = "errorBoxCon";
            this.errorBoxCon.Size = new System.Drawing.Size(139, 21);
            this.errorBoxCon.TabIndex = 31;
            this.errorBoxCon.Text = "Error Contents";
            // 
            // errorBox
            // 
            this.errorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Location = new System.Drawing.Point(410, 35);
            this.errorBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(139, 21);
            this.errorBox.TabIndex = 17;
            this.errorBox.Text = "None Error";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(410, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "에러 횟수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(410, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "에러 내용";
            // 
            // writeBox
            // 
            this.writeBox.AutoSize = true;
            this.writeBox.ForeColor = System.Drawing.Color.Red;
            this.writeBox.Location = new System.Drawing.Point(32, 428);
            this.writeBox.Name = "writeBox";
            this.writeBox.Size = new System.Drawing.Size(87, 14);
            this.writeBox.TabIndex = 51;
            this.writeBox.Text = "Disconnected";
            // 
            // slaveIdNum
            // 
            this.slaveIdNum.Location = new System.Drawing.Point(80, 39);
            this.slaveIdNum.Name = "slaveIdNum";
            this.slaveIdNum.Size = new System.Drawing.Size(62, 22);
            this.slaveIdNum.TabIndex = 53;
            this.slaveIdNum.Text = "1";
            this.slaveIdNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 52;
            this.label3.Text = "Slave:";
            // 
            // cntReadTimer
            // 
            this.cntReadTimer.Interval = 333;
            this.cntReadTimer.Tick += new System.EventHandler(this.cntReadTimer_Tick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 14);
            this.label4.TabIndex = 54;
            this.label4.Text = "00";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 14);
            this.label5.TabIndex = 55;
            this.label5.Text = "01";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 14);
            this.label9.TabIndex = 56;
            this.label9.Text = "02";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 14);
            this.label10.TabIndex = 57;
            this.label10.Text = "03";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(31, 233);
            this.tableLayoutPanel1.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(4, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 14);
            this.label16.TabIndex = 66;
            this.label16.Text = "09";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(4, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 14);
            this.label15.TabIndex = 63;
            this.label15.Text = "08";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 14);
            this.label11.TabIndex = 59;
            this.label11.Text = "04";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 14);
            this.label12.TabIndex = 62;
            this.label12.Text = "05";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 14);
            this.label13.TabIndex = 60;
            this.label13.Text = "06";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(4, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 14);
            this.label14.TabIndex = 61;
            this.label14.Text = "07";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(31, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 285);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slave01";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Value});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(61, 16);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(75, 258);
            this.listView1.SmallImageList = this.imageList_itemMargine;
            this.listView1.TabIndex = 67;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 71;
            // 
            // imageList_itemMargine
            // 
            this.imageList_itemMargine.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_itemMargine.ImageSize = new System.Drawing.Size(1, 22);
            this.imageList_itemMargine.TransparentColor = System.Drawing.Color.White;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(32, 93);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(47, 14);
            this.label34.TabIndex = 62;
            this.label34.Text = "적용 값:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(216, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 285);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slave02";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label20, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label21, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label22, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label23, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(31, 233);
            this.tableLayoutPanel2.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 14);
            this.label6.TabIndex = 66;
            this.label6.Text = "09";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 14);
            this.label7.TabIndex = 63;
            this.label7.Text = "08";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 14);
            this.label8.TabIndex = 59;
            this.label8.Text = "04";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(4, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 14);
            this.label17.TabIndex = 54;
            this.label17.Text = "00";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(4, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 14);
            this.label18.TabIndex = 62;
            this.label18.Text = "05";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(4, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 14);
            this.label19.TabIndex = 60;
            this.label19.Text = "06";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(4, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 14);
            this.label20.TabIndex = 55;
            this.label20.Text = "01";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(4, 165);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 14);
            this.label21.TabIndex = 61;
            this.label21.Text = "07";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(4, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 14);
            this.label22.TabIndex = 56;
            this.label22.Text = "02";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(4, 73);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 14);
            this.label23.TabIndex = 57;
            this.label23.Text = "03";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(61, 16);
            this.listView2.Margin = new System.Windows.Forms.Padding(0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(75, 258);
            this.listView2.SmallImageList = this.imageList_itemMargine;
            this.listView2.TabIndex = 67;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Value";
            this.columnHeader1.Width = 71;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Controls.Add(this.listView3);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(403, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 285);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Slave03";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label24, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.label25, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label26, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label27, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label28, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label29, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label30, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label31, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label32, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label33, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(27, 47);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(31, 233);
            this.tableLayoutPanel3.TabIndex = 58;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(4, 213);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 14);
            this.label24.TabIndex = 66;
            this.label24.Text = "09";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(4, 188);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 14);
            this.label25.TabIndex = 63;
            this.label25.Text = "08";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(4, 96);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 14);
            this.label26.TabIndex = 59;
            this.label26.Text = "04";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(4, 4);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 14);
            this.label27.TabIndex = 54;
            this.label27.Text = "00";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(4, 119);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 14);
            this.label28.TabIndex = 62;
            this.label28.Text = "05";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(4, 142);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 14);
            this.label29.TabIndex = 60;
            this.label29.Text = "06";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(4, 27);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 14);
            this.label30.TabIndex = 55;
            this.label30.Text = "01";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(4, 165);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(23, 14);
            this.label31.TabIndex = 61;
            this.label31.Text = "07";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(4, 50);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(23, 14);
            this.label32.TabIndex = 56;
            this.label32.Text = "02";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(4, 73);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(23, 14);
            this.label33.TabIndex = 57;
            this.label33.Text = "03";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(61, 16);
            this.listView3.Margin = new System.Windows.Forms.Padding(0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(75, 258);
            this.listView3.SmallImageList = this.imageList_itemMargine;
            this.listView3.TabIndex = 67;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 71;
            // 
            // rowNum
            // 
            this.rowNum.Location = new System.Drawing.Point(80, 65);
            this.rowNum.Name = "rowNum";
            this.rowNum.Size = new System.Drawing.Size(62, 22);
            this.rowNum.TabIndex = 72;
            this.rowNum.Text = "1";
            this.rowNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(12, 68);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(67, 14);
            this.label35.TabIndex = 71;
            this.label35.Text = "Row Num:";
            // 
            // saveExcelTimer
            // 
            this.saveExcelTimer.Interval = 3000;
            this.saveExcelTimer.Tick += new System.EventHandler(this.saveExcelTimer_Tick);
            // 
            // adress06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 454);
            this.Controls.Add(this.rowNum);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.slaveIdNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.writeBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maxValueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.errorBoxCon);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("나눔스퀘어_ac", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "adress06";
            this.Text = "메인";
            this.Load += new System.EventHandler(this.adress06_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer responseTimer;
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 포트설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그확인ToolStripMenuItem;
        private System.Windows.Forms.TextBox maxValueBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox errorBoxCon;
        private System.Windows.Forms.TextBox errorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label writeBox;
        private System.Windows.Forms.TextBox slaveIdNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer cntReadTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ImageList imageList_itemMargine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox rowNum;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Timer saveExcelTimer;
    }
}

