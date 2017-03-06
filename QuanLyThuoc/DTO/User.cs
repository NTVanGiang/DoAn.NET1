using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Users
    {
       
        private string _IdUser;

        public string IdUser
        {
            get { return _IdUser; }
            set { _IdUser = value; }
        }
        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        private string _PassWord;

        public string PassWord
        {
            get { return _PassWord; }
            set { _PassWord = value; }
        }
        private string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public Users(string IdUser,string UserName,string PassWord,string HoTen,string DiaChi)
        {
            this._IdUser = IdUser;
            this._UserName = UserName;
            this._PassWord = PassWord;
            this._HoTen = HoTen;
            this._DiaChi = DiaChi;
        }
    }
}
