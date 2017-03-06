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
    public class BUS_HoaDonXuat
    {
        DAL_HoaDonXuat dal_hoadonxuat = new DAL_HoaDonXuat();
        public DataTable Get()
        {
            return dal_hoadonxuat.Get();
        }
        public bool Insert_HoaDonXuat(HoaDonXuat pHoaDonXuat)
        {
            return dal_hoadonxuat.Insert_HoaDonXuat(pHoaDonXuat);
        }
        public bool Update_HoaDonXuat(HoaDonXuat pHoaDonXuat)
        {
            return dal_hoadonxuat.Update_HoaDonXuat(pHoaDonXuat);
        }
        public bool Delete_HoaDonXuat(string MaHDX)
        {
            return dal_hoadonxuat.Delete_HoaDonXuat(MaHDX);
        }
        public DataTable Timkiem_Tenbn(string timkiem)
        {
            return dal_hoadonxuat.Timkiem_Tenbn(timkiem);
        }
        
        public DataTable getMaBN()
        {
            return dal_hoadonxuat.getMaBenhNhan();
        }
        public DataTable GetHDX_AllWithMaHD(string MaHDX)
        {
            return dal_hoadonxuat.GetHDX_AllWithMaHD(MaHDX);
        }
        public string get_Tenbenhnhan(string MaBN)
        {
            return dal_hoadonxuat.get_Tenbenhnhan(MaBN);
        }
    }
}
