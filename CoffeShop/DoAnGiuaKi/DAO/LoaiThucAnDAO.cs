using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DAO
{
    class LoaiThucAnDAO
    {
        private static LoaiThucAnDAO instance;

        public static LoaiThucAnDAO Instance
        {
            get { if (instance == null) instance = new LoaiThucAnDAO(); return instance; }
            private set => instance = value;
        }

        private LoaiThucAnDAO() { }

        public DataTable ShowLoaiThucAn()
        {
            string sql = "select * from LoaiThucAn";
            DataTable table =  DataProvider.Instance.ExcutrQuery(sql);
            return table;
        }

    }
}
