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
    public partial class frmDSKH : DevExpress.XtraEditors.XtraForm
    {
        Boolean toanBo = false;
        private class Data
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
        public frmDSKH()
        {
            InitializeComponent();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPreview.Enabled = false;
            if (cmbChiNhanh.SelectedValue != null)
            {
                if (cmbChiNhanh.SelectedValue.ToString().Trim() == "true")
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

        private void frmDSKH_Load(object sender, EventArgs e)
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
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn hủy thao tác sao kê danh sách khách hàng?",
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

            this.sp_ReportDSKHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_ReportDSKHTableAdapter.Fill(this.dS.sp_ReportDSKH, toanBo);
            if (bdsDSKH.Count == 0)
            {
                MessageBox.Show("Danh sách trống. Không có dữ liệu để in", "Thông báo !", MessageBoxButtons.OK);
                btnPreview.Enabled = false;
            }
            else
            {
                btnPreview.Enabled = true;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DSKH rpt = new DSKH(toanBo);
            rpt.lbChiNhanh.Text = cmbChiNhanh.Text.Trim().ToUpper();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}