using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH_PhanTan.Report
{
    public partial class frmDSTK : DevExpress.XtraEditors.XtraForm
    {
        DateTime dateTo;
        DateTime dateFrom;
        DateTime now = DateTime.Now;
        Boolean toanBo = false;
        private class Data
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
        public frmDSTK()
        {
            InitializeComponent();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPreview.Enabled = false;
            if (cmbChiNhanh.SelectedValue != null)
            {
                if(cmbChiNhanh.SelectedValue.ToString().Trim() == "true")
                {
                    toanBo = true;
                    return;
                }
                if (cmbChiNhanh.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    toanBo = false;
                    Program.servername = cmbChiNhanh.SelectedValue.ToString();
                }
                if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi chuyển chi nhánh", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    
                }
            }
        }


        private void DSSTK_Load(object sender, EventArgs e)
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            _comboItems.Add(new Data { Name = "Bến Thành", Value = "MSI\\SERVER1" });
            _comboItems.Add(new Data { Name = "Tân Định", Value = "MSI\\SERVER2" });
            _comboItems.Add(new Data { Name = "Cả 2 Chi Nhánh", Value = "true" });
            cmbChiNhanh.DisplayMember = "Name";
            cmbChiNhanh.ValueMember = "Value";
            cmbChiNhanh.DataSource = _comboItems;
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup.Trim() == "NGANHANG")
            {
               
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }
            btnPreview.Enabled = false;
            ngayBatDau.DateTime = now;
            ngayKetThuc.DateTime = now;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn hủy thao tác sao kê danh sách tài khoản?",
                      "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            this.sp_ReportDSTKTableAdapter.Connection.ConnectionString = Program.connstr;
            String chiNhanh;
            if(cmbChiNhanh.SelectedValue == "MSI\\SERVER1")
            {
                chiNhanh = "BENTHANH";
            }
            else
            {
                chiNhanh = "TANDINH";
            }
            this.sp_ReportDSTKTableAdapter.Fill(this.dS.sp_ReportDSTK, dateFrom, dateTo, toanBo, chiNhanh);
            if (bdsDSTK.Count == 0)
            {
                MessageBox.Show("Danh sách trống. Không có dữ liệu để in", "Thông báo !", MessageBoxButtons.OK);
                btnPreview.Enabled = false;
            }
            else
            {
                btnPreview.Enabled = true;
            }
        }

        private void ngayBatDau_EditValueChanged(object sender, EventArgs e)
        {
            dateFrom = ngayBatDau.DateTime;
        }

        private void ngayKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            dateTo = ngayKetThuc.DateTime;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            
            DSTK rpt = new DSTK(dateFrom, dateTo, toanBo);

            /*rpt.lblTieuDe.Text = ‘DANH SÁCH PHIẾU ‘ +cmbLoai.Text.ToUpper() + ‘ NHÂN VIÊN LẬP TRONG NĂM ‘ &cmbNam.Text;
            rpt.lblHoTen.Text = cmbHoten.Text;
*/          rpt.lbChiNhanh.Text = cmbChiNhanh.Text.Trim().ToUpper();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}