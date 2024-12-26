using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LichThiBLL
    {
        LichThiDAL lichThiDAL = new LichThiDAL();
        public List<LichThi> DS_LichThi(string id, int uID)
        {
            return lichThiDAL.ListLichThi(id,uID);
        }

        public bool AddLich(LichThi lichThi)
        {
            return lichThiDAL.AddLichThi(lichThi);
        }
    }
}
