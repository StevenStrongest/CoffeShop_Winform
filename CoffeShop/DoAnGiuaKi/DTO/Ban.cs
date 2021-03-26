using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnGiuaKi.DTO
{
    public class Ban
    {
        private int id;
        public int Id { get => id; set => id = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int Tang { get => tang; set => tang = value; }

        private string tenBan;

        private string trangthai;

        private int tang;

        public Ban(int id, string ten, string tt, int tang)
        {
            this.Id = id;
            this.TenBan = ten;
            this.Trangthai = tt;
            this.Tang = tang;
        }

        public Ban(DataRow row)
        {
            this.Id = (int)row["idBan"];
            this.TenBan = row["tenBan"].ToString();
            this.Trangthai = row["trangthai"].ToString();
            this.Tang = (int)row["idTang"];
        }
    }
}
