namespace SEGP
{
    partial class Chat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConnectChatbtn = new System.Windows.Forms.Button();
            this.Portyourtxt = new System.Windows.Forms.TextBox();
            this.IPYourtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SendChatsmsbtn = new System.Windows.Forms.Button();
            this.sms = new System.Windows.Forms.TextBox();
            this.BodyChat = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.portfrindtxt = new System.Windows.Forms.TextBox();
            this.IPfrindtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Portyourtxt);
            this.groupBox1.Controls.Add(this.IPYourtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your IP and Port";
            // 
            // ConnectChatbtn
            // 
            this.ConnectChatbtn.BackColor = System.Drawing.Color.PowderBlue;
            this.ConnectChatbtn.Location = new System.Drawing.Point(1145, 99);
            this.ConnectChatbtn.Name = "ConnectChatbtn";
            this.ConnectChatbtn.Size = new System.Drawing.Size(86, 29);
            this.ConnectChatbtn.TabIndex = 5;
            this.ConnectChatbtn.Text = "Connect";
            this.ConnectChatbtn.UseVisualStyleBackColor = false;
            this.ConnectChatbtn.Click += new System.EventHandler(this.ConnectChatbtn_Click);
            // 
            // Portyourtxt
            // 
            this.Portyourtxt.Location = new System.Drawing.Point(161, 89);
            this.Portyourtxt.Name = "Portyourtxt";
            this.Portyourtxt.Size = new System.Drawing.Size(124, 21);
            this.Portyourtxt.TabIndex = 4;
            // 
            // IPYourtxt
            // 
            this.IPYourtxt.Location = new System.Drawing.Point(119, 30);
            this.IPYourtxt.Name = "IPYourtxt";
            this.IPYourtxt.Size = new System.Drawing.Size(411, 21);
            this.IPYourtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // SendChatsmsbtn
            // 
            this.SendChatsmsbtn.Location = new System.Drawing.Point(1197, 552);
            this.SendChatsmsbtn.Name = "SendChatsmsbtn";
            this.SendChatsmsbtn.Size = new System.Drawing.Size(75, 23);
            this.SendChatsmsbtn.TabIndex = 2;
            this.SendChatsmsbtn.Text = "Send";
            this.SendChatsmsbtn.UseVisualStyleBackColor = true;
            this.SendChatsmsbtn.Click += new System.EventHandler(this.SendChatsmsbtn_Click);
            // 
            // sms
            // 
            this.sms.Location = new System.Drawing.Point(21, 552);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(1159, 21);
            this.sms.TabIndex = 6;
            // 
            // BodyChat
            // 
            this.BodyChat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BodyChat.FormattingEnabled = true;
            this.BodyChat.Location = new System.Drawing.Point(21, 171);
            this.BodyChat.Name = "BodyChat";
            this.BodyChat.Size = new System.Drawing.Size(1260, 368);
            this.BodyChat.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.portfrindtxt);
            this.groupBox2.Controls.Add(this.IPfrindtxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(585, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 136);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friends IP and Port";
            // 
            // portfrindtxt
            // 
            this.portfrindtxt.Location = new System.Drawing.Point(161, 89);
            this.portfrindtxt.Name = "portfrindtxt";
            this.portfrindtxt.Size = new System.Drawing.Size(124, 21);
            this.portfrindtxt.TabIndex = 4;
            // 
            // IPfrindtxt
            // 
            this.IPfrindtxt.Location = new System.Drawing.Point(119, 30);
            this.IPfrindtxt.Name = "IPfrindtxt";
            this.IPfrindtxt.Size = new System.Drawing.Size(411, 21);
            this.IPfrindtxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "IP:";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SEGP.Properties.Resources.simple_background_by_hexdef101_d7x7rup;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ConnectChatbtn);
            this.Controls.Add(this.BodyChat);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.SendChatsmsbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(1300, 600);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Portyourtxt;
        private System.Windows.Forms.TextBox IPYourtxt;
        private System.Windows.Forms.Button ConnectChatbtn;
        private System.Windows.Forms.Button SendChatsmsbtn;
        private System.Windows.Forms.TextBox sms;
        private System.Windows.Forms.ListBox BodyChat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox portfrindtxt;
        private System.Windows.Forms.TextBox IPfrindtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
