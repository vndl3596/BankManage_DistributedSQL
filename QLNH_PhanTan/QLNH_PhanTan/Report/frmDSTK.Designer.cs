
namespace QLNH_PhanTan.Report
{
    partial class frmDSTK
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnManHinh = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ngayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.ngayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.dS = new QLNH_PhanTan.DS();
            this.bdsDSTK = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ReportDSTKTableAdapter = new QLNH_PhanTan.DSTableAdapters.sp_ReportDSTKTableAdapter();
            this.tableAdapterManager = new QLNH_PhanTan.DSTableAdapters.TableAdapterManager();
            this.sp_ReportDSTKGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new QLNH_PhanTan.DSTableAdapters.TaiKhoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ReportDSTKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
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
            this.bar2.FloatLocation = new System.Drawing.Point(461, 159);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1111, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 669);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1111, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 649);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1111, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 649);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnManHinh);
            this.groupControl1.Controls.Add(this.btnPreview);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.ngayKetThuc);
            this.groupControl1.Controls.Add(this.ngayBatDau);
            this.groupControl1.Controls.Add(this.cmbChiNhanh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1111, 357);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(716, 254);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 46);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnManHinh
            // 
            this.btnManHinh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnManHinh.Location = new System.Drawing.Point(555, 254);
            this.btnManHinh.Name = "btnManHinh";
            this.btnManHinh.Size = new System.Drawing.Size(110, 46);
            this.btnManHinh.TabIndex = 7;
            this.btnManHinh.Text = "Xem";
            this.btnManHinh.UseVisualStyleBackColor = false;
            this.btnManHinh.Click += new System.EventHandler(this.btnManHinh_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Lime;
            this.btnPreview.Location = new System.Drawing.Point(396, 254);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(110, 46);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Xuất File";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đến Ngày:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Từ Ngày:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi Nhánh:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.EditValue = null;
            this.ngayKetThuc.Location = new System.Drawing.Point(524, 195);
            this.ngayKetThuc.MenuManager = this.barManager1;
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKetThuc.Size = new System.Drawing.Size(302, 26);
            this.ngayKetThuc.TabIndex = 2;
            this.ngayKetThuc.EditValueChanged += new System.EventHandler(this.ngayKetThuc_EditValueChanged);
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.EditValue = null;
            this.ngayBatDau.Location = new System.Drawing.Point(524, 137);
            this.ngayBatDau.MenuManager = this.barManager1;
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayBatDau.Size = new System.Drawing.Size(302, 26);
            this.ngayBatDau.TabIndex = 1;
            this.ngayBatDau.EditValueChanged += new System.EventHandler(this.ngayBatDau_EditValueChanged);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(524, 73);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(302, 28);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSTK
            // 
            this.bdsDSTK.DataMember = "sp_ReportDSTK";
            this.bdsDSTK.DataSource = this.dS;
            // 
            // sp_ReportDSTKTableAdapter
            // 
            this.sp_ReportDSTKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLNH_PhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_ReportDSTKGridControl
            // 
            this.sp_ReportDSTKGridControl.DataSource = this.bdsDSTK;
            this.sp_ReportDSTKGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_ReportDSTKGridControl.Location = new System.Drawing.Point(0, 377);
            this.sp_ReportDSTKGridControl.MainView = this.gridView1;
            this.sp_ReportDSTKGridControl.MenuManager = this.barManager1;
            this.sp_ReportDSTKGridControl.Name = "sp_ReportDSTKGridControl";
            this.sp_ReportDSTKGridControl.Size = new System.Drawing.Size(1111, 292);
            this.sp_ReportDSTKGridControl.TabIndex = 14;
            this.sp_ReportDSTKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.sp_ReportDSTKGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.dS;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // frmDSTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 689);
            this.Controls.Add(this.sp_ReportDSTKGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDSTK";
            this.Text = "Danh Sách Tài Khoản";
            this.Load += new System.EventHandler(this.DSSTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ReportDSTKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.DateEdit ngayKetThuc;
        private DevExpress.XtraEditors.DateEdit ngayBatDau;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsDSTK;
        private DS dS;
        private DSTableAdapters.sp_ReportDSTKTableAdapter sp_ReportDSTKTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sp_ReportDSTKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnManHinh;
        private System.Windows.Forms.Button btnPreview;
    }
}