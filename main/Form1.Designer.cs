namespace main
{
    partial class Form1
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
            this.onBtn = new System.Windows.Forms.Button();
            this.offBtn = new System.Windows.Forms.Button();
            this.sendTxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.leftTxt = new System.Windows.Forms.TextBox();
            this.rightTxt = new System.Windows.Forms.TextBox();
            this.bothSendBtn = new System.Windows.Forms.Button();
            this.gearTxt = new System.Windows.Forms.TextBox();
            this.rpmTxt = new System.Windows.Forms.TextBox();
            this.constantRpmBtn = new System.Windows.Forms.Button();
            this.constantRpmTxt = new System.Windows.Forms.TextBox();
            this.secondsTxt = new System.Windows.Forms.TextBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.secToMinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // onBtn
            // 
            this.onBtn.Location = new System.Drawing.Point(32, 74);
            this.onBtn.Name = "onBtn";
            this.onBtn.Size = new System.Drawing.Size(75, 23);
            this.onBtn.TabIndex = 0;
            this.onBtn.Text = "ON";
            this.onBtn.UseVisualStyleBackColor = true;
            this.onBtn.Click += new System.EventHandler(this.onBtn_Click);
            // 
            // offBtn
            // 
            this.offBtn.Location = new System.Drawing.Point(128, 74);
            this.offBtn.Name = "offBtn";
            this.offBtn.Size = new System.Drawing.Size(75, 23);
            this.offBtn.TabIndex = 1;
            this.offBtn.Text = "OFF";
            this.offBtn.UseVisualStyleBackColor = true;
            this.offBtn.Click += new System.EventHandler(this.offBtn_Click);
            // 
            // sendTxt
            // 
            this.sendTxt.Location = new System.Drawing.Point(66, 12);
            this.sendTxt.Name = "sendTxt";
            this.sendTxt.Size = new System.Drawing.Size(100, 20);
            this.sendTxt.TabIndex = 2;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(80, 38);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // leftTxt
            // 
            this.leftTxt.Location = new System.Drawing.Point(39, 190);
            this.leftTxt.Name = "leftTxt";
            this.leftTxt.Size = new System.Drawing.Size(100, 20);
            this.leftTxt.TabIndex = 4;
            // 
            // rightTxt
            // 
            this.rightTxt.Location = new System.Drawing.Point(172, 190);
            this.rightTxt.Name = "rightTxt";
            this.rightTxt.Size = new System.Drawing.Size(100, 20);
            this.rightTxt.TabIndex = 5;
            // 
            // bothSendBtn
            // 
            this.bothSendBtn.Location = new System.Drawing.Point(119, 227);
            this.bothSendBtn.Name = "bothSendBtn";
            this.bothSendBtn.Size = new System.Drawing.Size(75, 23);
            this.bothSendBtn.TabIndex = 6;
            this.bothSendBtn.Text = "Send All";
            this.bothSendBtn.UseVisualStyleBackColor = true;
            this.bothSendBtn.Click += new System.EventHandler(this.bothSendBtn_Click);
            // 
            // gearTxt
            // 
            this.gearTxt.Location = new System.Drawing.Point(145, 190);
            this.gearTxt.Name = "gearTxt";
            this.gearTxt.Size = new System.Drawing.Size(21, 20);
            this.gearTxt.TabIndex = 7;
            // 
            // rpmTxt
            // 
            this.rpmTxt.Location = new System.Drawing.Point(106, 154);
            this.rpmTxt.Name = "rpmTxt";
            this.rpmTxt.Size = new System.Drawing.Size(100, 20);
            this.rpmTxt.TabIndex = 8;
            // 
            // constantRpmBtn
            // 
            this.constantRpmBtn.Location = new System.Drawing.Point(394, 227);
            this.constantRpmBtn.Name = "constantRpmBtn";
            this.constantRpmBtn.Size = new System.Drawing.Size(75, 23);
            this.constantRpmBtn.TabIndex = 9;
            this.constantRpmBtn.Text = "Constant RPM";
            this.constantRpmBtn.UseVisualStyleBackColor = true;
            this.constantRpmBtn.Click += new System.EventHandler(this.constantRpmBtn_Click);
            // 
            // constantRpmTxt
            // 
            this.constantRpmTxt.Location = new System.Drawing.Point(381, 167);
            this.constantRpmTxt.Name = "constantRpmTxt";
            this.constantRpmTxt.Size = new System.Drawing.Size(100, 20);
            this.constantRpmTxt.TabIndex = 10;
            // 
            // secondsTxt
            // 
            this.secondsTxt.Location = new System.Drawing.Point(381, 58);
            this.secondsTxt.Name = "secondsTxt";
            this.secondsTxt.Size = new System.Drawing.Size(100, 20);
            this.secondsTxt.TabIndex = 11;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(409, 38);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(26, 13);
            this.timeLbl.TabIndex = 12;
            this.timeLbl.Text = "time";
            // 
            // secToMinBtn
            // 
            this.secToMinBtn.Location = new System.Drawing.Point(394, 93);
            this.secToMinBtn.Name = "secToMinBtn";
            this.secToMinBtn.Size = new System.Drawing.Size(75, 23);
            this.secToMinBtn.TabIndex = 13;
            this.secToMinBtn.Text = "Sec to Min";
            this.secToMinBtn.UseVisualStyleBackColor = true;
            this.secToMinBtn.Click += new System.EventHandler(this.secToMinBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(529, 296);
            this.Controls.Add(this.secToMinBtn);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.secondsTxt);
            this.Controls.Add(this.constantRpmTxt);
            this.Controls.Add(this.constantRpmBtn);
            this.Controls.Add(this.rpmTxt);
            this.Controls.Add(this.gearTxt);
            this.Controls.Add(this.bothSendBtn);
            this.Controls.Add(this.rightTxt);
            this.Controls.Add(this.leftTxt);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendTxt);
            this.Controls.Add(this.offBtn);
            this.Controls.Add(this.onBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onBtn;
        private System.Windows.Forms.Button offBtn;
        private System.Windows.Forms.TextBox sendTxt;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox leftTxt;
        private System.Windows.Forms.TextBox rightTxt;
        private System.Windows.Forms.Button bothSendBtn;
        private System.Windows.Forms.TextBox gearTxt;
        private System.Windows.Forms.TextBox rpmTxt;
        private System.Windows.Forms.Button constantRpmBtn;
        private System.Windows.Forms.TextBox constantRpmTxt;
        private System.Windows.Forms.TextBox secondsTxt;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button secToMinBtn;
    }
}

