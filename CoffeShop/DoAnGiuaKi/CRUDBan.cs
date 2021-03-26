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

namespace DoAnGiuaKi
{
    public partial class CRUDBan : Form
    {
        public CRUDBan()
        {
            InitializeComponent();
            LoadTang();
        }

        void LoadTang()
        {
            cbTang.DataSource = TangDAO.Instance.LoadDataTang();
            cbTang.DisplayMember = "tenTang";
            cbTang.ValueMember = "idTang";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txbTenBan.Text;
            int id = (int)cbTang.SelectedValue;

            if(ten == "")
            {
                MessageBox.Show("Vui lòng nhập tên bàn");
            }
            else
            {
                BanDAO.Instance.ThemBan(ten, id);
                MessageBox.Show("Thêm thành công");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CRUDBan_FormClosed(object sender, FormClosedEventArgs e)
        {
           DialogResult =  DialogResult.OK;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
