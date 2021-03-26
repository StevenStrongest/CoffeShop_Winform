using DoAnGiuaKi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DAO
{
    class TaikhoanDAO
    {
        private static TaikhoanDAO instance;

        internal static TaikhoanDAO Instance 
        {
            get { if (instance == null) instance = new TaikhoanDAO(); return TaikhoanDAO.instance; }
            private set => instance = value; 
        }

        private TaikhoanDAO() { }

        public bool Dangnhap(string taikhoan,string matkhau)
        {
            string sql = "select * from TaiKhoan where tenTaiKhoan = '" + taikhoan + "' and matkhau = '" + matkhau + "'";
            var rs =  DataProvider.Instance.ExcutrQuery(sql);
            return rs.Rows.Count > 0;
        }

        public TaiKhoan TaiKhoanDangNhap(string taikhoan)
        {
            string sql = "select * from TaiKhoan where tenTaiKhoan = '" + taikhoan + "'";
            DataTable table = DataProvider.Instance.ExcutrQuery(sql);
            foreach(DataRow row in table.Rows)
            {
                return new TaiKhoan(row);
            }
            return null;
        }

        public void CapNhatTaiKhoan(string taikhoan, string matkhau)
        {
            string sql = "update TaiKhoan set matkhau = '"+matkhau+ "' where tenTaiKhoan = '"+taikhoan+"'";
            DataProvider.Instance.ExcuteNoneQuery(sql);           
        }

        public DataTable DanhsachTaiKhoan()
        {
            string sql = "select * from TaiKhoan";
            DataTable table = DataProvider.Instance.ExcutrQuery(sql);
            return table;
        }

        public int ThemTaiKhoan(string tk,string mk,int loai)
        {
            int rs = 0;
            string sql = "insert into TaiKhoan(tenTaiKhoan,matkhau,loaiTK) values('"+tk+"','"+mk+"', "+loai+")";
            rs = DataProvider.Instance.ExcuteNoneQuery(sql);
            return rs;
        }

        public DataTable SearchTaiKhoan(string val)
        {
            return DataProvider.Instance.ExcutrQuery("select * from TaiKhoan where tenTaiKhoan like N'%"+val+"%' ");
        }

        public void XoaTaiKhoan(string tk)
        {
            DataProvider.Instance.ExcuteNoneQuery("Delete from TaiKhoan where tenTaiKhoan = '"+tk+"'");
        }
    }
}
