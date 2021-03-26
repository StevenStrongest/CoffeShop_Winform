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
    public partial class CRUDDatBAn : Form
    {
        public CRUDDatBAn()
        {
            InitializeComponent();
            LoadDataBanDat();
        }

        void LoadDataBanDat()
        {
            List<DatBan> db = DatBanDAO.Instance.DatBanList();
            foreach (DatBan data in db)
            {
                string trangthai = string.Empty;
                if (data.Trangthai == 0)
                {
                    trangthai = "Đã trả trước";
                }
                else
                {
                    trangthai = "Chưa thanh toán";
                }
                dataDatBan.Rows.Add(data.Id, data.Tenkhachhang, data.Sdt, data.TenBan, data.Ngaydat, trangthai, data.Ghichu);
            }

            cbxBan.DataSource = BanDAO.Instance.DanhSachBanAll();
            cbxBan.DisplayMember = "tenBan";
            cbxBan.ValueMember = "idBan";
            rdoFalse.Checked = true;
                
        }

        void LoadData()
        {
            
            DataTable table = DatBanDAO.Instance.ShowDatBan();
            int i = 0;
            string tt = string.Empty;

           
            foreach (DataRow row in table.Rows)
            {              
                if ((int)row["trangthai"] == 0)
                {
                    tt = "Đã trả trước";
                }
                else
                {
                    tt = "Chưa thanh toán";
                }
                dataDatBan.ColumnCount = 7;
                dataDatBan.Rows[i].Cells["iddat"].Value = row["idDat"].ToString();
                dataDatBan.Rows[i].Cells["tenKhachHang"].Value = row["tenKhachHang"].ToString();
                dataDatBan.Rows[i].Cells["sdt"].Value = row["sdt"].ToString();
                dataDatBan.Rows[i].Cells["Ban"].Value = row["tenBan"].ToString();
                dataDatBan.Rows[i].Cells["NgayDat"].Value = row["NgayDat"].ToString();
                dataDatBan.Rows[i].Cells["ghichu"].Value = row["Ghichu"].ToString();               
                dataDatBan.Rows[i].Cells["trangthai"].Value = tt;
                i++;
            }           
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
           
            string ten = txbTenKhachHang.Text;
            string sdt = txbSdt.Text;
            int vsdt = 0;
            int ban = (int)cbxBan.SelectedValue;
            int tt = 0;
            string ngay = dtpNgay.Value.ToString();
            string trangthai = string.Empty;
            int ktra = 0;
            ktra = DatBanDAO.Instance.KiemTraDatBan(ban);
            if (!Int32.TryParse(sdt, out vsdt))
            {
                MessageBox.Show("Điện thoại nhập phải là số");               
            }           
            else
            {
                if (ktra > 0 && ktra != 0)
                {
                    MessageBox.Show("Bàn đã có người đặt");
                }
                else
                {
                    if (DatBanDAO.Instance.KiemtraSdt(sdt) > 0)
                    {
                        MessageBox.Show("Đã tồn tại số điện thoại");
                    }
                    else
                    {
                        if (rdoTrue.Checked == true)
                        {
                            tt = 0;
                        }
                        else if (rdoFalse.Checked == true)
                        {
                            tt = 1;
                        }
                        string ghichu = txbGhichu.Text;
                        if (tt == 0)
                        {
                            trangthai = "Đã trả trước";
                        }
                        else
                        {
                            trangthai = "Chưa thanh toán";
                        }

                        DatBanDAO.Instance.ThemDatBan(ten, sdt, ban, ngay, tt, ghichu);
                        int Maxid = DatBanDAO.Instance.LayMaxId();
                        BanDAO.Instance.UpdateTrangThaiTable("Đã đặt trước", ban);
                        dataDatBan.Rows.Add(Maxid, ten, sdt, ban, ngay, trangthai, ghichu);
                    }                   
                }                            
                //LoadData();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(dataDatBan.SelectedRows.Count > 0)
            {
                int id = (int)dataDatBan.CurrentRow.Cells["iddat"].Value;
                int idBan = DatBanDAO.Instance.LayIdBan(id);
                DatBanDAO.Instance.HuyDat(id);
                dataDatBan.Rows.RemoveAt(dataDatBan.SelectedRows[0].Index);
                MessageBox.Show("Hủy thành công");
                BanDAO.Instance.UpdateTrangThaiTable("Trống", idBan);
            }
            
        }
    }
}
