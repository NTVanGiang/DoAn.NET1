using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonNhap
    {
        private string _MaHDN;

        public string MaHDN
        {
            get { return _MaHDN; }
            set { _MaHDN = value; }
        }
        private string _MaCC;

        public string MaNCC
        {
            get { return _MaCC; }
            set { _MaCC = value; }
        }
        private string _NguoiGiao;

        public string NguoiGiao
        {
            get { return _NguoiGiao; }
            set { _NguoiGiao = value; }
        }
        private string _NguoiNhan;

        public string NguoiNhan
        {
            get { return _NguoiNhan; }
            set { _NguoiNhan = value; }
        }
        private string _TongTienThuoc;

        public string TongTienThuoc
        {
            get { return _TongTienThuoc; }
            set { _TongTienThuoc = value; }
        }
        
        private string _NgayNhap;

        public string NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }
        public HoaDonNhap(string MaHDN,string MaNCC,string NguoiGiao,string NguoiNhan,string TongTienThuoc,string NgayNhap)
        {
            this._MaHDN = MaHDN;
            this._MaCC = MaNCC;
            this._NguoiGiao = NguoiGiao;
            this._NguoiNhan = NguoiNhan;
            this._TongTienThuoc = TongTienThuoc;       
            this._NgayNhap = NgayNhap;
        }
    }
}
