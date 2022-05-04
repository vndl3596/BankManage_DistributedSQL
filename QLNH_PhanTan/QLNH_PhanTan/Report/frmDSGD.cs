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
    public partial class frmDSGD : DevExpress.XtraEditors.XtraForm
    {
        DateTime dateTo;
        DateTime dateFrom;
  
        DateTime now = DateTime.Now;      
        private class Data
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
        public frmDSGD()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDSTK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmDSGD_Load(object sender, EventArgs e)
        {
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            txtSOTK.Text = ((DataRowView)bdsDSTK[bdsDSTK.Position])["SOTK"].ToString().Trim();
            cmbChiNhanh.DataSource = Program.bdsDSPM;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup.Trim() == "NGANHANG")
            {
                Program.bdsDSPM.Filter = "TENCN <> 'Khách Hàng' ";
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

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPreview.Enabled = false;
            if (cmbChiNhanh.SelectedValue != null)
            {
               
                if (cmbChiNhanh.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                  
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
                    try{
                        this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
                        txtSOTK.Text = ((DataRowView)bdsDSTK[bdsDSTK.Position])["SOTK"].ToString().Trim();
                    }
                    catch(Exception)
                    {

                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn hủy thao tác sao kê giao dịch?",
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
            this.sP_SaoKeTK_CNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_SaoKeTK_CNTableAdapter.Fill(this.dS.SP_SaoKeTK_CN, txtSOTK.Text.Trim(), dateFrom, dateTo);
            if (bdsRp_TK.Count == 0)
            {
                MessageBox.Show("Danh sách trống. Không có dữ liệu để in", "Thông báo !", MessageBoxButtons.OK);
                btnPreview.Enabled = false;
            }
            else
            {
                btnPreview.Enabled = true;
            }
        }

        private void taiKhoanGridControl_Click(object sender, EventArgs e)
        {
            txtSOTK.Text = ((DataRowView)bdsDSTK[bdsDSTK.Position])["SOTK"].ToString().Trim();
        }

        private void ngayBatDau_EditValueChanged(object sender, EventArgs e)
        {
            dateFrom = ngayBatDau.DateTime;
        }

        private void ngayKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            dateTo = ngayKetThuc.DateTime;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DSGD rpt = new DSGD(txtSOTK.Text.Trim(),dateFrom, dateTo);
            rpt.lbChiNhanh.Text = cmbChiNhanh.Text.Trim().ToUpper();
            rpt.lbSTK.Text = txtSOTK.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}