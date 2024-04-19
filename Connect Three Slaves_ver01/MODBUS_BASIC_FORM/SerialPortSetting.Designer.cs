namespace MODBUS_BASIC_FORM
{
    partial class SerialPortSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.portConnect = new System.Windows.Forms.Button();
            this.baudRateBox = new System.Windows.Forms.ComboBox();
            this.dataBitsBox = new System.Windows.Forms.ComboBox();
            this.stopBitBox = new System.Windows.Forms.ComboBox();
            this.parityBox = new System.Windows.Forms.ComboBox();
            this.comText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.portFormClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox.ForeColor = System.Drawing.Color.White;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(126, 12);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(77, 20);
            this.comboBox.TabIndex = 4;
            // 
            // portConnect
            // 
            this.portConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.portConnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.portConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.portConnect.Font = new System.Drawing.Font("나눔스퀘어_ac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.portConnect.ForeColor = System.Drawing.Color.White;
            this.portConnect.Location = new System.Drawing.Point(12, 267);
            this.portConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.portConnect.Name = "portConnect";
            this.portConnect.Size = new System.Drawing.Size(98, 40);
            this.portConnect.TabIndex = 3;
            this.portConnect.Text = "포트 연결";
            this.portConnect.UseVisualStyleBackColor = false;
            this.portConnect.Click += new System.EventHandler(this.portConnect_Click);
            // 
            // baudRateBox
            // 
            this.baudRateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.baudRateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baudRateBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.baudRateBox.ForeColor = System.Drawing.Color.White;
            this.baudRateBox.FormattingEnabled = true;
            this.baudRateBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400"});
            this.baudRateBox.Location = new System.Drawing.Point(126, 57);
            this.baudRateBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.baudRateBox.Name = "baudRateBox";
            this.baudRateBox.Size = new System.Drawing.Size(77, 20);
            this.baudRateBox.TabIndex = 5;
            // 
            // dataBitsBox
            // 
            this.dataBitsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBitsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataBitsBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataBitsBox.ForeColor = System.Drawing.Color.White;
            this.dataBitsBox.FormattingEnabled = true;
            this.dataBitsBox.Items.AddRange(new object[] {
            "8"});
            this.dataBitsBox.Location = new System.Drawing.Point(126, 102);
            this.dataBitsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataBitsBox.Name = "dataBitsBox";
            this.dataBitsBox.Size = new System.Drawing.Size(77, 20);
            this.dataBitsBox.TabIndex = 6;
            // 
            // stopBitBox
            // 
            this.stopBitBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBitBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopBitBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBitBox.ForeColor = System.Drawing.Color.White;
            this.stopBitBox.FormattingEnabled = true;
            this.stopBitBox.Items.AddRange(new object[] {
            "One"});
            this.stopBitBox.Location = new System.Drawing.Point(126, 147);
            this.stopBitBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopBitBox.Name = "stopBitBox";
            this.stopBitBox.Size = new System.Drawing.Size(77, 20);
            this.stopBitBox.TabIndex = 7;
            // 
            // parityBox
            // 
            this.parityBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parityBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parityBox.ForeColor = System.Drawing.Color.White;
            this.parityBox.FormattingEnabled = true;
            this.parityBox.Items.AddRange(new object[] {
            "None"});
            this.parityBox.Location = new System.Drawing.Point(126, 193);
            this.parityBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.parityBox.Name = "parityBox";
            this.parityBox.Size = new System.Drawing.Size(77, 20);
            this.parityBox.TabIndex = 8;
            // 
            // comText
            // 
            this.comText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comText.AutoSize = true;
            this.comText.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comText.ForeColor = System.Drawing.Color.White;
            this.comText.Location = new System.Drawing.Point(23, 14);
            this.comText.Name = "comText";
            this.comText.Size = new System.Drawing.Size(77, 17);
            this.comText.TabIndex = 36;
            this.comText.Text = "COM";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Data Bits";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Stop Bit";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Parity";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.baudRateBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataBitsBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.stopBitBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.parityBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.comText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(227, 226);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // portFormClose
            // 
            this.portFormClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.portFormClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.portFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.portFormClose.Font = new System.Drawing.Font("나눔스퀘어_ac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.portFormClose.ForeColor = System.Drawing.Color.White;
            this.portFormClose.Location = new System.Drawing.Point(141, 267);
            this.portFormClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.portFormClose.Name = "portFormClose";
            this.portFormClose.Size = new System.Drawing.Size(98, 40);
            this.portFormClose.TabIndex = 42;
            this.portFormClose.Text = "닫기";
            this.portFormClose.UseVisualStyleBackColor = true;
            this.portFormClose.Click += new System.EventHandler(this.portFormClose_Click);
            // 
            // SerialPortSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(257, 324);
            this.Controls.Add(this.portFormClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.portConnect);
            this.Name = "SerialPortSetting";
            this.Text = "포트 설정";
            this.Load += new System.EventHandler(this.SerialPortSetting_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label comText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button portFormClose;
        public System.Windows.Forms.ComboBox comboBox;
        public System.Windows.Forms.Button portConnect;
        public System.Windows.Forms.ComboBox baudRateBox;
        public System.Windows.Forms.ComboBox dataBitsBox;
        public System.Windows.Forms.ComboBox stopBitBox;
        public System.Windows.Forms.ComboBox parityBox;
    }
}