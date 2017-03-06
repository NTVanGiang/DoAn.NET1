using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonXuat
    {
        private string _MaCTHDX;

        public string MaCTHDX
        {
            get { return _MaCTHDX; }
            set { _MaCTHDX = value; }
        }
        private string _MaHDX;

        public string MaHDX
        {
            get { return _MaHDX; }
            set { _MaHDX = value; }
        }
        private string _MaThuoc;

        public string MaThuoc
        {
            get { return _MaThuoc; }
            set { _MaThuoc = value; }
        }
        private string _SoLuong;

        public string SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        
        public ChiTietHoaDonXuat(string MaCTHDX,string MaHDX,string MaThuoc,string SoLuong)
        {
            this._MaCTHDX = MaCTHDX;
            this._MaHDX = MaHDX;
            this._MaThuoc = MaThuoc;
            this._SoLuong = SoLuong;
            
        }

    }
}
