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
    public class DAL_DonViTinh:DBConnect
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DonViTinh", conn);
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

        public bool Insert_DonViTinh(DonViTinh pDonViTinh)
        {
            try
            {               
                string query = string.Format("INSERT INTO DonViTinh values(N'{0}')", pDonViTinh.TenDVT);
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
        public bool Update_DonViTinh(DonViTinh pDonViTinh)
        {
            try
            {
                string query = string.Format("UPDATE DonViTinh SET TenDVT=N'{0}' where MaDVT={1}", pDonViTinh.TenDVT,pDonViTinh.MaDVT);
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
        public bool Delete_DonViTinh(string MaDVT)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM DonViTinh where MaDVT=" + MaDVT, conn);
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

    }
}
