using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH_PhanTan
{
    public partial class frmDangNhap : Form
    {
        //Lưu tên server lúc đăng nhập
        private String nameServerDN;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS.V_DS_PHANMANH);
            Program.bdsDSPM = this.bdsDSPM;
            cmbChiNhanh.SelectedIndex = 1;
            cmbChiNhanh.SelectedIndex = 0;

        }

        private void cmbChiNhanh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue != null)
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
                nameServerDN = Program.servername;
            }
            // gán server đã chọn vào biến toàn cục.

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng.", "Báo lỗi đăng nhập",
                    MessageBoxButtons.OK);
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu đăng nhập không được rỗng.", "Báo lỗi đăng nhập",
                    MessageBoxButtons.OK);
                txtTaiKhoan.Focus();
                return;
            }

            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
            Program.servername = nameServerDN;
            if (Program.KetNoi() == 0)
                return;
            Program.mChinhanh = cmbChiNhanh.SelectedIndex;
            Program.connstrDN = Program.connstr;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;


            if (Program.myReader.Read())
            {
                Program.username = Program.myReader.GetString(0);
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
            }
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn vui lòng xem lại!", "", MessageBoxButtons.OK);
                return;
            }
            
            
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh = new frmMain();
            Program.frmChinh.MANV.Text = "Mã nhân viên: " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ và tên: " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;
            
            Program.frmChinh.Show();
            Program.FrmDangNhap.Visible = false;
            txtTaiKhoan.Text = "Username";
            txtMatKhau.Text = "Password";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn thoát không ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
