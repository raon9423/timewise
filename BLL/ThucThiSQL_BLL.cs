using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThucThiSQL_BLL
    {
        ThucThiSQL_DAL thucThiDAL = new ThucThiSQL_DAL();

        public bool DeleteUser_ThongTin(int id)
        {
            return thucThiDAL.DeleteUser_ThongTinSV(id);
        }
        public bool DeleteThongTinSV(string mssv)
        {
            return thucThiDAL.DeleteThongTinSV( mssv);
        }
        public bool DeleteLichHocLichThi(int userId)
        {
            return thucThiDAL.DeleteLichHocLichThi(userId);
        }
        public bool DeleteMusic( int id) {
            return thucThiDAL.DeleteMucsic(id);
        }

    }
}
