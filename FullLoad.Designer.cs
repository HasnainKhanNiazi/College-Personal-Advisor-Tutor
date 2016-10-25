namespace SEGP
{
    partial class FullLoad
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
            this.ggg = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ggg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ggg
            // 
            this.ggg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ggg.Location = new System.Drawing.Point(0, 0);
            this.ggg.MainView = this.gridView1;
            this.ggg.Name = "ggg";
            this.ggg.Size = new System.Drawing.Size(1300, 600);
            this.ggg.TabIndex = 1;
            this.ggg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.ggg;
            this.gridView1.Name = "gridView1";
            // 
            // FullLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SEGP.Properties.Resources.simple_background_by_hexdef101_d7x7rup;
            this.Controls.Add(this.ggg);
            this.Name = "FullLoad";
            this.Size = new System.Drawing.Size(1300, 600);
            this.Load += new System.EventHandler(this.FullLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ggg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ggg;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

    }
}
