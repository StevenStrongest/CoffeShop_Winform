using DoAnGiuaKi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        internal static HoaDonDAO Instance { get { if (instance == null) instance = new HoaDonDAO(); return instance; } private set => instance = value; }

        private HoaDonDAO() { }

        public int GetIdHoaDon(int idBan)
        {
            int idHd = 0;
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExcutrQuery("select * from HoaDon where idBan = " + idBan + "and trangthai = N'Chưa thanh toán'");
            foreach(DataRow row in table.Rows)
            {
                idHd = (int)row["idHoaDon"];
            }
            return idHd;
        }

        public int KiemTraTrangThaiBan(int id)
        {
            string query = "select count(*) from HoaDon  where idBan = " + id;
            int kq = (int)DataProvider.Instance.ExcuteScalar(query);
            return kq;
        }

        public int KiemTraHoaDon(int id)
        {
            string query = "select count(*) from HoaDon  where idBan = " + id;
            int kq = (int)DataProvider.Instance.ExcuteScalar(query);
            if(kq > 0)
            {
                kq = (int)DataProvider.Instance.ExcuteScalar("select count(*) from HoaDon where trangthai = N'Chưa thanh toán' and idBan = " + id);
                if(kq > 0)
                {
                    kq = 1;
                }
                else
                {
                    kq = 2;
                }
            }
            else if(kq != 0)
            {
                kq = (int)DataProvider.Instance.ExcuteScalar("select count(*) from HoaDon where trangthai = N'Đã thanh toán' and idBan = " + id);
                if(kq > 0)
                    kq = 2;
                else
                kq = 3;
            }
            return kq;
        }

        public int GetIdBillFromIDTable(int idTable)
        {
            DataTable table = DataProvider.Instance.ExcutrQuery("select * from HoaDon where idBan = " + idTable + " and trangthai = N'Chưa thanh toán'");
            int id = -1;
            if (table.Rows.Count > 0)
            {
                HoaDon hd = new HoaDon(table.Rows[0]);
                id = hd.IdHoaDon;
            }

            return id;
        }

        public void UpdateHoaDon(int idBan, string trangthai, int tongtien)
        {
            string query = "update HoaDon set ngaynhan = GETDATE(), trangthai = N'"+trangthai+"', tongtien = "+tongtien+" where idBan = " + idBan;
            DataProvider.Instance.ExcuteNoneQuery(query);
        }

        public void ThemHoaDon(int id)
        {
            string query = "insert into HoaDon(idBan,ngaynhan,trangthai) values(" + id + ",GETDATE(), N'Chưa thanh toán')";
            DataProvider.Instance.ExcuteNoneQuery(query);
        }

        public DataTable ThongKeHoaDon(string ngay1, string ngay2)
        {
            string sql = "select hd.idHoaDon, hd.ngayNhan, hd.trangthai, hd.tongtien, b.tenBan from HoaDon as hd, Ban as b where ngayNhan >= '"+ngay1+"' and ngayNhan <= '"+ngay2+"' and hd.trangthai = N'Đã thanh toán' and hd.idBan = b.idBan";
            DataTable table =  DataProvider.Instance.ExcutrQuery(sql);
            return table;
        }

        public int GetMaxIDHoaDon()
        {
            int maxid = (int)DataProvider.Instance.ExcuteScalar("select MAX(idHoaDon) from HoaDon");
            return maxid;
        }
    }
}
