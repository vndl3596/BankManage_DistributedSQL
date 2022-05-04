namespace QLNH_PhanTan
{
    partial class frmKhachHang
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label pHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dS = new QLNH_PhanTan.DS();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new QLNH_PhanTan.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new QLNH_PhanTan.DSTableAdapters.TableAdapterManager();
            this.bdsCN = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new QLNH_PhanTan.DSTableAdapters.ChiNhanhTableAdapter();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbPhai = new System.Windows.Forms.ComboBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.ngayCap = new DevExpress.XtraEditors.DateEdit();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKH = new DevExpress.XtraGrid.GridControl();
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(48, 23);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(69, 21);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(436, 19);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(37, 21);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(436, 66);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(43, 21);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(48, 130);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(73, 21);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa Chỉ:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(48, 75);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(89, 21);
            nGAYCAPLabel.TabIndex = 10;
            nGAYCAPLabel.Text = "Ngày Cấp:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(48, 184);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(65, 21);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "Số ĐT:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(436, 180);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(69, 21);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "Mã CN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(436, 123);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(46, 21);
            pHAILabel.TabIndex = 15;
            pHAILabel.Text = "Phái:";
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
            this.btnThemKH,
            this.btnGhiKH,
            this.btnXoaKH,
            this.btnUndo,
            this.btnRefresh,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(389, 171);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemKH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiKH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaKH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Caption = "Thêm";
            this.btnThemKH.Id = 0;
            this.btnThemKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKH.ImageOptions.Image")));
            this.btnThemKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemKH.ImageOptions.LargeImage")));
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemKH_ItemClick);
            // 
            // btnGhiKH
            // 
            this.btnGhiKH.Caption = "Ghi";
            this.btnGhiKH.Id = 1;
            this.btnGhiKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiKH.ImageOptions.Image")));
            this.btnGhiKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiKH.ImageOptions.LargeImage")));
            this.btnGhiKH.Name = "btnGhiKH";
            this.btnGhiKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiKH_ItemClick);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Caption = "Xóa";
            this.btnXoaKH.Id = 2;
            this.btnXoaKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKH.ImageOptions.Image")));
            this.btnXoaKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaKH.ImageOptions.LargeImage")));
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaKH_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục Hồi";
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Reload";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1190, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 896);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1190, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 866);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1190, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 866);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KhachHang";
            this.bdsKH.DataSource = this.dS;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLNH_PhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Controls.Add(this.cmbChiNhanh);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 30);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(1190, 62);
            this.groupControl3.TabIndex = 14;
            this.groupControl3.Text = "groupControl3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chi Nhánh:";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(181, 19);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(462, 28);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(pHAILabel);
            this.groupControl1.Controls.Add(this.cmbPhai);
            this.groupControl1.Controls.Add(mACNLabel);
            this.groupControl1.Controls.Add(this.txtCN);
            this.groupControl1.Controls.Add(sODTLabel);
            this.groupControl1.Controls.Add(this.txtSDT);
            this.groupControl1.Controls.Add(nGAYCAPLabel);
            this.groupControl1.Controls.Add(this.ngayCap);
            this.groupControl1.Controls.Add(dIACHILabel);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(tENLabel);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(hOLabel);
            this.groupControl1.Controls.Add(this.txtHo);
            this.groupControl1.Controls.Add(cMNDLabel);
            this.groupControl1.Controls.Add(this.txtCMND);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 580);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1190, 316);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "groupControl1";
            // 
            // cmbPhai
            // 
            this.cmbPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "PHAI", true));
            this.cmbPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhai.FormattingEnabled = true;
            this.cmbPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbPhai.Location = new System.Drawing.Point(515, 117);
            this.cmbPhai.Name = "cmbPhai";
            this.cmbPhai.Size = new System.Drawing.Size(186, 28);
            this.cmbPhai.TabIndex = 16;
            // 
            // txtCN
            // 
            this.txtCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "MACN", true));
            this.txtCN.Location = new System.Drawing.Point(515, 173);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(186, 28);
            this.txtCN.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "SODT", true));
            this.txtSDT.Location = new System.Drawing.Point(156, 177);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(181, 28);
            this.txtSDT.TabIndex = 13;
            // 
            // ngayCap
            // 
            this.ngayCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "NGAYCAP", true));
            this.ngayCap.EditValue = new System.DateTime(2020, 11, 23, 0, 0, 0, 0);
            this.ngayCap.Location = new System.Drawing.Point(156, 72);
            this.ngayCap.MenuManager = this.barManager1;
            this.ngayCap.Name = "ngayCap";
            this.ngayCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCap.Properties.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 0, 0);
            this.ngayCap.Size = new System.Drawing.Size(181, 26);
            this.ngayCap.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(156, 123);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(181, 28);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(515, 66);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(186, 28);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(515, 19);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(186, 28);
            this.txtHo.TabIndex = 3;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(156, 23);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(181, 28);
            this.txtCMND.TabIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridView1.GridControl = this.gcKH;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.AllowEdit = false;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 94;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 25;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.OptionsColumn.AllowEdit = false;
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 94;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.OptionsColumn.AllowEdit = false;
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 94;
            // 
            // gcKH
            // 
            this.gcKH.DataSource = this.bdsKH;
            this.gcKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKH.Location = new System.Drawing.Point(0, 92);
            this.gcKH.MainView = this.gridView1;
            this.gcKH.MenuManager = this.barManager1;
            this.gcKH.Name = "gcKH";
            this.gcKH.Size = new System.Drawing.Size(1190, 488);
            this.gcKH.TabIndex = 14;
            this.gcKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcKH.Click += new System.EventHandler(this.gcKH_Click);
            // 
            // frmKhachHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 916);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcKH);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmKhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnThemKH;
        private DevExpress.XtraBars.BarButtonItem btnGhiKH;
        private DevExpress.XtraBars.BarButtonItem btnXoaKH;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsKH;
        private DS dS;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsCN;
        private DSTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.TextBox txtSDT;
        private DevExpress.XtraEditors.DateEdit ngayCap;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtCMND;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.ComboBox cmbPhai;
        private DevExpress.XtraGrid.GridControl gcKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
    }
}