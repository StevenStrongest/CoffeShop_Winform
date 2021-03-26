using DoAnGiuaKi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotificationAlert;

namespace DoAnGiuaKi
{
    public partial class CRUMonAn : Form
    {     
        private static int num;

        private static CRUMonAn instance;

        public static CRUMonAn Instance 
        { 
            get { if (instance == null) instance = new CRUMonAn(); return instance; } 
            private set => instance = value; 
        
        }

        public CRUMonAn()
        {
            InitializeComponent();
            AddDataTextBox();
            HideError();
        }

        void AddDataTextBox()
        {
            DataTable table = ThucAnDAO.Instance.ShowLoaiThucAn();
            cbxLoai.DataSource = table;
            cbxLoai.DisplayMember = "tenLoai";
            cbxLoai.ValueMember = "idLoaiTA";
        }
        
        void HideError()
        {
            panelErrorName.Visible = false;
            panelErrorPrice.Visible = false;
        }
        void ShowErrorName(string er)
        {
            panelErrorName.Visible = true;
            labelErrorName.Text = er;
        }

        void ShowErrorPrice(string er)
        {
            panelErrorPrice.Visible = true;
            labelErrorPrice.Text = er;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbTen.TextInput == "" || txbGia.TextInput == "")
            {
                if (txbTen.TextInput == "")
                {
                    txbTen.onFocusBorderColor = Color.Red;
                    ShowErrorName("Tên món ăn không được để trống");
                }

                if (txbGia.TextInput == "")
                {
                    txbGia.onFocusBorderColor = Color.Red;
                    ShowErrorPrice("Giá món ăn không được để trống");
                }
                else
                {                   
                    if(!Int32.TryParse(txbGia.TextInput, out num))
                    {
                        txbGia.onFocusBorderColor = Color.Red;
                        ShowErrorPrice("Giá món ăn chứa kí tự khác số");
                    }
                }
            }
            else
            {
                if(Int32.TryParse(txbGia.TextInput, out num))
                {
                    HideError();
                    int id = (int)cbxLoai.SelectedValue;
                    string ten = txbTen.TextInput;
                    ThucAnDAO.Instance.ThemMonAn(ten, num, id);
                    NotificationAlert.SuccessAlert success = new SuccessAlert();
                    success.Alert("Thêm thành công");
                    success.ShowDialog();
                }
                else
                {
                    txbGia.onFocusBorderColor = Color.Red;
                    ShowErrorPrice("Giá món ăn chứa kí tự khác số");
                }
            }                           

        }

        private void txbTen_Click(object sender, EventArgs e)
        {
            if (txbTen.TextInput != "")
            {
                HideError();
                txbTen.onFocusBorderColor = Color.Green;
            }
            else
            {
                txbTen.onFocusBorderColor = Color.Red;
                ShowErrorName("Tên món ăn không được để trống");
            }
        }

        private void txbTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            HideError();
            txbTen.onFocusBorderColor = Color.Green;
        }

        private void txbGia_Click(object sender, EventArgs e)
        {

            if (txbGia.TextInput != "")
            {
                HideError();
                txbGia.onFocusBorderColor = Color.Green;
            }
            else
            {
                if (!Int32.TryParse(txbGia.TextInput, out num))
                {
                    txbGia.onFocusBorderColor = Color.Red;
                    ShowErrorPrice("Giá món ăn chứa kí tự khác số");
                }
                else
                {
                    HideError();
                    txbGia.onFocusBorderColor = Color.Green;
                }
            }
        }

        private void CRUMonAn_Load(object sender, EventArgs e)
        {
           
        }

        private void CRUMonAn_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
