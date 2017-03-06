using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private string _MaNCC;

        public string MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
        private string _TenNCC;

        public string TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _DienThoai;

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public NhaCungCap(string MaNCC,string TenNCC,string DiaChi,string DienThoai,string Email)
        {
            this._MaNCC = MaNCC;
            this._TenNCC = TenNCC;
            this._DiaChi = DiaChi;
            this._DienThoai = DienThoai;
            this._Email = Email;
        }
    }
}
