using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class Regex_KQHT
    {
        public List<string> PhanTich_tr(string html)
        {
            List<string> list = new List<string>();
            string pattern = @"<tr role=""row"" class=""(?:odd|even)"".*?"">(.*?)</tr>";
            MatchCollection matches = Regex.Matches(html, pattern, RegexOptions.Singleline);
            foreach (Match match in matches)
            {
                string content = match.Groups[1].Value;
                list.Add(content);

            }
            return list;
        }
        public List<string> PhanTich_td(string html)
        {
            List<string> list = new List<string>();
            string pattern = @"<td(.*?)>(.*?)</td>";
            MatchCollection matches = Regex.Matches(html, pattern, RegexOptions.Singleline);
            foreach (Match match in matches)
            {
                string title = match.Groups[1].Value.Trim();
                string divContent = match.Groups[2].Value.Trim(); 
                list.Add(divContent);
            }
            return list;
        }

        public List<string> PhanTichNoiDung_td(string html)
        {
            List<string> list = new List<string>();
            string pattern = @"<div(.*?)>(.*?)</div>";
            MatchCollection matches = Regex.Matches(html, pattern, RegexOptions.Singleline);
            foreach (Match match in matches)
            {
                string title = match.Groups[1].Value.Trim();
                string divContent = match.Groups[2].Value.Trim();
                list.Add(divContent);
            }
            return list;
        }

        public List<Diem> DS_Diem(string html)
        {
            List<Diem> listDiem = new List<Diem>();
            var listTR = PhanTich_tr(html);
            foreach (var tr in listTR)
            {
                List<string> attrDiem = new List<string>();
                var listTD = PhanTich_td(tr);
                foreach(var td in listTD)
                {
                    if (td.Contains("div"))
                    {
                        var x = PhanTichNoiDung_td(td);
                        if (x.Count == 1)
                            attrDiem.Add(x[0]);
                        else
                            attrDiem.Add(null);
                    }
                    else attrDiem.Add(td);
                }

                Diem diem = new Diem();
                diem.MaMonHoc = attrDiem[0];
                diem.TenMonHoc = attrDiem[1];
                diem.SoTinChi = string.IsNullOrEmpty(attrDiem[2]) ? diem.SoTinChi : Convert.ToInt32(attrDiem[2]);
                diem.DiemChuyenCan = string.IsNullOrEmpty(attrDiem[3]) ? -1 : Convert.ToDouble(attrDiem[3].Replace(",", "."));
                diem.DiemHeSo11 = string.IsNullOrEmpty(attrDiem[4]) ? -1 : Convert.ToDouble(attrDiem[4].Replace(",", "."));
                diem.DiemHeSo12 = string.IsNullOrEmpty(attrDiem[5]) ? -1 : Convert.ToDouble(attrDiem[5].Replace(",", "."));
                diem.DiemHeSo13 = string.IsNullOrEmpty(attrDiem[6]) ? -1 : Convert.ToDouble(attrDiem[6].Replace(",", "."));
                diem.DiemTieuLuan = string.IsNullOrEmpty(attrDiem[7]) ? -1 : Convert.ToDouble(attrDiem[7].Replace(",", "."));
                diem.DiemThucHanh1 = string.IsNullOrEmpty(attrDiem[8]) ? -1 : Convert.ToDouble(attrDiem[8].Replace(",", "."));
                diem.DiemThucHanh2 = string.IsNullOrEmpty(attrDiem[9]) ? -1 : Convert.ToDouble(attrDiem[9].Replace(",", "."));
                diem.DiemThucHanh3 = string.IsNullOrEmpty(attrDiem[10]) ? -1 : Convert.ToDouble(attrDiem[10].Replace(",", "."));
                diem.DiemThi = string.IsNullOrEmpty(attrDiem[11]) ? -1 : Convert.ToDouble(attrDiem[11].Replace(",", "."));
                diem.DiemTongKet = string.IsNullOrEmpty(attrDiem[12]) ? -1 : Convert.ToDouble(attrDiem[12].Replace(",", "."));
                diem.DiemTinChi = string.IsNullOrEmpty(attrDiem[13]) ? -1 : Convert.ToDouble(attrDiem[13].Replace(",", "."));
                diem.DiemChu = attrDiem[14];
                diem.GhiChu = attrDiem[15];
                listDiem.Add(diem);
            }

            return listDiem;
        }
    }
}
