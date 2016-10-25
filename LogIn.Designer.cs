namespace SEGP
{
    partial class LogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInbtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ggglogin = new System.Windows.Forms.DataGridView();
            this.User_Nametxt = new System.Windows.Forms.TextBox();
            this.Passwrodtxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ggglogin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // LogInbtn
            // 
            this.LogInbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.LogInbtn.Font = new System.Drawing.Font("Minion Pro Med", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInbtn.Location = new System.Drawing.Point(148, 191);
            this.LogInbtn.Name = "LogInbtn";
            this.LogInbtn.Size = new System.Drawing.Size(84, 29);
            this.LogInbtn.TabIndex = 6;
            this.LogInbtn.Text = "LogIn";
            this.LogInbtn.UseVisualStyleBackColor = false;
            this.LogInbtn.Click += new System.EventHandler(this.LogInbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ggglogin
            // 
            this.ggglogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ggglogin.Location = new System.Drawing.Point(12, 127);
            this.ggglogin.Name = "ggglogin";
            this.ggglogin.Size = new System.Drawing.Size(381, 150);
            this.ggglogin.TabIndex = 7;
            this.ggglogin.Visible = false;
            // 
            // User_Nametxt
            // 
            this.User_Nametxt.Location = new System.Drawing.Point(31, 73);
            this.User_Nametxt.Multiline = true;
            this.User_Nametxt.Name = "User_Nametxt";
            this.User_Nametxt.Size = new System.Drawing.Size(334, 32);
            this.User_Nametxt.TabIndex = 0;
            this.User_Nametxt.Validating += new System.ComponentModel.CancelEventHandler(this.User_Nametxt_Validating_1);
            // 
            // Passwrodtxt
            // 
            this.Passwrodtxt.Location = new System.Drawing.Point(31, 137);
            this.Passwrodtxt.Multiline = true;
            this.Passwrodtxt.Name = "Passwrodtxt";
            this.Passwrodtxt.PasswordChar = '*';
            this.Passwrodtxt.Size = new System.Drawing.Size(334, 32);
            this.Passwrodtxt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Passwrodtxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.User_Nametxt);
            this.panel1.Controls.Add(this.LogInbtn);
            this.panel1.Location = new System.Drawing.Point(553, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 313);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "LogIn";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SEGP.Properties.Resources._7003091_hot_air_balloon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 671);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ggglogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ggglogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogInbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView ggglogin;
        private System.Windows.Forms.TextBox User_Nametxt;
        private System.Windows.Forms.TextBox Passwrodtxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}