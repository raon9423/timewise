using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietLichThi
    {
        public string Thu { get; set; }
        public DateTime Ngay { get; set; }
        public List<LichThi> ChiTietLich { get; set; }
    }
}
