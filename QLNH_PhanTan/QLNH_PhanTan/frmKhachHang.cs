using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLNH_PhanTan
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        int vitriKH=0;
        Boolean isEditingKH=false;
        String maCN;
        DateTime now = DateTime.Now;
        String CMND;
        public frmKhachHang()
        {
            InitializeComponent();
            if (Program.mGroup.Trim() == "NGANHANG")
            {
                btnGhiKH.Enabled = false;
                btnRefresh.Enabled = false;
                btnThemKH.Enabled = false;
                btnUndo.Enabled = false;
                btnXoaKH.Enabled = false;
                txtCN.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtHo.ReadOnly = true;
                txtCMND.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtTen.ReadOnly = true;
                ngayCap.ReadOnly = true;
            }
        }

        private void btnThemKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtCMND.Focus();
            vitriKH = bdsKH.Position;
            isEditingKH = true;
            bdsKH.AddNew();
            gcKH.Enabled = false;
            txtCN.Text = maCN;
            cmbPhai.SelectedIndex = 1;
            cmbPhai.SelectedIndex = 0;
            txtCMND.Text = "";
            txtCMND.ReadOnly = false;
            txtCMND.Focus();
           ngayCap.EditValue = now;
            btnThemKH.Enabled = btnXoaKH.Enabled = btnThoat.Enabled = false;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
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
            dS.EnforceConstraints = false;
            this.chiNhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiNhanhTableAdapter.Fill(this.dS.ChiNhanh);
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);
           
            maCN = ((DataRowView)bdsCN[0])["MACN"].ToString().Trim();
            CMND = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString().Trim();
            txtCMND.ReadOnly = true;
            txtCN.ReadOnly = true;
            
        }

        private void btnGhiKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Chứng minh nhân dân không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtCMND.Focus();
            }
            else if(!Program.isValidInputCMNDSTK.IsMatch(txtCMND.Text.Trim()))
            {
                MessageBox.Show("Chứng minh nhân dân không đúng định dạng !", "Thông báo !", MessageBoxButtons.OK);
                txtCMND.Focus();
            }
            else if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ khách hàng không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtHo.Focus();
            }
            else if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTen.Focus();
            }
            else if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtSDT.Focus();
            }
            else if (!Program.isValidInputSDT.IsMatch(txtSDT.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng !", "Thông báo !", MessageBoxButtons.OK);
                txtSDT.Focus();
            }
            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtDiaChi.Focus();
            }
            else if (ngayCap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày cấp!", "Thông báo !", MessageBoxButtons.OK);
                txtDiaChi.Focus();
            }
            else if (ngayCap.DateTime.CompareTo(now) == 1)
            {
                MessageBox.Show("Không được chọn quá ngày hiện tại!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                String str_sp = "sp_KIEMTRACMNDTONTAI";
                Program.Sqlcmd = Program.conn.CreateCommand();
                Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.Sqlcmd.CommandText = str_sp;
                Program.Sqlcmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = txtCMND.Text;
                Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.Sqlcmd.ExecuteNonQuery();
                String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                if (ret == "1" && isEditingKH == true)
                {
                    MessageBox.Show("Chứng minh nhân dân đã tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        bdsKH.EndEdit();            // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                        bdsKH.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                        this.khachHangTableAdapter.Update(this.dS.KhachHang);         // cập nhật dl từ dataset về database thông qua tableadapter
                        isEditingKH = false;
                        gcKH.Enabled = true;
                        btnThemKH.Enabled = btnXoaKH.Enabled = btnThoat.Enabled=true;
                        txtCMND.ReadOnly = true;
                        MessageBox.Show("Lưu thành công!", "Thông báo !", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi khách hàng. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnXoaKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsKH.Count == 0)
            {
                return;
            }
            else
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                String str_sp = "SP_KTXOAKHACHHANG";
                Program.Sqlcmd = Program.conn.CreateCommand();
                Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.Sqlcmd.CommandText = str_sp;
                Program.Sqlcmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = CMND;
                Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.Sqlcmd.ExecuteNonQuery();
                String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                if (ret == "1" )
                {
                    MessageBox.Show("Khách hàng này đã có tài khoản không thể xóa. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng ?", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        try
                        {
                            bdsKH.RemoveCurrent();         //xóa row đang chọn ra khỏi dataset
                            this.khachHangTableAdapter.Update(this.dS.KhachHang);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa khách hàng! " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            bdsKH.CancelEdit();
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            if (isEditingKH == true)
            {
               
                bdsKH.Position = vitriKH;
                gcKH.Enabled = true;
                btnThemKH.Enabled = btnXoaKH.Enabled = btnThoat.Enabled = true;
                txtCMND.ReadOnly = true;
                isEditingKH = false;
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    try
                    {
                        dS.EnforceConstraints = false;
                        this.chiNhanhTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.chiNhanhTableAdapter.Fill(this.dS.ChiNhanh);
                        maCN = ((DataRowView)bdsCN[0])["MACN"].ToString().Trim();
                        this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                        CMND = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString().Trim();

                    }
                    catch (Exception) { }
                }
            }
        }

        private void gcKH_Click(object sender, EventArgs e)
        {
            CMND=((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString().Trim();

        }


    }
}