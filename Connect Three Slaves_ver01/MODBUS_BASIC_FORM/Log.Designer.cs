namespace MODBUS_BASIC_FORM
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.form2LogBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // form2LogBox
            // 
            this.form2LogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.form2LogBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.form2LogBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.form2LogBox.Location = new System.Drawing.Point(21, 64);
            this.form2LogBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.form2LogBox.Multiline = true;
            this.form2LogBox.Name = "form2LogBox";
            this.form2LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.form2LogBox.Size = new System.Drawing.Size(440, 449);
            this.form2LogBox.TabIndex = 11;
            this.form2LogBox.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.continueBtn);
            this.panel1.Controls.Add(this.form2LogBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 533);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // clearBtn
            // 
            this.clearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearBtn.BackgroundImage")));
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(367, 23);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 34);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopBtn.BackgroundImage")));
            this.stopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBtn.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stopBtn.ForeColor = System.Drawing.Color.White;
            this.stopBtn.Location = new System.Drawing.Point(121, 23);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(94, 34);
            this.stopBtn.TabIndex = 13;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("continueBtn.BackgroundImage")));
            this.continueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.continueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueBtn.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.continueBtn.ForeColor = System.Drawing.Color.White;
            this.continueBtn.Location = new System.Drawing.Point(21, 23);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(94, 34);
            this.continueBtn.TabIndex = 12;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 533);
            this.Controls.Add(this.panel1);
            this.Name = "Log";
            this.Text = "Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button continueBtn;
        public System.Windows.Forms.TextBox form2LogBox;
        private System.Windows.Forms.Button clearBtn;
    }
}