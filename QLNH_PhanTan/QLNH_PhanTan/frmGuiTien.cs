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
using DevExpress.ClipboardSource.SpreadsheetML;

namespace QLNH_PhanTan
{
    public partial class frmGuiTien : DevExpress.XtraEditors.XtraForm
    {
        private class Data
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
        String loaiGD;
        public frmGuiTien()
        {
            InitializeComponent();
            
        }

        private void cmbLoaiGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiGD.SelectedValue!=null)
            {
                loaiGD = cmbLoaiGD.SelectedValue.ToString().Trim();
            }
        }

    
        private void frmGuiTien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

            BindingList<Data> _comboItems = new BindingList<Data>();
            _comboItems.Add(new Data { Name = "Gửi Tiền", Value = "GT" });
            _comboItems.Add(new Data { Name = "Rút Tiền", Value = "RT" });
            cmbLoaiGD.DataSource = _comboItems;
            cmbLoaiGD.DisplayMember = "Name";
            cmbLoaiGD.ValueMember = "Value";
            txtHoTen.Text = Program.mHoten;
            txtMaNV.Text = Program.username;
            cmbLoaiGD.SelectedIndex = -1;
            cmbLoaiGD.SelectedIndex = 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtSoTK.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtSoTK.Focus();
            }
            else if (txtSoTien.Text.Trim() == "")
            {
                MessageBox.Show("Số tiền không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtSoTien.Focus();
            }
            else if (int.Parse(txtSoTien.Text.Trim())<100000)
            {
                MessageBox.Show("Số tiền phải lớn hơn 100.000 !", "Thông báo !", MessageBoxButtons.OK);
                txtSoTien.Focus();
            }
            else
            {
                try
                {
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    String str_sp = "sp_GOIRUT";
                    Program.Sqlcmd = Program.conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@stk", SqlDbType.VarChar).Value = txtSoTK.Text;
                    Program.Sqlcmd.Parameters.Add("@loai", SqlDbType.VarChar).Value = loaiGD;
                    Program.Sqlcmd.Parameters.Add("@money", SqlDbType.Money).Value = txtSoTien.Text;
                    Program.Sqlcmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = txtMaNV.Text;
                    Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.Sqlcmd.ExecuteNonQuery();
                    String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                    if (ret == "0")
                    {
                        MessageBox.Show("Số tài khoản không tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ret == "1")
                    {
                        MessageBox.Show("Số dư không đủ để rút. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ret == "2" && loaiGD == "GT")
                    {
                        this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
                        MessageBox.Show("Gửi tiền thành công!", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ret == "2" && loaiGD == "RT")
                    {
                        MessageBox.Show("Rút tiền thành công!", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Giao dịch thất bại!", "Thông báo !", MessageBoxButtons.OK);
                }
            }
            
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gD_GOIRUTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
    }
}