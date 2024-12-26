using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NgayTrongTuanBLL
    {
        NgayTrongTuanDAL ngayTrongTuanDAL = new NgayTrongTuanDAL();
        public List<NgayTrongTuan> DS_NgayTrongTuan()
        {
            return ngayTrongTuanDAL.ListNgay();
        }
        public bool AddNgay(NgayTrongTuan ngay)
        {
            return ngayTrongTuanDAL.AddNgay(ngay);
        }

        public NgayTrongTuan timNgay_id(string id)
        {
            return ngayTrongTuanDAL.timNgay_id(id);
        }


    }
}
