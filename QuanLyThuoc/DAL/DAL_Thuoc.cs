using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Thuoc:DBConnect
    {
        public DataTable Get()
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
       DataTable dt = new DataTable();
        
        public bool Insert_Thuoc(Thuoc pThuoc)
        {
            try
           {
                

                string query = string.Format("INSERT INTO Thuoc values (N'{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}','{7}','{8}')", pThuoc.TenThuoc, pThuoc.MaNhom, pThuoc.SoLuong, pThuoc.GiaBan, pThuoc.MaDVT, pThuoc.CongDung, pThuoc.PhanTacDung, pThuoc.NgaySanXuat, pThuoc.HanSuDung);
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
        public bool Update_Thuoc(Thuoc pThuoc)
        {
            try
            {
                
                string query = string.Format("UPDATE Thuoc SET TenThuoc=N'{0}', MaNhom='{1}', SoLuong='{2}', GiaBan='{3}', MaDVT='{4}', CongDung=N'{5}', PhanTacDung=N'{6}', NgaySanXuat='{7}',HanSuDung='{8}' where MaThuoc='{9}'", pThuoc.TenThuoc, pThuoc.MaNhom, pThuoc.SoLuong, pThuoc.GiaBan, pThuoc.MaDVT, pThuoc.CongDung, pThuoc.PhanTacDung, pThuoc.NgaySanXuat, pThuoc.HanSuDung,pThuoc.MaThuoc);
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
        public bool Delete_Thuoc(string MaThuoc)
        {
            try
            {
               

                SqlCommand cmd = new SqlCommand("DELETE FROM Thuoc where MaThuoc=" + MaThuoc, conn);
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
        public DataTable Get_MaNhom()
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
        public DataTable Get_MaDVT()
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
        public DataTable Timkiem_Tenthuoc(string Timkiem)
        {
            try
            {
                string query = "select * from Thuoc where TenThuoc = '"+Timkiem+"' ";
                SqlCommand cm = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }

        }
        public DataTable Timkiem_TenNhom(string Timkiem)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Timkiem_TenNhom", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tennhom", SqlDbType.NVarChar)).Value = Timkiem;
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
        public void Load_ten(TextBox txt)
        {
            DBConnect a = new DBConnect();
            a.LoadDataToCollection(txt, "TenThuoc", "Thuoc");
        }
        public void Load_tennhom(TextBox txt)
        {
            DBConnect a = new DBConnect();
            a.LoadDataToCollection(txt, "TenNhom", "NhomThuoc");
        }



    }
}
