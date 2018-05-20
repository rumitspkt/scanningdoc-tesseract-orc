namespace ScanningDoc
{
   partial class frmAdvancedSetting
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvancedSetting));
         this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
         this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
         this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
         this.btnThem = new DevExpress.XtraEditors.SimpleButton();
         this.edtMaLQ = new DevExpress.XtraEditors.TextEdit();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.cbbMaVB = new DevExpress.XtraEditors.ComboBoxEdit();
         this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
         this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
         this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
         this.gridControl1 = new DevExpress.XtraGrid.GridControl();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
         this.layoutControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.edtMaLQ.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cbbMaVB.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // layoutControl1
         // 
         this.layoutControl1.Controls.Add(this.btnRefresh);
         this.layoutControl1.Controls.Add(this.btnXoa);
         this.layoutControl1.Controls.Add(this.btnThem);
         this.layoutControl1.Controls.Add(this.edtMaLQ);
         this.layoutControl1.Controls.Add(this.labelControl1);
         this.layoutControl1.Controls.Add(this.cbbMaVB);
         this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.layoutControl1.Location = new System.Drawing.Point(0, 0);
         this.layoutControl1.Name = "layoutControl1";
         this.layoutControl1.Root = this.layoutControlGroup1;
         this.layoutControl1.Size = new System.Drawing.Size(444, 105);
         this.layoutControl1.TabIndex = 0;
         this.layoutControl1.Text = "layoutControl1";
         // 
         // btnRefresh
         // 
         this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
         this.btnRefresh.Location = new System.Drawing.Point(343, 12);
         this.btnRefresh.Name = "btnRefresh";
         this.btnRefresh.Size = new System.Drawing.Size(89, 22);
         this.btnRefresh.StyleController = this.layoutControl1;
         this.btnRefresh.TabIndex = 9;
         this.btnRefresh.Text = "Refresh";
         this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
         // 
         // btnXoa
         // 
         this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
         this.btnXoa.Location = new System.Drawing.Point(372, 38);
         this.btnXoa.Name = "btnXoa";
         this.btnXoa.Size = new System.Drawing.Size(60, 22);
         this.btnXoa.StyleController = this.layoutControl1;
         this.btnXoa.TabIndex = 8;
         this.btnXoa.Text = "Xóa";
         this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
         // 
         // btnThem
         // 
         this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
         this.btnThem.Location = new System.Drawing.Point(308, 38);
         this.btnThem.Name = "btnThem";
         this.btnThem.Size = new System.Drawing.Size(60, 22);
         this.btnThem.StyleController = this.layoutControl1;
         this.btnThem.TabIndex = 7;
         this.btnThem.Text = "Thêm";
         this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
         // 
         // edtMaLQ
         // 
         this.edtMaLQ.Location = new System.Drawing.Point(223, 38);
         this.edtMaLQ.Name = "edtMaLQ";
         this.edtMaLQ.Size = new System.Drawing.Size(81, 20);
         this.edtMaLQ.StyleController = this.layoutControl1;
         this.edtMaLQ.TabIndex = 6;
         // 
         // labelControl1
         // 
         this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl1.Appearance.Options.UseFont = true;
         this.labelControl1.Location = new System.Drawing.Point(12, 12);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(327, 19);
         this.labelControl1.StyleController = this.layoutControl1;
         this.labelControl1.TabIndex = 5;
         this.labelControl1.Text = "Nhóm các mã văn bản                              ";
         // 
         // cbbMaVB
         // 
         this.cbbMaVB.Location = new System.Drawing.Point(75, 38);
         this.cbbMaVB.Name = "cbbMaVB";
         this.cbbMaVB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.cbbMaVB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
         this.cbbMaVB.Size = new System.Drawing.Size(81, 20);
         this.cbbMaVB.StyleController = this.layoutControl1;
         this.cbbMaVB.TabIndex = 4;
         this.cbbMaVB.SelectedIndexChanged += new System.EventHandler(this.cbbMaVB_SelectedIndexChanged);
         // 
         // layoutControlGroup1
         // 
         this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.layoutControlGroup1.GroupBordersVisible = false;
         this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem6});
         this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlGroup1.Name = "layoutControlGroup1";
         this.layoutControlGroup1.Size = new System.Drawing.Size(444, 105);
         this.layoutControlGroup1.TextVisible = false;
         // 
         // emptySpaceItem1
         // 
         this.emptySpaceItem1.AllowHotTrack = false;
         this.emptySpaceItem1.Location = new System.Drawing.Point(0, 52);
         this.emptySpaceItem1.Name = "emptySpaceItem1";
         this.emptySpaceItem1.Size = new System.Drawing.Size(424, 33);
         this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
         // 
         // layoutControlItem2
         // 
         this.layoutControlItem2.Control = this.labelControl1;
         this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItem2.Name = "layoutControlItem2";
         this.layoutControlItem2.Size = new System.Drawing.Size(331, 26);
         this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem2.TextVisible = false;
         // 
         // layoutControlItem3
         // 
         this.layoutControlItem3.Control = this.edtMaLQ;
         this.layoutControlItem3.Location = new System.Drawing.Point(148, 26);
         this.layoutControlItem3.Name = "layoutControlItem3";
         this.layoutControlItem3.Size = new System.Drawing.Size(148, 26);
         this.layoutControlItem3.Text = "Mã liên quan";
         this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 13);
         // 
         // layoutControlItem4
         // 
         this.layoutControlItem4.Control = this.btnThem;
         this.layoutControlItem4.Location = new System.Drawing.Point(296, 26);
         this.layoutControlItem4.Name = "layoutControlItem4";
         this.layoutControlItem4.Size = new System.Drawing.Size(64, 26);
         this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem4.TextVisible = false;
         // 
         // layoutControlItem5
         // 
         this.layoutControlItem5.Control = this.btnXoa;
         this.layoutControlItem5.Location = new System.Drawing.Point(360, 26);
         this.layoutControlItem5.Name = "layoutControlItem5";
         this.layoutControlItem5.Size = new System.Drawing.Size(64, 26);
         this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem5.TextVisible = false;
         // 
         // layoutControlItem1
         // 
         this.layoutControlItem1.Control = this.cbbMaVB;
         this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
         this.layoutControlItem1.Name = "layoutControlItem1";
         this.layoutControlItem1.Size = new System.Drawing.Size(148, 26);
         this.layoutControlItem1.Text = "Mã văn bản";
         this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 13);
         // 
         // layoutControlItem6
         // 
         this.layoutControlItem6.Control = this.btnRefresh;
         this.layoutControlItem6.Location = new System.Drawing.Point(331, 0);
         this.layoutControlItem6.Name = "layoutControlItem6";
         this.layoutControlItem6.Size = new System.Drawing.Size(93, 26);
         this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem6.TextVisible = false;
         // 
         // gridControl1
         // 
         this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridControl1.Location = new System.Drawing.Point(0, 105);
         this.gridControl1.MainView = this.gridView1;
         this.gridControl1.Name = "gridControl1";
         this.gridControl1.Size = new System.Drawing.Size(444, 156);
         this.gridControl1.TabIndex = 1;
         this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
         // 
         // gridView1
         // 
         this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
         this.gridView1.GridControl = this.gridControl1;
         this.gridView1.Name = "gridView1";
         // 
         // gridColumn1
         // 
         this.gridColumn1.Caption = "Mã liên quan";
         this.gridColumn1.FieldName = "Name";
         this.gridColumn1.Name = "gridColumn1";
         this.gridColumn1.OptionsColumn.AllowEdit = false;
         this.gridColumn1.OptionsColumn.AllowFocus = false;
         this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
         this.gridColumn1.Visible = true;
         this.gridColumn1.VisibleIndex = 0;
         // 
         // frmAdvancedSetting
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(444, 261);
         this.Controls.Add(this.gridControl1);
         this.Controls.Add(this.layoutControl1);
         this.Name = "frmAdvancedSetting";
         this.Text = "Cài đặt nâng cao";
         this.Load += new System.EventHandler(this.frmAdvancedSetting_Load);
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
         this.layoutControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.edtMaLQ.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cbbMaVB.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraLayout.LayoutControl layoutControl1;
      private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
      private DevExpress.XtraEditors.SimpleButton btnXoa;
      private DevExpress.XtraEditors.SimpleButton btnThem;
      private DevExpress.XtraEditors.TextEdit edtMaLQ;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private DevExpress.XtraEditors.ComboBoxEdit cbbMaVB;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
      private DevExpress.XtraGrid.GridControl gridControl1;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
      private DevExpress.XtraEditors.SimpleButton btnRefresh;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
   }
}