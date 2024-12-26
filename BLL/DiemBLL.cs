using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DiemBLL
    {
        DiemDAL diemDAL = new DiemDAL();

        public List<Diem> DS_Diem()
        {
            return diemDAL.DS_Diem();
        }

        public bool AddDiem(Diem diem)
        {
            return diemDAL.AddDiem(diem);
        }
    }
}
