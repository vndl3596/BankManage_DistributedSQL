namespace QLNH_PhanTan
{
    partial class frmTaiKhoan
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
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QLNH_PhanTan.DS();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new QLNH_PhanTan.DSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new QLNH_PhanTan.DSTableAdapters.TableAdapterManager();
            this.gD_GOIRUTTableAdapter = new QLNH_PhanTan.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.gcTK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsGuiRutTien = new System.Windows.Forms.BindingSource(this.components);
            this.bsdChuyenTien = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENTableAdapter = new QLNH_PhanTan.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.dSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new QLNH_PhanTan.DSTableAdapters.KhachHangTableAdapter();
            this.bsdKH = new System.Windows.Forms.BindingSource(this.components);
            this.sp_HIENTHIKHACHHANGTableAdapter = new QLNH_PhanTan.DSTableAdapters.sp_HIENTHIKHACHHANGTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ngayMoTK = new DevExpress.XtraEditors.DateEdit();
            this.txtSoDu = new System.Windows.Forms.TextBox();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcDSKH = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCN = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new QLNH_PhanTan.DSTableAdapters.ChiNhanhTableAdapter();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGuiRutTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdChuyenTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMoTK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMoTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(24, 94);
            sOTKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(107, 21);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "Số tài khoản:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(633, 148);
            cMNDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(69, 21);
            cMNDLabel.TabIndex = 2;
            cMNDLabel.Text = "CMND:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(580, 200);
            mACNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(122, 21);
            mACNLabel.TabIndex = 4;
            mACNLabel.Text = "Mã Chi Nhánh:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(79, 164);
            sODULabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(63, 21);
            sODULabel.TabIndex = 6;
            sODULabel.Text = "Số Dư:";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Location = new System.Drawing.Point(590, 94);
            nGAYMOTKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(112, 21);
            nGAYMOTKLabel.TabIndex = 8;
            nGAYMOTKLabel.Text = "Ngày mở TK:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemTK,
            this.btnGhiTK,
            this.btnXoaTK,
            this.btnUndo,
            this.btnRefresh,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 21;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemTK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiTK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaTK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemTK
            // 
            this.btnThemTK.Caption = "Thêm";
            this.btnThemTK.Id = 15;
            this.btnThemTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTK.ImageOptions.Image")));
            this.btnThemTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemTK.ImageOptions.LargeImage")));
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemTK_ItemClick);
            // 
            // btnGhiTK
            // 
            this.btnGhiTK.Caption = "Ghi";
            this.btnGhiTK.Id = 16;
            this.btnGhiTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiTK.ImageOptions.Image")));
            this.btnGhiTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiTK.ImageOptions.LargeImage")));
            this.btnGhiTK.Name = "btnGhiTK";
            this.btnGhiTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiTK_ItemClick);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Caption = "Xóa";
            this.btnXoaTK.Id = 17;
            this.btnXoaTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTK.ImageOptions.Image")));
            this.btnXoaTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaTK.ImageOptions.LargeImage")));
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaTK_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục Hồi";
            this.btnUndo.Id = 18;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Reload";
            this.btnRefresh.Id = 19;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 20;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlTop.Size = new System.Drawing.Size(1412, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 895);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1412, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 865);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1412, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 865);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbChiNhanh);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 30);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1412, 78);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(226, 24);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(576, 28);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "TaiKhoan";
            this.bdsTK.DataSource = this.dS;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLNH_PhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // gcTK
            // 
            this.gcTK.DataSource = this.bdsTK;
            this.gcTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTK.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcTK.Location = new System.Drawing.Point(2, 28);
            this.gcTK.MainView = this.gridView1;
            this.gcTK.Margin = new System.Windows.Forms.Padding(4);
            this.gcTK.MenuManager = this.barManager1;
            this.gcTK.Name = "gcTK";
            this.gcTK.Size = new System.Drawing.Size(382, 279);
            this.gcTK.TabIndex = 6;
            this.gcTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcTK;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 31;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.OptionsColumn.AllowEdit = false;
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 117;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 31;
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.AllowEdit = false;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 117;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 31;
            this.colSODU.Name = "colSODU";
            this.colSODU.OptionsColumn.AllowEdit = false;
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 117;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 31;
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 117;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 31;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.OptionsColumn.AllowEdit = false;
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 117;
            // 
            // bdsGuiRutTien
            // 
            this.bdsGuiRutTien.DataMember = "FK_GD_GOIRUT_TaiKhoan";
            this.bdsGuiRutTien.DataSource = this.bdsTK;
            // 
            // bsdChuyenTien
            // 
            this.bsdChuyenTien.DataMember = "FK_GD_CHUYENTIEN_TaiKhoan";
            this.bsdChuyenTien.DataSource = this.bdsTK;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // dSBindingSource
            // 
            this.dSBindingSource.DataSource = this.dS;
            this.dSBindingSource.Position = 0;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // bsdKH
            // 
            this.bsdKH.DataMember = "sp_HIENTHIKHACHHANG";
            this.bsdKH.DataSource = this.dS;
            // 
            // sp_HIENTHIKHACHHANGTableAdapter
            // 
            this.sp_HIENTHIKHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(nGAYMOTKLabel);
            this.groupControl2.Controls.Add(this.ngayMoTK);
            this.groupControl2.Controls.Add(sODULabel);
            this.groupControl2.Controls.Add(this.txtSoDu);
            this.groupControl2.Controls.Add(mACNLabel);
            this.groupControl2.Controls.Add(this.txtMaCN);
            this.groupControl2.Controls.Add(cMNDLabel);
            this.groupControl2.Controls.Add(this.txtCMND);
            this.groupControl2.Controls.Add(sOTKLabel);
            this.groupControl2.Controls.Add(this.txtSTK);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 108);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1026, 787);
            this.groupControl2.TabIndex = 18;
            // 
            // ngayMoTK
            // 
            this.ngayMoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "NGAYMOTK", true));
            this.ngayMoTK.EditValue = null;
            this.ngayMoTK.Location = new System.Drawing.Point(748, 90);
            this.ngayMoTK.Margin = new System.Windows.Forms.Padding(4);
            this.ngayMoTK.MenuManager = this.barManager1;
            this.ngayMoTK.Name = "ngayMoTK";
            this.ngayMoTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayMoTK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayMoTK.Size = new System.Drawing.Size(238, 26);
            this.ngayMoTK.TabIndex = 9;
            // 
            // txtSoDu
            // 
            this.txtSoDu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SODU", true));
            this.txtSoDu.Location = new System.Drawing.Point(186, 160);
            this.txtSoDu.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(239, 28);
            this.txtSoDu.TabIndex = 7;
            // 
            // txtMaCN
            // 
            this.txtMaCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "MACN", true));
            this.txtMaCN.Location = new System.Drawing.Point(748, 196);
            this.txtMaCN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(236, 28);
            this.txtMaCN.TabIndex = 5;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(748, 144);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(236, 28);
            this.txtCMND.TabIndex = 3;
            // 
            // txtSTK
            // 
            this.txtSTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SOTK", true));
            this.txtSTK.Location = new System.Drawing.Point(186, 94);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(239, 28);
            this.txtSTK.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gcTK);
            this.groupControl3.Controls.Add(this.gcDSKH);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(1026, 108);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(386, 787);
            this.groupControl3.TabIndex = 23;
            this.groupControl3.Text = "Danh Sách Tài Khoản";
            // 
            // gcDSKH
            // 
            this.gcDSKH.DataSource = this.bsdKH;
            this.gcDSKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDSKH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDSKH.Location = new System.Drawing.Point(2, 307);
            this.gcDSKH.MainView = this.gridView2;
            this.gcDSKH.Margin = new System.Windows.Forms.Padding(4);
            this.gcDSKH.MenuManager = this.barManager1;
            this.gcDSKH.Name = "gcDSKH";
            this.gcDSKH.Size = new System.Drawing.Size(382, 478);
            this.gcDSKH.TabIndex = 0;
            this.gcDSKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gcDSKH.Click += new System.EventHandler(this.gcDSKH_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND1,
            this.colHOTEN,
            this.colDIACHI,
            this.colSODT,
            this.colPHAI,
            this.colMACN1});
            this.gridView2.DetailHeight = 437;
            this.gridView2.GridControl = this.gcDSKH;
            this.gridView2.Name = "gridView2";
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.MinWidth = 31;
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.OptionsColumn.AllowEdit = false;
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 0;
            this.colCMND1.Width = 117;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 31;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 117;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 31;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            this.colDIACHI.Width = 117;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 31;
            this.colSODT.Name = "colSODT";
            this.colSODT.OptionsColumn.AllowEdit = false;
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 3;
            this.colSODT.Width = 117;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 31;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.Width = 117;
            // 
            // colMACN1
            // 
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.MinWidth = 31;
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.OptionsColumn.AllowEdit = false;
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 4;
            this.colMACN1.Width = 117;
            // 
            // bdsCN
            // 
            this.bdsCN.DataMember = "ChiNhanh";
            this.bdsCN.DataSource = this.dS;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 915);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTaiKhoan";
            this.Text = "Tài Khoản";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGuiRutTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdChuyenTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMoTK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMoTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemTK;
        private DevExpress.XtraBars.BarButtonItem btnGhiTK;
        private DevExpress.XtraBars.BarButtonItem btnXoaTK;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsTK;
        private DS dS;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private System.Windows.Forms.BindingSource bdsGuiRutTien;
        private System.Windows.Forms.BindingSource bsdChuyenTien;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private System.Windows.Forms.BindingSource dSBindingSource;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.BindingSource bsdKH;
        private DSTableAdapters.sp_HIENTHIKHACHHANGTableAdapter sp_HIENTHIKHACHHANGTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.DateEdit ngayMoTK;
        private System.Windows.Forms.TextBox txtSoDu;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.BindingSource bdsCN;
        private DSTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private DevExpress.XtraGrid.GridControl gcDSKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
    }
}