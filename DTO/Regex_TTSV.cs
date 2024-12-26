using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class Regex_TTSV
    {
        private string runPatternDefault(string attributeName, string html)
        {
            string pattern = $@"<span lang=""{attributeName}"">.*?:\s*<b>(.*?)<\/b>";
            Match match = Regex.Match(html, pattern);
            if (match.Success)
            {
                string x = match.Groups[1].Value;
                return x;
            }
            return null;
        }

        private string runPattern(int index, string html)
        {
            string pattern1 = @"<label.*?>.*?Email NTT: <span.*?>(.*?)<\/span>.*?<\/label>";
            string pattern2 = @"<label.*?>.*?Mật khẩu email NTT: <span.*?>(.*?)<\/span>.*?<\/label>";
            string[] pattern = new string[2] { pattern1, pattern2};
            Match match = Regex.Match(html, pattern[index]);
            if (match != null)
            {
                string x = match.Groups[1].Value;
                return x;
            }
            return null;
        }

        private string runPattern3(string attributeName, string html)
        {
            string pattern = $@"<span\s+lang=""{attributeName}"">(.*?)<\/span>\s*:\s*<span\s+class=""bold"">(.*?)<\/span>";
            MatchCollection matches = Regex.Matches(html, pattern);
            if (matches.Count > 0)
            {
                string x = matches[0].Groups[2].Value;
                return matches[0].Groups[2].Value;
            }

            return null;

        }
        private DateTime ConvertToDateTime(string dateString)
        {
            if (string.IsNullOrEmpty(dateString)) return default;
            string[] dateParts = dateString.Split('/');
            if (dateParts.Length != 3)
            {
                throw new ArgumentException("Chuỗi ngày không đúng định dạng.");
            }
            int day = int.Parse(dateParts[0]);
            int month = int.Parse(dateParts[1]);
            int year = int.Parse(dateParts[2]);
            DateTime date = new DateTime(year, month, day);

            return date;
        }

        public ThongTinSV DS_ThongTin(string html)
        {
            #region Map thông tin sinh viên và thuộc tính để regex
            Dictionary<string, string> studentInfo = new Dictionary<string, string>()
        {
            {"MSSV", "thongtinsinhvien-mssv"},
            {"HoTen", "thongtinsinhvien-hovaten"},
            {"GioiTinh", "thongtinsinhvien-gioitinh"},
            {"TrangThai", "thongtinsinhvien-trangthai"},
            {"MaHoSo", "thongtinsinhvien-mahoso"},
            {"NgayVaoTruong", "thongtinsinhvien-ngayvaotruong"},
            {"LopHoc", "thongtinsinhvien-lophoc"},
            {"CoSo", "thongtinsinhvien-coso"},
            {"BacDaoTao", "thongtinsinhvien-bacdaotao"},
            {"LoaiHinhDaoTao", "thongtinsinhvien-loaidaotao"},
            {"Khoa", "thongtinsinhvien-khoa"},
            {"Nganh", "thongtinsinhvien-nganh"},
            {"ChuyenNganh", "thongtinsinhvien-chuyennganh"},
            {"KhoaHoc", "thongtinsinhvien-khoahoc"},
            {"NgaySinh", "thongtinsinhvien-ngaysinh"},
            {"DanToc", "thongtinsinhvien-dantoc"},
            {"TonGiao", "thongtinsinhvien-tongiao"},
            {"KhuVuc", "thongtinsinhvien-khuvuc"},
            {"SoCCCD", "thongtinsinhvien-socmnd"},
            {"NgayCapCCCD", "thongtinsinhvien-ngaycap"},
            {"NoiCapCCCD", "thongtinsinhvien-noicap"},
            {"DoiTuong","thongtinsinhvien-doituong" },
            {"NgayVaoDoan","thongtinsinhvien-ngayvaodoan" },
            {"NgayVaoDang","thongtinsinhvien-ngayvaodang" },
            {"DienThoai", "thongtinsinhvien-sdt"},
            {"Email", "thongtinsinhvien-email"},
            {"EmailNTT", "thongtinsinhvien-emailntt"},
            {"MatKhauEmailNTT", "thongtinsinhvien-matkhauemailntt"},
            {"DiaChiLienHe", "thongtinsinhvien-diachilienlac"},
            {"NoiSinh", "thongtinsinhvien-noisinh"},
            {"HoKhauThuongTru", "thongtinsinhvien-hktt"}

        };
            #endregion
            Dictionary<string, string> inforRegexed = new Dictionary<string, string>();
            int i = 0;
            foreach (var info in studentInfo)
            {
                if (i < 3)
                    inforRegexed.Add(info.Key, runPatternDefault(info.Value, html));
                else
                    inforRegexed.Add(info.Key, runPattern3(info.Value, html));
                i++;
            }
            ThongTinSV sinhVien = new ThongTinSV();
            sinhVien.MSSV = inforRegexed["MSSV"]== null ? "" : inforRegexed["MSSV"];
            sinhVien.HoTen = inforRegexed["HoTen"]== null ? "" : inforRegexed["HoTen"];
            sinhVien.GioiTinh = inforRegexed["GioiTinh"]== null ? "" : inforRegexed["GioiTinh"];
            sinhVien.TrangThai = inforRegexed["TrangThai"]== null ? "" : inforRegexed["TrangThai"];
            sinhVien.MaHoSo = inforRegexed["MaHoSo"]== null ? "" : inforRegexed["MaHoSo"];
            sinhVien.NgayVaoTruong = ConvertToDateTime(inforRegexed["NgayVaoTruong"]);
            sinhVien.LopHoc = inforRegexed["LopHoc"]== null ? "" : inforRegexed["LopHoc"];
            sinhVien.CoSo = inforRegexed["CoSo"]== null ? "" : inforRegexed["CoSo"];
            sinhVien.BacDaoTao = inforRegexed["BacDaoTao"]== null ? "" : inforRegexed["BacDaoTao"];
            sinhVien.LoaiHinhDaoTao = inforRegexed["LoaiHinhDaoTao"]== null ? "" : inforRegexed["LoaiHinhDaoTao"];
            sinhVien.Khoa = inforRegexed["Khoa"]== null ? "" : inforRegexed["Khoa"];
            sinhVien.Nganh = inforRegexed["Nganh"]== null ? "" : inforRegexed["Nganh"];
            sinhVien.ChuyenNganh = inforRegexed["ChuyenNganh"]== null ? "" : inforRegexed["ChuyenNganh"];
            sinhVien.KhoaHoc = inforRegexed["KhoaHoc"]== null ? "" : inforRegexed["KhoaHoc"];
            sinhVien.NgaySinh = ConvertToDateTime(inforRegexed["NgaySinh"]);
            sinhVien.DanToc = inforRegexed["DanToc"]== null ? "" : inforRegexed["DanToc"];
            sinhVien.TonGiao = inforRegexed["TonGiao"]== null ? "" : inforRegexed["TonGiao"];
            sinhVien.KhuVuc = inforRegexed["KhuVuc"]== null ? "" : inforRegexed["KhuVuc"];
            sinhVien.SoCCCD = inforRegexed["SoCCCD"]== null ? "" : inforRegexed["SoCCCD"];
            sinhVien.NgayCapCCCD = ConvertToDateTime(inforRegexed["NgayCapCCCD"]);
            sinhVien.NoiCapCCCD = inforRegexed["NoiCapCCCD"] == null ? "" : inforRegexed["NoiCapCCCD"];
            sinhVien.DoiTuong = inforRegexed["DoiTuong"]== null ? "" : inforRegexed["DoiTuong"];
            sinhVien.NgayVaoDoan = ConvertToDateTime(inforRegexed["NgayVaoDoan"]);
            sinhVien.NgayVaoDang = ConvertToDateTime(inforRegexed["NgayVaoDang"]) ;
            sinhVien.DienThoai = inforRegexed["DienThoai"]== null ? "" : inforRegexed["DienThoai"];
            sinhVien.Email = inforRegexed["Email"]== null ? "" : inforRegexed["Email"];
            string mailNTT = runPattern(0, html);
            string passMailNTT = runPattern(1, html);
            sinhVien.EmailNTT = mailNTT == null ? "" : mailNTT;
            sinhVien.MatKhauEmailNTT = passMailNTT == null ? "" : passMailNTT;
            sinhVien.DiaChiLienHe = inforRegexed["DiaChiLienHe"]== null ? "" : inforRegexed["DiaChiLienHe"];
            sinhVien.NoiSinh = inforRegexed["NoiSinh"]== null ? "" : inforRegexed["NoiSinh"];
            sinhVien.HoKhauThuongTru = inforRegexed["HoKhauThuongTru"]== null ? "" : inforRegexed["HoKhauThuongTru"];

            return sinhVien;
        }


    }
}
