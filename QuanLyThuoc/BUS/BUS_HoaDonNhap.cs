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
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap dal_hoadonnhap = new DAL_HoaDonNhap();
        public DataTable Get()
        {
            return dal_hoadonnhap.Get();
        }
        public bool Insert_HoaDonNhap(HoaDonNhap pHoaDonNhap)
        {
            return dal_hoadonnhap.Insert_HoaDonNhap(pHoaDonNhap);
        }
        public bool Update_HoaDonNhap(HoaDonNhap pHoaDonNhap)
        {
            return dal_hoadonnhap.Update_HoaDonNhap(pHoaDonNhap);
        }
        public bool Delete_HoaDonNhap(string MaHDN)
        {
            return dal_hoadonnhap.Delete_HoaDonNhap(MaHDN);
        }
        public DataTable Timkiem_tenncc(string timkiem)
        {
            return dal_hoadonnhap.Timkiem_tenncc(timkiem);
        }
        public DataTable Get_tenncc()
        {
            return dal_hoadonnhap.Get_tenncc();
        }
        public DataTable Get_tennccWithMa(string Mancc)
        {
            return dal_hoadonnhap.Get_tennccWithMa(Mancc);
        }

    }
}
