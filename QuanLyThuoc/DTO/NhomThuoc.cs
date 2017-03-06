using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhomThuoc
    {
        private string _MaNhom;

        public string MaNhom
        {
            get { return _MaNhom; }
            set { _MaNhom = value; }
        }
        private string _TenNhom;

        public string TenNhom
        {
            get { return _TenNhom; }
            set { _TenNhom = value; }
        }
        public NhomThuoc(string MaNhom,string TenNhom)
        {
            this._MaNhom = MaNhom;
            this._TenNhom = TenNhom;
        }
    }
}
