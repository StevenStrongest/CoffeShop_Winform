using DoAnGiuaKi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DAO
{
    public class ThongTinHoaDonDAO
    {
        private static ThongTinHoaDonDAO instance;
       
        internal static ThongTinHoaDonDAO Instance { get { if (instance == null) instance = new ThongTinHoaDonDAO(); return instance; } private set => instance = value; }
       
        public DataTable ShowThongTinHoaDon(int id)
        {
            DataTable data = DataProvider.Instance.ExcutrQuery("select ta.tenTA,ta.gia,tt.soluong from HoaDon as hd, thongtinHoaDon as tt, ThucAn as ta where tt.idHoaDon = hd.idHoaDon and tt.idTA = ta.idTA and hd.idBan = " + id + "and hd.trangthai = N'Chưa thanh toán'");
            return data;
        }       

        public void ThemThongTinHoaDon(int idHD, int idTA, int sl)
        {
            string query = "insert into thongtinHoaDon(idHoaDon, idTA, soluong) values("+idHD+", "+idTA+", "+sl+")";
            DataProvider.Instance.ExcuteScalar(query);
        }

        public void CapNhatThongTinHoaDon(int idHD, int idTA, int sl)
        {
            string query = "update thongtinHoaDon set idTA = " + idTA + ",soluong = " + sl + " where idHoaDon = " + idHD;
            DataProvider.Instance.ExcuteNoneQuery(query);
        }

        public List<ThongTinHoaDon> tthd(int id, int idTA)
        {
            List<ThongTinHoaDon> tt = new List<ThongTinHoaDon>();
            DataTable table = DataProvider.Instance.ExcutrQuery("select * from thongtinHoaDon where idHoaDon = " + id + "and idTA = " + idTA);
            foreach (DataRow row in table.Rows)
            {
                ThongTinHoaDon cthd = new ThongTinHoaDon(row);
                tt.Add(cthd);
            }

            return tt;
        }

        public DataTable LaySlThucAn()
        {
            DataTable table = DataProvider.Instance.ExcutrQuery("select DISTINCT ThucAn.idTA from thongtinHoaDon,ThucAn where thongtinHoaDon.idTA  = ThucAn.idTA");
            return table;
        }

        public List<ThongTinHoaDon> Loadtthd()
        {
            List<ThongTinHoaDon> tt = new List<ThongTinHoaDon>();
            DataTable table = DataProvider.Instance.ExcutrQuery("select * from thongtinHoaDon");
            foreach (DataRow row in table.Rows)
            {
                ThongTinHoaDon cthd = new ThongTinHoaDon(row);
                tt.Add(cthd);
            }

            return tt;
        }

        public DataTable LayThongTinTheoIDTA(int id)
        {
            
            DataTable table = DataProvider.Instance.ExcutrQuery("select thongtinHoaDon.soluong,ThucAn.tenTA from thongtinHoaDon,ThucAn where thongtinHoaDon.idTA = ThucAn.idTA and thongtinHoaDon.idTA = " + id);
            return table;
        }

        public void ThanhToan(int idhd)
        {
            string query = "delete from thongtinHoaDon where idHoaDon = " + idhd;
            DataProvider.Instance.ExcuteNoneQuery(query);
        }

        public void UpdateSoLuongFood(int idHD, int idTA, int sl)
        {
            DataProvider.Instance.ExcuteNoneQuery("update thongtinHoaDon set soluong =" + sl + " where idTA = " + idTA + " and idHoaDon = " + idHD);
        }

        public int KiemTraTonTaiFood(int idHD, int idTA)
        {
            int kq = 0;
            string query = "select count(*) from thongtinHoaDon where idHoaDon =" + idHD + "and idTA =" + idTA;
            kq = (int)DataProvider.Instance.ExcuteScalar(query);
            return kq;

        }

        public int KiemtraTonTaiThongTinHoaDon(int idHD)
        {
            int kq = 0;
            string query = "select count(*) from thongtinHoaDon where idHoaDon =" + idHD;
            kq = (int)DataProvider.Instance.ExcuteScalar(query);
            return kq;
        }
    }
}
