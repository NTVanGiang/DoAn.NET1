using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuoc
    {
        private string _MaThuoc;

        public string MaThuoc
        {
            get { return _MaThuoc; }
            set { _MaThuoc = value; }
        }
        private string _TenThuoc;

        public string TenThuoc
        {
            get { return _TenThuoc; }
            set { _TenThuoc = value; }
        }
        private string _MaNhom;

        public string MaNhom
        {
            get { return _MaNhom; }
            set { _MaNhom = value; }
        }
        private string _SoLuong;

        public string SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private string _GiaBan;

        public string GiaBan
        {
            get { return _GiaBan; }
            set { _GiaBan = value; }
        }
        private string _MaDVT;

        public string MaDVT
        {
            get { return _MaDVT; }
            set { _MaDVT = value; }
        }
        private string _CongDung;

        public string CongDung
        {
            get { return _CongDung; }
            set { _CongDung = value; }
        }
        private string _PhanTacDung;

        public string PhanTacDung
        {
            get { return _PhanTacDung; }
            set { _PhanTacDung = value; }
        }
        private string _NgaySanXuat;

        public string NgaySanXuat
        {
            get { return _NgaySanXuat; }
            set { _NgaySanXuat = value; }
        }
        private string _HanSuDung;

        public string HanSuDung
        {
            get { return _HanSuDung; }
            set { _HanSuDung = value; }
        }
        public Thuoc(string MaThuoc,string TenThuoc,string MaNhom,string SoLuong,string GiaBan,string MaDVT,string CongDung,string PhanTacDung,string NgaySanXuat,string HanSuDung)
        {
            this._MaThuoc = MaThuoc;
            this._TenThuoc = TenThuoc;
            this._MaNhom = MaNhom;
            this._SoLuong = SoLuong;
            this._GiaBan = GiaBan;
            this._MaDVT = MaDVT;
            this._CongDung = CongDung;
            this._PhanTacDung = PhanTacDung;
            this._NgaySanXuat = NgaySanXuat;
            this._HanSuDung = HanSuDung;
        }
    }
}
