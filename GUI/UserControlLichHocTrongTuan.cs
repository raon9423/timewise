using BLL;
using CefSharp.DevTools.Audits;
using DAL;
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
using Time;

namespace GUI
{
    public partial class UserControlLichHocTrongTuan : UserControl
    {
        public int soTuan = 0;
        public int userId = 0;
        public int UID;


        public UserControlLichHocTrongTuan()
        {
            InitializeComponent();
        }

        public UserControlLichHocTrongTuan(int uid)
        {
            InitializeComponent();
            userId = uid;
            UID = uid;
        }
        public void ChangeTextColor(Color color)
        {
            this.ForeColor = color;
        }
        private void UserControlLichHocTrongTuan_Load(object sender, EventArgs e)
        {
            displayDays();

        }

        private void displayDays(DateTime ngay = default)
        {
            if (ngay == default)
                ngay = DateTime.Now;
            var dayOfWeek = ngay.DayOfWeek;
            if (dayOfWeek != DayOfWeek.Monday)
                while (ngay.DayOfWeek != DayOfWeek.Monday)
                    ngay = ngay.AddDays(-1);
            NgayTrongTuanBLL ngayTrongTuanBLL = new NgayTrongTuanBLL();
            var listNgay = new List<NgayTrongTuan>();

            for (int i = 1; i <= 7; i++)
            {
                string id = ngay.ToShortDateString().Replace("/", "");
                NgayTrongTuan ngayTrongTuan = ngayTrongTuanBLL.timNgay_id(id);
                UC_Ngay uc_Ngay = new UC_Ngay();
                uc_Ngay.BackColor = Color.White;
                uc_Ngay.txtThu.Text = ngayTrongTuan.Thu;
                uc_Ngay.txtNgay.Text = ngayTrongTuan.Ngay.ToString("dd/MM/yyyy");
                if (ngayTrongTuan.Ngay == DateTime.Today)
                    uc_Ngay.SetBackground(Color.LightBlue);
                flpBuoi.Controls.Add(uc_Ngay);
                ngay = ngay.AddDays(1);
                listNgay.Add(ngayTrongTuan);
            }

            foreach (var lh in listNgay)
            {
                LichHocBLL lichHocBLL = new LichHocBLL();
                List<LichHoc> lichHocs = lichHocBLL.ListLichHoc(lh.IdNgay,UID);
                UC_LichHoc uc_LichHocSang = new UC_LichHoc();
                UC_LichHoc uc_LichHocChieu = new UC_LichHoc();
                UC_LichHoc uc_LichHocToi = new UC_LichHoc();
                flpSang.Controls.Add(uc_LichHocSang);
                flpChieu.Controls.Add(uc_LichHocChieu);
                flpToi.Controls.Add(uc_LichHocToi);
                if (lichHocs.Count > 0)
                    foreach (LichHoc lichHoc in lichHocs)
                    {
                        if (lichHoc.BuoiHoc == "Sáng")
                        {
                            UserControlLichHoc usclh = new UserControlLichHoc();
                            uc_LichHocSang.flpLich.Controls.Add(usclh);
                            usclh.BackColor = Color.White;
                            usclh.txtMon.Text = lichHoc.MonHoc;
                            usclh.txtChiTiet.Text = "Lớp\t: " + lichHoc.LopHoc.Split('-')[0] +
                                "\r\n" + "Tiết\t: " + lichHoc.Tiet + "\r\n" + "Phòng\t: " + lichHoc.Phong +
                                "\r\n" + "GV\t: " + lichHoc.GiangVien + "\r\n" + "Ghi chú\t: " + lichHoc.GhiChu;
                        }
                        else if (lichHoc.BuoiHoc == "Chiều")
                        {
                            UserControlLichHoc usclh = new UserControlLichHoc();
                            uc_LichHocChieu.flpLich.Controls.Add(usclh);
                            usclh.BackColor = Color.White;
                            usclh.txtMon.Text = lichHoc.MonHoc;
                            usclh.txtChiTiet.Text = "Lớp\t: " + lichHoc.LopHoc.Split('-')[0] +
                                "\r\n" + "Tiết\t: " + lichHoc.Tiet + "\r\n" + "Phòng\t: " + lichHoc.Phong +
                                "\r\n" + "GV\t: " + lichHoc.GiangVien + "\r\n" + "Ghi chú\t: " + lichHoc.GhiChu;
                        }
                        else if (lichHoc.BuoiHoc == "Tối")
                        {
                            UserControlLichHoc usclh = new UserControlLichHoc();
                            usclh.BackColor = Color.White;
                            usclh.txtMon.Text = lichHoc.MonHoc;
                            usclh.txtChiTiet.Text = "Lớp\t: " + lichHoc.LopHoc.Split('-')[0] +
                                "\r\n" + "Tiết\t: " + lichHoc.Tiet + "\r\n" + "Phòng\t: " + lichHoc.Phong +
                                "\r\n" + "GV\t: " + lichHoc.GiangVien + "\r\n" + "Ghi chú\t: " + lichHoc.GhiChu;
                        }
                    }

            }


        }


        private void lbLichHoc_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            soTuan++;
            if (soTuan == 9) btnNext.Visible = false;
            if (!btnPrevious.Visible)
                if (soTuan > 0) btnPrevious.Visible = true;
            flpBuoi.Controls.Clear();
            flpSang.Controls.Clear();
            flpChieu.Controls.Clear();
            flpToi.Controls.Clear();
            flpSang.Size = new Size(0, 0);
            flpChieu.Size = new Size(0, 0);
            flpToi.Size = new Size(0, 0);
            pnlLichHocSang.Size = new Size(0, 0);
            pnlLichHocChieu.Size = new Size(0, 0);
            pnlLichHocToi.Size = new Size(0, 0);
            displayDays(DateTime.Now.AddDays(soTuan * 7));
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            soTuan--;
            if (soTuan == 0) btnPrevious.Visible = false;
            if (!btnNext.Visible)
                if (soTuan < 2) btnNext.Visible = true;
            flpBuoi.Controls.Clear();
            flpSang.Controls.Clear();
            flpChieu.Controls.Clear();
            flpToi.Controls.Clear();
            flpSang.Size = new Size(0, 0);
            flpChieu.Size = new Size(0, 0);
            flpToi.Size = new Size(0, 0);
            pnlLichHocSang.Size = new Size(0, 0);
            pnlLichHocChieu.Size = new Size(0, 0);
            pnlLichHocToi.Size = new Size(0, 0);
            displayDays(DateTime.Now.AddDays(soTuan * 7));
        }
    }
}
