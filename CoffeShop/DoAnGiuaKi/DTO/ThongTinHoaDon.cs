using DoAnGiuaKi.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DTO
{
    public class ThongTinHoaDon
    {
        private int idThongTin;
        private int idHoaDon;
        private int idTA;
        private int soluong;

        public int IdThongTin { get => idThongTin; set => idThongTin = value; }
        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IdTA { get => idTA; set => idTA = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public ThongTinHoaDon(int tt, int hd, int ta, int sl)
        {
            this.IdHoaDon = tt;
            this.IdHoaDon = hd;
            this.IdTA = ta;
            this.Soluong = sl;
        }       

        public ThongTinHoaDon(DataRow row)
        {
            this.IdThongTin = (int)row["idThontin"];
            this.IdHoaDon = (int)row["idHoaDon"];
            this.IdTA = (int)row["idTA"];
            this.Soluong = (int)row["soluong"];
        }
    }
}
