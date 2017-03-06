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
    public class BUS_DonViTinh
    {
        DAL_DonViTinh dal_donvitinh = new DAL_DonViTinh();
        public DataTable Get()
        {
            return dal_donvitinh.Get();
        }
        public bool Insert_DonViTinh(DonViTinh pDonViTinh)
        {
            return dal_donvitinh.Insert_DonViTinh(pDonViTinh);
        }
        public bool Update_DonViTinh(DonViTinh pDonViTinh)
        {
            return dal_donvitinh.Update_DonViTinh(pDonViTinh);
        }
        public bool Delete_DonViTinh(string MaDVT)
        {
            return dal_donvitinh.Delete_DonViTinh(MaDVT);

        }

    }
}
