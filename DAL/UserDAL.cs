using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL : Database
    {
        public List<User> listUser()
        {
            List<User> users = new List<User>();
            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Users";
            cmd.Connection = sqlConnection;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string userName = reader.GetString(1);
                string pass = reader.GetString(2);
                string email = reader.GetString(3);
                string nameOfUser = reader.GetString(4);
                bool isLogin = reader.GetInt32(5) == 0 ? false : true;

                User user = new User();

                user.userID = userId;
                user.userName = userName;
                user.userPass = pass;
                user.email = email;
                user.nameOfUser = nameOfUser;
                user.isLogin = isLogin;
                users.Add(user);
            }
            reader.Close();
            return users;
        }

        public bool AddUser(User user)
        {
            OpenConnection();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Insert into Users values (@usName,@pass,@usMail,@name, @log)";

            //SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
            //parId.Value = user.userID;
            //sqlCommand.Parameters.Add(parId);

            SqlParameter parusName = new SqlParameter("@usName", SqlDbType.NVarChar);
            parusName.Value = user.userName;
            sqlCommand.Parameters.Add(parusName);


            SqlParameter parPass = new SqlParameter("@pass", SqlDbType.NVarChar);
            parPass.Value = user.userPass;
            sqlCommand.Parameters.Add(parPass);

            SqlParameter parMail = new SqlParameter("@usMail", SqlDbType.NVarChar);
            parMail.Value = user.email;
            sqlCommand.Parameters.Add(parMail);

            SqlParameter parName = new SqlParameter("@name", SqlDbType.NVarChar);
            parName.Value = user.nameOfUser == null ? "" : user.nameOfUser;
            sqlCommand.Parameters.Add(parName);

            SqlParameter parLog = new SqlParameter("@log", SqlDbType.Int);
            parLog.Value = user.isLogin ? 1 : 0;
            sqlCommand.Parameters.Add(parLog);
            sqlCommand.Connection = sqlConnection;

            try
            {
                int check = sqlCommand.ExecuteNonQuery();
                if (check > 0)
                    return true;
            }
            catch
            {
            }
            return false;
        }

        public bool UpdataUserLogin(User user)
        {
            OpenConnection();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Users set IsLogIn = @log where Username = @usName and HashedPassword = @pass";

            //SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
            //parId.Value = user.userID;
            //sqlCommand.Parameters.Add(parId);

            SqlParameter parusName = new SqlParameter("@usName", SqlDbType.NVarChar);
            parusName.Value = user.userName;
            sqlCommand.Parameters.Add(parusName);

            SqlParameter parPass = new SqlParameter("@pass", SqlDbType.NVarChar);
            parPass.Value = user.userPass;
            sqlCommand.Parameters.Add(parPass);

            SqlParameter parLog = new SqlParameter("@log", SqlDbType.Int);
            parLog.Value = user.isLogin ? 1 : 0;
            sqlCommand.Parameters.Add(parLog);
            sqlCommand.Connection = sqlConnection;


            sqlCommand.Connection = sqlConnection;

            try
            {
                int check = sqlCommand.ExecuteNonQuery();
                if (check > 0)
                    return true;
            }
            catch
            {
            }
            return false;
        }
        public bool UpdataPassword(User user)
        {
            OpenConnection();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Users set HashedPassword = @pass where UserId = @id";

            SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
            parId.Value = user.userID;
            sqlCommand.Parameters.Add(parId);
            SqlParameter parPass = new SqlParameter("@pass", SqlDbType.NVarChar);
            parPass.Value = user.userPass;
            sqlCommand.Parameters.Add(parPass);

            sqlCommand.Connection = sqlConnection;

            try
            {
                int check = sqlCommand.ExecuteNonQuery();
                if (check > 0)
                    return true;
            }
            catch
            {
            }
            return false;
        }
        public bool UpdataUser(User user)
        {
            OpenConnection();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Users set Username = @usName, HashedPassword = @pass, Email = @usMail,FullName = @name, IsLogIn = @log where UserId = @id";

            SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
            parId.Value = user.userID;
            sqlCommand.Parameters.Add(parId);

            SqlParameter parusName = new SqlParameter("@usName", SqlDbType.NVarChar);
            parusName.Value = user.userName;
            sqlCommand.Parameters.Add(parusName);

            SqlParameter parPass = new SqlParameter("@pass", SqlDbType.NVarChar);
            parPass.Value = user.userPass;
            sqlCommand.Parameters.Add(parPass);

            SqlParameter parMail = new SqlParameter("@usMail", SqlDbType.NVarChar);
            parMail.Value = user.email == null ? "" : user.email;
            sqlCommand.Parameters.Add(parMail);

            SqlParameter parName = new SqlParameter("@name", SqlDbType.NVarChar);
            parName.Value = user.nameOfUser == null ? "" : user.nameOfUser;
            sqlCommand.Parameters.Add(parName);

            SqlParameter parLog = new SqlParameter("@log", SqlDbType.Int);
            parLog.Value = user.isLogin ? 1 : 0;
            sqlCommand.Parameters.Add(parLog);
            sqlCommand.Connection = sqlConnection;



            try
            {
                int check = sqlCommand.ExecuteNonQuery();
                if (check > 0)
                    return true;
            }
            catch
            {
            }
            return false;
        }

        public bool DeleteUser(User user)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Delete From Users Where UserId = @id";

            SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
            parId.Value = user.userID;
            sqlCommand.Parameters.Add(parId);

            sqlCommand.Connection = sqlConnection;
            try
            {
                int check = sqlCommand.ExecuteNonQuery();
                if (check > 0) return true;

            }
            catch
            {
            }
            return false;
        }

        public int isUser(User user)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * from Users where Username = @usName and HashedPassword = @pass";
            sqlCommand.Connection = sqlConnection;

            //SqlParameter parId = new SqlParameter("@Id", SqlDbType.Int);
            //parId.Value = user.userID;
            //sqlCommand.Parameters.Add(parId);

            SqlParameter parusName = new SqlParameter("@usName", SqlDbType.NVarChar);
            parusName.Value = user.userName;
            sqlCommand.Parameters.Add(parusName);

            SqlParameter parPass = new SqlParameter("@pass", SqlDbType.NVarChar);
            parPass.Value = user.userPass;
            sqlCommand.Parameters.Add(parPass);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            int id = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                    id = reader.GetInt32(0);
                return id;
            }
            reader.Close();
            return 0;
        }
        public string GetUserEmail(int userId)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT Email FROM Users WHERE UserId = @UserId";
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@UserId", userId);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            string email = null;

            if (reader.HasRows)
                while (reader.Read())
                    email = reader.GetString(0);
            reader.Close();
            return email;
        }

        public User GetUserByID(int userId)
        {
            OpenConnection();
            User user = new User();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT * FROM Users WHERE UserId = @UserId";
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@UserId", userId);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string userName = reader.GetString(1);
                string pass = reader.GetString(2);
                string email = reader.GetString(3);
                string nameOfUser = reader.GetString(4);
                bool isLogin = reader.GetInt32(5) == 0 ? false : true;


                user.userID = userId;
                user.userName = userName;
                user.userPass = pass;
                user.email = email;
                user.nameOfUser = nameOfUser;
                user.isLogin = isLogin;
            }
            reader.Close();
            return user;
        }

        public bool isUserLogin(User user)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * from Users where Username = @usName and HashedPassword = @pass";
            sqlCommand.Connection = sqlConnection;

            //SqlParameter parId = new SqlParameter("@Id", SqlDbType.Int);
            //parId.Value = user.userID;
            //sqlCommand.Parameters.Add(parId);

            SqlParameter parusName = new SqlParameter("@usName", SqlDbType.NVarChar);
            parusName.Value = user.userName;
            sqlCommand.Parameters.Add(parusName);

            SqlParameter parPass = new SqlParameter("@pass", SqlDbType.NVarChar);
            parPass.Value = user.userPass;
            sqlCommand.Parameters.Add(parPass);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            int isLog = 0;
            if (reader.HasRows)
                while (reader.Read())
                    isLog = reader.GetInt32(5);
            if (isLog != 0)
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }
    }
}
