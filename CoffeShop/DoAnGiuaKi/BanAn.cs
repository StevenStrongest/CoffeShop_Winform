using DoAnGiuaKi.DAO;
using DoAnGiuaKi.DTO;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnGiuaKi
{
    public partial class BanAn : Form
    {
        private int Tongtien = 0;
        private TaiKhoan tk;

        public TaiKhoan Tk
        {
            get => tk;
            set
            {
                this.tk = value;
            }
        }

        public BanAn(TaiKhoan acc)
        {
            InitializeComponent();
            this.Tk = acc;
            //TrangThaiBan();
            LoadBan();
            LoadLoaiThucAn();
            LoadThucAnTheoLoai((int)cbxLoaiTA.SelectedValue);
            KiemTraLoaiTaiKhoan();
        }

        public void KiemTraLoaiTaiKhoan()
        {
           if(Tk.Loaitk == 3)
            {
                btnDat.Enabled = false;
                btnThanhToan.Enabled = false;
            }                 
        }

        #region Method
        void LoadBan()
        {
            List<Ban> BanList = BanDAO.Instance.LoadBAnList();

            foreach (Ban item in BanList)
            {
                lswData.LargeImageList = TableList;
                lswData.View = View.LargeIcon;
                ListViewItem i = new ListViewItem();
                i.Text = item.TenBan;
                i.Tag = item.Id;
                if(item.Trangthai == "Có Người")
                {
                    i.ImageIndex = 2;
                }
                else if(item.Trangthai == "Đã đặt trước")
                {
                    i.ImageIndex = 1;
                }
                else
                {
                    i.ImageIndex = 0;
                }
                lswData.Items.Add(i);             
            }
        }

        //Load Loại Thức Ăn
        void LoadLoaiThucAn()
        {
            DataTable table = LoaiThucAnDAO.Instance.ShowLoaiThucAn();
            cbxLoaiTA.DataSource = table;
            cbxLoaiTA.DisplayMember = "tenLoai";
            cbxLoaiTA.ValueMember = "idLoaiTA";
        }

        //Load thức ăn theo idLoai  thức ăn
        void LoadThucAnTheoLoai(int id)
        {
            DataTable table = ThucAnDAO.Instance.ShowThucAnTuLoaiThucAn(id);
            cbxTA.DataSource = table;
            cbxTA.DisplayMember = "tenTA";
            cbxTA.ValueMember = "idTA";
        }

        void TrangThaiBan()
        {
            List<Ban> banList = BanDAO.Instance.LoadBAnList();
            foreach(Ban item in banList)
            {
                int id = item.Id;
                int idtt = HoaDonDAO.Instance.GetIdBillFromIDTable(id);
                int ktra = ThongTinHoaDonDAO.Instance.KiemtraTonTaiThongTinHoaDon(idtt);
                if (ktra > 0)
                {
                    BanDAO.Instance.UpdateTrangThaiTable("Có Người", id);
                }
                else
                {
                    BanDAO.Instance.UpdateTrangThaiTable("Trống", id);
                }
            }
            
        }

        void ShowHoaDon(int id)
        {
            DataTable table = ThongTinHoaDonDAO.Instance.ShowThongTinHoaDon(id);        
            dataBill.DataSource = table;
            int i = 0;
            int tongtien = 0;
            foreach(DataRow row in table.Rows)
            {               
                int total = (int)row["gia"] * (int)row["soluong"];
                dataBill.Rows[i].Cells[0].Value = total.ToString();
                tongtien += total;
                i++;
            }
            dataBill.Rows[table.Rows.Count].Cells[1].Value = "Tong tien";
            dataBill.Rows[table.Rows.Count].Cells[0].Value = tongtien.ToString();
            Tongtien = tongtien;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = (int)(sender as Button).Tag;
            ShowHoaDon(id);
        }

        private void BanAn_Load(object sender, EventArgs e)
        {           
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (InvokeRequired)
            {
                clockprogress.Invoke((MethodInvoker)delegate
                {
                clockprogress.Text = DateTime.Now.ToString("hh:mm:ss");
                clockprogress.SubscriptText = DateTime.Now.ToString("tt");
                });
            }
        }
        #endregion

        private void lswData_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView ls = sender as ListView;
            if(ls.SelectedItems.Count > 0)
            {
                ListViewItem item = ls.SelectedItems[0];
                int id = 0;
                Int32.TryParse(item.Tag.ToString(), out id);
                DataTable table = ThongTinHoaDonDAO.Instance.ShowThongTinHoaDon(id);
                dataBill.DataSource = table;
                if(table.Rows.Count > 0)
                {
                    ShowHoaDon(id);
                }               
            }
        }

        private void cbxLoaiTA_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;           
            if(cb.SelectedValue != null)
            {
                Int32.TryParse(cb.SelectedValue.ToString(), out id);
                LoadThucAnTheoLoai(id);
            }        
        }

        private void btnDat_Click(object sender, EventArgs e)
        {          
            uint rs;
            if(txbSl.Text != "")
            {
                if(UInt32.TryParse(txbSl.Text, out rs))
                {
                    try
                    {
                        
                        int idBan = (int)lswData.SelectedItems[0].Tag;
                        int idTA = 0;
                        int sl = 0;
                        if(BanDAO.Instance.KiemTraTrangThaiBan(idBan) != "Đã đặt trước")
                        {
                            BanDAO.Instance.UpdateTrangThaiTable("Có Người", idBan);
                            Int32.TryParse(txbSl.Text, out sl);
                            Int32.TryParse(cbxTA.SelectedValue.ToString(), out idTA);
                            int kq = HoaDonDAO.Instance.KiemTraHoaDon(idBan);
                            if (kq == 2)
                            {
                                HoaDonDAO.Instance.ThemHoaDon(idBan);
                                int maxID = HoaDonDAO.Instance.GetMaxIDHoaDon();
                                ThongTinHoaDonDAO.Instance.ThemThongTinHoaDon(maxID, idTA, sl);
                                ShowHoaDon(idBan);
                                BanDAO.Instance.UpdateTrangThaiTable("Có Người", idBan);
                            }
                            else if (kq == 1)
                            {
                                int idHoaDon = HoaDonDAO.Instance.GetIdBillFromIDTable(idBan);
                                int ktra = ThongTinHoaDonDAO.Instance.KiemTraTonTaiFood(idHoaDon, idTA);
                                if (ktra > 0)
                                {
                                    int slnhap = 0;
                                    int slcu = 0;
                                    Int32.TryParse(txbSl.Text, out slnhap);
                                    DataTable table = ThongTinHoaDonDAO.Instance.ShowThongTinHoaDon(idBan);
                                    List<ThongTinHoaDon> tt = ThongTinHoaDonDAO.Instance.tthd(idHoaDon, idTA);
                                    foreach (ThongTinHoaDon hd in tt)
                                    {
                                        slcu = hd.Soluong;
                                    }
                                    slnhap += slcu;
                                    ThongTinHoaDonDAO.Instance.UpdateSoLuongFood(idHoaDon, idTA, slnhap);
                                    ShowHoaDon(idBan);
                                    BanDAO.Instance.UpdateTrangThaiTable("Có Người", idBan);
                                }
                                else
                                {
                                    int idhd = HoaDonDAO.Instance.GetIdBillFromIDTable(idBan);
                                    ThongTinHoaDonDAO.Instance.ThemThongTinHoaDon(idHoaDon, idTA, sl);
                                    ShowHoaDon(idBan);
                                    BanDAO.Instance.UpdateTrangThaiTable("Có Người", idBan);
                                }
                            }
                            else if (kq == 0)
                            {
                                HoaDonDAO.Instance.ThemHoaDon(idBan);
                                int idHoaDon = HoaDonDAO.Instance.GetIdBillFromIDTable(idBan);
                                ThongTinHoaDonDAO.Instance.ThemThongTinHoaDon(idHoaDon, idTA, sl);
                                HoaDonDAO.Instance.UpdateHoaDon(idBan, "Chưa thanh toán", 0);
                                ShowHoaDon(idBan);
                                BanDAO.Instance.UpdateTrangThaiTable("Có Người", idBan);
                            }
                            lswData.Items.Clear();
                            LoadBan();
                        }
                        else
                        {
                            MessageBox.Show("Bàn đã được đặt trước");
                        }
                        
                    }
                    
                    catch
                    {
                        MessageBox.Show("Chưa chọn bàn đặt món");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Số lượng món ăn không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int idBan = (int)lswData.SelectedItems[0].Tag;
                int idhd = HoaDonDAO.Instance.GetIdBillFromIDTable(idBan);
                HoaDonDAO.Instance.UpdateHoaDon(idBan, "Đã thanh toán", Tongtien);
                BanDAO.Instance.UpdateTrangThaiTable("Trống", idBan);
                ShowHoaDon(idBan);
                lswData.Items.Clear();
                LoadBan();
            }
            catch
            {
                MessageBox.Show("Chưa chọn bàn thanh toán");
            }
            
        }
    }
}

