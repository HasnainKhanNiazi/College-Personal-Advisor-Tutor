﻿namespace SEGP
{
    partial class Year2
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
            this.gggyc2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1y2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gggyc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gggyc2
            // 
            this.gggyc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gggyc2.Location = new System.Drawing.Point(0, 0);
            this.gggyc2.MainView = this.gridView1y2;
            this.gggyc2.Name = "gggyc2";
            this.gggyc2.Size = new System.Drawing.Size(1300, 600);
            this.gggyc2.TabIndex = 0;
            this.gggyc2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1y2});
            // 
            // gridView1y2
            // 
            this.gridView1y2.GridControl = this.gggyc2;
            this.gridView1y2.Name = "gridView1y2";
            this.gridView1y2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1y2_MouseDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1300, 600);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // Year2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SEGP.Properties.Resources.simple_background_by_hexdef101_d7x7rup;
            this.Controls.Add(this.gggyc2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Year2";
            this.Size = new System.Drawing.Size(1300, 600);
            this.Load += new System.EventHandler(this.Year2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gggyc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gggyc2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1y2;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}