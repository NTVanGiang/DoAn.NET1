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
    public class DAL_ChiTietHoaDonNhap:DBConnect
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietHoaDonNhap", conn);
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

        public bool Insert_ChiTietHoaDonNhap(ChiTietHoaDonNhap pChiTietHoaDonNhap)
        {
            try
            {
                string query = string.Format("INSERT INTO ChiTietHoaDonNhap values ('{0}','{1}','{2}','{3}')",pChiTietHoaDonNhap.MaHDN,pChiTietHoaDonNhap.MaThuoc,pChiTietHoaDonNhap.SoLuong,pChiTietHoaDonNhap.GiaNhap);

                return DBConnect.runCmd(query)>0;

            }
            catch
            {
                return false;
            }
        }
        public bool Update_ChiTietHoaDonNhap(ChiTietHoaDonNhap pChiTietHoaDonNhap)
        {
            try
            {
                string query = string.Format("UPDATE ChiTietHoaDonNhap SET MaThuoc='{0}',SoLuong='{1}', GiaNhap='{2}' where MaCTHDN='{3}'", pChiTietHoaDonNhap.MaThuoc, pChiTietHoaDonNhap.SoLuong, pChiTietHoaDonNhap.GiaNhap, pChiTietHoaDonNhap.MaCTHDN);
                return DBConnect.runCmd(query)>0;

            }
            catch
            {
                return false;
            }
        }
        public bool Delete_ChiTietHoaDonNhap(string MaCTHDN)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietHoaDonNhap where MaCTHDN=" + MaCTHDN , conn);
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
        public DataTable Timkiem_Tenthuoc(string timkiem)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Timkiem_tenthuoc1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tent", SqlDbType.NVarChar)).Value = timkiem;
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
        public DataTable Get_Tenthuoc()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Thuoc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch
            {
                return null;
            }
        }

        public DataTable Get_AllWithMaHDN(string MaHDN)
        {
            string query = string.Format("select * from ChiTietHoaDonNhap where MaHDN=" + MaHDN);
            return DBConnect.getTable(query);
        }

    }
}
