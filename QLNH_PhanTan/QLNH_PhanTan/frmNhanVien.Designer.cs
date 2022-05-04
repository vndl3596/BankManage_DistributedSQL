namespace QLNH_PhanTan
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label mACNLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.dS = new QLNH_PhanTan.DS();
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLNH_PhanTan.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLNH_PhanTan.DSTableAdapters.TableAdapterManager();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.checkXoaNV = new System.Windows.Forms.CheckBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cmbPhai = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.bsdCN = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new QLNH_PhanTan.DSTableAdapters.ChiNhanhTableAdapter();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            mACNLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsdCN)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(124, 65);
            mANVLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(113, 21);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(854, 54);
            hOLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(37, 21);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(1266, 54);
            tENLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(43, 21);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(174, 180);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(73, 21);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa Chỉ:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(190, 114);
            pHAILabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(46, 21);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "Phái:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(854, 114);
            sODTLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(50, 21);
            sODTLabel.TabIndex = 10;
            sODTLabel.Text = "SĐT:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(960, 299);
            mACNLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(0, 21);
            mACNLabel.TabIndex = 12;
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(854, 176);
            trangThaiXoaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(143, 21);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "Nhân viên đã xóa:";
            // 
            // mACNLabel1
            // 
            mACNLabel1.AutoSize = true;
            mACNLabel1.Location = new System.Drawing.Point(928, 234);
            mACNLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mACNLabel1.Name = "mACNLabel1";
            mACNLabel1.Size = new System.Drawing.Size(0, 21);
            mACNLabel1.TabIndex = 15;
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
            this.barButtonItem1,
            this.btnThemNV,
            this.btnLuuNV,
            this.btnXoaNV,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat,
            this.btnChuyen});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(406, 174);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChuyen),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Caption = "Thêm";
            this.btnThemNV.Id = 1;
            this.btnThemNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.ImageOptions.Image")));
            this.btnThemNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemNV.ImageOptions.LargeImage")));
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemNV_ItemClick);
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.Caption = "Ghi";
            this.btnLuuNV.Id = 3;
            this.btnLuuNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuNV.ImageOptions.Image")));
            this.btnLuuNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuuNV.ImageOptions.LargeImage")));
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuNV_ItemClick);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Caption = "Xóa";
            this.btnXoaNV.Id = 4;
            this.btnXoaNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNV.ImageOptions.Image")));
            this.btnXoaNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaNV.ImageOptions.LargeImage")));
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaNV_ItemClick);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Caption = "Chuyển Chi Nhánh";
            this.btnChuyen.Id = 9;
            this.btnChuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyen.ImageOptions.Image")));
            this.btnChuyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChuyen.ImageOptions.LargeImage")));
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyen_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1485, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 890);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1485, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 860);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1485, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 860);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(406, 161);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cmbChiNhanh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 30);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1485, 78);
            this.groupControl1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh:";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(226, 24);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(24);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(576, 28);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSNV
            // 
            this.bdsDSNV.DataMember = "NhanVien";
            this.bdsDSNV.DataSource = this.dS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLNH_PhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.bdsDSNV;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(19);
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 108);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.Margin = new System.Windows.Forms.Padding(19);
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1485, 374);
            this.nhanVienGridControl.TabIndex = 24;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.nhanVienGridControl.Click += new System.EventHandler(this.nhanVienGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.DetailHeight = 2080;
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 154;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 576;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 154;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 576;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 154;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 576;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 154;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 576;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 154;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 576;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 154;
            this.colSODT.Name = "colSODT";
            this.colSODT.OptionsColumn.AllowEdit = false;
            this.colSODT.Width = 576;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 154;
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 5;
            this.colMACN.Width = 576;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 154;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.OptionsColumn.AllowEdit = false;
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 6;
            this.colTrangThaiXoa.Width = 576;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(mACNLabel1);
            this.groupControl2.Controls.Add(this.txtCN);
            this.groupControl2.Controls.Add(trangThaiXoaLabel);
            this.groupControl2.Controls.Add(this.checkXoaNV);
            this.groupControl2.Controls.Add(mACNLabel);
            this.groupControl2.Controls.Add(sODTLabel);
            this.groupControl2.Controls.Add(this.txtSDT);
            this.groupControl2.Controls.Add(pHAILabel);
            this.groupControl2.Controls.Add(this.cmbPhai);
            this.groupControl2.Controls.Add(dIACHILabel);
            this.groupControl2.Controls.Add(this.txtDiaChi);
            this.groupControl2.Controls.Add(tENLabel);
            this.groupControl2.Controls.Add(this.txtTen);
            this.groupControl2.Controls.Add(hOLabel);
            this.groupControl2.Controls.Add(this.txtHo);
            this.groupControl2.Controls.Add(mANVLabel);
            this.groupControl2.Controls.Add(this.txtMaNV);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 482);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(10);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1485, 408);
            this.groupControl2.TabIndex = 29;
            // 
            // txtCN
            // 
            this.txtCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "MACN", true));
            this.txtCN.Location = new System.Drawing.Point(1335, 114);
            this.txtCN.Margin = new System.Windows.Forms.Padding(4);
            this.txtCN.Name = "txtCN";
            this.txtCN.ReadOnly = true;
            this.txtCN.Size = new System.Drawing.Size(309, 28);
            this.txtCN.TabIndex = 16;
            // 
            // checkXoaNV
            // 
            this.checkXoaNV.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsDSNV, "TrangThaiXoa", true));
            this.checkXoaNV.Location = new System.Drawing.Point(1066, 166);
            this.checkXoaNV.Margin = new System.Windows.Forms.Padding(6);
            this.checkXoaNV.Name = "checkXoaNV";
            this.checkXoaNV.Size = new System.Drawing.Size(28, 48);
            this.checkXoaNV.TabIndex = 15;
            this.checkXoaNV.UseVisualStyleBackColor = true;
            this.checkXoaNV.CheckedChanged += new System.EventHandler(this.checkXoaNV_CheckedChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "SODT", true));
            this.txtSDT.Location = new System.Drawing.Point(932, 114);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(8);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(309, 28);
            this.txtSDT.TabIndex = 11;
            // 
            // cmbPhai
            // 
            this.cmbPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "PHAI", true));
            this.cmbPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhai.FormattingEnabled = true;
            this.cmbPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbPhai.Location = new System.Drawing.Point(312, 115);
            this.cmbPhai.Margin = new System.Windows.Forms.Padding(8);
            this.cmbPhai.Name = "cmbPhai";
            this.cmbPhai.Size = new System.Drawing.Size(490, 28);
            this.cmbPhai.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(312, 176);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(8);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(490, 28);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(1335, 50);
            this.txtTen.Margin = new System.Windows.Forms.Padding(8);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(309, 28);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(932, 50);
            this.txtHo.Margin = new System.Windows.Forms.Padding(8);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(309, 28);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(312, 54);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(8);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(490, 28);
            this.txtMaNV.TabIndex = 1;
            // 
            // bsdCN
            // 
            this.bsdCN.DataMember = "ChiNhanh";
            this.bsdCN.DataSource = this.dS;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhanVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 910);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsdCN)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnThemNV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnLuuNV;
        private DevExpress.XtraBars.BarButtonItem btnXoaNV;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.BindingSource bdsDSNV;
        private DS dS;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cmbPhai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.CheckBox checkXoaNV;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.BindingSource bsdCN;
        private DSTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnChuyen;
    }
}