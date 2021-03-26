using DoAnGiuaKi.DAO;
using NotificationAlert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnGiuaKi
{
    public partial class QuanLyTaiKhoan : Form
    {
        private DTO.TaiKhoan tk;
        DataTable newtable = new DataTable();

        public DTO.TaiKhoan Tk
        {
            get => tk;
            set
            {
                this.tk = value;
            }
        }

        public QuanLyTaiKhoan(DTO.TaiKhoan acc)
        {
            InitializeComponent();
            this.Tk = acc;
            LoadDataTaiKhoan();
            AutoCompleteSearch();
            dataAcc.AllowUserToAddRows = false;
        }

        void LoadDataTaiKhoan()
        {
            DataTable table = TaikhoanDAO.Instance.DanhsachTaiKhoan();         
            newtable.Clear();
            newtable.Columns.Add("tenTaiKhoan");
            newtable.Columns.Add("matkhau");
            newtable.Columns.Add("loaiTK");         
            foreach (DataRow row in table.Rows)
            {
                string loai = string.Empty;
                if ((int)row["loaiTK"] == 1)
                {
                    loai = "Admin";
                }
                else if((int)row["loaiTK"] == 2)
                {
                    loai = "Nhân Viên";
                }
                else
                {
                    loai = "Đầu Bếp";
                }
                DataRow r = newtable.NewRow();
                dataAcc.Rows.Add(row["tenTaiKhoan"], row["matkhau"], loai);
                string t = (string)row["tenTaiKhoan"];
                string m = (string)row["matkhau"];
                string l = loai;
                r["tenTaiKhoan"] = t;
                r["matkhau"] = m;
                r["loaiTK"] = l;
                newtable.Rows.Add(r);
            }
        }

        void Clear()
        {
            //for (int i = 2; i < dataAcc.Rows.Count; i++)
            //{           
            //    dataAcc.Rows.RemoveAt(i);
            //}
            dataAcc.Refresh();
            dataAcc.Parent.Refresh();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CRUDTaiKhoan tk = new CRUDTaiKhoan();
           DialogResult rs = tk.ShowDialog();
           if(rs == DialogResult.OK)
            {
                dataAcc.DataSource = SearchAcc("");
            }
        }

        void AutoCompleteSearch()
        {
            txbSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            DataTable table = TaikhoanDAO.Instance.DanhsachTaiKhoan();
            foreach (DataRow row in table.Rows)
            {
                col.Add(row["tenTaiKhoan"].ToString());
            }
            txbSearch.AutoCompleteCustomSource = col;

        }

        DataTable SearchAcc(string val)
        {
            DataTable table = TaikhoanDAO.Instance.SearchTaiKhoan(val);
            newtable.Clear();
            foreach (DataRow row in table.Rows)
            {
                string loai = string.Empty;
                if ((int)row["loaiTK"] == 1)
                {
                    loai = "Admin";
                }
                else if ((int)row["loaiTK"] == 2)
                {
                    loai = "Nhân Viên";
                }
                else
                {
                    loai = "Đầu Bếp";
                }
                DataRow r = newtable.NewRow();
                string t = (string)row["tenTaiKhoan"];
                string m = (string)row["matkhau"];
                string l = loai;
                r["tenTaiKhoan"] = t;
                r["matkhau"] = m;
                r["loaiTK"] = l;
                newtable.Rows.Add(r);
            }
            return newtable;
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string val = txbSearch.Text;
            dataAcc.DataSource = SearchAcc(val);
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
            panelSearch.BackColor = Color.Green;
        }

        private void txbSearch_Leave(object sender, EventArgs e)
        {
            if (txbSearch.Text == "")
            {
                txbSearch.Text = "Tìm Kiếm";
                dataAcc.DataSource = SearchAcc("");
                //LoadDataTaiKhoan();
            }
        }

        public void ThongBao(string ms)
        {
            NotificationAlert.SuccessAlert al = new SuccessAlert();
            al.Alert(ms);
            al.ShowDialog();
            al.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
        }

        private void dataAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           

            try
            {                
                int c = dataAcc.CurrentCell.RowIndex;                                  
                var senderGrid = (DataGridView)sender;
                string tk = (string)dataAcc.CurrentRow.Cells[0].Value;
                if (tk == null)
                {
                    tk = (string)dataAcc.Rows[c].Cells[1].Value;
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        TaikhoanDAO.Instance.XoaTaiKhoan(tk);
                        ThongBao("Xóa Thành Công");
                        dataAcc.DataSource = SearchAcc("");
                    }
                }
               // MessageBox.Show(tk);
                if (tk != null)
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 3)
                    {
                        if (tk == Tk.Taikhoan)
                        {
                            MessageBox.Show("Không thể xóa tài khoản hiện đang hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (rs == DialogResult.Yes)
                            {
                                TaikhoanDAO.Instance.XoaTaiKhoan(tk);
                                ThongBao("Xóa Thành Công");
                                dataAcc.DataSource = SearchAcc("");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại dữ liệu");
                }
            }
            catch
            {

                MessageBox.Show("Không tồn tại dữ liệu");
            }
                
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
