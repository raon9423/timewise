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
    public class NgayTrongTuanDAL : Database
    {
        public List<NgayTrongTuan> ListNgay()
        {
            List<NgayTrongTuan> ngayTrongTuans = new List<NgayTrongTuan>();
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From ThuVaNgay";
            cmd.Connection = sqlConnection;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NgayTrongTuan ngayTrongTuan = new NgayTrongTuan();
                string Id = reader.GetString(0);
                string Thu = reader.GetString(1);
                DateTime Ngay = reader.GetDateTime(2);

                ngayTrongTuan.IdNgay = Id;
                ngayTrongTuan.Thu = Thu;
                ngayTrongTuan.Ngay = Ngay;  

                ngayTrongTuans.Add(ngayTrongTuan);
            }

            return ngayTrongTuans;
        }

        public bool AddNgay(NgayTrongTuan ngay)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Insert into ThuVaNgay values (@Id,@Thu,@Ngay)";

            SqlParameter parId = new SqlParameter("@Id", SqlDbType.VarChar);
            parId.Value = ngay.IdNgay;
            sqlCommand.Parameters.Add(parId);

            SqlParameter parThu = new SqlParameter("@Thu", SqlDbType.NVarChar);
            parThu.Value = ngay.Thu;
            sqlCommand.Parameters.Add(parThu);

            SqlParameter parNgay = new SqlParameter("@Ngay", SqlDbType.NVarChar);
            parNgay.Value = ngay.Ngay;
            sqlCommand.Parameters.Add(parNgay);

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
        public NgayTrongTuan timNgay_id(string id)
        {
            OpenConnection();
            NgayTrongTuan ngayTrongTuan = new NgayTrongTuan();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select * from ThuVaNgay Where Id = @Id";

            SqlParameter parId = new SqlParameter("@Id", SqlDbType.VarChar);
            parId.Value = id;
            sqlCommand.Parameters.Add(parId);
            sqlCommand.Connection = sqlConnection;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string Id = reader.GetString(0);
                string Thu = reader.GetString(1);
                DateTime Ngay = reader.GetDateTime(2);

                ngayTrongTuan.IdNgay = Id;
                ngayTrongTuan.Thu = Thu;
                ngayTrongTuan.Ngay = Ngay;

            }
            return ngayTrongTuan;
        }
    }
}
