using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DBConnect
    {
        //private String sqlcon = "Data Source=(local);Initial Catalog=dbThuoc;Integrated Security=True";
        protected static SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=dbThuoc;Integrated Security=True");

        public DBConnect()
        {
            if (conn == null) conn = new SqlConnection();
        }
        public SqlConnection openConnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }
        public bool closeConnection()
        {
            if (conn.State != ConnectionState.Closed) conn.Close();
            return true;
        }

        public static DataTable getTable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int runCmd(string query)
        {
            try
            {
                SqlCommand _cmd = new SqlCommand(query, conn);
                _cmd.Connection.Open();
                int i = _cmd.ExecuteNonQuery();
                _cmd.Connection.Close();
                return i;
            }
            catch (Exception ex)
            {
                return 0;
                throw;
            }
        }
        public void LoadDataToCollection(TextBox txttextbox, string field, string TableName)
        {

            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            string sql = "Select  " + field + " from " + TableName + " ";
            SqlCommand com = new SqlCommand();

            com.Connection = conn;
            com.CommandText = sql;
            com.CommandType = CommandType.Text;

            SqlDataReader reader;
            reader = com.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    auto2.Add(reader[field].ToString());
                }
                txttextbox.AutoCompleteCustomSource = auto2;
            }
            conn.Close();
        }
    }
}
