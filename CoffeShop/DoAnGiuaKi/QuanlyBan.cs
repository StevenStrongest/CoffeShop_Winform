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
    public partial class QuanlyBan : Form
    {
        private int id = 1;
        public QuanlyBan()
        {
            InitializeComponent();
            LoadBan(id);
        }

        void LoadBan(int id)
        {
            DataTable table = BanDAO.Instance.DanhSachBan(id);
            dataTable.DataSource = table;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if(id < 3)
            {
                id++;
                LoadBan(id);
            }                      
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(id > 1)
            {
                id--;
                LoadBan(id);
            }
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CRUDBan ban = new CRUDBan();
            ban.ShowDialog();
            if(ban.DialogResult == DialogResult.OK)
            {
                LoadBan(id);
            }
        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int c = dataTable.CurrentCell.RowIndex;
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    int idBan = (int)dataTable.Rows[c].Cells[1].Value;
                    string trangthai = BanDAO.Instance.KiemTraTrangThaiBan(idBan);
                    if(trangthai == "Trống")
                    {
                        BanDAO.Instance.XoaBan(idBan);
                        MessageBox.Show("Xóa thành công");
                        LoadBan(id);
                    }
                    else if(trangthai == "Đã đặt trước")
                    {
                        MessageBox.Show("Không thể xóa! Bàn hiện đã được đặt trước");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa! Bàn hiện đang có khách");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không tồn tại dữ liệu");
            }
            
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
            panelSearch.BackColor = Color.Green;
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string val = txbSearch.Text;
            dataTable.DataSource = BanDAO.Instance.SearchBan(val);
        }

        private void txbSearch_Leave(object sender, EventArgs e)
        {
            if(txbSearch.Text == "")
            {
                txbSearch.Text = "Tìm Kiếm";
                LoadBan(id);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CRUDDatBAn dt = new CRUDDatBAn();
            dt.ShowDialog();
        }
    }
}
