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
    public class LichHocDAL : Database
    {
        public List<LichHoc> ListLichHoc(string ID, int userId)
        {
            List<LichHoc> lichHocs = new List<LichHoc>();
            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From LichHoc where IdNgay = @Id and UserId = @userId";
            cmd.Connection = sqlConnection;

            SqlParameter parIdLich = new SqlParameter("@Id", SqlDbType.VarChar);
            parIdLich.Value = ID;
            cmd.Parameters.Add(parIdLich);
            SqlParameter parUserId = new SqlParameter("@userId", SqlDbType.Int);
            parUserId.Value = userId;
            cmd.Parameters.Add(parUserId);
            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LichHoc lich = new LichHoc();

                int Id = reader.GetInt32(0);
                string BuoiHoc = reader.GetString(1);
                string MonHoc = reader.GetString(2);
                string LopHoc = reader.GetString(3);
                string Tiet = reader.GetString(4);
                string Phong = reader.GetString(5);
                string GiangVien = reader.GetString(6);
                string GhiChu = reader.GetString(7);
                bool TamNgung = reader.GetBoolean(8);



                lich.Id = Id;
                lich.BuoiHoc = BuoiHoc;
                lich.MonHoc = MonHoc;
                lich.LopHoc = LopHoc;
                lich.Tiet = Tiet;
                lich.Phong = Phong;
                lich.GiangVien = GiangVien;
                lich.GhiChu = GhiChu;
                lich.TamNgung = TamNgung;
                lich.IdNgay = ID;
                lich.UserId = userId;
                lichHocs.Add(lich);


            }
            reader.Close();

            
            return lichHocs;
        }

        public bool AddLichHoc(LichHoc lichHoc)
        {
            OpenConnection();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Insert into LichHoc values (@Buoi,@Mon,@Lop,@Tiet,@Phong,@GV,@GhiChu,@TamNgung,@IdNgay,@userId)";

            SqlParameter parBuoi = new SqlParameter("@Buoi", SqlDbType.NVarChar);
            parBuoi.Value = lichHoc.BuoiHoc;
            sqlCommand.Parameters.Add(parBuoi);

            SqlParameter parMon = new SqlParameter("@Mon", SqlDbType.NVarChar);
            parMon.Value = lichHoc.MonHoc;
            sqlCommand.Parameters.Add(parMon);

            SqlParameter parLop = new SqlParameter("@Lop", SqlDbType.NVarChar);
            parLop.Value = lichHoc.LopHoc;
            sqlCommand.Parameters.Add(parLop);

            SqlParameter parTiet = new SqlParameter("@Tiet", SqlDbType.NVarChar);
            parTiet.Value = lichHoc.Tiet;
            sqlCommand.Parameters.Add(parTiet);

            SqlParameter parPhong = new SqlParameter("@Phong", SqlDbType.NVarChar);
            parPhong.Value = lichHoc.Phong;
            sqlCommand.Parameters.Add(parPhong);

            SqlParameter parGV = new SqlParameter("@GV", SqlDbType.NVarChar);
            parGV.Value = lichHoc.GiangVien;
            sqlCommand.Parameters.Add(parGV);
            
            SqlParameter parGhiChu = new SqlParameter("@GhiChu", SqlDbType.NVarChar);
            parGhiChu.Value = lichHoc.GhiChu;
            sqlCommand.Parameters.Add(parGhiChu); 
            
            SqlParameter parTamNgung = new SqlParameter("@TamNgung", SqlDbType.NVarChar);
            parTamNgung.Value = lichHoc.TamNgung;
            sqlCommand.Parameters.Add(parTamNgung);
            
            SqlParameter parIdNgay = new SqlParameter("@IdNgay", SqlDbType.NVarChar);
            parIdNgay.Value = lichHoc.IdNgay;
            sqlCommand.Parameters.Add(parIdNgay);
            SqlParameter parUserid = new SqlParameter("@userId", SqlDbType.Int);
            parUserid.Value = lichHoc.UserId;
            sqlCommand.Parameters.Add(parUserid);

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

        //public bool UpdateLichHoc(LichHoc lichHoc)
        //{
        //    OpenConnection();

        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.CommandType = CommandType.Text;
        //    sqlCommand.CommandText = "Update LichHoc set ThuTrongTuan = @thu,Ngay = @ngay where IdLich = @idLich";

        //    SqlParameter parId = new SqlParameter("@idLich", SqlDbType.VarChar);
        //    parId.Value = lichHoc.IdLich;
        //    sqlCommand.Parameters.Add(parId);

        //    SqlParameter parThu = new SqlParameter("@thu", SqlDbType.NVarChar);
        //    parThu.Value = lichHoc.Thu;
        //    sqlCommand.Parameters.Add(parThu);

        //    SqlParameter parNgay = new SqlParameter("@ngay", SqlDbType.Date);
        //    parNgay.Value = lichHoc.Ngay;
        //    sqlCommand.Parameters.Add(parNgay);
        //    sqlCommand.Connection = sqlConnection;


        //    try
        //    {
        //        int check = sqlCommand.ExecuteNonQuery();
        //        if (check > 0)
        //            return true;
        //    }
        //    catch
        //    {
        //    }
        //    return false;
        //}

        //public bool Delete(LichHoc lichHoc)
        //{
        //    OpenConnection();

        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.CommandType = CommandType.Text;
        //    sqlCommand.CommandText = "Delete LichHoc where IdLich = @idLich";

        //    SqlParameter parId = new SqlParameter("@idLich", SqlDbType.Int);
        //    parId.Value = lichHoc.IdLich;
        //    sqlCommand.Parameters.Add(parId);

        //    try
        //    {
        //        int check = sqlCommand.ExecuteNonQuery();
        //        if (check > 0)
        //            return true;
        //    }
        //    catch
        //    {
        //    }
        //    return false;
        //}

        //public bool isLichHoc(LichHoc lichHoc)
        //{
        //    OpenConnection();

        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.CommandType = CommandType.Text;
        //    sqlCommand.CommandText = "Select * From LichHoc where IdLich = @idLich";

        //    SqlParameter parId = new SqlParameter("@idLich", SqlDbType.Int);
        //    parId.Value = lichHoc.IdLich;
        //    sqlCommand.Parameters.Add(parId);

        //    sqlCommand.Connection = sqlConnection;
        //    SqlDataReader reader = sqlCommand.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        reader.Close();
        //        return true;
        //    }
        //    reader.Close();
        //    return false;
        //}
    }
}
