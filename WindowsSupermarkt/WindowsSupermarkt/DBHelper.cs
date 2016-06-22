using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsSupermarkt.DBHelper
{
    class DBHelper
    {
        public static string connStr = "Data Source=(local);Initial Catalog=Supermarket;Integrated Security=True";
        private SqlConnection conn;
        public DBHelper()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connStr;
        }

        private void GetConnection()
        {
            if (conn.State == ConnectionState.Open)
            {

            }
            else
            {
                conn.Open();
            }

        }

        public int execute(string sqlStirng)
        {
            GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = sqlStirng;
            int i = cmd.ExecuteNonQuery();
            return i;
        }

        public SqlDataReader DataReader(string sqlStirng)
        {
            GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlStirng;
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataSet Datagridview(string s)
        {
            GetConnection();
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
