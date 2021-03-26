using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DTO
{
    public class TaiKhoan
    {
        private string taikhoan;

        private string matkhau;

        private int loaitk;
        public TaiKhoan(string tk, string mk, int loaitk)
        {
            this.Taikhoan = tk;
            this.Matkhau = mk;
            this.Loaitk = loaitk;
        }

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Loaitk { get => loaitk; set => loaitk = value; }

        public TaiKhoan(DataRow row)
        {
            this.Taikhoan = row["tenTaiKhoan"].ToString();
            this.Matkhau = row["matkhau"].ToString();
            this.Loaitk = (int)row["loaiTK"];
        }
    }
}
