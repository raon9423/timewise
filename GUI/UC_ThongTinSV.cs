using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_ThongTinSV : UserControl
    {
        public static UC_ThongTinSV _instance;
        public static UC_ThongTinSV Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ThongTinSV();
                return _instance;
            }
        }
        public UC_ThongTinSV()
        {
            InitializeComponent();
        }

        public void ChangeTextColor(Color color)
        {
            this.ForeColor = color;
        }


        public void setAllValues(ThongTinSV sinhVien)
        {
            lblMSSV.Text = sinhVien.MSSV;
            lblHoTen.Text = sinhVien.HoTen;
            lblGioiTinh.Text = sinhVien.GioiTinh;
            lblTrangThai.Text = sinhVien.TrangThai;
            lblMaHoSo.Text = sinhVien.MaHoSo;
            lblNgayVaoTruong.Text = sinhVien.NgayVaoTruong.ToString("dd/MM/yyyy");
            lblLopHoc.Text = sinhVien.LopHoc;
            lblCoSo.Text = sinhVien.CoSo;
            lblBacDaoTao.Text = sinhVien.BacDaoTao;
            lblLoaiHinhDaoTao.Text = sinhVien.LoaiHinhDaoTao;
            lblKhoa.Text = sinhVien.Khoa;
            lblNganh.Text = sinhVien.Nganh;
            lblChuyenNganh.Text = sinhVien.ChuyenNganh;
            lblKhoaHoc.Text = sinhVien.KhoaHoc;
            lblNgaySinh.Text = sinhVien.NgaySinh.ToString("dd/MM/yyyy");
            lblDanToc.Text = sinhVien.DanToc;
            lblTonGiao.Text = sinhVien.TonGiao;
            lblKhuVuc.Text = sinhVien.KhuVuc;
            lblCCCD.Text = sinhVien.SoCCCD;
            lblNgayCap.Text = sinhVien.NgayCapCCCD.ToString("dd/MM/yyyy");
            lblNoiCap.Text = sinhVien.NoiCapCCCD;
            lblDoiTuong.Text = sinhVien.DoiTuong;
            lblNgayVaoDoan.Text = sinhVien.NgayVaoDoan.ToString("dd/MM/yyyy");
            lblNgayVaoDang.Text = sinhVien.NgayVaoDang.ToString("dd/MM/yyyy");
            lblDienThoai.Text = sinhVien.DienThoai;
            lblEmail.Text = sinhVien.Email;
            lblEmailNtt.Text = sinhVien.EmailNTT;
            lblMatKhau.Text = sinhVien.MatKhauEmailNTT;
            lblDiaChiLienHe.Text = sinhVien.DiaChiLienHe;
            lblNoiSinh.Text = sinhVien.NoiSinh;
            lblHoKhauThuongTru.Text = sinhVien.HoKhauThuongTru;
        }

        private void lblTrangThai_Click(object sender, EventArgs e)
        {

        }

        private void lblMaHoSo_Click(object sender, EventArgs e)
        {

        }

        private void lblNgayVaoTruong_Click(object sender, EventArgs e)
        {

        }

        private void lblLopHoc_Click(object sender, EventArgs e)
        {

        }

        private void lblCoSo_Click(object sender, EventArgs e)
        {

        }

        private void lblBacDaoTao_Click(object sender, EventArgs e)
        {

        }

        private void lblLoaiHinhDaoTao_Click(object sender, EventArgs e)
        {

        }

        private void lblKhoa_Click(object sender, EventArgs e)
        {

        }

        private void lblNganh_Click(object sender, EventArgs e)
        {

        }

        private void lblKhoaHoc_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblHoKhauThuongTru_Click(object sender, EventArgs e)
        {

        }
    }
}
