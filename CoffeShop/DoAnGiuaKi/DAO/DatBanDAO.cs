using DoAnGiuaKi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DAO
{
    class DatBanDAO
    {
        private static DatBanDAO instance;

        public static DatBanDAO Instance
        {
            get { if (instance == null) instance = new DatBanDAO(); return instance; }
            private set => instance = value;
        }

        private DatBanDAO() { }

        public DataTable ShowDatBan()
        {
            string sql = "select idDat,tenKhachHang,sdt,NgayDat,DatBan.trangthai,Ghichu,tenBan from DatBan inner join Ban on DatBan.idBan = Ban.idBan";
            DataTable table = DataProvider.Instance.ExcutrQuery(sql);
            return table;
        }

        public void ThemDatBan(string ten, string sdt, int idBan, string day, int tt, string ghichu)
        {
            string sql = "insert into DatBan(tenKhachHang, sdt, idBan, NgayDat, trangthai, Ghichu) values(N'"+ten+"', '"+sdt+"', "+idBan+", '"+day+"', "+tt+", N'"+ghichu+"')";
            DataProvider.Instance.ExcuteNoneQuery(sql);
        }

        public int KiemTraDatBan(int id)
        {
            string sql = "select count(*) from DatBan where idBan = " + id;
            int rs = (int)DataProvider.Instance.ExcuteScalar(sql);
            return rs;
        }

        public int KiemtraSdt(string sdt)
        {
            int i = 0;
            string sql = "select * from DatBan where sdt = '"+sdt+"'";
            DataTable tb = DataProvider.Instance.ExcutrQuery(sql);
            foreach(DataRow r in tb.Rows)
            {
                i++;
            }
            return i;

        }

        public int LayIdBan(int id)
        {
            DataTable table = DataProvider.Instance.ExcutrQuery("select * from DatBan where idDat =" + id);
            int i = 0;
            i = table.Rows[0].Field<int>("idBan");
            return i;
        }

        public void HuyDat(int id)
        {
            DataProvider.Instance.ExcuteNoneQuery("delete from DatBan where idDat = " + id);
        }

        public List<DatBan> DatBanList()
        {
            string sql = "select * from DatBan inner join Ban on DatBan.idBan = Ban.idBan";
            List<DatBan> db = new List<DatBan>();
            DataTable table = DataProvider.Instance.ExcutrQuery(sql);
            foreach(DataRow row in table.Rows)
            {
                DatBan data = new DatBan(row);
                db.Add(data);
            }

            return db;
        }

        public int LayMaxId()
        {
            int id = 0;
            id = (int)DataProvider.Instance.ExcuteScalar("select Max(idDat) from DatBan");
            return id;
        }
    }
}
