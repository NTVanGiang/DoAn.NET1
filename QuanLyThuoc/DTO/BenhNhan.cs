using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhan
    {
        private string _MaBN;

        public string MaBN
        {
            get { return _MaBN; }
            set { _MaBN = value; }
        }
        private string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private string _Tuoi;

        public string Tuoi
        {
            get { return _Tuoi; }
            set { _Tuoi = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _DienThoai;
        private string text1;
        private string text2;
        private int v;
        private string text3;
        private string text4;

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        public BenhNhan(string MaBN,string HoTen,string Tuoi,string DiaChi,string DienThoai)
        {
            this._MaBN = MaBN;
            this._HoTen = HoTen;
            this._Tuoi = Tuoi;
            this._DiaChi = DiaChi;
            this._DienThoai = DienThoai;
        }
        public BenhNhan(string HoTen, string Tuoi, string DiaChi, string DienThoai)
        {
            this._MaBN = MaBN;
            this._HoTen = HoTen;
            this._Tuoi = Tuoi;
            this._DiaChi = DiaChi;
            this._DienThoai = DienThoai;
        }

        public BenhNhan(string text1, string text2, int v, string text3, string text4)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.v = v;
            this.text3 = text3;
            this.text4 = text4;
        }
    }
}
