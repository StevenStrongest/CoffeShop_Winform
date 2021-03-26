using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DAO
{
    class ThucAnDAO
    {
        private static ThucAnDAO instance;

        internal static ThucAnDAO Instance { get { if (instance == null) instance = new ThucAnDAO(); return instance; } private set => instance = value; }

        public DataTable ShowThucAnTuHoaDon(int idTa)
        {
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExcutrQuery("select * from ThucAn where idTA = " +idTa);
            return table;
        }

        public void UpdateFood(string ten, int gia, int idLoai, int id)
        {
            string sql = "update ThucAn set tenTA = N'" + ten + "',gia = " + gia + ",idLoaiTA = " + idLoai + "where idTA = " + id;
            DataProvider.Instance.ExcuteNoneQuery(sql);
        }

        public DataTable ShowThucAnTuLoaiThucAn(int id)
        {
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExcutrQuery("select * from ThucAn where idLoaiTA = " + id);
            return table;
        }

        public DataTable ShowLoaiThucAn()
        { 
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExcutrQuery("select * from LoaiThucAn");
            return table;
        }

        public DataTable ShowThucAn()
        {
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExcutrQuery("select ta.idTA,ta.tenTA,ta.gia,l.tenLoai from ThucAn as ta,LoaiThucAn as l where ta.idLoaiTA = l.idLoaiTA");
            return table;
        }

        public DataTable LayidThucAn()
        {
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExcutrQuery("select ta.idTA,ta.tenTA,ta.gia,tt.soluong from HoaDon as hd, thongtinHoaDon as tt, ThucAn as ta where tt.idHoaDon = hd.idHoaDon and tt.idTA = ta.idTA and hd.trangthai = N'Chưa thanh toán'");
            return table;
        }

        public DataTable ShowThucAnTuId(int id)
        {
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExcutrQuery("select ta.idTA,ta.tenTA,ta.gia,l.tenLoai from ThucAn as ta,LoaiThucAn as l where ta.idLoaiTA = l.idLoaiTA and ta.idTA = " + id);
            return table;
        }

        public DataTable SearchFood(string val)
        {
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExcutrQuery("select ta.idTA,ta.tenTA,ta.gia,l.tenLoai from ThucAn as ta,LoaiThucAn as l where tenTA like N'%" + val+ "%' and ta.idLoaiTA = l.idLoaiTA");
            return table;
        }

        public void ThemMonAn(string ten, int gia, int id)
        {
            string sql = "insert into ThucAn(tenTA, gia, idLoaiTA) values(N'"+ten+"', "+gia+", "+id+")";
            DataProvider.Instance.ExcuteNoneQuery(sql);
        }

        public void XoaMonAn(int id)
        {
            string sql = "delete from ThucAn where idTA = " + id;
            DataProvider.Instance.ExcuteNoneQuery(sql);
        }
    }
}
