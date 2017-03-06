using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_User:DBConnect
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Users", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                return null;
            }
        }

        DataTable dt = new DataTable();

        //public DAL_User()
        //{
        //    dt = Get();

        //    dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };

        //}
        public bool Insert_User(Users pUser)
        {
            try
            {
                
                string query = string.Format("INSERT INTO Users values (N'{0}','{1}',N'{2}',N'{3}')", pUser.UserName, pUser.PassWord, pUser.HoTen, pUser.DiaChi);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                int i = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return i > 0;

            }
            catch
            {
                return false;
            }
        }
        public bool Update_User(Users pUser)
        {
            try
            {
                
                string query = string.Format("UPDATE Users SET UserName=N'{0}', PassWord='{1}', HoTen=N'{2}', DiaChi=N'{3}' where UserId={4}", pUser.UserName, pUser.PassWord, pUser.HoTen, pUser.DiaChi, pUser.IdUser);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                int i = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return i > 0;

            }
            catch
            {
                return false;
            }
        }
        public bool Delete_User(string IdUser)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("DELETE FROM Users where UserId=" + IdUser, conn);
                cmd.Connection.Open();
                int i = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return i > 0;

            }
            catch
            {
                return false;
            }
        }
        public bool CheckLogin(string user, string pass)
        {
            string query = string.Format("select * from Users where UserName ='{0}' and PassWord='{1}'", user, pass);
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataTable tb = new DataTable();
            dt.Fill(tb);
            if (tb.Rows.Count > 0) return true;
            else return false;
        }


        }
    }
