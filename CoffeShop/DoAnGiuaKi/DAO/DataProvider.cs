using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKi.DAO
{
    public class DataProvider
    {
        private string stringQuery = @"Server=LAPTOP-R74QETB4\SQLEXPRESS;Database=QuanLyNhaHang;User Id=sa;Password=1234$;";

        private static DataProvider instance;

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value;
        }

        private DataProvider() { }

        public DataTable ExcutrQuery(string sql, object[] prameter = null)
        {
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(stringQuery);
            con.Open();
            SqlCommand cm = new SqlCommand(sql,con);
            if(prameter != null)
            {
                string[] listPara = sql.Split(' ');
                int i = 0;
                foreach(var item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        cm.Parameters.AddWithValue(item, prameter[i]);
                    }
                    i++;
                }
            }
            SqlDataAdapter data = new SqlDataAdapter(cm);
            data.Fill(table);
            con.Close();
            return table;
        }

        public int ExcuteNoneQuery(string sql, object[] prameter = null)
        {
            int data = 0;
            SqlConnection con = new SqlConnection(stringQuery);
            con.Open();
            SqlCommand cm = new SqlCommand(sql, con);
            if (prameter != null)
            {
                string[] listPara = sql.Split(' ');
                int i = 0;
                foreach (var item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        cm.Parameters.AddWithValue(item, prameter[i]);
                    }
                    i++;
                }
            }           
            data = cm.ExecuteNonQuery();
            con.Close();
            return data;
        }

        public object ExcuteScalar(string sql, object[] prameter = null)
        {
            object x = 0;
            SqlConnection con = new SqlConnection(stringQuery);
            con.Open();
            SqlCommand cm = new SqlCommand(sql, con);
            if (prameter != null)
            {
                string[] listPara = sql.Split(' ');
                int i = 0;
                foreach (var item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        cm.Parameters.AddWithValue(item, prameter[i]);
                    }
                    i++;
                }
            }            
            x = cm.ExecuteScalar();
            con.Close();
            return x;
        }

    }
}
