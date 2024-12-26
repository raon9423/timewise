using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();

        public List<User> ListUser()
        {
            return userDAL.listUser();
        }

        public bool AddUser(User user)
        {
            return userDAL.AddUser(user);
        }

        public bool DeleteUser(User user)
        {
            return userDAL.DeleteUser(user);
        }

        public bool UpdatePassword(User user)
        {
           return userDAL.UpdataPassword(user);
        }
        public bool UpdateUser(User user)
        {
            return userDAL.UpdataUser(user);
        }
        public bool UpdateUserLogin(User user)
        {
            return userDAL.UpdataUserLogin(user);
        }

        public int isUser(User user)
        {
            return (userDAL.isUser(user));
        }
        public bool isUserLogin(User user)
        {
            return userDAL.isUserLogin(user);
        }
        public string GetEmailById(int id)
        {
            return userDAL.GetUserEmail(id); 
        }
        public User GetUserById(int id)
        {
            return userDAL.GetUserByID(id);
        }
    }
}
