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
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlEdit = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPublisher)).BeginInit();
            this.groupControlPublisher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlEdit)).BeginInit();
            this.groupControlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
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
            this.groupControlPublisher.Size = new System.Drawing.Size(995, 74);
            this.groupControlPublisher.TabIndex = 0;
            this.groupControlPublisher.Text = "Action";
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(500, 32);
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "EDIT";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(347, 32);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXoa.Size = new System.Drawing.Size(85, 30);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "DELETE";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReload
            // 
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.Location = new System.Drawing.Point(648, 32);
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnReload.Size = new System.Drawing.Size(85, 30);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "RELOAD";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(193, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThem.Size = new System.Drawing.Size(93, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "ADD NEW";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 74);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(995, 331);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colPhone,
            this.colAddress});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "LIST ALL OF PUBLISHER";
            // 
            // colID
            // 
            this.colID.AppearanceCell.Options.UseTextOptions = true;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 40;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 308;
            // 
            // colPhone
            // 
            this.colPhone.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPhone.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.ReadOnly = true;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            this.colPhone.Width = 150;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.ReadOnly = true;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 3;
            this.colAddress.Width = 472;
            // 
            // groupControlEdit
            // 
            this.groupControlEdit.Controls.Add(this.labelControl4);
            this.groupControlEdit.Controls.Add(this.labelControl3);
            this.groupControlEdit.Controls.Add(this.labelControl2);
            this.groupControlEdit.Controls.Add(this.lblId);
            this.groupControlEdit.Controls.Add(this.btnHuy);
            this.groupControlEdit.Controls.Add(this.btnSave);
            this.groupControlEdit.Controls.Add(this.txtAddress);
            this.groupControlEdit.Controls.Add(this.txtPhone);
            this.groupControlEdit.Controls.Add(this.txtName);
            this.groupControlEdit.Controls.Add(this.txtID);
            this.groupControlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlEdit.Location = new System.Drawing.Point(0, 405);
            this.groupControlEdit.Name = "groupControlEdit";
            this.groupControlEdit.Size = new System.Drawing.Size(995, 90);
            this.groupControlEdit.TabIndex = 2;
            this.groupControlEdit.Text = "Edit";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(532, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Address";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(374, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Phone";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(114, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(19, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(11, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(905, 37);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnHuy.Size = new System.Drawing.Size(93, 30);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "CANCEL";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(809, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSave.Size = new System.Drawing.Size(93, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(577, 42);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(226, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(410, 42);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(36, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(51, 20);
            this.txtID.TabIndex = 0;
            // 
            // frmPublisher
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 495);
            this.Controls.Add(this.groupControlEdit);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControlPublisher);
            this.Name = "frmPublisher";
            this.Text = "   Publisher  ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPublisher)).EndInit();
            this.groupControlPublisher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlEdit)).EndInit();
            this.groupControlEdit.ResumeLayout(false);
            this.groupControlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlPublisher;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraEditors.GroupControl groupControlEdit;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblId;
    }
}