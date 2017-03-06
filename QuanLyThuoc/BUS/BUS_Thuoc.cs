using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Thuoc
    {
        DAL_Thuoc dal_thuoc = new DAL_Thuoc();
        public DataTable Get()
        {
            return dal_thuoc.Get();
        }
        public bool Insert_Thuoc(Thuoc pThuoc)
        {
            return dal_thuoc.Insert_Thuoc(pThuoc);
        }
        public bool Update_Thuoc(Thuoc pThuoc)
        {
            return dal_thuoc.Update_Thuoc(pThuoc);
        }
        public bool Delete_Thuoc(string MaThuoc)
        {
            return dal_thuoc.Delete_Thuoc(MaThuoc);
        }
        public DataTable Get_MaNhom()
        {
            return dal_thuoc.Get_MaNhom();
        }
        public DataTable Get_MaDVT()
        {
            return dal_thuoc.Get_MaDVT();
        }
        public DataTable Timkiem_Tenthuoc(string Timkiem)
        {
            return dal_thuoc.Timkiem_Tenthuoc(Timkiem);
        }
        public DataTable Timkiem_TenNhom(string Timkiem)
        {
            return dal_thuoc.Timkiem_TenNhom(Timkiem);
        }
        public void Load_ten(TextBox txt)
        {
             dal_thuoc.Load_ten(txt);
        }
        public void Load_tennhom(TextBox txt)
        {
            dal_thuoc.Load_tennhom(txt);
        }


    }
}
