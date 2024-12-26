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
    public class LichThiDAL : Database
    {
        public List<LichThi> ListLichThi(string ID, int userId)
        {
            List<LichThi> lichThis = new List<LichThi>();
            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From LichThi where IdNgay = @Id And UserId = @userId";
            cmd.Connection = sqlConnection;

            SqlParameter parIdLich = new SqlParameter("@Id", SqlDbType.VarChar);
            parIdLich.Value = ID;
            cmd.Parameters.Add(parIdLich);

            SqlParameter parUserid = new SqlParameter("@userId", SqlDbType.Int);
            parUserid.Value = userId;
            cmd.Parameters.Add(parUserid);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LichThi lich = new LichThi();

                int Id = reader.GetInt32(0);
                string BuoiHoc = reader.GetString(1);
                string MonHoc = reader.GetString(2);
                string LopHoc = reader.GetString(3);
                string Tiet = reader.GetString(4);
                string Phong = reader.GetString(5);
                string GioThi = reader.GetString(6);


                lich.Id = Id;
                lich.BuoiThi = BuoiHoc;
                lich.MonThi = MonHoc;
                lich.Lop = LopHoc;
                lich.Tiet = Tiet;
                lich.Phong = Phong;
                lich.GioThi = GioThi;
                lich.IdNgay = ID;
                lich.UserId = userId;

                lichThis.Add(lich);


            }
            reader.Close();


            return lichThis;
        }
        public bool AddLichThi(LichThi lichThi)
        {
            OpenConnection();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Insert into LichThi values (@Buoi,@Mon,@Lop,@Tiet,@Phong,@GioThi,@IdNgay, @userId)";

            SqlParameter parBuoi = new SqlParameter("@Buoi", SqlDbType.NVarChar);
            parBuoi.Value = lichThi.BuoiThi;
            sqlCommand.Parameters.Add(parBuoi);

            SqlParameter parMon = new SqlParameter("@Mon", SqlDbType.NVarChar);
            parMon.Value = lichThi.MonThi;
            sqlCommand.Parameters.Add(parMon);

            SqlParameter parLop = new SqlParameter("@Lop", SqlDbType.NVarChar);
            parLop.Value = lichThi.Lop;
            sqlCommand.Parameters.Add(parLop);

            SqlParameter parTiet = new SqlParameter("@Tiet", SqlDbType.NVarChar);
            parTiet.Value = lichThi.Tiet;
            sqlCommand.Parameters.Add(parTiet);

            SqlParameter parPhong = new SqlParameter("@Phong", SqlDbType.NVarChar);
            parPhong.Value = lichThi.Phong;
            sqlCommand.Parameters.Add(parPhong);


            SqlParameter parTamNgung = new SqlParameter("@GioThi", SqlDbType.NVarChar);
            parTamNgung.Value = lichThi.GioThi;
            sqlCommand.Parameters.Add(parTamNgung);

            SqlParameter parIdNgay = new SqlParameter("@IdNgay", SqlDbType.NVarChar);
            parIdNgay.Value = lichThi.IdNgay;
            sqlCommand.Parameters.Add(parIdNgay);

            SqlParameter parUserid = new SqlParameter("@userid", SqlDbType.Int);
            parUserid.Value = lichThi.UserId;
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
        //public bool AddLichHoc(LichHoc lichHoc)
        //{
        //    OpenConnection();

        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.CommandType = CommandType.Text;
        //    sqlCommand.CommandText = "Insert into LichHoc values (@Buoi,@Mon,@Lop,@Tiet,@Phong,@GV,@GhiChu,@TamNgung,@IdNgay)";

        //    SqlParameter parBuoi = new SqlParameter("@Buoi", SqlDbType.NVarChar);
        //    parBuoi.Value = lichHoc.BuoiHoc;
        //    sqlCommand.Parameters.Add(parBuoi);

        //    SqlParameter parMon = new SqlParameter("@Mon", SqlDbType.NVarChar);
        //    parMon.Value = lichHoc.MonHoc;
        //    sqlCommand.Parameters.Add(parMon);

        //    SqlParameter parLop = new SqlParameter("@Lop", SqlDbType.NVarChar);
        //    parLop.Value = lichHoc.LopHoc;
        //    sqlCommand.Parameters.Add(parLop);

        //    SqlParameter parTiet = new SqlParameter("@Tiet", SqlDbType.NVarChar);
        //    parTiet.Value = lichHoc.Tiet;
        //    sqlCommand.Parameters.Add(parTiet);

        //    SqlParameter parPhong = new SqlParameter("@Phong", SqlDbType.NVarChar);
        //    parPhong.Value = lichHoc.Phong;
        //    sqlCommand.Parameters.Add(parPhong);

        //    SqlParameter parGV = new SqlParameter("@GV", SqlDbType.NVarChar);
        //    parGV.Value = lichHoc.GiangVien;
        //    sqlCommand.Parameters.Add(parGV);

        //    SqlParameter parGhiChu = new SqlParameter("@GhiChu", SqlDbType.NVarChar);
        //    parGhiChu.Value = lichHoc.GhiChu;
        //    sqlCommand.Parameters.Add(parGhiChu);

        //    SqlParameter parTamNgung = new SqlParameter("@TamNgung", SqlDbType.NVarChar);
        //    parTamNgung.Value = lichHoc.TamNgung;
        //    sqlCommand.Parameters.Add(parTamNgung);

        //    SqlParameter parIdNgay = new SqlParameter("@IdNgay", SqlDbType.NVarChar);
        //    parIdNgay.Value = lichHoc.IdNgay;
        //    sqlCommand.Parameters.Add(parIdNgay);

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
    }
}
