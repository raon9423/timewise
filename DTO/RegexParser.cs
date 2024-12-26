using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class RegexParser
    {
        public KetQuaPT_Regex PhanTichHtml(string html)
        {
            List<NgayTrongTuan> listNgay = new List<NgayTrongTuan>();
            List<LichHoc> listLichHoc = new List<LichHoc>();
            List<LichThi> listLichThi = new List<LichThi>();
            string muaPattern = @"<tr role=""row"">(.*?)</tr>";
            Regex regex = new Regex(muaPattern, RegexOptions.Singleline);
            MatchCollection matches = regex.Matches(html);

            Match thuNgay = matches[0];
            Match sang = matches[1];
            Match chieu = matches[2];
            Match toi = matches[3];

            var listThuNgay = PhanTichThuNgay(thuNgay.Groups[1].Value);
            foreach (string tn in listThuNgay)
            {
                NgayTrongTuan ngayTrongTuan = new NgayTrongTuan();
                var thuVaNgay = tn.Split(':');
                string thu = thuVaNgay[0];
                DateTime result = Convert.ToDateTime(thuVaNgay[1], System.Globalization.CultureInfo.GetCultureInfo("en-GB"));
                DateTime ngay = result;
                string id = result.ToShortDateString().Replace("/", "");

                ngayTrongTuan.Thu = thu;
                ngayTrongTuan.Ngay = ngay;
                ngayTrongTuan.IdNgay = id;

                listNgay.Add(ngayTrongTuan);

            }

            var listLHSang = PhanTichHang_Buoi(sang.Groups[1].Value, listThuNgay);
            foreach (var lhSang in listLHSang)
                if (lhSang != null)
                {
                    string Buoi = lhSang["Buoi"];
                    string Ngay = lhSang["Ngay"];
                    string Mon = lhSang["Mon"];
                    string Lop = lhSang["Lop"];
                    string Tiet = lhSang["Tiet"];
                    string Phong = lhSang["Phong"];
                    string GV = lhSang["GV"];
                    string GhiChu = lhSang["GhiChu"];
                    string TamNgung = lhSang["TamNgung"];
                    string GioThi = lhSang["GioThi"];
                    if(!string.IsNullOrEmpty(GV) && string.IsNullOrEmpty(GioThi))
                    {
                        LichHoc lichHoc = new LichHoc();
                        lichHoc.BuoiHoc = Buoi;

                        var thuVaNgay = Ngay.Split(':');
                        DateTime result = Convert.ToDateTime(thuVaNgay[1], System.Globalization.CultureInfo.GetCultureInfo("en-GB"));
                        string id = result.ToShortDateString().Replace("/", "");

                        lichHoc.IdNgay = id;
                        lichHoc.MonHoc = Mon;
                        lichHoc.LopHoc = Lop;
                        lichHoc.Tiet = Tiet;
                        lichHoc.Phong = Phong;
                        lichHoc.GiangVien = GV;
                        lichHoc.GhiChu = GhiChu;
                        lichHoc.TamNgung = TamNgung == "Tạm ngưng" ? true : false;

                        listLichHoc.Add(lichHoc);   
                    }
                    else if(string.IsNullOrEmpty(GV) && !string.IsNullOrEmpty(GioThi))
                    {
                        LichThi lichThi = new LichThi();
                        lichThi.BuoiThi = Buoi;

                        var thuVaNgay = Ngay.Split(':');
                        DateTime result = Convert.ToDateTime(thuVaNgay[1], System.Globalization.CultureInfo.GetCultureInfo("en-GB"));
                        string id = result.ToShortDateString().Replace("/", "");

                        lichThi.IdNgay = id;
                        lichThi.MonThi = Mon;
                        lichThi.Lop = Lop;
                        lichThi.Tiet = Tiet;
                        lichThi.Phong = Phong;
                        lichThi.GioThi = GioThi;

                        listLichThi.Add(lichThi);
                    }

                }

            var listLHChieu = PhanTichHang_Buoi(chieu.Groups[1].Value, listThuNgay);
            foreach (var lh in listLHChieu)
                if (lh != null)
                {
                    string Buoi = lh["Buoi"];
                    string Ngay = lh["Ngay"];
                    string Mon = lh["Mon"];
                    string Lop = lh["Lop"];
                    string Tiet = lh["Tiet"];
                    string Phong = lh["Phong"];
                    string GV = lh["GV"];
                    string GhiChu = lh["GhiChu"];
                    string TamNgung = lh["TamNgung"];
                    string GioThi = lh["GioThi"];
                    if (!string.IsNullOrEmpty(GV) && string.IsNullOrEmpty(GioThi))
                    {
                        LichHoc lichHoc = new LichHoc();
                        lichHoc.BuoiHoc = Buoi;

                        var thuVaNgay = Ngay.Split(':');
                        DateTime result = Convert.ToDateTime(thuVaNgay[1], System.Globalization.CultureInfo.GetCultureInfo("en-GB"));
                        string id = result.ToShortDateString().Replace("/", "");

                        lichHoc.IdNgay = id;
                        lichHoc.MonHoc = Mon;
                        lichHoc.LopHoc = Lop;
                        lichHoc.Tiet = Tiet;
                        lichHoc.Phong = Phong;
                        lichHoc.GiangVien = GV;
                        lichHoc.GhiChu = GhiChu;
                        lichHoc.TamNgung = TamNgung == "Tạm ngưng" ? true : false;

                        listLichHoc.Add(lichHoc);
                    }
                    else if (string.IsNullOrEmpty(GV) && !string.IsNullOrEmpty(GioThi))
                    {
                        LichThi lichThi = new LichThi();
                        lichThi.BuoiThi = Buoi;

                        var thuVaNgay = Ngay.Split(':');
                        DateTime result = Convert.ToDateTime(thuVaNgay[1], System.Globalization.CultureInfo.GetCultureInfo("en-GB"));
                        string id = result.ToShortDateString().Replace("/", "");

                        lichThi.IdNgay = id;
                        lichThi.MonThi = Mon;
                        lichThi.Lop = Lop;
                        lichThi.Tiet = Tiet;
                        lichThi.Phong = Phong;
                        lichThi.GioThi = GioThi;

                        listLichThi.Add(lichThi);
                    }


                }

            var listLHToi = PhanTichHang_Buoi(toi.Groups[1].Value, listThuNgay);
            foreach (var lh in listLHToi)
                if (lh != null)
                {
                    string Buoi = lh["Buoi"];
                    string Ngay = lh["Ngay"];
                    string Mon = lh["Mon"];
                    string Lop = lh["Lop"];
                    string Tiet = lh["Tiet"];
                    string Phong = lh["Phong"];
                    string GV = lh["GV"];
                    string GhiChu = lh["GhiChu"];
                    string TamNgung = lh["TamNgung"];
                    string GioThi = lh["GioThi"];
                    if (!string.IsNullOrEmpty(GV) && string.IsNullOrEmpty(GioThi))
                    {
                        LichHoc lichHoc = new LichHoc();
                        lichHoc.BuoiHoc = Buoi;

                        var thuVaNgay = Ngay.Split(':');
                        DateTime result = Convert.ToDateTime(thuVaNgay[1], System.Globalization.CultureInfo.GetCultureInfo("en-GB"));
                        string id = result.ToShortDateString().Replace("/", "");

                        lichHoc.IdNgay = id;
                        lichHoc.MonHoc = Mon;
                        lichHoc.LopHoc = Lop;
                        lichHoc.Tiet = Tiet;
                        lichHoc.Phong = Phong;
                        lichHoc.GiangVien = GV;
                        lichHoc.GhiChu = GhiChu;
                        lichHoc.TamNgung = TamNgung == "Tạm ngưng" ? true : false;

                        listLichHoc.Add(lichHoc);
                    }
                    else if (string.IsNullOrEmpty(GV) && !string.IsNullOrEmpty(GioThi))
                    {
                        LichThi lichThi = new LichThi();
                        lichThi.BuoiThi = Buoi;

                        var thuVaNgay = Ngay.Split(':');
                        DateTime result = Convert.ToDateTime(thuVaNgay[1], System.Globalization.CultureInfo.GetCultureInfo("en-GB"));
                        string id = result.ToShortDateString().Replace("/", "");

                        lichThi.IdNgay = id;
                        lichThi.MonThi = Mon;
                        lichThi.Lop = Lop;
                        lichThi.Tiet = Tiet;
                        lichThi.Phong = Phong;
                        lichThi.GioThi = GioThi;

                        listLichThi.Add(lichThi);
                    }

                }
            KetQuaPT_Regex ketQuaPT = new KetQuaPT_Regex();
            ketQuaPT.NgayTrongTuan = listNgay;
            ketQuaPT.LichHocs = listLichHoc;
            ketQuaPT.LichThis = listLichThi;
            return ketQuaPT;
        }

        private List<string> PhanTichThuNgay(string html)
        {
            List<string> listThuNgay = new List<string>();
            string pattern = @"<th><span.*?>(.*?)<\/span><br>(.*?)<\/th>";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(html);

            foreach (Match match in matches)
            {
                string tenNgay = match.Groups[1].Value.Trim();
                string ngayThang = match.Groups[2].Value.Trim();
                listThuNgay.Add($"{tenNgay}: {ngayThang}");
            }
            return listThuNgay;
        }

        private List<Dictionary<string, string>> PhanTichHang_Buoi(string html, List<string> tns)
        {
            List<Dictionary<string, string>> results = new List<Dictionary<string, string>>();

            string tdPattern = @"<td.*?>(.*?)<\/td>";

            Regex tdRegex = new Regex(tdPattern, RegexOptions.Singleline);

            MatchCollection matches = tdRegex.Matches(html);

            string buoiHoc = @"<b.*?>(.*?)<\/b>";
            Regex buoiHocRegex = new Regex(buoiHoc, RegexOptions.Singleline);
            MatchCollection buoiHocMatch = buoiHocRegex.Matches(matches[0].Groups[1].Value.Trim());
            string buoi = buoiHocMatch[0].Groups[1].Value.Trim();

            // Duyệt qua từng kết quả và trích xuất nội dung
            int tn = 0;
            for (int m = 1; m < matches.Count; m++)
            {
                Match match = matches[m];
                string content = match.Groups[1].Value.Trim();
                if (!string.IsNullOrEmpty(content))
                {
                    if (content.Contains("<div class=\"tamngung\"><span>Tạm ngưng</span></div>"))
                        content = content.Replace("<div class=\"tamngung\"><span>Tạm ngưng</span></div>", "<span class=\"tamngung\">Tạm ngưng</span>");

                    string lichPattern = @"<div.*?>(.*?)<\/div>";
                    Regex lichRegex = new Regex(lichPattern, RegexOptions.Singleline);
                    MatchCollection lichs = lichRegex.Matches(content);

                    foreach (Match lich in lichs)
                    {
                        string contentLich = lich.Groups[1].Value.Trim();

                        string tamNgungPattern = @"<span class=""tamngung"">(.*?)</span>";
                        string tenMonHocMau = @"<b><a.*?>(.*?)</a></b>";
                        string maMonHocMau = @"<p>(.*?)</p>";
                        string tietHocMau = @"<span lang=""lichtheotuan-tiet"">.*?</span>:\s*(.*?)<br>";
                        string phongHocMau = @"<span lang=""giang-duong"">.*?</span>:\s*<font>(.*?)</font>";
                        string giaoVienMau = @"<span lang=""lichtheotuan-gv"">.*?</span>:\s*<font>(.*?)</font>";
                        string ghiChuMau = @"<p><span lang=""lichtheotuan-ghichu"">.*?</span>:\s(.*?)</p>";
                        string gioThiPattern = @"<p><span\s+lang\s*=\s*""lichtheotuan-giothi"">Giờ thi</span>:\s*(.*?)<\/p>";

                        Regex tamNgungRegex = new Regex(tamNgungPattern, RegexOptions.Singleline);
                        Regex tenMonHocRegex = new Regex(tenMonHocMau, RegexOptions.Singleline);
                        Regex maMonHocRegex = new Regex(maMonHocMau, RegexOptions.Singleline);
                        Regex tietHocRegex = new Regex(tietHocMau, RegexOptions.Singleline);
                        Regex phongHocRegex = new Regex(phongHocMau, RegexOptions.Singleline);
                        Regex giaoVienRegex = new Regex(giaoVienMau, RegexOptions.Singleline);
                        Regex ghiChuRegex = new Regex(ghiChuMau, RegexOptions.Singleline);
                        Regex gioThiRegex = new Regex(gioThiPattern, RegexOptions.Singleline);

                        MatchCollection tamNgungMatches = tamNgungRegex.Matches(contentLich);
                        MatchCollection tenMonHocMatches = tenMonHocRegex.Matches(contentLich);
                        MatchCollection maMonHocMatches = maMonHocRegex.Matches(contentLich);
                        MatchCollection tietHocMatches = tietHocRegex.Matches(contentLich);
                        MatchCollection phongHocMatches = phongHocRegex.Matches(contentLich);
                        MatchCollection giaoVienMatches = giaoVienRegex.Matches(contentLich);
                        MatchCollection ghiChuMatches = ghiChuRegex.Matches(contentLich);
                        MatchCollection gioThiMatches = gioThiRegex.Matches(contentLich);


                        Dictionary<string, string> monHoc = new Dictionary<string, string>
                        {
                            { "Buoi", buoi },
                            { "Ngay", tns[tn] },
                            { "Mon", tenMonHocMatches.Count > 0 ? tenMonHocMatches[0].Groups[1].Value.Trim() : string.Empty },
                            { "Lop", maMonHocMatches.Count > 0 ? maMonHocMatches[0].Groups[1].Value.Trim() : string.Empty },
                            { "Tiet", tietHocMatches.Count > 0 ? tietHocMatches[0].Groups[1].Value.Trim() : string.Empty },
                            { "Phong", phongHocMatches.Count > 0 ? phongHocMatches[0].Groups[1].Value.Trim() : string.Empty },
                            { "GV", giaoVienMatches.Count > 0 ? giaoVienMatches[0].Groups[1].Value.Trim() : string.Empty },
                            { "GhiChu",ghiChuMatches.Count > 0 ? ghiChuMatches[0].Groups[1].Value.Trim() : string.Empty },
                            { "TamNgung",tamNgungMatches.Count > 0 ? tamNgungMatches[0].Groups[1].Value.Trim() : string.Empty },
                            { "GioThi", gioThiMatches.Count > 0 ? gioThiMatches[0].Groups[1].Value.Trim() : string.Empty}
                        };
                        results.Add(monHoc);
                        Console.WriteLine(monHoc["GhiChu"]  );
                    }

                }
                else
                {
                    results.Add(null);
                }
                tn++;
            }

            return results;
        }
        //private MucLichHoc PhanTichHang(string hangHtml)
        //{
        //    MucLichHoc mucHoc = new MucLichHoc();

        //    string caHocMau = @"<td.*?>(.*?)</td>";
        //    string tenMonHocMau = @"<b><a.*?>(.*?)</a></b>";
        //    string maMonHocMau = @"<p>(.*?)</p>";
        //    string tietHocMau = @"<span lang=""lichtheotuan-tiet"">.*?</span>:\s*(.*?)<br>";
        //    string phongHocMau = @"<span lang=""giang-duong"">.*?</span>:\s*<font>(.*?)</font>";
        //    string giaoVienMau = @"<span lang=""lichtheotuan-gv"">.*?</span>:\s*<font>(.*?)</font>";
        //    string ghiChuMau = @"<span lang=""lichtheotuan-ghichu"">.*?</span>:\s*(.*?)<br>";

        //    Regex caHocRegex = new Regex(caHocMau, RegexOptions.Singleline);
        //    Regex tenMonHocRegex = new Regex(tenMonHocMau, RegexOptions.Singleline);
        //    Regex maMonHocRegex = new Regex(maMonHocMau, RegexOptions.Singleline);
        //    Regex tietHocRegex = new Regex(tietHocMau, RegexOptions.Singleline);
        //    Regex phongHocRegex = new Regex(phongHocMau, RegexOptions.Singleline);
        //    Regex giaoVienRegex = new Regex(giaoVienMau, RegexOptions.Singleline);
        //    Regex ghiChuRegex = new Regex(ghiChuMau, RegexOptions.Singleline);

        //    MatchCollection caHocMatches = caHocRegex.Matches(hangHtml);
        //    MatchCollection tenMonHocMatches = tenMonHocRegex.Matches(hangHtml);
        //    MatchCollection maMonHocMatches = maMonHocRegex.Matches(hangHtml);
        //    MatchCollection tietHocMatches = tietHocRegex.Matches(hangHtml);
        //    MatchCollection phongHocMatches = phongHocRegex.Matches(hangHtml);
        //    MatchCollection giaoVienMatches = giaoVienRegex.Matches(hangHtml);
        //    MatchCollection ghiChuMatches = ghiChuRegex.Matches(hangHtml);

        //    if (caHocMatches.Count < 1 || tenMonHocMatches.Count < 1 || tietHocMatches.Count < 1)
        //    {
        //        return null;
        //    }

        //    mucHoc.CaHoc = caHocMatches[0].Groups[1].Value.Trim();
        //    mucHoc.MonHoc = tenMonHocMatches[0].Groups[1].Value.Trim();
        //    mucHoc.MaMonHoc = maMonHocMatches.Count > 0 ? maMonHocMatches[0].Groups[1].Value.Trim() : string.Empty;
        //    mucHoc.TietHoc = tietHocMatches[0].Groups[1].Value.Trim();
        //    mucHoc.PhongHoc = phongHocMatches.Count > 0 ? phongHocMatches[0].Groups[1].Value.Trim() : string.Empty;
        //    mucHoc.GiaoVien = giaoVienMatches.Count > 0 ? giaoVienMatches[0].Groups[1].Value.Trim() : string.Empty;
        //    mucHoc.GhiChu = ghiChuMatches.Count > 0 ? ghiChuMatches[0].Groups[1].Value.Trim() : string.Empty;

        //    return mucHoc;
        //}
    }

}
