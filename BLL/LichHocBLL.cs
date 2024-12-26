using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LichHocBLL
    {
        LichHocDAL lichHocDAL = new LichHocDAL();

        public List<LichHoc> ListLichHoc(string id,int userId)
        {
            return lichHocDAL.ListLichHoc(id, userId);
        }

        public bool AddLichHoc(LichHoc lichHoc)
        {
            return lichHocDAL.AddLichHoc(lichHoc);
        }
    }
}
