using DoAnGiuaKi.DAO;
using DoAnGiuaKi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnGiuaKi
{
    public partial class ThongTinTaiKhoan : Form
    {
        public ThongTinTaiKhoan(TaiKhoan acc)
        {
            InitializeComponent();
            LoadTaiKhoan(acc);
        }

        void LoadTaiKhoan(TaiKhoan acc)
        {
            txbTaiKhoan.TextName = acc.Taikhoan;
            txbTaiKhoan.Enabled = false;
            txbTaiKhoan.BackColor = Color.Gainsboro;
            txbPass.TextName = acc.Matkhau;
            txbRePass.TextName = acc.Matkhau;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thông tin sẽ không được thay đổi bạn có chắc muốn hủy thao tác?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(rs == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void btnDoi_Click(object sender, EventArgs e)
        {
            if(txbPass.TextName == "" || txbRePass.TextName == "")
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(txbPass.TextName != txbRePass.TextName)
                    MessageBox.Show("Mật khẩu nhập lại ko đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    TaikhoanDAO.Instance.CapNhatTaiKhoan(txbTaiKhoan.TextName, txbPass.TextName);
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }


        }
    }
}
