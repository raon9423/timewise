using BLL;
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
    public partial class UserControlThiTrongTuan : UserControl
    {
        private int soTuan = 0;
        int userId;

        public UserControlThiTrongTuan()
        {
            InitializeComponent();
        }
        public UserControlThiTrongTuan(int uid)
        {
            InitializeComponent();
            userId = uid;

        }

        private void UserControlThiTrongTuan_Load(object sender, EventArgs e)
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
                flpBuoi.Controls.Add(uc_Ngay);
                if (ngayTrongTuan.Ngay == DateTime.Today)
                    uc_Ngay.SetBackground(Color.LightBlue);
                ngay = ngay.AddDays(1);
                listNgay.Add(ngayTrongTuan);
            }

            foreach (var lh in listNgay)
            {
                LichThiBLL lichThiBLL = new LichThiBLL();
                List<LichThi> lichThis = lichThiBLL.DS_LichThi(lh.IdNgay, userId);
                UC_LichHoc uc_LichHocSang = new UC_LichHoc();
                UC_LichHoc uc_LichHocChieu = new UC_LichHoc();
                UC_LichHoc uc_LichHocToi = new UC_LichHoc();
                uc_LichHocSang.BackColor = Color.Blue;
                flpSang.Controls.Add(uc_LichHocSang);
                uc_LichHocChieu.BackColor = Color.Blue;
                flpChieu.Controls.Add(uc_LichHocChieu);
                uc_LichHocToi.BackColor = Color.Blue;
                flpToi.Controls.Add(uc_LichHocToi);
                if (lichThis.Count > 0)
                    foreach (var lichThi in lichThis)
                    {
                        if (lichThi.BuoiThi == "Sáng")
                        {
                            UserControlLichHoc usclh = new UserControlLichHoc();
                            uc_LichHocSang.flpLich.Controls.Add(usclh);
                            usclh.BackColor = Color.White;
                            usclh.txtMon.Text = lichThi.MonThi;
                            usclh.txtChiTiet.Text = "Lớp\t: " + lichThi.Lop.Split('-')[0] +
                                "\r\n" + "Tiết\t: " + lichThi.Tiet + "\r\n" + "Phòng\t: " + lichThi.Phong +
                                "\r\n" + "Giờ thi\t: " + lichThi.GioThi;
                        }
                        else if (lichThi.BuoiThi == "Chiều")
                        {
                            UserControlLichHoc usclh = new UserControlLichHoc();
                            uc_LichHocChieu.flpLich.Controls.Add(usclh);
                            usclh.BackColor = Color.White;
                            usclh.txtMon.Text = lichThi.MonThi;
                            usclh.txtChiTiet.Text = "Lớp\t: " + lichThi.Lop.Split('-')[0] +
                                "\r\n" + "Tiết\t: " + lichThi.Tiet + "\r\n" + "Phòng\t: " + lichThi.Phong +
                                "\r\n" + "Giờ thi\t: " + lichThi.GioThi;
                        }
                        else if (lichThi.BuoiThi == "Tối")
                        {
                            UserControlLichHoc usclh = new UserControlLichHoc();
                            uc_LichHocToi.flpLich.Controls.Add(usclh);
                            usclh.BackColor = Color.White;
                            usclh.txtMon.Text = lichThi.MonThi;
                            usclh.txtChiTiet.Text = "Lớp\t: " + lichThi.Lop.Split('-')[0] +
                                "\r\n" + "Tiết\t: " + lichThi.Tiet + "\r\n" + "Phòng\t: " + lichThi.Phong +
                                "\r\n" + "Giờ thi\t: " + lichThi.GioThi;
                        }
                    }

            }

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

            pnlLichHocSang.Size = new Size(0, 0);
            pnlLichHocChieu.Size = new Size(0, 0);
            pnlLichHocToi.Size = new Size(0, 0);

            flpSang.Size = new Size(0, 0);
            flpChieu.Size = new Size(0, 0);
            flpToi.Size = new Size(0, 0);
            displayDays(DateTime.Now.AddDays(soTuan * 7));
        }

    }
}
