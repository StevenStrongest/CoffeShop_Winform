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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();          
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taikhoan = txbUser.Text;
            string matkhau = txtPass.Text;
            if (Dangnhap(taikhoan, matkhau))
            {
                TaiKhoan acc = TaikhoanDAO.Instance.TaiKhoanDangNhap(taikhoan);
                MainForm mainApp = new MainForm(acc);
                this.Hide();
                mainApp.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        bool Dangnhap(string taikhoan, string matkhau)
        {
            return TaikhoanDAO.Instance.Dangnhap(taikhoan,matkhau);
        }

        private void txbUser_Leave(object sender, EventArgs e)
        {
            if(txbUser.Text == "")
            {
                txbUser.Text = "Tài khoản";
                panelUser.BackColor = Color.LightBlue;
            }     
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                txtPass.Text = "Mật khẩu";
                txtPass.BackColor = Color.LightBlue;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txbUser_Enter(object sender, EventArgs e)
        {
            if (txbUser.Text == "Tài khoản")
                txbUser.Clear();
            panelUser.BackColor = Color.FromArgb(91, 189, 43);
            panelPass.BackColor = Color.LightBlue;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Mật khẩu")
                txtPass.Clear();
            panelPass.BackColor = Color.FromArgb(91, 189, 43);
            panelUser.BackColor = Color.LightBlue;
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
