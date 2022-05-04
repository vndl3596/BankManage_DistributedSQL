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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        String maCN;
        Boolean isAddNV = false;
        Int32 vitriNV = 0;
        string maNVXoa = "";

        Stack<String> undoStack;
        String insertBack;
        String updateBack;
        String deleteBack;
        String ho, ten, diaChi, gioiTinh, sdt;
        int drop = 0;

        public frmNhanVien()
        {
            InitializeComponent();
            if (Program.mGroup.Trim() == "NGANHANG")
            {
                btnLuuNV.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnReload.Enabled = false;
                btnThemNV.Enabled = false;
                btnXoaNV.Enabled = false;
                btnChuyen.Enabled = false;
                txtCN.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtHo.ReadOnly = true;
                txtMaNV.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtTen.ReadOnly = true;
                checkXoaNV.Enabled = false;
            }

        }
        void checkStackUndo()
        {
            if (undoStack.Count > 0)
                btnPhucHoi.Enabled = true;
            else
                btnPhucHoi.Enabled = false;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            undoStack = new Stack<string>(10);
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
            maCN = ((DataRowView)bsdCN[0])["MACN"].ToString().Trim();
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            maNVXoa = ((DataRowView)bdsDSNV[bdsDSNV.Position])["MANV"].ToString().Trim();
            if (maNVXoa == Program.username)
            {
                btnXoaNV.Enabled = false;
                btnChuyen.Enabled = false;
            }
            DataRowView drv = (DataRowView)bdsDSNV[bdsDSNV.Position];
            ho = drv["HO"].ToString();
            ten = drv["TEN"].ToString();
            diaChi = drv["DIACHI"].ToString();
            gioiTinh = drv["PHAI"].ToString();
            sdt = drv["SODT"].ToString();
            drop = (int)drv["TrangThaiXoa"];
            txtMaNV.ReadOnly = true;
            txtCN.ReadOnly = true;
            maNVXoa = ((DataRowView)bdsDSNV[bdsDSNV.Position])["MANV"].ToString().Trim();
            if (maNVXoa == Program.username)
            {
                btnXoaNV.Enabled = false;
                btnChuyen.Enabled = false;
            }
            else
            {
                if (Program.mGroup.Trim() != "NGANHANG")
                {
                    btnXoaNV.Enabled = true;
                    btnChuyen.Enabled = true;
                }
            }
            checkStackUndo();
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
                        maCN = ((DataRowView)bsdCN[0])["MACN"].ToString().Trim();
                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                        maNVXoa = ((DataRowView)bdsDSNV[bdsDSNV.Position])["MANV"].ToString().Trim();
                        if (maNVXoa == Program.username)
                        {
                            checkXoaNV.Enabled = false;
                        }
                        checkStackUndo();

                    }
                    catch (Exception) { }
                }
            }
        }

        private void btnThemNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtMaNV.Focus();
            vitriNV = bdsDSNV.Position;
            isAddNV = true;

            bdsDSNV.AddNew();

            nhanVienGridControl.Enabled = false;
            txtCN.Text = maCN;
            checkXoaNV.Checked = false;
            cmbPhai.SelectedIndex = 1;
            cmbPhai.SelectedIndex = 0;
            checkXoaNV.Enabled = false;
            cmbChiNhanh.Enabled = false;
            txtMaNV.ReadOnly = false;
            txtMaNV.Focus();

            btnThemNV.Enabled = btnXoaNV.Enabled = btnThoat.Enabled = btnChuyen.Enabled = false;
        }

        private void btnLuuNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaNV.Focus();
            }
            else if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtHo.Focus();
            }
            else if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
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
            else
            {
                if (isAddNV == true)
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    String str_sp = "sp_KIEMTRAMANHANVIENTONTAI";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = txtMaNV.Text;
                    Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.Sqlcmd.ExecuteNonQuery();
                    String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                    if (ret == "1")
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        try
                        {
                            bdsDSNV.EndEdit();            // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                            bdsDSNV.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                            this.nhanVienTableAdapter.Update(this.dS.NhanVien);         // cập nhật dl từ dataset về database thông qua tableadapter                           
                            isAddNV = false;
                            nhanVienGridControl.Enabled = true;
                            btnThemNV.Enabled = btnXoaNV.Enabled = btnChuyen.Enabled = true;
                            txtMaNV.ReadOnly = true;
                            MessageBox.Show("Lưu thành công!", "Thông báo !", MessageBoxButtons.OK);
                            insertBack = "delete from NhanVien where MANV = '" + txtMaNV.Text + "'";
                            undoStack.Push(insertBack);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi nhân viên. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }

                }
                else
                {
                   
                    try
                    {
                        DataRowView drv = (DataRowView)bdsDSNV[bdsDSNV.Position];
                        ho = drv["HO"].ToString();
                        ten = drv["TEN"].ToString();
                        diaChi = drv["DIACHI"].ToString();
                        gioiTinh = drv["PHAI"].ToString();
                        sdt = drv["SODT"].ToString();
                        drop = (int)drv["TrangThaiXoa"];
                        updateBack = "update NhanVien set HO = N'" + ho + "', " +
                                        "TEN = N'" + ten + "' , " +
                                        "DIACHI = N'" + diaChi + "' , " +
                                        "PHAI = '" + gioiTinh + "' , " +
                                        "SODT = N'" + sdt + "' , " +
                                        "MACN = N'" + maCN + "' , " +
                                        "TrangThaiXoa = '" + drop + "' " +
                                        "WHERE MANV = '" + txtMaNV.Text.Trim() + "';";
                        bdsDSNV.EndEdit();            // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                        bdsDSNV.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                        this.nhanVienTableAdapter.Update(this.dS.NhanVien);         // cập nhật dl từ dataset về database thông qua tableadapter
                        isAddNV = false;
                        nhanVienGridControl.Enabled = true;
                        btnThemNV.Enabled = btnXoaNV.Enabled = btnChuyen.Enabled = true;
                        txtMaNV.ReadOnly = true;
                        MessageBox.Show("Lưu thành công!", "Thông báo !", MessageBoxButtons.OK);
                        undoStack.Push(updateBack);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi nhân viên. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    }

                }

            }
            checkStackUndo();
        }

        private void btnXoaNV_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (bdsDSNV.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa hoàn toàn nhân viên này?", "Thông báo !", MessageBoxButtons.YesNo);
                if (ds == DialogResult.Yes)
                {
                    //SP_KTNHANVIENDUOCXOA
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    String str_sp = "SP_KTNHANVIENDUOCXOA";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = maNVXoa;
                    Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.Sqlcmd.ExecuteNonQuery();
                    String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                    if (ret == "1")
                    {
                        DialogResult ds1 = MessageBox.Show("Nhân viên này đã có tài khoản, bạn có chắc muốn xóa?\nThao tác này không thể hoàn tác!!", "Thông báo !", MessageBoxButtons.YesNo);
                        if (ds1== DialogResult.Yes) {
                            try {
                                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                                String str_sp1 = "SP_XOALOGIN";
                                Program.Sqlcmd = Program.conn.CreateCommand();
                                Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                                Program.Sqlcmd.CommandText = str_sp1;
                                Program.Sqlcmd.Parameters.Add("@TENUSER", SqlDbType.VarChar).Value = txtMaNV.Text.Trim();
                                Program.Sqlcmd.Parameters.Add("@GROUPNAME", SqlDbType.VarChar).Value = Program.mGroup;
                                Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                                Program.Sqlcmd.ExecuteNonQuery();
                                String ret1 = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                                if (ret1 == "0")
                                {
                                    MessageBox.Show("Bạn không có quyền này!!", "Thông báo !", MessageBoxButtons.OK);
                                    return;
                                }
                                else
                                {
                                   
                                    bdsDSNV.EndEdit();            // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                                    bdsDSNV.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);                              
                                    MessageBox.Show("Xóa thành công!", "Thông báo !", MessageBoxButtons.OK);
                                }
                            }
                            catch (Exception ex) {
                                MessageBox.Show("Lỗi xóa login. Xóa thất bại" + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                            }

                        }
                      
                    }
                    else
                    {

                        updateBack = "update NhanVien set HO = N'" + ho + "', " +
                       "TEN = N'" + ten + "' , " +
                       "DIACHI = N'" + diaChi + "' , " +
                       "PHAI = '" + gioiTinh + "' , " +
                       "SODT = N'" + sdt + "' , " +
                       "MACN = N'" + maCN + "' , " +
                       "TrangThaiXoa = '" + drop + "' " +
                       "WHERE MANV = '" + txtMaNV.Text.Trim() + "';";
                        try
                        {
                            DataRowView drv = (DataRowView)bdsDSNV[bdsDSNV.Position];
                            ho = drv["HO"].ToString();
                            ten = drv["TEN"].ToString();
                            diaChi = drv["DIACHI"].ToString();
                            gioiTinh = drv["PHAI"].ToString();
                            sdt = drv["SODT"].ToString();
                            drop = (int)drv["TrangThaiXoa"];
                            deleteBack = "insert into NhanVien(MANV,HO,TEN,DIACHI,PHAI,SODT,MACN,TrangThaiXoa)";
                            deleteBack += " values('" + txtMaNV.Text + "' , " + "N'" + ho + "', " +
                            "N'" + ten + "' , " +
                            "N'" + diaChi + "' , " +
                            "N'" + gioiTinh + "' , " +
                            "N'" + sdt + "' , " +
                            "'" + maCN + "' , " +
                            "'" + drop + "' )";
                            undoStack.Push(deleteBack);
                            bdsDSNV.RemoveCurrent();         //xóa row đang chọn ra khỏi dataset
                            this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                            bdsDSNV.Position = 0;
                            MessageBox.Show("Xóa thành công!", "Thông báo !", MessageBoxButtons.OK);
                            checkStackUndo();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa nhân viên. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsDSNV.CancelEdit();
            if (Program.KetNoi() == 0) return;
            String lenh = undoStack.Pop();
            int n = Program.ExecSqlNonQuery(lenh);
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            checkStackUndo();
        }

        private void btnChuyen_ItemClick(object sender, ItemClickEventArgs e)
        { 
            if (bdsDSNV.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn chuyển chi nhánh nhân viên này?\nThao tác này không thể hoàn tác!!", "Thông báo !", MessageBoxButtons.YesNo);
                if (ds == DialogResult.Yes)
                {
                    //SP_KTNHANVIENDUOCXOA
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    String str_sp = "SP_KTNHANVIENDUOCXOA";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = maNVXoa;
                    Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.Sqlcmd.ExecuteNonQuery();
                    String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                    if (ret == "1")
                    {
                        DialogResult ds1 = MessageBox.Show("Nhân viên này đã có tài khoản, bạn có chắc muốn chuyển?\nThao tác này không thể hoàn tác!!", "Thông báo !", MessageBoxButtons.YesNo);
                        if (ds1 == DialogResult.Yes)
                        {
                            try
                            {
                                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                                String str_sp1 = "SP_XOALOGIN";
                                Program.Sqlcmd = Program.conn.CreateCommand();
                                Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                                Program.Sqlcmd.CommandText = str_sp1;
                                Program.Sqlcmd.Parameters.Add("@TENUSER", SqlDbType.VarChar).Value = txtMaNV.Text.Trim();
                                Program.Sqlcmd.Parameters.Add("@GROUPNAME", SqlDbType.VarChar).Value = Program.mGroup;
                                Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                                Program.Sqlcmd.ExecuteNonQuery();
                                String ret1 = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                                if (ret1 == "0")
                                {
                                    MessageBox.Show("Bạn không có quyền này!!", "Thông báo !", MessageBoxButtons.OK);
                                    return;
                                }
                                else
                                {
                                    try
                                    {
                                        if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                                        String str_sp2 = "SP_CHUYENCHINHANHNV";
                                        Program.Sqlcmd = Program.conn.CreateCommand();
                                        Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                                        Program.Sqlcmd.CommandText = str_sp2;
                                        Program.Sqlcmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = txtMaNV.Text.Trim();
                                        if (txtCN.Text.Trim().Equals("BENTHANH"))
                                        {
                                            Program.Sqlcmd.Parameters.Add("@macn", SqlDbType.VarChar).Value = "TANDINH ";
                                        }
                                        else
                                        {
                                            Program.Sqlcmd.Parameters.Add("@macn", SqlDbType.VarChar).Value = "BENTHANH ";
                                        }
                                        Program.Sqlcmd.ExecuteNonQuery();
                                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                                        this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                                        MessageBox.Show("Chuyển thành công", "Thông báo !", MessageBoxButtons.OK);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Chuyển thất bại" + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi xóa login. Xóa thất bại" + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                            }

                        }

                    }
                    else
                    {
                        try
                        {
                            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                            String str_sp2 = "SP_CHUYENCHINHANHNV";
                            Program.Sqlcmd = Program.conn.CreateCommand();
                            Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                            Program.Sqlcmd.CommandText = str_sp2;
                            Program.Sqlcmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = txtMaNV.Text.Trim();
                            if (txtCN.Text.Trim().Equals("BENTHANH"))
                            {
                                Program.Sqlcmd.Parameters.Add("@macn", SqlDbType.VarChar).Value = "TANDINH ";
                            }
                            else
                            {
                                Program.Sqlcmd.Parameters.Add("@macn", SqlDbType.VarChar).Value = "BENTHANH ";
                            }
                            Program.Sqlcmd.ExecuteNonQuery();
                            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                            MessageBox.Show("Chuyển thành công", "Thông báo !", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Chuyển thất bại" + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsDSNV.CancelEdit();
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            if (isAddNV == true)
            {

                bdsDSNV.Position = vitriNV;
                nhanVienGridControl.Enabled = true;
                btnThemNV.Enabled = btnXoaNV.Enabled = btnThoat.Enabled = cmbChiNhanh.Enabled = true;
                txtMaNV.ReadOnly = true;
                isAddNV = false;
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void nhanVienGridControl_Click(object sender, EventArgs e)
        {
            maNVXoa = ((DataRowView)bdsDSNV[bdsDSNV.Position])["MANV"].ToString().Trim();
             if (maNVXoa == Program.username)
            {
                btnXoaNV.Enabled = false;
                btnChuyen.Enabled = false;
            }
            else
            {
                if (Program.mGroup.Trim() != "NGANHANG")
                {
                    btnXoaNV.Enabled = true;
                    btnChuyen.Enabled = true;
                }
            }
            DataRowView drv = (DataRowView)bdsDSNV[bdsDSNV.Position];
            ho = drv["HO"].ToString();
            ten = drv["TEN"].ToString();
            diaChi = drv["DIACHI"].ToString();
            gioiTinh = drv["PHAI"].ToString();
            sdt = drv["SODT"].ToString();
            drop = (int)drv["TrangThaiXoa"];
        }

        private void checkXoaNV_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}