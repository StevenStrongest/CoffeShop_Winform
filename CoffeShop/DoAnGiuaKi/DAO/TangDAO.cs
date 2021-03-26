using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DAO
{
    class TangDAO
    {
        private static TangDAO instance;

        public static TangDAO Instance
        {
            get { if (instance == null) instance = new TangDAO(); return instance; }
            private set => instance = value;
        }

        private TangDAO() { }

        public DataTable LoadDataTang()
        {
            string sql = "select * from Tang";
          DataTable table =  DataProvider.Instance.ExcutrQuery(sql);
            return table;
        }
    }
}
