using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User_ThongTinBLL
    {
        User_ThongTinDAL user_ThongtinDAL = new User_ThongTinDAL();

        public User_ThongTin GetUser_ThongTinById(int ID)
        {
            return user_ThongtinDAL.GetThongTinUser(ID);
        }
        public bool AddUserThongTin(User_ThongTin user_ThongTin)
        {
            return user_ThongtinDAL.AddUser_ThongTin(user_ThongTin);
        }
    }
}
