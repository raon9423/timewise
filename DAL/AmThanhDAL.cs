using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class AmThanhDAL : Database
    {

        public List<AmThanh> DS_AmThanh(int userId)
        {
            List<AmThanh> amThanhs = new List<AmThanh>();
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * from Music Where UserId = @userId";
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@userId", userId);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                AmThanh amThanh = new AmThanh();
                int id = reader.GetInt32(0);
                string path = reader.GetString(1);

                amThanh.Id = id;
                amThanh.Path = path;
                amThanh.UserId = userId; 
                amThanhs.Add(amThanh);
            }

            return amThanhs;
        }

        public bool AddAmThanh(AmThanh amThanh)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Insert into Music values(@path, @userId)";

            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@path",amThanh.Path); 
            sqlCommand.Parameters.AddWithValue("@userId", amThanh.UserId);

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

        public bool UpdateAmThanh(AmThanh amThanh)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Update Musics set MusicName = @path, UserId = @userId where MusicId = @id";

            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@id",amThanh.Id);
            sqlCommand.Parameters.AddWithValue("@path", amThanh.Path);
            sqlCommand.Parameters.AddWithValue("@userId", amThanh.UserId);

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

        public bool DeleteAmThanh(AmThanh amThanh)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Delete Music where MusicId = @id";

            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@id", amThanh.Id);
           

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
        public bool DeleteAmThanhByPath(string path)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Delete Music where FilePath = @path";

            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@path", path);


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
    }
}
