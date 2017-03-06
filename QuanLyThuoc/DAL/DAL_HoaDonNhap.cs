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
    public class DAL_HoaDonNhap:DBConnect
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HoaDonNhap", conn);
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

        public  bool Insert_HoaDonNhap(HoaDonNhap pHoaDonNhap)
        {
            try
            {
                string query = string.Format("INSERT INTO HoaDonNhap values('{0}', N'{1}', N'{2}', '', '{3}')", pHoaDonNhap.MaNCC, pHoaDonNhap.NguoiGiao, pHoaDonNhap.NguoiNhan, pHoaDonNhap.NgayNhap);
                return DBConnect.runCmd(query)>0;
            }
            catch
            {
                return false;
            }
        }
        public bool Update_HoaDonNhap(HoaDonNhap pHoaDonNhap)
        {
            try
            {
                string query = string.Format("UPDATE HoaDonNhap SET MaNCC='{0}', NguoiGiao=N'{1}', NguoiNhan=N'{2}', NgayNhap='{3}' where MaHDN='{4}'", pHoaDonNhap.MaNCC, pHoaDonNhap.NguoiGiao, pHoaDonNhap.NguoiNhan, pHoaDonNhap.NgayNhap, pHoaDonNhap.MaHDN);
                return DBConnect.runCmd(query) > 0;

            }
            catch
            {
                return false;
            }
        }
        public bool Delete_HoaDonNhap(string MaHDN)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM HoaDonNhap where MaHDN=" + MaHDN, conn);
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
        public DataTable Timkiem_tenncc(string timkiem)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Timkiem_nhacc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tennhacc", SqlDbType.NVarChar)).Value = timkiem;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
               
            }
            catch
            {
                return null;
            }
        }

        public DataTable Get_tenncc()
        {
            try
            {
                string query = string.Format("select * from NhaCungCap", conn);
                return DBConnect.getTable(query);
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get_tennccWithMa(string Mancc)
        {
            try
            {
                string query = string.Format("select * from NhaCungCap where MaNCC='"+Mancc+"'", conn);
                return DBConnect.getTable(query);
            }
            catch
            {
                return null;
            }
        }


    }
}
