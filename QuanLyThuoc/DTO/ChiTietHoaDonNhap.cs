using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonNhap
    {
        private string _MaCTHDN;

        public string MaCTHDN
        {
            get { return _MaCTHDN; }
            set { _MaCTHDN = value; }
        }
        private string _MaHDN;

        public string MaHDN
        {
            get { return _MaHDN; }
            set { _MaHDN = value; }
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
        private string _GiaNhap;

        public string GiaNhap
        {
            get { return _GiaNhap; }
            set { _GiaNhap = value; }
        }
        public ChiTietHoaDonNhap(string MaCTHDN,string MaHDN,string MaThuoc,string SoLuong,string GiaNhap)
        {
            this._MaCTHDN = MaCTHDN;
            this._MaHDN = MaHDN;
            this._MaThuoc = MaThuoc;
            this._SoLuong = SoLuong;
            this._GiaNhap = GiaNhap;
        }
    }
}
