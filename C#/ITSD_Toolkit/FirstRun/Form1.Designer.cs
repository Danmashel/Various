namespace FirstRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.locationSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backupLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wsusServerLocation = new System.Windows.Forms.TextBox();
            this.backupCheckbox = new System.Windows.Forms.CheckBox();
            this.setTimeCheckbox = new System.Windows.Forms.CheckBox();
            this.wsusCheckbox = new System.Windows.Forms.CheckBox();
            this.softpackCheckbox = new System.Windows.Forms.CheckBox();
            this.installESETCheckbox = new System.Windows.Forms.CheckBox();
            this.updateWindowsCheckbox = new System.Windows.Forms.CheckBox();
            this.poweroptionsCheckbox = new System.Windows.Forms.CheckBox();
            this.runFirstBtn = new System.Windows.Forms.Button();
            this.runLastBtn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.softwareLocation = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.wsusLocationLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.runFirstDoneLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.runLastDoneLabel = new System.Windows.Forms.Label();
            this.wsusPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location:";
            // 
            // locationSelect
            // 
            this.locationSelect.FormattingEnabled = true;
            this.locationSelect.Items.AddRange(new object[] {
            "Location 1",
            "Location 2",
            "Location 3",
            "Location 4"});
            this.locationSelect.Location = new System.Drawing.Point(102, 12);
            this.locationSelect.Name = "locationSelect";
            this.locationSelect.Size = new System.Drawing.Size(121, 21);
            this.locationSelect.TabIndex = 1;
            this.locationSelect.SelectedIndexChanged += new System.EventHandler(this.locationSelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "LOG";
            // 
            // backupLocation
            // 
            this.backupLocation.Location = new System.Drawing.Point(102, 39);
            this.backupLocation.Name = "backupLocation";
            this.backupLocation.Size = new System.Drawing.Size(206, 20);
            this.backupLocation.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Backup Location: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "WSUS IP/Port:";
            // 
            // wsusServerLocation
            // 
            this.wsusServerLocation.Location = new System.Drawing.Point(102, 116);
            this.wsusServerLocation.Name = "wsusServerLocation";
            this.wsusServerLocation.Size = new System.Drawing.Size(98, 20);
            this.wsusServerLocation.TabIndex = 8;
            // 
            // backupCheckbox
            // 
            this.backupCheckbox.AutoSize = true;
            this.backupCheckbox.Checked = true;
            this.backupCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backupCheckbox.Location = new System.Drawing.Point(22, 149);
            this.backupCheckbox.Name = "backupCheckbox";
            this.backupCheckbox.Size = new System.Drawing.Size(127, 17);
            this.backupCheckbox.TabIndex = 10;
            this.backupCheckbox.Text = "Mount backup server";
            this.backupCheckbox.UseVisualStyleBackColor = true;
            // 
            // setTimeCheckbox
            // 
            this.setTimeCheckbox.AutoSize = true;
            this.setTimeCheckbox.Checked = true;
            this.setTimeCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setTimeCheckbox.Location = new System.Drawing.Point(171, 149);
            this.setTimeCheckbox.Name = "setTimeCheckbox";
            this.setTimeCheckbox.Size = new System.Drawing.Size(100, 17);
            this.setTimeCheckbox.TabIndex = 11;
            this.setTimeCheckbox.Text = "Set correct time";
            this.setTimeCheckbox.UseVisualStyleBackColor = true;
            // 
            // wsusCheckbox
            // 
            this.wsusCheckbox.AutoSize = true;
            this.wsusCheckbox.Checked = true;
            this.wsusCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wsusCheckbox.Location = new System.Drawing.Point(22, 172);
            this.wsusCheckbox.Name = "wsusCheckbox";
            this.wsusCheckbox.Size = new System.Drawing.Size(138, 17);
            this.wsusCheckbox.TabIndex = 12;
            this.wsusCheckbox.Text = "Use local WSUS server";
            this.wsusCheckbox.UseVisualStyleBackColor = true;
            // 
            // softpackCheckbox
            // 
            this.softpackCheckbox.AutoSize = true;
            this.softpackCheckbox.Checked = true;
            this.softpackCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.softpackCheckbox.Location = new System.Drawing.Point(22, 195);
            this.softpackCheckbox.Name = "softpackCheckbox";
            this.softpackCheckbox.Size = new System.Drawing.Size(100, 17);
            this.softpackCheckbox.TabIndex = 14;
            this.softpackCheckbox.Text = "Install SoftPack";
            this.softpackCheckbox.UseVisualStyleBackColor = true;
            // 
            // installESETCheckbox
            // 
            this.installESETCheckbox.AutoSize = true;
            this.installESETCheckbox.Checked = true;
            this.installESETCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.installESETCheckbox.Location = new System.Drawing.Point(171, 172);
            this.installESETCheckbox.Name = "installESETCheckbox";
            this.installESETCheckbox.Size = new System.Drawing.Size(84, 17);
            this.installESETCheckbox.TabIndex = 13;
            this.installESETCheckbox.Text = "Install ESET";
            this.installESETCheckbox.UseVisualStyleBackColor = true;
            // 
            // updateWindowsCheckbox
            // 
            this.updateWindowsCheckbox.AutoSize = true;
            this.updateWindowsCheckbox.Checked = true;
            this.updateWindowsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updateWindowsCheckbox.Location = new System.Drawing.Point(171, 196);
            this.updateWindowsCheckbox.Name = "updateWindowsCheckbox";
            this.updateWindowsCheckbox.Size = new System.Drawing.Size(108, 17);
            this.updateWindowsCheckbox.TabIndex = 15;
            this.updateWindowsCheckbox.Text = "Update Windows";
            this.updateWindowsCheckbox.UseVisualStyleBackColor = true;
            // 
            // poweroptionsCheckbox
            // 
            this.poweroptionsCheckbox.AutoSize = true;
            this.poweroptionsCheckbox.Checked = true;
            this.poweroptionsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.poweroptionsCheckbox.Location = new System.Drawing.Point(22, 219);
            this.poweroptionsCheckbox.Name = "poweroptionsCheckbox";
            this.poweroptionsCheckbox.Size = new System.Drawing.Size(133, 17);
            this.poweroptionsCheckbox.TabIndex = 16;
            this.poweroptionsCheckbox.Text = "Disable Power Options";
            this.poweroptionsCheckbox.UseVisualStyleBackColor = true;
            // 
            // runFirstBtn
            // 
            this.runFirstBtn.Location = new System.Drawing.Point(35, 247);
            this.runFirstBtn.Name = "runFirstBtn";
            this.runFirstBtn.Size = new System.Drawing.Size(103, 25);
            this.runFirstBtn.TabIndex = 17;
            this.runFirstBtn.Text = "Make it so!";
            this.runFirstBtn.UseVisualStyleBackColor = true;
            this.runFirstBtn.Click += new System.EventHandler(this.runFirstBtn_Click);
            // 
            // runLastBtn
            // 
            this.runLastBtn.Location = new System.Drawing.Point(152, 247);
            this.runLastBtn.Name = "runLastBtn";
            this.runLastBtn.Size = new System.Drawing.Size(103, 25);
            this.runLastBtn.TabIndex = 18;
            this.runLastBtn.Text = "Clean up!";
            this.runLastBtn.UseVisualStyleBackColor = true;
            this.runLastBtn.Click += new System.EventHandler(this.runLastBtn_Click);
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.FormattingEnabled = true;
            this.logBox.HorizontalScrollbar = true;
            this.logBox.Location = new System.Drawing.Point(315, 39);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(454, 212);
            this.logBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Software Location:";
            // 
            // softwareLocation
            // 
            this.softwareLocation.Location = new System.Drawing.Point(102, 64);
            this.softwareLocation.Name = "softwareLocation";
            this.softwareLocation.Size = new System.Drawing.Size(206, 20);
            this.softwareLocation.TabIndex = 5;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(102, 90);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(98, 20);
            this.usernameBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(206, 90);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(102, 20);
            this.passwordBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "User/Pass:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "WSUS Server Location: ";
            // 
            // wsusLocationLabel
            // 
            this.wsusLocationLabel.AutoSize = true;
            this.wsusLocationLabel.Location = new System.Drawing.Point(429, 263);
            this.wsusLocationLabel.Name = "wsusLocationLabel";
            this.wsusLocationLabel.Size = new System.Drawing.Size(0, 13);
            this.wsusLocationLabel.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Run First done: ";
            // 
            // runFirstDoneLabel
            // 
            this.runFirstDoneLabel.AutoSize = true;
            this.runFirstDoneLabel.Location = new System.Drawing.Point(593, 263);
            this.runFirstDoneLabel.Name = "runFirstDoneLabel";
            this.runFirstDoneLabel.Size = new System.Drawing.Size(0, 13);
            this.runFirstDoneLabel.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(665, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Run Last done:";
            // 
            // runLastDoneLabel
            // 
            this.runLastDoneLabel.AutoSize = true;
            this.runLastDoneLabel.Location = new System.Drawing.Point(741, 263);
            this.runLastDoneLabel.Name = "runLastDoneLabel";
            this.runLastDoneLabel.Size = new System.Drawing.Size(0, 13);
            this.runLastDoneLabel.TabIndex = 30;
            // 
            // wsusPort
            // 
            this.wsusPort.Location = new System.Drawing.Point(208, 116);
            this.wsusPort.Name = "wsusPort";
            this.wsusPort.Size = new System.Drawing.Size(47, 20);
            this.wsusPort.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 279);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wsusPort);
            this.Controls.Add(this.runLastDoneLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.runFirstDoneLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.wsusLocationLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.softwareLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.runLastBtn);
            this.Controls.Add(this.runFirstBtn);
            this.Controls.Add(this.poweroptionsCheckbox);
            this.Controls.Add(this.updateWindowsCheckbox);
            this.Controls.Add(this.installESETCheckbox);
            this.Controls.Add(this.softpackCheckbox);
            this.Controls.Add(this.wsusCheckbox);
            this.Controls.Add(this.setTimeCheckbox);
            this.Controls.Add(this.backupCheckbox);
            this.Controls.Add(this.wsusServerLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backupLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationSelect);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ITSD Toolkit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox locationSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox backupLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox wsusServerLocation;
        private System.Windows.Forms.CheckBox backupCheckbox;
        private System.Windows.Forms.CheckBox setTimeCheckbox;
        private System.Windows.Forms.CheckBox wsusCheckbox;
        private System.Windows.Forms.CheckBox softpackCheckbox;
        private System.Windows.Forms.CheckBox installESETCheckbox;
        private System.Windows.Forms.CheckBox updateWindowsCheckbox;
        private System.Windows.Forms.CheckBox poweroptionsCheckbox;
        private System.Windows.Forms.Button runFirstBtn;
        private System.Windows.Forms.Button runLastBtn;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox softwareLocation;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label wsusLocationLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label runFirstDoneLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label runLastDoneLabel;
        private System.Windows.Forms.TextBox wsusPort;
        private System.Windows.Forms.Label label8;
    }
}

