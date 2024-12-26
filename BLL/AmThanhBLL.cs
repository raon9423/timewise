using CefSharp.DevTools.Page;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AmThanhBLL
    {
        AmThanhDAL amThanhDAL = new AmThanhDAL();

        public List<AmThanh> DS_AmThanh(int userId)
        {
            return amThanhDAL.DS_AmThanh(userId);
        }

        public bool AddAmThanh(AmThanh amThanh)
        {
            return amThanhDAL.AddAmThanh(amThanh);
        }

        public bool DeleteAmThanh(AmThanh amThanh)
        {
            return amThanhDAL.DeleteAmThanh(amThanh);
        }
        public bool UpdateAmThanh(AmThanh amThanh)
        {
            return amThanhDAL.UpdateAmThanh(amThanh);
        }

        public bool DeleteAmThanhByPath(string path)
        {
            return amThanhDAL.DeleteAmThanhByPath(path);
        }
    }
}
