namespace SEGP
{
    partial class Year1
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
            this.gggcy1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gggcy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gggcy1
            // 
            this.gggcy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gggcy1.Location = new System.Drawing.Point(0, 0);
            this.gggcy1.MainView = this.layoutView1;
            this.gggcy1.Name = "gggcy1";
            this.gggcy1.Size = new System.Drawing.Size(1300, 600);
            this.gggcy1.TabIndex = 0;
            this.gggcy1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.Card.BackColor = System.Drawing.Color.DimGray;
            this.layoutView1.Appearance.Card.Options.UseBackColor = true;
            this.layoutView1.Appearance.CardCaption.BackColor = System.Drawing.Color.Gainsboro;
            this.layoutView1.Appearance.CardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.FieldCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutView1.Appearance.FieldCaption.Options.UseFont = true;
            this.layoutView1.Appearance.FieldValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.layoutView1.Appearance.FieldValue.Options.UseBorderColor = true;
            this.layoutView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.layoutView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.layoutView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Lime;
            this.layoutView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.layoutView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.layoutView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.layoutView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.layoutView1.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.layoutView1.Appearance.HideSelectionCardCaption.Options.UseBackColor = true;
            this.layoutView1.CardMinSize = new System.Drawing.Size(298, 410);
            this.layoutView1.GridControl = this.gggcy1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.AllowBorderColorBlending = true;
            this.layoutView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.layoutView1.OptionsView.ShowCardFieldBorders = true;
            this.layoutView1.OptionsView.ShowViewCaption = true;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.layoutView1.ViewCaption = "<b>Press (Control+F) to Search </b>";
            this.layoutView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.layoutView1_MouseDown);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
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
            // Year1
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SEGP.Properties.Resources.simple_background_by_hexdef101_d7x7rup;
            this.Controls.Add(this.gggcy1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Year1";
            this.Size = new System.Drawing.Size(1300, 600);
            this.Load += new System.EventHandler(this.Year1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gggcy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gggcy1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;

    }
}
