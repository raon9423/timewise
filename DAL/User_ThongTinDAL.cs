using DTO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User_ThongTinDAL : Database
    {
        public User_ThongTin GetThongTinUser(int id)
        {
            User_ThongTin user_ThongTin = new User_ThongTin();
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * from User_ThongTin where IdUser = @id";
            sqlCommand.Connection = sqlConnection;

            SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
            parId.Value = id;
            sqlCommand.Parameters.Add(parId);


            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                int ID = reader.GetInt32(0);
                int UserID = reader.GetInt32(1);
                int ThongTinId = reader.GetInt32(2);

                user_ThongTin.Id = ID;
                user_ThongTin.IdUser = UserID;
                user_ThongTin.ThongTinId = ThongTinId;

            }
            reader.Close();

            return user_ThongTin;
        }

        public bool AddUser_ThongTin(User_ThongTin user_ThongTin)
        {
            OpenConnection();
            string query = "INSERT INTO User_ThongTin values(@id,@thongTinId)";
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = sqlConnection;

            command.Parameters.AddWithValue("@id", user_ThongTin.IdUser);
            command.Parameters.AddWithValue("@thongTinId", user_ThongTin.ThongTinId);

            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }
}
