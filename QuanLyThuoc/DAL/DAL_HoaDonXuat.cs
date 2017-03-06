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
    public class DAL_HoaDonXuat:DBConnect
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HoaDonXuat", conn);
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
        public DAL_HoaDonXuat()
        {
            dt = Get();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        public bool Insert_HoaDonXuat(HoaDonXuat pHoaDonXuat)
        {
            try
            {
                string query = string.Format("INSERT INTO HoaDonXuat values('{0}','{1}','')", pHoaDonXuat.MaBN, pHoaDonXuat.NgayLap);
                return DBConnect.runCmd(query)>0;
            }
            catch
            {
                return false;
            }
        }
        public bool Update_HoaDonXuat(HoaDonXuat pHoaDonXuat)
        {
            try
            {
                string query = string.Format("UPDATE HoaDonXuat SET MaBN = {0} , NgayLap = '{1}' WHERE MaHDX = '{2}' ", pHoaDonXuat.MaBN, pHoaDonXuat.NgayLap, pHoaDonXuat.MaHDX);
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
        public bool Delete_HoaDonXuat(string MaHDX)
        {
            //try
            //{
                SqlCommand cmd = new SqlCommand("delete from HoaDonXuat where MaHDX = '" + MaHDX + "'", conn);
                cmd.Connection.Open();
                int i = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return i > 0;
            //}
            //catch
            //{
            //    return false;
            //}
        }
        public DataTable Timkiem_Tenbn(string timkiem)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("timkiem_tenbn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tenbenhnhan", SqlDbType.NVarChar)).Value = timkiem;
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
        

        public DataTable getMaBenhNhan()
        {
            return DBConnect.getTable("select * from BenhNhan");
        }

        public DataTable GetHDX_AllWithMaHD(string MaHDX)
        {
            string query = string.Format("SELECT * FROM HoaDonXuat where MaHDX='{0}'", MaHDX);
            return DBConnect.getTable(query);
        }
        public string get_Tenbenhnhan(string MaBN)
        {
            string query = string.Format("select TenBN from BenhNhan where MaBN ='{0}'", MaBN);
            return query;
        }
        //public HoaDonXuat getHoadonxuat(string MaHDX)
        //{
        //    string query = string.Format("select * from HoaDonXuat where MaBN ='{0}'", MaHDX);

        //}
    }
}
