using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNH_PhanTan
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
      
        public frmMain()
        {
            InitializeComponent();
            if(Program.mGroup.Trim() == "NGANHANG")
            {
                btnChuyenTien.Enabled = false;
                btnGuiTien.Enabled = false;
            }
        }
        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                ShowMdiChildren(typeof(frmNhanVien));

        }
        private void btnDangXuat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn đăng xuất không ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                this.Close();
               
                Program.FrmDangNhap.Visible = true;
            }
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmKhachHang));
        }

        private void btnMoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmTaiKhoan));
        }

        private void btnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDangKy));
        }

        private void btnGuiTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmGuiTien));
        }

        private void btnChuyenTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmChuyenTien));
        }

        private void btnDSGiaoDich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.frmDSGD));
        }

        private void btnDSTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.frmDSTK));
        }

        private void btnDSKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.frmDSKH));
        }

      
    }
}
