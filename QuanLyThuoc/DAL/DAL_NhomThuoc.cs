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
    public class DAL_NhomThuoc : DBConnect
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhomThuoc", conn);
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

        
        public bool Insert_NhomThuoc(NhomThuoc pNhomThuoc)
        {
            try
            {
                string query = string.Format("INSERT INTO NhomThuoc values(N'{0}')", pNhomThuoc.TenNhom);
                SqlCommand _cmd = new SqlCommand(query, conn);
                _cmd.Connection.Open();
                int i = _cmd.ExecuteNonQuery();
                _cmd.Connection.Close();
                return i > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool Update_NhomThuoc(NhomThuoc pNhomThuoc)
        {
            try
            {
                string query = string.Format("UPDATE NhomThuoc SET TenNhom = N'{0}' where MaNhom = {1} ", pNhomThuoc.TenNhom, pNhomThuoc.MaNhom);
                SqlCommand _cmd = new SqlCommand(query, conn);
                _cmd.Connection.Open();
                int i = _cmd.ExecuteNonQuery();
                _cmd.Connection.Close();
                return i > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete_NhomThuoc(string MaNhom)
        {
            try
            {
                SqlCommand _cmd = new SqlCommand("DELETE from NhomThuoc where MaNhom = " + MaNhom, conn);
                _cmd.Connection.Open();
                int i = _cmd.ExecuteNonQuery();
                _cmd.Connection.Close();
                return i > 0;
            }
            catch
            {
                return false;
            }
        }

    }
}
