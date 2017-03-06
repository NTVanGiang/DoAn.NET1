using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_BenhNhan
    {
        DAL_BenhNhan dal_benhnhan = new DAL_BenhNhan();
        public DataTable Get()
        {
            return dal_benhnhan.Get();
        }
        public bool Insert_BenhNhan(BenhNhan pBenhNhan)
        {
            return dal_benhnhan.Insert_BenhNhan(pBenhNhan);
        }
        public bool Update_BenhNhan(BenhNhan pBenhNhan)
        {
            return dal_benhnhan.Update_BenhNhan(pBenhNhan);
        }
        public bool Delete_BenhNhan(string MaBN)
        {
            return dal_benhnhan.Delete_BenhNhan(MaBN);
        }

    }
}
