using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThucThiSQL_DAL : Database
    {
        public bool DeleteMucsic(int Iduser)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Delete Music where UserId = @ iduser";
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@iduser",Iduser);
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
        public bool DeleteUser_ThongTinSV(int Iduser)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Delete User_ThongTin where IdUser = @ iduser";
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@iduser", Iduser);
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
        public bool DeleteThongTinSV(string mssv)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Delete ThongTinSV where MSSV = @mssv";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@mssv", mssv);
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

        public bool DeleteLichHocLichThi(int userId)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Delete LichThi where UserId = @id Delete LichHoc where UserId = @id Delete ThuVaNgay";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", userId);
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


    }
}
