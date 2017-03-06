using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonXuat
    {
        private string _MaHDX;

        public string MaHDX
        {
            get { return _MaHDX; }
            set { _MaHDX = value; }
        }
        private string _MaBN;

        public string MaBN
        {
            get { return _MaBN; }
            set { _MaBN = value; }
        }
        private string _NgayLap;

        public string NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }
        private string _TongTien;

        public string TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
        public HoaDonXuat(string MaHDX,string MaBN,string NgayLap,string TongTien)
        {
            this._MaHDX = MaHDX;
            this._MaBN = MaBN;
            this._NgayLap = NgayLap;
            this._TongTien = TongTien;
        }

    }
}
