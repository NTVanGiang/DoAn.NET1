using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonViTinh
    {
        private string _MaDVT;

        public string MaDVT
        {
            get { return _MaDVT; }
            set { _MaDVT = value; }
        }
        private string _TenDVT;

        public string TenDVT
        {
            get { return _TenDVT; }
            set { _TenDVT = value; }
        }
        public DonViTinh(string MaDVT,string TenDVT)
        {
            this._MaDVT = MaDVT;
            this._TenDVT = TenDVT;
        }
    }
}
