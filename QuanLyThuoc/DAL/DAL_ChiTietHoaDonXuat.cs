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
    public class DAL_ChiTietHoaDonXuat : DBConnect
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietHoaDonXuat", conn);
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

        public bool Insert(ChiTietHoaDonXuat pChiTietHoaDonXuat)
        {
            //try
            //{
                string query = string.Format("INSERT INTO ChiTietHoaDonXuat values({0} , {1} ,{2})", pChiTietHoaDonXuat.MaHDX, pChiTietHoaDonXuat.MaThuoc, pChiTietHoaDonXuat.SoLuong);
                SqlCommand _cmd = new SqlCommand(query, conn);
                _cmd.Connection.Open();
                int i = _cmd.ExecuteNonQuery();
                _cmd.Connection.Close();
                return i > 0;
            //}
            //catch
            //{
            //    return false;

            //}
        }
        public bool Update(ChiTietHoaDonXuat pChiTietHoaDonXuat)
        {
            try
            {
                string query = string.Format("UPDATE ChiTietHoaDonXuat SET MaThuoc='{0}', SoLuong='{1}' where MaCTHDX={2}", pChiTietHoaDonXuat.MaThuoc, pChiTietHoaDonXuat.SoLuong, pChiTietHoaDonXuat.MaCTHDX);
                return DBConnect.runCmd(query)>0;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(string MaCTHDX)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietHoaDonXuat where MaCTHDX=" + MaCTHDX , conn);
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
                SqlCommand cmd = new SqlCommand("Timkiem_tenthuoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tenthuoc", SqlDbType.NVarChar)).Value = timkiem;
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
        public DataTable Get_Tenbn()
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
        public DataTable Get_TenbnWithMa(string Mabn)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from BenhNhan where MaBN='"+Mabn+"'", conn);
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
        public string Get_Giaban(string Mathuoc)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select GiaBan from Thuoc where MaThuoc=" + Mathuoc, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt == null ? "" : dt.Rows[0]["GiaBan"].ToString();
            }
            catch (Exception)
            {
                return "";
                throw;
            }
        }
        public string Get_Donvitinh(string Mathuoc)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select TenDVT from DonViTinh where MaDVT in (select MaDVT from Thuoc where MaThuoc = " + Mathuoc + " )", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return (dt == null ? "---" : dt.Rows[0]["TenDVT"].ToString());
            }
            catch (Exception)
            {
                return "";
                throw;
            }
        }

        public DataTable Get_AllWithMaHD(string MaHDX)
        {
            string query = string.Format(" SELECT * FROM ChiTietHoaDonXuat where MaHDX = '{0}' ", MaHDX);
            return DBConnect.getTable(query);
        }


    }
}
