using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongTinSVBLL
    {
        ThongTinSVDAL thongTinSVDAL = new ThongTinSVDAL();

        public List<ThongTinSV> ThongTinSinhVien()
        {
            return thongTinSVDAL.GetAllThongTinSV();
        }
        public ThongTinSV GetThongTinSVByMSSV(string mssv)
        {
            return thongTinSVDAL.GetThongTinByMSVV(mssv);
        }

        public ThongTinSV GetThongTinSVById(int id)
        {
            return thongTinSVDAL.GetThongTinById(id);
        }
        public bool AddThongTinSV(ThongTinSV sinhVien)
        {
            return thongTinSVDAL.AddThongTinSV(sinhVien);
        }


    }
}
