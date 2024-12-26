using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichThi
    {
        public  int Id { get; set; }
        public string IdNgay { get; set; }
        public string BuoiThi { get; set; }
        public string MonThi{ get; set; }
        public string Lop { get; set; }
        public string Tiet { get; set; }
        public string Phong { get; set; }
        public string GioThi { get; set; }
        public int UserId { get; set; }
    }
}
