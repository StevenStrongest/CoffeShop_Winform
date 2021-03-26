using DoAnGiuaKi.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DTO
{
    class DatBan
    {
        private int id;

        private string tenkhachhang;

        private string sdt;

        private int idban;

        private DateTime ngaydat;

        private int trangthai;

        private string ghichu;

        string tenBan;

        public int Id { get => id; set => id = value; }
        public string Tenkhachhang { get => tenkhachhang; set => tenkhachhang = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Idban { get => idban; set => idban = value; }
        public DateTime Ngaydat { get => ngaydat; set => ngaydat = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }

        public DatBan(int id, string ten, string sdt, int idBan, DateTime ngay, int trangthai, string ghichu, string tenBan)
        {
            this.Id = id;
            this.Tenkhachhang = ten;
            this.Sdt = sdt;
            this.Idban = idban;
            this.Ngaydat = ngay;
            this.Trangthai = trangthai;
            this.Ghichu = ghichu;
            this.TenBan = tenBan;
        }     

        public DatBan(DataRow row)
        {
            this.Id = (int)row["idDat"];
            this.Tenkhachhang = row["tenKhachHang"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Idban = (int)row["idBan"];
            this.Ngaydat = (DateTime)row["NgayDat"];
            this.Trangthai = (int)row["trangthai"];
            this.Ghichu = (string)row["Ghichu"];
            this.TenBan = row["tenBan"].ToString();
        }
    }
}
