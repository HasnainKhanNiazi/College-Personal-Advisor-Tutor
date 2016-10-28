namespace SEGP
{
    partial class InsertTeachers
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
            this.gggbackend = new System.Windows.Forms.DataGridView();
            this.Browse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gggbackend)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gggbackend
            // 
            this.gggbackend.AllowUserToAddRows = false;
            this.gggbackend.AllowUserToDeleteRows = false;
            this.gggbackend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gggbackend.Location = new System.Drawing.Point(25, 225);
            this.gggbackend.Name = "gggbackend";
            this.gggbackend.Size = new System.Drawing.Size(1251, 362);
            this.gggbackend.TabIndex = 18;
            this.gggbackend.Visible = false;
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Browse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.Location = new System.Drawing.Point(581, 450);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(223, 44);
            this.Browse.TabIndex = 13;
            this.Browse.Text = "Select Files to Insert Data";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImage = global::SEGP.Properties.Resources.Jumpshare__1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Browse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 600);
            this.panel1.TabIndex = 23;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // InsertTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SEGP.Properties.Resources.simple_background_by_hexdef101_d7x7rup;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gggbackend);
            this.Name = "InsertTeachers";
            this.Size = new System.Drawing.Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)(this.gggbackend)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gggbackend;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Panel panel1;
    }
}
