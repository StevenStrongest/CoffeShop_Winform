using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DTO
{
    class HoaDon
    {
        private int idBan;
        private DateTime ngayNhan;
        private string trangthai;
        private int idHoaDon;

        public int IdBan { get => idBan; set => idBan = value; }
        public DateTime NgayNhan { get => ngayNhan; set => ngayNhan = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }

        public HoaDon(int id, DateTime ngay, string trangthai, int idhd)
        {
            this.IdBan = id;
            this.NgayNhan = ngay;
            this.Trangthai = trangthai;
            this.IdHoaDon = idhd;
        }

        public HoaDon(DataRow row)
        {

            this.IdBan = (int)row["idBan"];
            this.NgayNhan = (DateTime)row["ngayNhan"];
            this.Trangthai = row["trangthai"].ToString();
            this.IdHoaDon = (int)row["idHoaDon"];
        }
    }
}
