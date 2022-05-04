
namespace QLNH_PhanTan.Report
{
    partial class frmDSGD
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsDSTK = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLNH_PhanTan.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSOTK = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnManHinh = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ngayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.ngayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.taiKhoanTableAdapter = new QLNH_PhanTan.DSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new QLNH_PhanTan.DSTableAdapters.TableAdapterManager();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.sP_SaoKeTK_CNGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsRp_TK = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSODUDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODUSAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_SaoKeTK_CNTableAdapter = new QLNH_PhanTan.DSTableAdapters.SP_SaoKeTK_CNTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SaoKeTK_CNGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRp_TK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
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
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1096, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 843);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1096, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 823);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1096, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 823);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.taiKhoanGridControl);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1096, 392);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.bdsDSTK;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanGridControl.Location = new System.Drawing.Point(588, 2);
            this.taiKhoanGridControl.MainView = this.gridView1;
            this.taiKhoanGridControl.MenuManager = this.barManager1;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(506, 388);
            this.taiKhoanGridControl.TabIndex = 1;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.taiKhoanGridControl.Click += new System.EventHandler(this.taiKhoanGridControl_Click);
            // 
            // bdsDSTK
            // 
            this.bdsDSTK.DataMember = "TaiKhoan";
            this.bdsDSTK.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.GridControl = this.taiKhoanGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.OptionsColumn.AllowEdit = false;
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.AllowEdit = false;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.OptionsColumn.AllowEdit = false;
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.OptionsColumn.AllowEdit = false;
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txtSOTK);
            this.groupControl2.Controls.Add(this.btnThoat);
            this.groupControl2.Controls.Add(this.btnManHinh);
            this.groupControl2.Controls.Add(this.btnPreview);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.ngayKetThuc);
            this.groupControl2.Controls.Add(this.ngayBatDau);
            this.groupControl2.Controls.Add(this.cmbChiNhanh);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(586, 388);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "groupControl2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số Tài Khoản:";
            // 
            // txtSOTK
            // 
            this.txtSOTK.Location = new System.Drawing.Point(158, 227);
            this.txtSOTK.Name = "txtSOTK";
            this.txtSOTK.Size = new System.Drawing.Size(302, 28);
            this.txtSOTK.TabIndex = 18;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(371, 281);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 46);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnManHinh
            // 
            this.btnManHinh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnManHinh.Location = new System.Drawing.Point(210, 281);
            this.btnManHinh.Name = "btnManHinh";
            this.btnManHinh.Size = new System.Drawing.Size(110, 46);
            this.btnManHinh.TabIndex = 16;
            this.btnManHinh.Text = "Xem";
            this.btnManHinh.UseVisualStyleBackColor = false;
            this.btnManHinh.Click += new System.EventHandler(this.btnManHinh_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Lime;
            this.btnPreview.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPreview.Location = new System.Drawing.Point(51, 281);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(110, 46);
            this.btnPreview.TabIndex = 15;
            this.btnPreview.Text = "Xuất File";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đến Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Từ Ngày:";
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.EditValue = null;
            this.ngayKetThuc.Location = new System.Drawing.Point(158, 172);
            this.ngayKetThuc.MenuManager = this.barManager1;
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKetThuc.Size = new System.Drawing.Size(302, 26);
            this.ngayKetThuc.TabIndex = 11;
            this.ngayKetThuc.EditValueChanged += new System.EventHandler(this.ngayKetThuc_EditValueChanged);
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.EditValue = null;
            this.ngayBatDau.Location = new System.Drawing.Point(158, 114);
            this.ngayBatDau.MenuManager = this.barManager1;
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayBatDau.Size = new System.Drawing.Size(302, 26);
            this.ngayBatDau.TabIndex = 10;
            this.ngayBatDau.EditValueChanged += new System.EventHandler(this.ngayBatDau_EditValueChanged);
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
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLNH_PhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.sP_SaoKeTK_CNGridControl);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 412);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1096, 431);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "groupControl3";
            // 
            // sP_SaoKeTK_CNGridControl
            // 
            this.sP_SaoKeTK_CNGridControl.DataSource = this.bdsRp_TK;
            this.sP_SaoKeTK_CNGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_SaoKeTK_CNGridControl.Location = new System.Drawing.Point(2, 28);
            this.sP_SaoKeTK_CNGridControl.MainView = this.gridView2;
            this.sP_SaoKeTK_CNGridControl.MenuManager = this.barManager1;
            this.sP_SaoKeTK_CNGridControl.Name = "sP_SaoKeTK_CNGridControl";
            this.sP_SaoKeTK_CNGridControl.Size = new System.Drawing.Size(1092, 401);
            this.sP_SaoKeTK_CNGridControl.TabIndex = 0;
            this.sP_SaoKeTK_CNGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsRp_TK
            // 
            this.bdsRp_TK.DataMember = "SP_SaoKeTK_CN";
            this.bdsRp_TK.DataSource = this.dS;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSODUDAU,
            this.colNGAYGD,
            this.colLOAIGD,
            this.colSOTIEN,
            this.colSODUSAU});
            this.gridView2.GridControl = this.sP_SaoKeTK_CNGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colSODUDAU
            // 
            this.colSODUDAU.FieldName = "SODUDAU";
            this.colSODUDAU.MinWidth = 25;
            this.colSODUDAU.Name = "colSODUDAU";
            this.colSODUDAU.OptionsColumn.AllowEdit = false;
            this.colSODUDAU.Visible = true;
            this.colSODUDAU.VisibleIndex = 0;
            this.colSODUDAU.Width = 94;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 25;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.OptionsColumn.AllowEdit = false;
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 1;
            this.colNGAYGD.Width = 94;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 25;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.OptionsColumn.AllowEdit = false;
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 2;
            this.colLOAIGD.Width = 94;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 25;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.OptionsColumn.AllowEdit = false;
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            this.colSOTIEN.Width = 94;
            // 
            // colSODUSAU
            // 
            this.colSODUSAU.FieldName = "SODUSAU";
            this.colSODUSAU.MinWidth = 25;
            this.colSODUSAU.Name = "colSODUSAU";
            this.colSODUSAU.OptionsColumn.AllowEdit = false;
            this.colSODUSAU.Visible = true;
            this.colSODUSAU.VisibleIndex = 4;
            this.colSODUSAU.Width = 94;
            // 
            // sP_SaoKeTK_CNTableAdapter
            // 
            this.sP_SaoKeTK_CNTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chi Nhánh:";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(158, 50);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(302, 28);
            this.cmbChiNhanh.TabIndex = 9;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // frmDSGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 863);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDSGD";
            this.Text = "Danh Sách Giao Dịch";
            this.Load += new System.EventHandler(this.frmDSGD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_SaoKeTK_CNGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRp_TK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource bdsDSTK;
        private DS dS;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnManHinh;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit ngayKetThuc;
        private DevExpress.XtraEditors.DateEdit ngayBatDau;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtSOTK;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DSTableAdapters.SP_SaoKeTK_CNTableAdapter sP_SaoKeTK_CNTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.BindingSource bdsRp_TK;
        private DevExpress.XtraGrid.GridControl sP_SaoKeTK_CNGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSODUDAU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSODUSAU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
    }
}