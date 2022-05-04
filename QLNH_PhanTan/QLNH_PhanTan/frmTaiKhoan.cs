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
    public partial class frmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        int vitriTK=0;
        
        Boolean isEditingTK = false;
        String maCN;
        DateTime now = DateTime.Now;
        public frmTaiKhoan()
        {
            InitializeComponent();
            if (Program.mGroup.Trim() == "NGANHANG")
            {
                btnThemTK.Enabled = false;
                btnRefresh.Enabled = false;
                btnGhiTK.Enabled = false;
                btnUndo.Enabled = false;
                btnXoaTK.Enabled = false;
                txtCMND.ReadOnly = true;
                txtMaCN.ReadOnly = true;
                txtSTK.ReadOnly = true;
                ngayMoTK.ReadOnly = true;
                txtSoDu.ReadOnly = true;
            }
        }


        private void btnThemTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtSTK.Focus();
            vitriTK = bdsTK.Position;
            isEditingTK = true;
            bdsTK.AddNew();
            gcTK.Enabled = false;
            txtMaCN.Text = maCN;        
            txtCMND.Text = "";
            txtCMND.ReadOnly = false;
            txtCMND.Focus();
            gcDSKH.Enabled = true;
            txtCMND.Text = ((DataRowView)bsdKH[bsdKH.Position])["CMND"].ToString().Trim();
            ngayMoTK.EditValue = now;
            btnThemTK.Enabled = btnXoaTK.Enabled = btnThoat.Enabled = false;
            
        }

        private void btnGhiTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtSoDu.Text.Trim() == "")
            {
                MessageBox.Show("Số dư không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtSoDu.Focus();
            }
            else if (txtSTK.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtSTK.Focus();
            }
            else if (!Program.isValidInputCMNDSTK.IsMatch(txtSTK.Text.Trim()))
            {
                MessageBox.Show("Chứng minh nhân dân không đúng định dạng !", "Thông báo !", MessageBoxButtons.OK);
                txtSTK.Focus();
            }
            else if (ngayMoTK.DateTime.CompareTo(now) == 1)
            {
                MessageBox.Show("Không được chọn quá ngày hiện tại!", "Thông báo!", MessageBoxButtons.OK);
            }
            else if (ngayMoTK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày mở TK!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                String str_sp = "sp_CHECKTONTAISTK";
                Program.Sqlcmd = Program.conn.CreateCommand();
                Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.Sqlcmd.CommandText = str_sp;
                Program.Sqlcmd.Parameters.Add("@STK", SqlDbType.VarChar).Value = txtSTK.Text;
                Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.Sqlcmd.ExecuteNonQuery();
                String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                if (ret == "1" && isEditingTK == true)
                {
                    MessageBox.Show("Số tài khoản đã tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else if (ret == "0" && isEditingTK == true)
                {
                    String str_addtk = "sp_TAOTAIKHOANKHACHHANG";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_addtk;
                    Program.Sqlcmd.Parameters.Add("@STK", SqlDbType.VarChar).Value = txtSTK.Text;
                    Program.Sqlcmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = txtCMND.Text;
                    Program.Sqlcmd.Parameters.Add("@SODU", SqlDbType.Money).Value = txtSoDu.Text;
                    Program.Sqlcmd.Parameters.Add("@MACN", SqlDbType.VarChar).Value = txtMaCN.Text;
                    Program.Sqlcmd.Parameters.Add("@NGAYMOTK", SqlDbType.DateTime).Value = ngayMoTK.DateTime;
                    Program.Sqlcmd.ExecuteNonQuery();
                    isEditingTK = false;
                    gcTK.Enabled = true;
                    btnThemTK.Enabled = btnXoaTK.Enabled = btnThoat.Enabled = true;
                    gcDSKH.Enabled = false;
                    MessageBox.Show("Lưu thành công!", "Thông báo !", MessageBoxButtons.OK);

                }
                else
                {
                    try
                    {
                        bdsTK.EndEdit();            // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                        bdsTK.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                        this.taiKhoanTableAdapter.Update(this.dS.TaiKhoan);         // cập nhật dl từ dataset về database thông qua tableadapter
                        isEditingTK = false;
                        gcTK.Enabled = true;
                        btnThemTK.Enabled = btnXoaTK.Enabled =btnThoat.Enabled= true;
                        gcDSKH.Enabled = false;
                        MessageBox.Show("Lưu thành công!", "Thông báo !", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi tài khoản. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnXoaTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsTK.Count == 0)
            {
                return;
            }
            else
            {
                if (bsdChuyenTien.Count > 0)
                {
                    MessageBox.Show("Tài khoản đã có giao dịch chuyển tiền, không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                if (bdsGuiRutTien.Count > 0)
                {
                    MessageBox.Show("Tài khoản đã có giao dịch gửi hoặc rút tiền, không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản ?", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        try
                        {
                            bdsTK.RemoveCurrent();         //xóa row đang chọn ra khỏi dataset
                            this.taiKhoanTableAdapter.Update(this.dS.TaiKhoan);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa tài khoản. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            this.sp_HIENTHIKHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_HIENTHIKHACHHANGTableAdapter.Fill(this.dS.sp_HIENTHIKHACHHANG);
            if (isEditingTK == true)
            {
                bdsTK.CancelEdit();
                bdsTK.Position = vitriTK;
                gcTK.Enabled = true;
                txtCMND.ReadOnly = true;
                btnThemTK.Enabled = btnXoaTK.Enabled = btnThoat.Enabled = true;             
                isEditingTK = false;
                gcDSKH.Enabled = false;
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
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
            this.chiNhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiNhanhTableAdapter.Fill(this.dS.ChiNhanh);

            maCN = ((DataRowView)bdsCN[0])["MACN"].ToString().Trim();
            txtMaCN.Text = maCN;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            this.sp_HIENTHIKHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_HIENTHIKHACHHANGTableAdapter.Fill(this.dS.sp_HIENTHIKHACHHANG);
            txtCMND.ReadOnly = true;
            txtMaCN.ReadOnly = true;
            gcDSKH.Enabled = false;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
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
                        txtMaCN.Text = maCN;
                        this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
                        this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
                        this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
                        this.sp_HIENTHIKHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sp_HIENTHIKHACHHANGTableAdapter.Fill(this.dS.sp_HIENTHIKHACHHANG);
                    }
                    catch (Exception) { }
                }
            }
        }

       

        private void gcDSKH_Click(object sender, EventArgs e)
        {
            txtCMND.Text = ((DataRowView)bsdKH[bsdKH.Position])["CMND"].ToString().Trim();
            txtMaCN.Text = maCN;
        }

    
    }
}