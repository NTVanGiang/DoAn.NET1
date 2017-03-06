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
    public class DAL_BenhNhan:DBConnect
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from BenhNhan", conn);
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
        
        public bool Insert_BenhNhan(BenhNhan pBenhNhan)
        {
            try
            {
                string query = string.Format("INSERT INTO BenhNhan values (N'{0}','{1}',N'{2}',N'{3}')", pBenhNhan.HoTen, pBenhNhan.Tuoi, pBenhNhan.DiaChi, pBenhNhan.DienThoai);
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
        public bool Update_BenhNhan(BenhNhan pBenhNhan)
        {
            try
            {
                string query = string.Format("UPDATE BenhNhan SET HoTen=N'{0}', Tuoi='{1}', DiaChi='{2}', DienThoai='{3}' where MaBN='{4}'", pBenhNhan.HoTen, pBenhNhan.Tuoi, pBenhNhan.DiaChi, pBenhNhan.DienThoai,pBenhNhan.MaBN);
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
        public bool Delete_BenhNhan(string MaBN)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE from BenhNhan where MaBN=" + MaBN, conn);
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
