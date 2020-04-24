namespace BookApiClient
{
    partial class frmPublisher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPublisher));
            this.groupControlPublisher = new DevExpress.XtraEditors.GroupControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPublisher)).BeginInit();
            this.groupControlPublisher.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlPublisher
            // 
            this.groupControlPublisher.Controls.Add(this.btnSua);
            this.groupControlPublisher.Controls.Add(this.btnXoa);
            this.groupControlPublisher.Controls.Add(this.btnReload);
            this.groupControlPublisher.Controls.Add(this.btnThem);
            this.groupControlPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlPublisher.Location = new System.Drawing.Point(0, 0);
            this.groupControlPublisher.Name = "groupControlPublisher";
            this.groupControlPublisher.Size = new System.Drawing.Size(995, 100);
            this.groupControlPublisher.TabIndex = 0;
            this.groupControlPublisher.Text = "Thao Tác";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(180, 43);
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThem.Size = new System.Drawing.Size(93, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "ADD NEW";
            // 
            // btnReload
            // 
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnReload.Location = new System.Drawing.Point(635, 43);
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnReload.Size = new System.Drawing.Size(85, 30);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "RELOAD";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(334, 43);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXoa.Size = new System.Drawing.Size(85, 30);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "DELETE";
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(487, 43);
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "EDIT";
            // 
            // frmPublisher
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 387);
            this.Controls.Add(this.groupControlPublisher);
            this.Name = "frmPublisher";
            this.Text = "   Publisher  ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPublisher)).EndInit();
            this.groupControlPublisher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlPublisher;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}