using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Diem
    {

        public int SoThuTu { get; set; }
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int SoTinChi { get; set; }
        public double DiemChuyenCan { get; set; }
        public double DiemHeSo11 { get; set; }
        public double DiemHeSo12 { get; set; }
        public double DiemHeSo13 { get; set; }
        public double DiemTieuLuan { get; set; }
        public double DiemThucHanh1 { get; set; }
        public double DiemThucHanh2 { get; set; }
        public double DiemThucHanh3 { get; set; }
        public double DiemThi { get; set; }
        public double DiemTongKet { get; set; }
        public double DiemTinChi { get; set; }
        public string DiemChu { get; set; }
        public string GhiChu { get; set; }
        public string GhiChuXetDuThi { get; set; }
        public string GhiChu_CK { get; set; }

        public override string ToString()
        {
            return $"Số thứ tự: {SoThuTu}\nMã môn học: {MaMonHoc}\nTên môn học: {TenMonHoc}\nSố tín chỉ: {SoTinChi}\n" +
                   $"Điểm chuyên cần: {DiemChuyenCan}\nĐiểm hệ số 1: {DiemHeSo11}\nĐiểm hệ số 2: {DiemHeSo12}\n" +
                   $"Điểm hệ số 3: {DiemHeSo13}\nĐiểm tiểu luận: {DiemTieuLuan}\nĐiểm thực hành 1: {DiemThucHanh1}\n" +
                   $"Điểm thực hành 2: {DiemThucHanh2}\nĐiểm thực hành 3: {DiemThucHanh3}\nĐiểm thi: {DiemThi}\n" +
                   $"Điểm tổng kết: {DiemTongKet}\nĐiểm tín chỉ: {DiemTinChi}\nĐiểm chữ: {DiemChu}\n" +
                   $"Ghi chú: {GhiChu}\nGhi chú xét dự thi: {GhiChuXetDuThi}\nGhi chú CK: {GhiChu_CK}";
        }

    }


}
