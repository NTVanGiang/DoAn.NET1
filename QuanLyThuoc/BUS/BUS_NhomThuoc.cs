using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_NhomThuoc
    {
        DAL_NhomThuoc dal_nhomthuoc = new DAL_NhomThuoc();
        public DataTable Get()
        {
            return dal_nhomthuoc.Get();
        }
        public bool Insert_NhomThuoc(NhomThuoc pNhomThuoc)
        {
            return dal_nhomthuoc.Insert_NhomThuoc(pNhomThuoc);
        }
        public bool Update_NhomThuoc(NhomThuoc pNhomThuoc)
        {
            return dal_nhomthuoc.Update_NhomThuoc(pNhomThuoc);
        }
        public bool Delete_NhomThuoc(string MaNhom)
        {
            return dal_nhomthuoc.Delete_NhomThuoc(MaNhom);
        }

    }
}
