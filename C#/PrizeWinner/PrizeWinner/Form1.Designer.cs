namespace PrizeWinner
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
            this.label1 = new System.Windows.Forms.Label();
            this.participantsList = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.pickButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.newName = new System.Windows.Forms.TextBox();
            this.ticketsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick Random Winner";
            // 
            // participantsList
            // 
            this.participantsList.FormattingEnabled = true;
            this.participantsList.Location = new System.Drawing.Point(12, 37);
            this.participantsList.Name = "participantsList";
            this.participantsList.Size = new System.Drawing.Size(200, 21);
            this.participantsList.TabIndex = 2;
            this.participantsList.Text = "Choose Participant";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(116, 179);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Participant";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // pickButton
            // 
            this.pickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickButton.Location = new System.Drawing.Point(12, 93);
            this.pickButton.Name = "pickButton";
            this.pickButton.Size = new System.Drawing.Size(200, 80);
            this.pickButton.TabIndex = 4;
            this.pickButton.Text = "Pick random winner";
            this.pickButton.UseVisualStyleBackColor = true;
            this.pickButton.Click += new System.EventHandler(this.pickButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(47, 208);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(126, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove Participant";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addTicketButton
            // 
            this.addTicketButton.Location = new System.Drawing.Point(47, 64);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(126, 23);
            this.addTicketButton.TabIndex = 7;
            this.addTicketButton.Text = "Add ticket to pool";
            this.addTicketButton.UseVisualStyleBackColor = true;
            this.addTicketButton.Click += new System.EventHandler(this.addTicketButton_Click);
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(10, 179);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(100, 20);
            this.newName.TabIndex = 8;
            // 
            // ticketsList
            // 
            this.ticketsList.FormattingEnabled = true;
            this.ticketsList.Location = new System.Drawing.Point(245, 37);
            this.ticketsList.Name = "ticketsList";
            this.ticketsList.Size = new System.Drawing.Size(120, 199);
            this.ticketsList.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ticket Totals";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketsList);
            this.Controls.Add(this.newName);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.pickButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.participantsList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Winner Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox participantsList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button pickButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.ListBox ticketsList;
        private System.Windows.Forms.Label label2;
    }
}

