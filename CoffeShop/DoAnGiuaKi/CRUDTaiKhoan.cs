using DoAnGiuaKi.DAO;
using NotificationAlert;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnGiuaKi
{
    public partial class CRUDTaiKhoan : Form
    {
        public CRUDTaiKhoan()
        {
            InitializeComponent();
            DataLoaiTaiKhoan();
            HideError();
        }      
        private static int num;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbTaiKhoan.TextInput == "" || txbMatKhau.TextInput == "")
            {
                if (txbTaiKhoan.TextInput == "")
                {
                    txbTaiKhoan.onFocusBorderColor = Color.Red;
                    ShowErrorTaiKhoan("Vui lòng không để trống tài khoản");                   
                }

                if (txbMatKhau.TextInput == "")
                {
                    txbMatKhau.onFocusBorderColor = Color.Red;
                    ShowErrorMatKhau("Vui lòng không để trống mật khẩu");
                }               
            }
            else
            {
                if (txbMatKhau.TextInput.Length < 3)
                {
                    ShowErrorMatKhau("Mật khẩu phải lớn hơn 3 kí tự");
                }
                else
                {
                    HideError();
                    int loai = ((KeyValuePair<int, string>)cbxLoai.SelectedItem).Key;
                    string tenTaiKhoan = txbTaiKhoan.TextInput;
                    string matkhau = txbMatKhau.TextInput;
                    TaikhoanDAO.Instance.ThemTaiKhoan(tenTaiKhoan, matkhau, loai);
                    NotificationAlert.SuccessAlert success = new SuccessAlert();
                    success.Alert("Thêm thành công");
                    success.ShowDialog();
                }            
           }
        }

        public void DataLoaiTaiKhoan()
        {
            Dictionary<int, string> data = new Dictionary<int, string>();
            data.Add(1,"Admin");
            data.Add(2,"Nhân Viên");
            data.Add(3,"Đầu Bếp");
            cbxLoai.DataSource = new BindingSource(data, null);
            cbxLoai.DisplayMember = "Value";
            cbxLoai.ValueMember = "Key";
        }


        void HideError()
        {
            panelErrorName.Visible = false;
            panelErrorPrice.Visible = false;
        }

        void ShowErrorTaiKhoan(string er)
        {
            panelErrorName.Visible = true;
            labelErrorName.Text = er;
        }

        void ShowErrorMatKhau(string er)
        {
            panelErrorPrice.Visible = true;
            labelErrorPrice.Text = er;
        }

        private void CRUDTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
