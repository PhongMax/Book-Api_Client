namespace BookApiClient
{
    partial class frmBook
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
            DevExpress.DataAccess.Json.UriJsonSource uriJsonSource2 = new DevExpress.DataAccess.Json.UriJsonSource();
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode11 = new DevExpress.DataAccess.Json.JsonSchemaNode("root", true, DevExpress.DataAccess.Json.JsonNodeType.Array);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode12 = new DevExpress.DataAccess.Json.JsonSchemaNode("ID", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode13 = new DevExpress.DataAccess.Json.JsonSchemaNode("Name", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode14 = new DevExpress.DataAccess.Json.JsonSchemaNode("PubDate", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<System.DateTime>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode15 = new DevExpress.DataAccess.Json.JsonSchemaNode("Cost", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode16 = new DevExpress.DataAccess.Json.JsonSchemaNode("Retail", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode17 = new DevExpress.DataAccess.Json.JsonSchemaNode("BookCategoryName", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode18 = new DevExpress.DataAccess.Json.JsonSchemaNode("PublisherName", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode19 = new DevExpress.DataAccess.Json.JsonSchemaNode("Images", true, DevExpress.DataAccess.Json.JsonNodeType.Array, typeof(string[]));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode20 = new DevExpress.DataAccess.Json.JsonSchemaNode("AuthorNames", true, DevExpress.DataAccess.Json.JsonNodeType.Array, typeof(string[]));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPubDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBookCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublisherName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.jsonDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(995, 495);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // jsonDataSource1
            // 
            uriJsonSource2.Uri = new System.Uri("https://bookapiptit.azurewebsites.net/api/books/getalltoview", System.UriKind.Absolute);
            this.jsonDataSource1.JsonSource = uriJsonSource2;
            this.jsonDataSource1.Name = "jsonDataSource1";
            jsonSchemaNode11.Nodes.Add(jsonSchemaNode12);
            jsonSchemaNode11.Nodes.Add(jsonSchemaNode13);
            jsonSchemaNode11.Nodes.Add(jsonSchemaNode14);
            jsonSchemaNode11.Nodes.Add(jsonSchemaNode15);
            jsonSchemaNode11.Nodes.Add(jsonSchemaNode16);
            jsonSchemaNode11.Nodes.Add(jsonSchemaNode17);
            jsonSchemaNode11.Nodes.Add(jsonSchemaNode18);
            jsonSchemaNode11.Nodes.Add(jsonSchemaNode19);
            jsonSchemaNode11.Nodes.Add(jsonSchemaNode20);
            this.jsonDataSource1.Schema = jsonSchemaNode11;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colPubDate,
            this.colCost,
            this.colRetail,
            this.colBookCategoryName,
            this.colPublisherName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colPubDate
            // 
            this.colPubDate.FieldName = "PubDate";
            this.colPubDate.Name = "colPubDate";
            this.colPubDate.OptionsColumn.ReadOnly = true;
            this.colPubDate.Visible = true;
            this.colPubDate.VisibleIndex = 2;
            // 
            // colCost
            // 
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.OptionsColumn.ReadOnly = true;
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 3;
            // 
            // colRetail
            // 
            this.colRetail.FieldName = "Retail";
            this.colRetail.Name = "colRetail";
            this.colRetail.OptionsColumn.ReadOnly = true;
            this.colRetail.Visible = true;
            this.colRetail.VisibleIndex = 4;
            // 
            // colBookCategoryName
            // 
            this.colBookCategoryName.FieldName = "BookCategoryName";
            this.colBookCategoryName.Name = "colBookCategoryName";
            this.colBookCategoryName.OptionsColumn.ReadOnly = true;
            this.colBookCategoryName.Visible = true;
            this.colBookCategoryName.VisibleIndex = 5;
            // 
            // colPublisherName
            // 
            this.colPublisherName.FieldName = "PublisherName";
            this.colPublisherName.Name = "colPublisherName";
            this.colPublisherName.OptionsColumn.ReadOnly = true;
            this.colPublisherName.Visible = true;
            this.colPublisherName.VisibleIndex = 6;
            // 
            // frmBook
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 495);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmBook";
            this.Text = "     Book    ";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPubDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraGrid.Columns.GridColumn colRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colBookCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colPublisherName;
    }
}