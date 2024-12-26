using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietLichHocDAL
    {
        public List<ChiTietLichHoc> DanhSachLichHoc(int userId)
        {
            List<ChiTietLichHoc> listLichHoc = new List<ChiTietLichHoc> ();
            NgayTrongTuanDAL ngayTTDAL = new NgayTrongTuanDAL();
            List <NgayTrongTuan> ngayTrongTuans = ngayTTDAL.ListNgay();

            foreach(var ngay in ngayTrongTuans)
            {
                ChiTietLichHoc chiTiet = new ChiTietLichHoc();
                chiTiet.Thu = ngay.Thu;
                chiTiet.Ngay = ngay.Ngay;

                LichHocDAL lichHocDAL = new LichHocDAL();
                List<LichHoc> lichHocs = lichHocDAL.ListLichHoc(ngay.IdNgay, userId);

                chiTiet.ChiTietLich = lichHocs;

                listLichHoc.Add(chiTiet);

            }

            return listLichHoc;
        }

    }
}
