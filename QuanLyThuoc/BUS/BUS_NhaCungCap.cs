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
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dal_nhacungcap = new DAL_NhaCungCap();
        public DataTable Get()
        {
            return dal_nhacungcap.Get();
        }
        public bool Insert_NhaCungCap(NhaCungCap pNhaCungCap)
        {
            return dal_nhacungcap.Insert_NhaCungCap(pNhaCungCap);
        }
        public bool Update_NhaCungCap(NhaCungCap pNhaCungCap)
        {
            return dal_nhacungcap.Update_NhaCungCap(pNhaCungCap);
        }
        public bool Delete_NhaCungCap(string MaNCC)
        {
            return dal_nhacungcap.Delete_NhaCungCap(MaNCC);
        }
        public DataTable Timkiem_Tenncc(string timkiem)
        {
            return dal_nhacungcap.Timkiem_Tenncc(timkiem);
        }
    }
}
