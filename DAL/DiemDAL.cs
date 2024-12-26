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
    public class DiemDAL : Database
    {
        public List<Diem> DS_Diem()
        {
            List<Diem> diems = new List<Diem>();
            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Diem";
            cmd.Connection = sqlConnection;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int SoThuTu = reader.GetInt32(0);
                string MaMonHoc = reader.GetString(1);
                string TenMonHoc = reader.GetString(2);
                int SoTinChi = reader.GetInt32(3);
                double DiemChuyenCan = reader.GetDouble(4);
                double DiemHeSo11 = reader.GetDouble(5);
                double DiemHeSo12 = reader.GetDouble(6);
                double DiemHeSo13 = reader.GetDouble(7);
                double DiemTieuLuan = reader.GetDouble(8);
                double DiemThucHanh1 = reader.GetDouble(9);
                double DiemThucHanh2 = reader.GetDouble(10);
                double DiemThucHanh3 = reader.GetDouble(11);
                double DiemThi = reader.GetDouble(12);
                double DiemTongKet = reader.GetDouble(13);
                double DiemTinChi = reader.GetDouble(14);
                string DiemChu = reader.GetString(15);
                string GhiChu = reader.GetString(16);
                string GhiChuXetDuThi = reader.GetString(17);
                string GhiChu_CK = reader.GetString(18);

                Diem diem = new Diem();
                diem.SoThuTu = SoThuTu;
                diem.MaMonHoc = MaMonHoc;
                diem.TenMonHoc = TenMonHoc;
                diem.SoTinChi = SoTinChi;
                diem.DiemChuyenCan = DiemChuyenCan;
                diem.DiemHeSo11 = DiemHeSo11;
                diem.DiemHeSo12 = DiemHeSo12;
                diem.DiemHeSo13 = DiemHeSo13;
                diem.DiemTieuLuan = DiemTieuLuan;
                diem.DiemThucHanh1 = DiemThucHanh1;
                diem.DiemThucHanh2 = DiemThucHanh2;
                diem.DiemThucHanh3 = DiemThucHanh3;
                diem.DiemThi = DiemThi;
                diem.DiemTongKet = DiemTongKet;
                diem.DiemTinChi = DiemTinChi;
                diem.DiemChu = DiemChu;
                diem.GhiChu = GhiChu;
                diem.GhiChuXetDuThi = GhiChuXetDuThi;
                diem.GhiChu_CK = GhiChu_CK;

                diems.Add(diem);
            }
            reader.Close();
            return diems;
        }

        public bool AddDiem(Diem diem)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Insert into Diem VALUES (@MaMonHoc, @TenMonHoc, @SoTinChi, @DiemChuyenCan, @DiemHeSo11, @DiemHeSo12, @DiemHeSo13, @DiemTieuLuan, @DiemThucHanh1, @DiemThucHanh2, @DiemThucHanh3, @DiemThi, @DiemTongKet, @DiemTinChi, @DiemChu, @GhiChu)";

            sqlCommand.Parameters.AddWithValue("@MaMonHoc", diem.MaMonHoc);
            sqlCommand.Parameters.AddWithValue("@TenMonHoc", diem.TenMonHoc);
            sqlCommand.Parameters.AddWithValue("@SoTinChi", diem.SoTinChi);
            sqlCommand.Parameters.AddWithValue("@DiemChuyenCan", diem.DiemChuyenCan);
            sqlCommand.Parameters.AddWithValue("@DiemHeSo11", diem.DiemHeSo11);
            sqlCommand.Parameters.AddWithValue("@DiemHeSo12", diem.DiemHeSo12);
            sqlCommand.Parameters.AddWithValue("@DiemHeSo13", diem.DiemHeSo13);
            sqlCommand.Parameters.AddWithValue("@DiemTieuLuan", diem.DiemTieuLuan);
            sqlCommand.Parameters.AddWithValue("@DiemThucHanh1", diem.DiemThucHanh1);
            sqlCommand.Parameters.AddWithValue("@DiemThucHanh2", diem.DiemThucHanh2);
            sqlCommand.Parameters.AddWithValue("@DiemThucHanh3", diem.DiemThucHanh3);
            sqlCommand.Parameters.AddWithValue("@DiemThi", diem.DiemThi);
            sqlCommand.Parameters.AddWithValue("@DiemTongKet", diem.DiemTongKet);
            sqlCommand.Parameters.AddWithValue("@DiemTinChi", diem.DiemTinChi);
            sqlCommand.Parameters.AddWithValue("@DiemChu", diem.DiemChu);
            sqlCommand.Parameters.AddWithValue("@GhiChu", diem.GhiChu);



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
        public bool RemoveAll()
        {
            return false;
        }
    }
}
// làm đi bạn