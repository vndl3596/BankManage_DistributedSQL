namespace QLNH_PhanTan
{
    partial class frmGuiTien
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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gD_GOIRUTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gD_GOIRUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLNH_PhanTan.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLoaiGD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.gD_GOIRUTTableAdapter = new QLNH_PhanTan.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new QLNH_PhanTan.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).BeginInit();
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
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1340, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 437);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1340, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 408);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1340, 29);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 408);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gD_GOIRUTGridControl);
            this.groupControl1.Controls.Add(this.btnHuyBo);
            this.groupControl1.Controls.Add(this.btnXacNhan);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cmbLoaiGD);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtHoTen);
            this.groupControl1.Controls.Add(this.txtMaNV);
            this.groupControl1.Controls.Add(this.txtSoTien);
            this.groupControl1.Controls.Add(this.txtSoTK);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1340, 408);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // gD_GOIRUTGridControl
            // 
            this.gD_GOIRUTGridControl.DataSource = this.gD_GOIRUTBindingSource;
            this.gD_GOIRUTGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.gD_GOIRUTGridControl.Location = new System.Drawing.Point(0, 2);
            this.gD_GOIRUTGridControl.MainView = this.gridView1;
            this.gD_GOIRUTGridControl.MenuManager = this.barManager1;
            this.gD_GOIRUTGridControl.Name = "gD_GOIRUTGridControl";
            this.gD_GOIRUTGridControl.Size = new System.Drawing.Size(1338, 404);
            this.gD_GOIRUTGridControl.TabIndex = 12;
            this.gD_GOIRUTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gD_GOIRUTBindingSource
            // 
            this.gD_GOIRUTBindingSource.DataMember = "GD_GOIRUT";
            this.gD_GOIRUTBindingSource.DataSource = this.dS;
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
            this.colLOAIGD,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colMANV});
            this.gridView1.GridControl = this.gD_GOIRUTGridControl;
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
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 25;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 1;
            this.colLOAIGD.Width = 94;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 25;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 2;
            this.colNGAYGD.Width = 94;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 25;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            this.colSOTIEN.Width = 94;
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
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.Red;
            this.btnHuyBo.Location = new System.Drawing.Point(501, 342);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(150, 46);
            this.btnHuyBo.TabIndex = 11;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.Location = new System.Drawing.Point(261, 342);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(150, 46);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gửi Tiền";
            // 
            // cmbLoaiGD
            // 
            this.cmbLoaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiGD.FormattingEnabled = true;
            this.cmbLoaiGD.Location = new System.Drawing.Point(261, 211);
            this.cmbLoaiGD.Name = "cmbLoaiGD";
            this.cmbLoaiGD.Size = new System.Drawing.Size(390, 28);
            this.cmbLoaiGD.TabIndex = 8;
            this.cmbLoaiGD.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiGD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại Giao Dịch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số Tài Khoản:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(261, 275);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(390, 28);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(691, 277);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(117, 28);
            this.txtMaNV.TabIndex = 2;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(261, 147);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(390, 28);
            this.txtSoTien.TabIndex = 1;
            // 
            // txtSoTK
            // 
            this.txtSoTK.Location = new System.Drawing.Point(261, 83);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(390, 28);
            this.txtSoTK.TabIndex = 0;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLNH_PhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmGuiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 457);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmGuiTien";
            this.Text = "Gửi Tiền";
            this.Load += new System.EventHandler(this.frmGuiTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbLoaiGD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXacNhan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource gD_GOIRUTBindingSource;
        private DS dS;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gD_GOIRUTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
    }
}