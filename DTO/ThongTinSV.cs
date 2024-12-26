using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinSV
    {
        public int Id { get; set; }
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string TrangThai { get; set; }
        public string MaHoSo { get; set; }
        public DateTime NgayVaoTruong { get; set; }
        public string LopHoc { get; set; }
        public string CoSo { get; set; }
        public string BacDaoTao { get; set; }
        public string LoaiHinhDaoTao { get; set; }
        public string Khoa { get; set; }
        public string Nganh { get; set; }
        public string ChuyenNganh { get; set; }
        public string KhoaHoc { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string KhuVuc { get; set; }
        public string SoCCCD { get; set; }
        public DateTime NgayCapCCCD { get; set; }
        public string NoiCapCCCD { get; set; }
        public string DoiTuong { get; set; }
        public DateTime NgayVaoDoan { get; set; }
        public DateTime NgayVaoDang { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string EmailNTT { get; set; }
        public string MatKhauEmailNTT { get; set; }
        public string DiaChiLienHe { get; set; }
        public string NoiSinh { get; set; }
        public string HoKhauThuongTru { get; set; }
        public override string ToString()
        {
            return $"MSSV: {MSSV}\n" +
                   $"Họ tên: {HoTen}\n" +
                   $"Giới tính: {GioiTinh}\n" +
                   $"Trạng thái: {TrangThai}\n" +
                   $"Mã hồ sơ: {MaHoSo}\n" +
                   $"Ngày vào trường: {NgayVaoTruong.ToShortDateString()}\n" +
                   $"Lớp học: {LopHoc}\n" +
                   $"Cơ sở: {CoSo}\n" +
                   $"Bậc đào tạo: {BacDaoTao}\n" +
                   $"Loại hình đào tạo: {LoaiHinhDaoTao}\n" +
                   $"Khoa: {Khoa}\n" +
                   $"Ngành: {Nganh}\n" +
                   $"Chuyên ngành: {ChuyenNganh}\n" +
                   $"Khóa học: {KhoaHoc}\n" +
                   $"Ngày sinh: {NgaySinh.ToShortDateString()}\n" +
                   $"Dân tộc: {DanToc}\n" +
                   $"Tôn giáo: {TonGiao}\n" +
                   $"Khu vực: {KhuVuc}\n" +
                   $"Số CCCD: {SoCCCD}\n" +
                   $"Ngày cấp CCCD: {NgayCapCCCD.ToShortDateString()}\n" +
                   $"Nơi cấp CCCD: {NoiCapCCCD}\n" +
                   $"Đối tượng: {DoiTuong}\n" +
                   $"Ngày vào Đoàn: {NgayVaoDoan.ToShortDateString()}\n" +
                   $"Ngày vào Đảng: {NgayVaoDang.ToShortDateString()}\n" +
                   $"Điện thoại: {DienThoai}\n" +
                   $"Email: {Email}\n" +
                   $"Email NTT: {EmailNTT}\n" +
                   $"Mật khẩu email NTT: {MatKhauEmailNTT}\n" +
                   $"Địa chỉ liên hệ: {DiaChiLienHe}\n" +
                   $"Nơi sinh: {NoiSinh}\n" +
                   $"Hộ khẩu thường trú: {HoKhauThuongTru}";
        }
    }
}
