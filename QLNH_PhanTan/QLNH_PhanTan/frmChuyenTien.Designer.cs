namespace QLNH_PhanTan
{
    partial class frmChuyenTien
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
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gD_CHUYENTIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gD_CHUYENTIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLNH_PhanTan.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_NHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtSoTKNhan = new System.Windows.Forms.TextBox();
            this.txtSoTKChuyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gD_CHUYENTIENTableAdapter = new QLNH_PhanTan.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.tableAdapterManager = new QLNH_PhanTan.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1119, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 788);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1119, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 759);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1119, 29);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 759);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gD_CHUYENTIENGridControl);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtHoTen);
            this.groupControl1.Controls.Add(this.btnHuyBo);
            this.groupControl1.Controls.Add(this.btnXacNhan);
            this.groupControl1.Controls.Add(this.txtMaNV);
            this.groupControl1.Controls.Add(this.txtSoTien);
            this.groupControl1.Controls.Add(this.txtSoTKNhan);
            this.groupControl1.Controls.Add(this.txtSoTKChuyen);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1119, 759);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Chuyển Tiền";
            // 
            // gD_CHUYENTIENGridControl
            // 
            this.gD_CHUYENTIENGridControl.DataSource = this.gD_CHUYENTIENBindingSource;
            this.gD_CHUYENTIENGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.gD_CHUYENTIENGridControl.Location = new System.Drawing.Point(0, 2);
            this.gD_CHUYENTIENGridControl.MainView = this.gridView1;
            this.gD_CHUYENTIENGridControl.MenuManager = this.barManager1;
            this.gD_CHUYENTIENGridControl.Name = "gD_CHUYENTIENGridControl";
            this.gD_CHUYENTIENGridControl.Size = new System.Drawing.Size(1117, 755);
            this.gD_CHUYENTIENGridControl.TabIndex = 16;
            this.gD_CHUYENTIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gD_CHUYENTIENBindingSource
            // 
            this.gD_CHUYENTIENBindingSource.DataMember = "GD_CHUYENTIEN";
            this.gD_CHUYENTIENBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK_CHUYEN,
            this.colSOTK_NHAN,
            this.colSOTIEN,
            this.colNGAYGD,
            this.colMANV});
            this.gridView1.GridControl = this.gD_CHUYENTIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK_CHUYEN
            // 
            this.colSOTK_CHUYEN.FieldName = "SOTK_CHUYEN";
            this.colSOTK_CHUYEN.MinWidth = 25;
            this.colSOTK_CHUYEN.Name = "colSOTK_CHUYEN";
            this.colSOTK_CHUYEN.Visible = true;
            this.colSOTK_CHUYEN.VisibleIndex = 0;
            this.colSOTK_CHUYEN.Width = 94;
            // 
            // colSOTK_NHAN
            // 
            this.colSOTK_NHAN.FieldName = "SOTK_NHAN";
            this.colSOTK_NHAN.MinWidth = 25;
            this.colSOTK_NHAN.Name = "colSOTK_NHAN";
            this.colSOTK_NHAN.Visible = true;
            this.colSOTK_NHAN.VisibleIndex = 1;
            this.colSOTK_NHAN.Width = 94;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 25;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 2;
            this.colSOTIEN.Width = 94;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 25;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 3;
            this.colNGAYGD.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 4;
            this.colMANV.Width = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Họ và Tên Nhân Viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Họ và Tên Nhân Viên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(524, 308);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(323, 28);
            this.txtHoTen.TabIndex = 15;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.Red;
            this.btnHuyBo.Location = new System.Drawing.Point(728, 425);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(119, 40);
            this.btnHuyBo.TabIndex = 14;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.Location = new System.Drawing.Point(524, 425);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(119, 40);
            this.btnXacNhan.TabIndex = 13;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(524, 367);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(323, 28);
            this.txtMaNV.TabIndex = 12;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(524, 239);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(323, 28);
            this.txtSoTien.TabIndex = 11;
            // 
            // txtSoTKNhan
            // 
            this.txtSoTKNhan.Location = new System.Drawing.Point(524, 169);
            this.txtSoTKNhan.Name = "txtSoTKNhan";
            this.txtSoTKNhan.Size = new System.Drawing.Size(323, 28);
            this.txtSoTKNhan.TabIndex = 10;
            // 
            // txtSoTKChuyen
            // 
            this.txtSoTKChuyen.Location = new System.Drawing.Point(524, 99);
            this.txtSoTKChuyen.Name = "txtSoTKChuyen";
            this.txtSoTKChuyen.Size = new System.Drawing.Size(323, 28);
            this.txtSoTKChuyen.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Nhân Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số Tài Khoản Nhận:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Tài Khoản Chuyển:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chuyển Tiền";
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.gD_CHUYENTIENTableAdapter;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLNH_PhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 808);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmChuyenTien";
            this.Text = "Chuyển Tiền";
            this.Load += new System.EventHandler(this.frmChuyenTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtSoTKNhan;
        private System.Windows.Forms.TextBox txtSoTKChuyen;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource gD_CHUYENTIENBindingSource;
        private DS dS;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gD_CHUYENTIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_NHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
    }
}