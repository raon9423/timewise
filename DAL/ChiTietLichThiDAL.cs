using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietLichThiDAL
    {
        public List<ChiTietLichThi> DanhSachLichThi(int userId)
        {
            List<ChiTietLichThi> listLichThi = new List<ChiTietLichThi>();
            NgayTrongTuanDAL ngayTTDAL = new NgayTrongTuanDAL();
            List<NgayTrongTuan> ngayTrongTuans = ngayTTDAL.ListNgay();

            foreach (var ngay in ngayTrongTuans)
            {
                ChiTietLichThi chiTiet = new ChiTietLichThi();
                chiTiet.Thu = ngay.Thu;
                chiTiet.Ngay = ngay.Ngay;

                LichThiDAL lichThiDAL = new LichThiDAL();
                List<LichThi> lichThis = lichThiDAL.ListLichThi(ngay.IdNgay, userId);

                chiTiet.ChiTietLich = lichThis;

                listLichThi.Add(chiTiet);

            }

            return listLichThi;
        }
    }
}
