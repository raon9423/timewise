using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public string email  { get; set; }
        public string nameOfUser { get; set; }
        public bool isLogin {  get; set; }
        public User()
        {
            isLogin = false;
        }
    }
}
