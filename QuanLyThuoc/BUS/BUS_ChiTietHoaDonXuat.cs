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
    public class BUS_ChiTietHoaDonXuat
    {
        DAL_ChiTietHoaDonXuat dal_chitiethoadonxuat = new DAL_ChiTietHoaDonXuat();
        public DataTable Get()
        {
            return dal_chitiethoadonxuat.Get();
        }
        public bool Insert(ChiTietHoaDonXuat pChiTietHoaDonXuat)
        {
            return dal_chitiethoadonxuat.Insert(pChiTietHoaDonXuat);
        }
        public bool Update(ChiTietHoaDonXuat pChiTietHoaDonXuat)
        {
            return dal_chitiethoadonxuat.Update(pChiTietHoaDonXuat);
        }
        public bool Delete(string MaCTHDX)
        {
            return dal_chitiethoadonxuat.Delete(MaCTHDX);
        }
        public DataTable Timkiem_Tenthuoc(string timkiem)
        {
            return dal_chitiethoadonxuat.Timkiem_Tenthuoc(timkiem);
        }
        public DataTable Get_Tenbn()
        {
            return dal_chitiethoadonxuat.Get_Tenbn();
        }
        public DataTable Get_TenbnWithMa(string MaBN)
        {
            return dal_chitiethoadonxuat.Get_TenbnWithMa(MaBN);
        }
        public DataTable Get_Tenthuoc()
        {
            return dal_chitiethoadonxuat.Get_Tenthuoc();
        }
        public string Get_Giaban(string Mathuoc)
        {
            return dal_chitiethoadonxuat.Get_Giaban(Mathuoc);
        }
        public string Get_Donvitinh(string Mathuoc)
        {
            return dal_chitiethoadonxuat.Get_Donvitinh(Mathuoc);
        }
        public DataTable Get_AllWithMaHD(string MaHDX)
        {
            return dal_chitiethoadonxuat.Get_AllWithMaHD(MaHDX);
        }
        
    }
}
