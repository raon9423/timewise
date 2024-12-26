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
    public class ThongTinSVDAL : Database
    {
        public List<ThongTinSV> GetAllThongTinSV()
        {
            List<ThongTinSV> thongTinSVs = new List<ThongTinSV>();

            using (sqlConnection)
            {
                OpenConnection();
                string query = "SELECT * FROM ThongTinSV";
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = sqlConnection;
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongTinSV sv = new ThongTinSV();
                        sv.MSSV = reader["MSSV"].ToString();
                        sv.HoTen = reader["HoTen"].ToString();
                        sv.GioiTinh = reader["GioiTinh"].ToString();
                        sv.TrangThai = reader["TrangThai"].ToString();
                        sv.MaHoSo = reader["MaHoSo"].ToString();
                        sv.NgayVaoTruong = Convert.ToDateTime(reader["NgayVaoTruong"]);
                        sv.LopHoc = reader["LopHoc"].ToString();
                        sv.CoSo = reader["CoSo"].ToString();
                        sv.BacDaoTao = reader["BacDaoTao"].ToString();
                        sv.LoaiHinhDaoTao = reader["LoaiHinhDaoTao"].ToString();
                        sv.Khoa = reader["Khoa"].ToString();
                        sv.Nganh = reader["Nganh"].ToString();
                        sv.ChuyenNganh = reader["ChuyenNganh"].ToString();
                        sv.KhoaHoc = reader["KhoaHoc"].ToString();
                        sv.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        sv.DanToc = reader["DanToc"].ToString();
                        sv.TonGiao = reader["TonGiao"].ToString();
                        sv.KhuVuc = reader["KhuVuc"].ToString();
                        sv.SoCCCD = reader["SoCCCD"].ToString();
                        sv.NgayCapCCCD = Convert.ToDateTime(reader["NgayCapCCCD"]);
                        sv.NoiCapCCCD = reader["NoiCapCCCD"].ToString();
                        sv.DoiTuong = reader["DoiTuong"].ToString();
                        sv.NgayVaoDoan = Convert.ToDateTime(reader["NgayVaoDoan"]);
                        sv.NgayVaoDang = Convert.ToDateTime(reader["NgayVaoDang"]);
                        sv.DienThoai = reader["DienThoai"].ToString();
                        sv.Email = reader["Email"].ToString();
                        sv.EmailNTT = reader["EmailNTT"].ToString();
                        sv.MatKhauEmailNTT = reader["MatKhauEmailNTT"].ToString();
                        sv.DiaChiLienHe = reader["DiaChiLienHe"].ToString();
                        sv.NoiSinh = reader["NoiSinh"].ToString();
                        sv.HoKhauThuongTru = reader["HoKhauThuongTru"].ToString();

                        thongTinSVs.Add(sv);
                    }
                }
            }

            return thongTinSVs;
        }
        
        public bool AddThongTinSV(ThongTinSV sv)
        {
            using (sqlConnection)
            {
                OpenConnection();
                string query = "INSERT INTO ThongTinSV (MSSV, HoTen, GioiTinh, TrangThai, MaHoSo, NgayVaoTruong, LopHoc, CoSo, BacDaoTao, LoaiHinhDaoTao, Khoa, Nganh, ChuyenNganh, KhoaHoc, NgaySinh, DanToc, TonGiao, KhuVuc, SoCCCD, NgayCapCCCD, NoiCapCCCD, DoiTuong, NgayVaoDoan, NgayVaoDang, DienThoai, Email, EmailNTT, MatKhauEmailNTT, DiaChiLienHe, NoiSinh, HoKhauThuongTru) VALUES (@MSSV, @HoTen, @GioiTinh, @TrangThai, @MaHoSo, @NgayVaoTruong, @LopHoc, @CoSo, @BacDaoTao, @LoaiHinhDaoTao, @Khoa, @Nganh, @ChuyenNganh, @KhoaHoc, @NgaySinh, @DanToc, @TonGiao, @KhuVuc, @SoCCCD, @NgayCapCCCD, @NoiCapCCCD, @DoiTuong, @NgayVaoDoan, @NgayVaoDang, @DienThoai, @Email, @EmailNTT, @MatKhauEmailNTT, @DiaChiLienHe, @NoiSinh, @HoKhauThuongTru)";
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = sqlConnection;

                command.Parameters.AddWithValue("@MSSV", sv.MSSV);
                command.Parameters.AddWithValue("@HoTen", sv.HoTen);
                command.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                command.Parameters.AddWithValue("@TrangThai", sv.TrangThai);
                command.Parameters.AddWithValue("@MaHoSo", sv.MaHoSo);
                command.Parameters.AddWithValue("@NgayVaoTruong", sv.NgayVaoTruong.Date);
                command.Parameters.AddWithValue("@LopHoc", sv.LopHoc);
                command.Parameters.AddWithValue("@CoSo", sv.CoSo);
                command.Parameters.AddWithValue("@BacDaoTao", sv.BacDaoTao);
                command.Parameters.AddWithValue("@LoaiHinhDaoTao", sv.LoaiHinhDaoTao);
                command.Parameters.AddWithValue("@Khoa", sv.Khoa);
                command.Parameters.AddWithValue("@Nganh", sv.Nganh);
                command.Parameters.AddWithValue("@ChuyenNganh", sv.ChuyenNganh);
                command.Parameters.AddWithValue("@KhoaHoc", sv.KhoaHoc);
                DateTime date = sv.NgaySinh.Date == default ? new DateTime(1753, 1, 1) : sv.NgaySinh.Date;
                command.Parameters.AddWithValue("@NgaySinh", date);
                command.Parameters.AddWithValue("@DanToc", sv.DanToc);
                command.Parameters.AddWithValue("@TonGiao", sv.TonGiao);
                command.Parameters.AddWithValue("@KhuVuc", sv.KhuVuc);
                command.Parameters.AddWithValue("@SoCCCD", sv.SoCCCD);
                date = sv.NgayCapCCCD.Date == default ? new DateTime(1753, 1, 1) : sv.NgayCapCCCD.Date;
                command.Parameters.AddWithValue("@NgayCapCCCD", date);
                command.Parameters.AddWithValue("@NoiCapCCCD", sv.NoiCapCCCD == null ? "" : sv.NoiCapCCCD);
                command.Parameters.AddWithValue("@DoiTuong", sv.DoiTuong);
                date = sv.NgayVaoDoan.Date == default ? new DateTime(1753,1,1) : sv.NgayVaoDoan.Date;
                command.Parameters.AddWithValue("@NgayVaoDoan", date);
                date = sv.NgayVaoDang.Date == default ? new DateTime(1753, 1, 1) : sv.NgayVaoDang.Date;
                command.Parameters.AddWithValue("@NgayVaoDang", date );
                command.Parameters.AddWithValue("@DienThoai", sv.DienThoai);
                command.Parameters.AddWithValue("@Email", sv.Email);
                command.Parameters.AddWithValue("@EmailNTT", sv.EmailNTT);
                command.Parameters.AddWithValue("@MatKhauEmailNTT", sv.MatKhauEmailNTT);
                command.Parameters.AddWithValue("@DiaChiLienHe", sv.DiaChiLienHe);
                command.Parameters.AddWithValue("@NoiSinh", sv.NoiSinh);
                command.Parameters.AddWithValue("@HoKhauThuongTru", sv.HoKhauThuongTru);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public ThongTinSV GetThongTinByMSVV(string mssv)
        {
            ThongTinSV sv = new ThongTinSV();
            using (sqlConnection)
            {
                OpenConnection();
                string query = "Select top 1 * from ThongTinSV where MSSV = @mssv";
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = sqlConnection;
                command.Parameters.AddWithValue("@mssv", mssv);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sv.Id =Convert.ToInt32(reader["Id"].ToString());
                        sv.MSSV = reader["MSSV"].ToString();
                        sv.HoTen = reader["HoTen"].ToString();
                        sv.GioiTinh = reader["GioiTinh"].ToString();
                        sv.TrangThai = reader["TrangThai"].ToString();
                        sv.MaHoSo = reader["MaHoSo"].ToString();
                        sv.NgayVaoTruong = Convert.ToDateTime(reader["NgayVaoTruong"]);
                        sv.LopHoc = reader["LopHoc"].ToString();
                        sv.CoSo = reader["CoSo"].ToString();
                        sv.BacDaoTao = reader["BacDaoTao"].ToString();
                        sv.LoaiHinhDaoTao = reader["LoaiHinhDaoTao"].ToString();
                        sv.Khoa = reader["Khoa"].ToString();
                        sv.Nganh = reader["Nganh"].ToString();
                        sv.ChuyenNganh = reader["ChuyenNganh"].ToString();
                        sv.KhoaHoc = reader["KhoaHoc"].ToString();
                        sv.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        sv.DanToc = reader["DanToc"].ToString();
                        sv.TonGiao = reader["TonGiao"].ToString();
                        sv.KhuVuc = reader["KhuVuc"].ToString();
                        sv.SoCCCD = reader["SoCCCD"].ToString();
                        sv.NgayCapCCCD = Convert.ToDateTime(reader["NgayCapCCCD"]);
                        sv.NoiCapCCCD = reader["NoiCapCCCD"].ToString();
                        sv.DoiTuong = reader["DoiTuong"].ToString();
                        sv.NgayVaoDoan = Convert.ToDateTime(reader["NgayVaoDoan"]);
                        sv.NgayVaoDang = Convert.ToDateTime(reader["NgayVaoDang"]);
                        sv.DienThoai = reader["DienThoai"].ToString();
                        sv.Email = reader["Email"].ToString();
                        sv.EmailNTT = reader["EmailNTT"].ToString();
                        sv.MatKhauEmailNTT = reader["MatKhauEmailNTT"].ToString();
                        sv.DiaChiLienHe = reader["DiaChiLienHe"].ToString();
                        sv.NoiSinh = reader["NoiSinh"].ToString();
                        sv.HoKhauThuongTru = reader["HoKhauThuongTru"].ToString();
                    }
                }
            }
            return sv;
        }

        public ThongTinSV GetThongTinById(int id)
        {
            ThongTinSV sv = new ThongTinSV();
            using (sqlConnection)
            {
                OpenConnection();
                string query = "Select top 1 * from ThongTinSV where Id = @id";
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = sqlConnection;
                command.Parameters.AddWithValue("@id", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sv.Id = Convert.ToInt32(reader["Id"].ToString());
                        sv.MSSV = reader["MSSV"].ToString();
                        sv.HoTen = reader["HoTen"].ToString();
                        sv.GioiTinh = reader["GioiTinh"].ToString();
                        sv.TrangThai = reader["TrangThai"].ToString();
                        sv.MaHoSo = reader["MaHoSo"].ToString();
                        sv.NgayVaoTruong = Convert.ToDateTime(reader["NgayVaoTruong"]);
                        sv.LopHoc = reader["LopHoc"].ToString();
                        sv.CoSo = reader["CoSo"].ToString();
                        sv.BacDaoTao = reader["BacDaoTao"].ToString();
                        sv.LoaiHinhDaoTao = reader["LoaiHinhDaoTao"].ToString();
                        sv.Khoa = reader["Khoa"].ToString();
                        sv.Nganh = reader["Nganh"].ToString();
                        sv.ChuyenNganh = reader["ChuyenNganh"].ToString();
                        sv.KhoaHoc = reader["KhoaHoc"].ToString();
                        sv.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        sv.DanToc = reader["DanToc"].ToString();
                        sv.TonGiao = reader["TonGiao"].ToString();
                        sv.KhuVuc = reader["KhuVuc"].ToString();
                        sv.SoCCCD = reader["SoCCCD"].ToString();
                        sv.NgayCapCCCD = Convert.ToDateTime(reader["NgayCapCCCD"]);
                        sv.NoiCapCCCD = reader["NoiCapCCCD"].ToString();
                        sv.DoiTuong = reader["DoiTuong"].ToString();
                        sv.NgayVaoDoan = Convert.ToDateTime(reader["NgayVaoDoan"]);
                        sv.NgayVaoDang = Convert.ToDateTime(reader["NgayVaoDang"]);
                        sv.DienThoai = reader["DienThoai"].ToString();
                        sv.Email = reader["Email"].ToString();
                        sv.EmailNTT = reader["EmailNTT"].ToString();
                        sv.MatKhauEmailNTT = reader["MatKhauEmailNTT"].ToString();
                        sv.DiaChiLienHe = reader["DiaChiLienHe"].ToString();
                        sv.NoiSinh = reader["NoiSinh"].ToString();
                        sv.HoKhauThuongTru = reader["HoKhauThuongTru"].ToString();
                    }
                }
            }
            return sv;
        }
    }
}
