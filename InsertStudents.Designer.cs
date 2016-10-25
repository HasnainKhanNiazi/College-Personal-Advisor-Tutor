namespace SEGP
{
    partial class InsertStudents
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
            this.label1 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.LoadSheetbtn = new System.Windows.Forms.Button();
            this.Browsetxt = new System.Windows.Forms.TextBox();
            this.Sheettxt = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.gggbackend = new System.Windows.Forms.DataGridView();
            this.ggg = new DevExpress.XtraGrid.GridControl();
            this.ggg1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OneStd = new System.Windows.Forms.Button();
            this.PanelManualStd = new System.Windows.Forms.Panel();
            this.Clearmanstd = new System.Windows.Forms.Button();
            this.INsertManstd = new System.Windows.Forms.Button();
            this.YearStdManul = new System.Windows.Forms.TextBox();
            this.ContactStdManul = new System.Windows.Forms.TextBox();
            this.EmailStdManul = new System.Windows.Forms.TextBox();
            this.ProgrameStdManul = new System.Windows.Forms.TextBox();
            this.FatherStdManul = new System.Windows.Forms.TextBox();
            this.NameStdManul = new System.Windows.Forms.TextBox();
            this.UobStdManul = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gggbackend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ggg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ggg1)).BeginInit();
            this.PanelManualStd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Data";
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Browse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.Location = new System.Drawing.Point(35, 78);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(80, 31);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // LoadSheetbtn
            // 
            this.LoadSheetbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LoadSheetbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadSheetbtn.Location = new System.Drawing.Point(35, 164);
            this.LoadSheetbtn.Name = "LoadSheetbtn";
            this.LoadSheetbtn.Size = new System.Drawing.Size(80, 31);
            this.LoadSheetbtn.TabIndex = 2;
            this.LoadSheetbtn.Text = "Load";
            this.LoadSheetbtn.UseVisualStyleBackColor = false;
            this.LoadSheetbtn.Click += new System.EventHandler(this.LoadSheetbtn_Click);
            // 
            // Browsetxt
            // 
            this.Browsetxt.Location = new System.Drawing.Point(191, 78);
            this.Browsetxt.Name = "Browsetxt";
            this.Browsetxt.Size = new System.Drawing.Size(330, 21);
            this.Browsetxt.TabIndex = 3;
            // 
            // Sheettxt
            // 
            this.Sheettxt.Location = new System.Drawing.Point(191, 164);
            this.Sheettxt.Name = "Sheettxt";
            this.Sheettxt.Size = new System.Drawing.Size(330, 21);
            this.Sheettxt.TabIndex = 4;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(1189, 164);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(82, 31);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // gggbackend
            // 
            this.gggbackend.AllowUserToAddRows = false;
            this.gggbackend.AllowUserToDeleteRows = false;
            this.gggbackend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gggbackend.Location = new System.Drawing.Point(20, 225);
            this.gggbackend.Name = "gggbackend";
            this.gggbackend.Size = new System.Drawing.Size(1251, 362);
            this.gggbackend.TabIndex = 8;
            this.gggbackend.Visible = false;
            // 
            // ggg
            // 
            this.ggg.Location = new System.Drawing.Point(20, 225);
            this.ggg.MainView = this.ggg1;
            this.ggg.Name = "ggg";
            this.ggg.Size = new System.Drawing.Size(1251, 362);
            this.ggg.TabIndex = 9;
            this.ggg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ggg1});
            // 
            // ggg1
            // 
            this.ggg1.GridControl = this.ggg;
            this.ggg1.Name = "ggg1";
            // 
            // OneStd
            // 
            this.OneStd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OneStd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneStd.Location = new System.Drawing.Point(1033, 164);
            this.OneStd.Name = "OneStd";
            this.OneStd.Size = new System.Drawing.Size(124, 31);
            this.OneStd.TabIndex = 10;
            this.OneStd.Text = "Insert Manually";
            this.OneStd.UseVisualStyleBackColor = false;
            this.OneStd.Click += new System.EventHandler(this.OneStd_Click);
            // 
            // PanelManualStd
            // 
            this.PanelManualStd.BackgroundImage = global::SEGP.Properties.Resources.simple_background_by_hexdef101_d7x7rup;
            this.PanelManualStd.Controls.Add(this.Clearmanstd);
            this.PanelManualStd.Controls.Add(this.INsertManstd);
            this.PanelManualStd.Controls.Add(this.YearStdManul);
            this.PanelManualStd.Controls.Add(this.ContactStdManul);
            this.PanelManualStd.Controls.Add(this.EmailStdManul);
            this.PanelManualStd.Controls.Add(this.ProgrameStdManul);
            this.PanelManualStd.Controls.Add(this.FatherStdManul);
            this.PanelManualStd.Controls.Add(this.NameStdManul);
            this.PanelManualStd.Controls.Add(this.UobStdManul);
            this.PanelManualStd.Controls.Add(this.label8);
            this.PanelManualStd.Controls.Add(this.label7);
            this.PanelManualStd.Controls.Add(this.label6);
            this.PanelManualStd.Controls.Add(this.label5);
            this.PanelManualStd.Controls.Add(this.label4);
            this.PanelManualStd.Controls.Add(this.label3);
            this.PanelManualStd.Controls.Add(this.label2);
            this.PanelManualStd.Location = new System.Drawing.Point(527, 66);
            this.PanelManualStd.Name = "PanelManualStd";
            this.PanelManualStd.Size = new System.Drawing.Size(386, 435);
            this.PanelManualStd.TabIndex = 11;
            this.PanelManualStd.Visible = false;
            // 
            // Clearmanstd
            // 
            this.Clearmanstd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Clearmanstd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearmanstd.Location = new System.Drawing.Point(244, 378);
            this.Clearmanstd.Name = "Clearmanstd";
            this.Clearmanstd.Size = new System.Drawing.Size(82, 31);
            this.Clearmanstd.TabIndex = 14;
            this.Clearmanstd.Text = "Clear";
            this.Clearmanstd.UseVisualStyleBackColor = false;
            this.Clearmanstd.Click += new System.EventHandler(this.Clearmanstd_Click);
            // 
            // INsertManstd
            // 
            this.INsertManstd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.INsertManstd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INsertManstd.Location = new System.Drawing.Point(123, 378);
            this.INsertManstd.Name = "INsertManstd";
            this.INsertManstd.Size = new System.Drawing.Size(82, 31);
            this.INsertManstd.TabIndex = 12;
            this.INsertManstd.Text = "Insert";
            this.INsertManstd.UseVisualStyleBackColor = false;
            this.INsertManstd.Click += new System.EventHandler(this.INsertManstd_Click);
            // 
            // YearStdManul
            // 
            this.YearStdManul.Location = new System.Drawing.Point(107, 306);
            this.YearStdManul.Name = "YearStdManul";
            this.YearStdManul.Size = new System.Drawing.Size(266, 21);
            this.YearStdManul.TabIndex = 13;
            // 
            // ContactStdManul
            // 
            this.ContactStdManul.Location = new System.Drawing.Point(107, 252);
            this.ContactStdManul.Name = "ContactStdManul";
            this.ContactStdManul.Size = new System.Drawing.Size(266, 21);
            this.ContactStdManul.TabIndex = 12;
            // 
            // EmailStdManul
            // 
            this.EmailStdManul.Location = new System.Drawing.Point(107, 206);
            this.EmailStdManul.Name = "EmailStdManul";
            this.EmailStdManul.Size = new System.Drawing.Size(266, 21);
            this.EmailStdManul.TabIndex = 11;
            // 
            // ProgrameStdManul
            // 
            this.ProgrameStdManul.Location = new System.Drawing.Point(107, 159);
            this.ProgrameStdManul.Name = "ProgrameStdManul";
            this.ProgrameStdManul.Size = new System.Drawing.Size(266, 21);
            this.ProgrameStdManul.TabIndex = 10;
            // 
            // FatherStdManul
            // 
            this.FatherStdManul.Location = new System.Drawing.Point(107, 113);
            this.FatherStdManul.Name = "FatherStdManul";
            this.FatherStdManul.Size = new System.Drawing.Size(266, 21);
            this.FatherStdManul.TabIndex = 9;
            // 
            // NameStdManul
            // 
            this.NameStdManul.Location = new System.Drawing.Point(107, 69);
            this.NameStdManul.Name = "NameStdManul";
            this.NameStdManul.Size = new System.Drawing.Size(266, 21);
            this.NameStdManul.TabIndex = 8;
            // 
            // UobStdManul
            // 
            this.UobStdManul.Location = new System.Drawing.Point(107, 19);
            this.UobStdManul.Name = "UobStdManul";
            this.UobStdManul.Size = new System.Drawing.Size(266, 21);
            this.UobStdManul.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Contact:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Programme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Father Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "UoB:";
            // 
            // InsertStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SEGP.Properties.Resources.simple_background_by_hexdef101_d7x7rup;
            this.Controls.Add(this.PanelManualStd);
            this.Controls.Add(this.OneStd);
            this.Controls.Add(this.gggbackend);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Sheettxt);
            this.Controls.Add(this.Browsetxt);
            this.Controls.Add(this.LoadSheetbtn);
            this.Controls.Add(this.ggg);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.label1);
            this.Name = "InsertStudents";
            this.Size = new System.Drawing.Size(1300, 600);
            this.Click += new System.EventHandler(this.InsertStudents_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gggbackend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ggg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ggg1)).EndInit();
            this.PanelManualStd.ResumeLayout(false);
            this.PanelManualStd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button LoadSheetbtn;
        private System.Windows.Forms.TextBox Browsetxt;
        private System.Windows.Forms.TextBox Sheettxt;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView gggbackend;
        private DevExpress.XtraGrid.GridControl ggg;
        private DevExpress.XtraGrid.Views.Grid.GridView ggg1;
        private System.Windows.Forms.Button OneStd;
        private System.Windows.Forms.Panel PanelManualStd;
        private System.Windows.Forms.Button Clearmanstd;
        private System.Windows.Forms.Button INsertManstd;
        private System.Windows.Forms.TextBox YearStdManul;
        private System.Windows.Forms.TextBox ContactStdManul;
        private System.Windows.Forms.TextBox EmailStdManul;
        private System.Windows.Forms.TextBox ProgrameStdManul;
        private System.Windows.Forms.TextBox FatherStdManul;
        private System.Windows.Forms.TextBox NameStdManul;
        private System.Windows.Forms.TextBox UobStdManul;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
