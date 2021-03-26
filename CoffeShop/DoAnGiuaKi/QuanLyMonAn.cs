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
using JTextBox;
using FontAwesome.Sharp;
using System.Collections;

namespace DoAnGiuaKi
{
    public partial class QuanLyMonAn : Form
    {
        private CRUMonAn formup = new CRUMonAn();
        public QuanLyMonAn()
        {
            InitializeComponent();
            LoadDataFood();
            AutoCompleteSearch();
        }

        public void LoadDataFood()
        {
            DataTable table = ThucAnDAO.Instance.ShowThucAn();
            dataFood.DataSource = table;
        } 
        
        void AutoCompleteSearch()
        {
            txbSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            DataTable table = ThucAnDAO.Instance.ShowThucAn();
            foreach(DataRow row in table.Rows)
            {
                col.Add(row["tenTA"].ToString());
            }          
            txbSearch.AutoCompleteCustomSource = col;

        }

        DataTable SearchFood(string val)
        {
            return ThucAnDAO.Instance.SearchFood(val);
        }

         

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string val = txbSearch.Text;
            dataFood.DataSource = SearchFood(val);          
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
            panelSearch.BackColor = Color.Green;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(txbSearch.Text == "")
            {
                txbSearch.Text = "Tìm Kiếm";
                LoadDataFood();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CRUMonAn ma = new CRUMonAn();
            DialogResult rs  = ma.ShowDialog();
            if(rs == DialogResult.OK)
            {
                LoadDataFood();
            }

        }
     
        //Xử lý sửa xóa món ăn
        private void dataFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int c = dataFood.CurrentCell.RowIndex;
                bool f = true;
                var SenderGrid = (DataGridView)sender;
                //Xóa
                if (SenderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 1)
                {
                    int id = (int)dataFood.Rows[c].Cells[2].Value;
                    DataTable table = ThucAnDAO.Instance.LayidThucAn();
                    foreach(DataRow r in table.Rows)
                    {
                        if(id == (int)r["idTA"])
                        {
                            MessageBox.Show("Món Ăn đang được đặt không thể thực hiện chức năng này");
                            f = false;
                        }
                    }
                    if (f == true) 
                    {
                        DialogResult rs = MessageBox.Show("Dữ liệu không thể khôi phục! Bạn có chắc muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (rs == DialogResult.Yes)
                        {
                            ThucAnDAO.Instance.XoaMonAn(id);
                            NotificationAlert.SuccessAlert al = new SuccessAlert();
                            al.Alert("Xóa thành công");
                            al.ShowDialog();
                            LoadDataFood();
                        }
                    }                       
                }
                //Sửa
                else if (SenderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    bool flag = true;
                    int id = (int)dataFood.Rows[c].Cells[2].Value;
                    DataTable tb = ThucAnDAO.Instance.LayidThucAn();
                    foreach (DataRow r in tb.Rows)
                    {
                        if (id == (int)r["idTA"])
                        {
                            MessageBox.Show("Món Ăn đang được đặt không thể thực hiện chức năng này");
                            flag = false;
                        }
                    }
                    DataTable table = ThucAnDAO.Instance.ShowThucAnTuId(id);
                    foreach (DataRow row in table.Rows)
                    {
                        formup.txbTen.TextInput = row["tenTA"].ToString();
                        formup.txbGia.TextInput = row["gia"].ToString();
                    }
                    formup.btnSua.Visible = true;
                    formup.txbID.TextInput = id.ToString();
                    formup.txbID.Enabled = false;
                    formup.panelID.Visible = true;
                    if(flag == true)
                    {
                        formup.btnSua.Click += BtnSua_Click;
                        formup.ShowDialog();
                    }                    
                }
            }
            catch
            {
                MessageBox.Show("Không tồn tại dữ liệu");
            }
                                                         
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            int idLoai = (int)formup.cbxLoai.SelectedValue;
            string ten = formup.txbTen.TextInput;
            int gia = 0;
            int id = 0;
            Int32.TryParse(formup.txbID.TextInput, out id);
            formup.txbID.BackColor = Color.FromArgb(160,160,160);
            Int32.TryParse(formup.txbGia.TextInput, out gia);
            ThucAnDAO.Instance.UpdateFood(ten,gia,idLoai,id);
            NotificationAlert.SuccessAlert tt = new SuccessAlert();
            tt.Alert("Cập nhật thành công");
            tt.ShowDialog();
            LoadDataFood();          
        }

    }
}
