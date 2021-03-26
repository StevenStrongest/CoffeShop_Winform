using DoAnGiuaKi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DAO
{
    public class BanDAO
    {
        private static BanDAO instance;

        public static BanDAO Instance 
        { 
            get { if (instance == null) instance = new BanDAO(); return instance; }
            private set => instance = value; 
        }

        private BanDAO() { }

        public DataTable DanhSachBan(int id)
        {
            DataTable table = DataProvider.Instance.ExcutrQuery("select * from Ban where idTang = " + id);
            return table;
        }

        public string KiemTraTrangThaiBan(int idBan)
        {
            DataTable data = DataProvider.Instance.ExcutrQuery("select * from ban where idBan = " + idBan);
            Ban table = new Ban(data.Rows[0]);
            return table.Trangthai;

        }

        public DataTable DanhSachBanAll()
        {
            DataTable table = DataProvider.Instance.ExcutrQuery("select * from Ban where trangthai = N'Trống'");
            return table;
        }

        public List<Ban> LoadBAnList()
        {
            List<Ban> Banlist = new List<Ban>();
            DataTable data = DataProvider.Instance.ExcutrQuery("select * from Ban where idTang = " + MainForm.idtang);
            foreach(DataRow item in data.Rows)
            {
                Ban table = new Ban(item);
                Banlist.Add(table);
            }
            return Banlist;
        }

        public DataTable SearchBan(string text)
        {
            string query = "select * from Ban where tenBan like '%" + text + "%'";
            DataTable table = DataProvider.Instance.ExcutrQuery(query);
            return table;

        }

        public void UpdateTrangThaiTable(string tt, int id)
        {
            DataProvider.Instance.ExcuteNoneQuery("update Ban set trangthai = N'"+tt+"' where idBan = " + id);
        }

        public void ThemBan(string ten, int idTang)
        {
            string sql = "insert into Ban(tenBan, trangthai, idTang) values('" + ten + "', N'Trống', "+idTang+")";
            DataProvider.Instance.ExcuteNoneQuery(sql);
        }

        public void XoaBan(int id)
        {
            DataProvider.Instance.ExcuteNoneQuery("delete from Ban where idBan = "+ id);
        }

    }
}
