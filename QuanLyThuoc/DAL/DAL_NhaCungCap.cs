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
    public class DAL_NhaCungCap:DBConnect
    {
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NhaCungCap", conn);
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

        //public DAL_NhaCungCap()
        //{
        //    dt = Get();
        //    dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        //}
        public bool Insert_NhaCungCap(NhaCungCap pNhaCungCap)
        {
            try
            {
                //SqlDataAdapter da = new SqlDataAdapter("select * from NhaCungCap", conn);
                //DataRow row = dt.NewRow();
                //row["MaNCC"] = 1000;
                //row["TenNCC"] = pNhaCungCap.TenNCC;
                //row["DiaChi"] = pNhaCungCap.DiaChi;
                //row["DienThoai"] = pNhaCungCap.DienThoai;
                //row["Email"] = pNhaCungCap.Email;

                //dt.Rows.Add(row);

                //SqlCommandBuilder cmdB = new SqlCommandBuilder(da);
                //da.Update(dt);
                //return true;
                string query = string.Format("INSERT INTO NhaCungCap values (N'{0}', N'{1}', N'{2}', N'{3}')", pNhaCungCap.TenNCC, pNhaCungCap.DiaChi, pNhaCungCap.DienThoai, pNhaCungCap.Email);
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
        public bool Update_NhaCungCap(NhaCungCap pNhaCungCap)
        {
            try
            {
                //SqlDataAdapter da = new SqlDataAdapter("select * from NhaCungCap", conn);
                //DataRow row = dt.Rows.Find(pNhaCungCap.MaNCC);
                //if(row!=null)
                //{
                //    row["TenNCC"] = pNhaCungCap.TenNCC;
                //    row["DiaChi"] = pNhaCungCap.DiaChi;
                //    row["DienThoai"] = pNhaCungCap.DienThoai;
                //    row["Email"] = pNhaCungCap.Email;
                //}                

                //SqlCommandBuilder cmdB = new SqlCommandBuilder(da);
                //da.Update(dt);
                //return true;
                string query = string.Format("UPDATE NhaCungCap SET TenNCC=N'{0}', DiaChi=N'{1}', DienThoai=N'{2}', Email=N'{3}' where MaNCC='{4}'", pNhaCungCap.TenNCC, pNhaCungCap.DiaChi, pNhaCungCap.DienThoai, pNhaCungCap.Email,pNhaCungCap.MaNCC);
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
        public bool Delete_NhaCungCap(string MaNCC)
        {
            try
            {
                //SqlDataAdapter da = new SqlDataAdapter("select * from NhaCungCap", conn);
                //DataRow row = dt.Rows.Find(MaNCC);
                //if (row != null)
                //{
                //    row.Delete();
                //}

                //SqlCommandBuilder cmdB = new SqlCommandBuilder(da);
                //da.Update(dt);
                //return true;
                SqlCommand cmd = new SqlCommand("DELETE FROM NhaCungCap where MaNCC=" + MaNCC, conn);
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
        public DataTable Timkiem_Tenncc(string timkiem)
        {
            try
            {
                string query = string.Format("select * from NhaCungCap where TenNCC like '%{0}%' ", timkiem);
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable tb = new DataTable();
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return null;
            }
        }

    }
}
