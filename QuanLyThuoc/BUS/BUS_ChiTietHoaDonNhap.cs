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
    public class BUS_ChiTietHoaDonNhap
    {
        DAL_ChiTietHoaDonNhap dal_chitiethoadonnhap = new DAL_ChiTietHoaDonNhap();
        public DataTable Get()
        {
            return dal_chitiethoadonnhap.Get();
        }
        public bool Insert_ChiTietHoaDonNhap(ChiTietHoaDonNhap pChiTietHoaDonNhap)
        {
            return dal_chitiethoadonnhap.Insert_ChiTietHoaDonNhap(pChiTietHoaDonNhap);
        }
        public bool Update_ChiTietHoaDonNhap(ChiTietHoaDonNhap pChiTietHoaDonNhap)
        {
            return dal_chitiethoadonnhap.Update_ChiTietHoaDonNhap(pChiTietHoaDonNhap);
        }
        public bool Delete_ChiTietHoaDonNhap(string MaCTHDN)
        {
            return dal_chitiethoadonnhap.Delete_ChiTietHoaDonNhap(MaCTHDN);
        }
        public DataTable Timkiem_Tenthuoc(string timkiem)
        {
            return dal_chitiethoadonnhap.Timkiem_Tenthuoc(timkiem);
        }
        public DataTable Get_Tenthuoc()
        {
            return dal_chitiethoadonnhap.Get_Tenthuoc();
        }
        public DataTable Get_AllWithMaHDN(string MaHDN)
        {
            return dal_chitiethoadonnhap.Get_AllWithMaHDN(MaHDN);
        }


    }
}
