using BLL;
using CefSharp;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using System.IO;
using NAudio.Wave;
using System.Diagnostics;
using System.Linq.Expressions;
using Time;

namespace GUI
{
    public partial class MainForm : Form
    {
        bool isLoginSuccess = false;
        bool sidebarExpand;
        bool homeCollapsed;
        bool thongKe;
        bool lichNhac;
        bool setting;
        int month, year;
        int userId;
        string MSSV;
        private bool isDarkMode = false;
        private Timer timer;
        public static MainForm _instance;
        public event EventHandler DarkModeToggled;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private bool timerStart;
        bool loadLichHoc, loadLichThi, loadLichNhac;

        UserControlLichHocTrongTuan LichHocTrongTuan;
        UserControlThiTrongTuan LichThiTrongTuan;
        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainForm();
                return _instance;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            timer = new Timer();
            timer.Interval = 20000;
            timer.Tick += ThongBaoTimer_tick;
            timer.Start();
            timerStart = true;
            isDarkModeColor();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            LichHocTrongTuan = new UserControlLichHocTrongTuan(userId);
            LichThiTrongTuan = new UserControlThiTrongTuan(userId);

            if (mainForm != null)
            {
                mainForm.DarkModeToggled += MainForm_DarkModeToggled;
            }
        }
        private void MainForm_DarkModeToggled(object sender, EventArgs e)
        {
            isDarkModeColor();
        }
        public MainForm(bool isLogin, int id)
        {
            InitializeComponent();
            this.isLoginSuccess = isLogin;
            this.userId = id;
            timer = new Timer();
            timer.Interval = 20000;
            timer.Tick += ThongBaoTimer_tick;
            timer.Start();
            timerStart = true;
            LichHocTrongTuan = new UserControlLichHocTrongTuan(userId);
            LichThiTrongTuan = new UserControlThiTrongTuan(userId);

            isDarkModeColor();
        }
        public MainForm(bool isLogin, int id, string mssv)
        {
            InitializeComponent();
            this.isLoginSuccess = isLogin;
            this.userId = id;
            this.MSSV = mssv;
            timer = new Timer();
            timer.Interval = 20000;
            timer.Tick += ThongBaoTimer_tick;
            timer.Start();
            timerStart = true;
            isDarkModeColor();
        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapsed)
            {
                pnlHomeContainer.Height += 10;
                if (pnlHomeContainer.Height == pnlHomeContainer.MaximumSize.Height)
                {
                    homeCollapsed = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                pnlHomeContainer.Height -= 10;
                if (pnlHomeContainer.Height == pnlHomeContainer.MinimumSize.Height)
                {
                    homeCollapsed = true;
                    HomeTimer.Stop();
                }

            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();


        }

        private void btnHomeClick(object sender, EventArgs e)
        {
            if (!pnlDesTop.Controls.Contains(UC_ThongTinSV.Instance))
            {
                pnlDesTop.Controls.Add(UC_ThongTinSV.Instance);
                UC_ThongTinSV.Instance.Dock = DockStyle.Fill;
                UC_ThongTinSV.Instance.BringToFront();
            }
            else
            {
                UC_ThongTinSV.Instance.BringToFront();
            }
        }
        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ShowNotification(string summary, string content)
        {
            Timewise.ShowBalloonTip(1000, summary, content, ToolTipIcon.Info);

        }
        private void PlaySound(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    using (var player = new SoundPlayer(filePath))
                    {
                        player.Play();
                    }
                }
                catch
                {
                    //MessageBox.Show("Không thể phát nhạc");
                }
            }
            //else
            //{
            //    //MessageBox.Show("Không thể phát nhạc");
            //}
        }
        private async Task PlaySound2(string filePath)
        {

            try
            {
                if (File.Exists(filePath))
                {
                    if (outputDevice != null)
                    {
                        outputDevice.Stop();
                        outputDevice.Dispose();
                        outputDevice = null;
                    }
                    outputDevice = new WaveOutEvent();
                    audioFile = new AudioFileReader(filePath);
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                }
                else
                {
                    MessageBox.Show("Không thể tìm thấy tệp nhạc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void PlaySound(string filePath)
        //{
        //    string selectedFile = filePath;
        //    using (var audioFile = new AudioFileReader(selectedFile))
        //    {
        //        if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
        //        {
        //            outputDevice.Stop();
        //        }
        //        outputDevice.Init(audioFile);
        //        outputDevice.Play();
        //    }
        //}
        private void ThongKeTimer_Tick(object sender, EventArgs e)
        {
            if (thongKe)
            {
                pnlThongKe.Height += 10;
                if (pnlThongKe.Height == pnlThongKe.MaximumSize.Height)
                {
                    thongKe = false;
                    ThongKeTimer.Stop();
                }
            }
            else
            {
                pnlThongKe.Height -= 10;
                if (pnlThongKe.Height == pnlThongKe.MinimumSize.Height)
                {
                    thongKe = true;
                    ThongKeTimer.Stop();
                }

            }
        }
        private async void ThongBaoTimer_tick(object sender, EventArgs e)
        {
            if (timerStart)
            {
                DateTime now = DateTime.Now;
                EventBLL eventBLL = new EventBLL();
                List<SuKien> suKiens = eventBLL.ListEvent(userId);

                foreach (SuKien suKien in suKiens)
                {
                    var gioPhut = suKien.EventTime.Split(':');
                    int hour = int.Parse(gioPhut[0]);
                    int min = int.Parse(gioPhut[1]);

                    if (suKien.EventDate.Date == now.Date && hour == now.Hour && min == now.Minute)
                    {
                        string summary = suKien.EventName;
                        string content = "Location: " + suKien.Location;
                        try
                        {
                            ShowNotification(summary, content);

                        }
                        catch { }
                        //string filePath = "C:Users\\KhangLap\\Desktop\\WrongTimes.mp3";
                        //PlaySound2(filePath); 
                        //PlaySound2(suKien.RecordingPath);
                        try
                        {
                            await PlaySound2(suKien.RecordingPath);
                            toolStripMenuStopMusic.Visible = true;

                        }
                        catch { }
                        //Gửi mail
                        UserBLL userBLL = new UserBLL();
                        string userEmail = userBLL.GetEmailById(userId);
                        try
                        {
                            if (!string.IsNullOrEmpty(userEmail))
                                SendEmail(userEmail, suKien);
                        }
                        catch { }

                        timer.Stop();

                        await Task.Delay(TimeSpan.FromMinutes(1));

                        timer.Start();

                    }
                }
                await Task.Delay(2000);
            }
        }
        private void SendEmail(string toEmail, SuKien ev)
        {
            //string fromEmail = "pdkhang1304@outlook.com";
            //string password = "13042004k";            
            string fromEmail = "TimeWiseApplication@outlook.com";
            string password = "matkhautimewisever1";
            try
            {
                string host = "smtp.office365.com";
                int port = 587;
                using (MailMessage mail = new MailMessage(fromEmail, toEmail))
                {
                    mail.Subject = ev.EventName;
                    mail.Body = ev.ToString();
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(host, port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(fromEmail, password);
                        smtp.Send(mail);
                    }
                }

                //MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeTimer.Start();

        }

        private void btnLich_Click(object sender, EventArgs e)
        {
            LichTimer.Start();

        }

        private void LichTimer_Tick(object sender, EventArgs e)
        {

            if (lichNhac)
            {
                pnlLich.Height += 10;
                if (pnlLich.Height == pnlLich.MaximumSize.Height)
                {
                    lichNhac = false;
                    LichTimer.Stop();
                }
            }
            else
            {
                pnlLich.Height -= 10;
                if (pnlLich.Height == pnlLich.MinimumSize.Height)
                {
                    lichNhac = true;
                    LichTimer.Stop();
                }

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadLichHoc = false;
            loadLichThi = false;
            User_ThongTinBLL user_ThongTinBLL = new User_ThongTinBLL();
            ThongTinSVBLL thongTinSVBLL = new ThongTinSVBLL();
            var user_ThongTin = user_ThongTinBLL.GetUser_ThongTinById(userId);
            //string mssv = thongTinSVBLL.GetThongTinSVById(user_ThongTin.ThongTinId).MSSV;
            var thongTinSV = thongTinSVBLL.GetThongTinSVById(user_ThongTin.ThongTinId);
            HienThiThongTinSV(thongTinSV);
        }

        private void HienThiThongTinSV(ThongTinSV thongTinSinhVien)
        {
            UC_ThongTinSV ucThongTinSinhVien = new UC_ThongTinSV();
            ucThongTinSinhVien.setAllValues(thongTinSinhVien);
            ucThongTinSinhVien.Dock = DockStyle.Fill;
            ucThongTinSinhVien.BringToFront();
            pnlDesTop.Controls.Add(ucThongTinSinhVien);
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            if (!pnlDesTop.Controls.Contains(LichThiTrongTuan))
                pnlDesTop.Controls.Add(LichThiTrongTuan);
            LichThiTrongTuan.Dock = DockStyle.Fill;
            LichThiTrongTuan.BringToFront();
        }


        private void btnThemLich_Click(object sender, EventArgs e)
        {
            using (FormThemNhacLich fnl = new FormThemNhacLich(userId))
            {

                if (fnl.ShowDialog() == DialogResult.OK)
                {
                    LoadDSSK_ListView();
                    if (!pnlDesTop.Controls.Contains(UC_NhacLich.Instance))
                    {
                        pnlDesTop.Controls.Add(UC_NhacLich.Instance);
                        UC_NhacLich.Instance.Dock = DockStyle.Fill;
                        //UC_NhacLich.Instance.BringToFront();
                    }
                    else
                    {
                        UC_NhacLich.Instance.Reload();
                        //UC_NhacLich.Instance.BringToFront();
                    }
                    fnl.Close();
                }
            }

        }
        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            if (!pnlDesTop.Controls.Contains(UserControlDiemRenLuyen.Instance))
            {
                pnlDesTop.Controls.Add(UserControlDiemRenLuyen.Instance);
                UserControlDiemRenLuyen.Instance.Dock = DockStyle.Fill;
                UserControlDiemRenLuyen.Instance.BringToFront();
            }
            else
            {
                UserControlDiemRenLuyen.Instance.BringToFront();
            }
        }

        private void btnLichToday_Click(object sender, EventArgs e)
        {
            if (!pnlDesTop.Controls.Contains(UserControlLichTheoNgay.Instance))
            {
                pnlDesTop.Controls.Add(UserControlLichTheoNgay.Instance);
                UserControlLichTheoNgay.Instance.Dock = DockStyle.Fill;
                UserControlLichTheoNgay.Instance.BringToFront();
            }
            else
            {
                UserControlLichTheoNgay.Instance.BringToFront();
            }
        }


        private void btnSuKien_Click(object sender, EventArgs e)
        {

        }

        // Load danh sách sự kiện listview
        private void LoadDSSK_ListView()
        {
            if (pnlDesTop.Contains(DanhSachLichNhac_ChinhSua.Instance))
                pnlDesTop.Controls.Remove(DanhSachLichNhac_ChinhSua.Instance);

            DanhSachLichNhac_ChinhSua dsNhacLich = new DanhSachLichNhac_ChinhSua(userId);
            pnlDesTop.Controls.Add(dsNhacLich);
            dsNhacLich.Dock = DockStyle.Fill;
            dsNhacLich.BringToFront();

        }
        private void LoadDSSK_TheoThang()
        {
            if (pnlDesTop.Contains(UC_NhacLich.Instance))
                pnlDesTop.Controls.Remove(UC_NhacLich.Instance);

            UC_NhacLich dsNhacLich = new UC_NhacLich(userId);
            pnlDesTop.Controls.Add(dsNhacLich);
            dsNhacLich.Dock = DockStyle.Fill;
            dsNhacLich.BringToFront();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            LoadDSSK_ListView();
        }

        private void btnDSLN_Click(object sender, EventArgs e)
        {

            LoadDSSK_TheoThang();
            //if (!pnlDesTop.Controls.Contains(UC_NhacLich.Instance))
            //{
            //    pnlDesTop.Controls.Add(UC_NhacLich.Instance);
            //    UC_NhacLich.Instance.Dock = DockStyle.Fill;
            //    UC_NhacLich.Instance.BringToFront();
            //    UC_NhacLich.Instance.userId = userId;
            //}
            //else
            //{
            //    UC_NhacLich.Instance.BringToFront();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_ThongTinBLL user_ThongTinBLL = new User_ThongTinBLL();
            var user_ThongTin = user_ThongTinBLL.GetUser_ThongTinById(userId);
            int id = user_ThongTin.ThongTinId;
            ThongTinSVBLL thongTinSVBLL = new ThongTinSVBLL();
            var thongTinSV = thongTinSVBLL.GetThongTinSVById(id);
            HienThiThongTinSV(thongTinSV);
            if (!pnlDesTop.Controls.Contains(UC_ThongTinSV.Instance))
            {
                pnlDesTop.Controls.Add(UC_ThongTinSV.Instance);
                UC_ThongTinSV.Instance.Dock = DockStyle.Fill;
                UC_ThongTinSV.Instance.setAllValues(thongTinSV);
                UC_ThongTinSV.Instance.BringToFront();
            }
            else
            {
                UC_ThongTinSV.Instance.BringToFront();
                UC_ThongTinSV.Instance.setAllValues(thongTinSV);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isDarkModeColor();
            DanhSachLichNhac_ChinhSua danhSachLichNhac_ChinhSua = Controls.Find("danhSachLichNhac_ChinhSua", true).FirstOrDefault() as DanhSachLichNhac_ChinhSua;
            UC_ThongTinSV ucThongTinSV = Controls.Find("uc_ThongTinSV", true).FirstOrDefault() as UC_ThongTinSV;
            Account account = pnlDesTop.Controls.Find("account", true).FirstOrDefault() as Account;
            UC_LichHoc ucLichHoc = Controls.Find("uc_LichHoc", true).FirstOrDefault() as UC_LichHoc;
            UserControlLichHocTrongTuan userControlLichHocTrongTuan = Controls.Find("userControlLichHocTrongTuan", true).FirstOrDefault() as UserControlLichHocTrongTuan;
            if (ucThongTinSV != null)
            {

                if (isDarkMode)
                    ucThongTinSV.ChangeTextColor(Color.White);

                else
                    ucThongTinSV.ChangeTextColor(Color.FromArgb(33, 25, 41));

            }
            OnDarkModeToggled();
        }
        protected virtual void OnDarkModeToggled()
        {
            DarkModeToggled?.Invoke(this, EventArgs.Empty);
        }
        void isDarkModeColor()
        {
            if (isDarkMode)
            {
                pnlDesTop.BackColor = SystemColors.Control;
                pnlDesTop.ForeColor = Color.Black;
            }
            else
            {
                pnlDesTop.BackColor = Color.FromArgb(31, 31, 31);
                pnlDesTop.ForeColor = Color.White;
            }
            isDarkMode = !isDarkMode;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Timewise.ShowBalloonTip(1000);
        }

        private void toolStripMenuStopMusic_Click(object sender, EventArgs e)
        {
            outputDevice.Stop();
            toolStripMenuStopMusic.Visible = false;
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide(); 
                Timewise.BalloonTipTitle = "Application Minimized";
                Timewise.BalloonTipText = "Ứng dụng vẫn đang chạy trong nền!";
                Timewise.BalloonTipIcon = ToolTipIcon.Warning;
                Timewise.ShowBalloonTip(1000);
            }
        }

        private void SettingTimer_Tick(object sender, EventArgs e)
        {
            if (setting)
            {
                pnlSetting.Height += 10;
                if (pnlSetting.Height == pnlSetting.MaximumSize.Height)
                {
                    setting = false;
                    SettingTimer.Stop();
                }
            }
            else
            {
                pnlSetting.Height -= 10;
                if (pnlSetting.Height == pnlSetting.MinimumSize.Height)
                {
                    setting = true;
                    SettingTimer.Stop();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SettingTimer.Start();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            User_ThongTinBLL userTTBLL = new User_ThongTinBLL();
            ThongTinSVBLL thongTinSVBLL = new ThongTinSVBLL();
            User user = userBLL.GetUserById(userId);

            var userThongTin = userTTBLL.GetUser_ThongTinById(userId);
            var thongTinSV = thongTinSVBLL.GetThongTinSVById(userThongTin.ThongTinId);
            Account account = new Account(user, thongTinSV);
            pnlDesTop.Controls.Add(account);
            account.Dock = DockStyle.Fill;
            account.BringToFront();
        }


        private void btnLichHoc_Click_1(object sender, EventArgs e)
        {
            if (!pnlDesTop.Controls.Contains(LichHocTrongTuan))
                pnlDesTop.Controls.Add(LichHocTrongTuan);
            LichHocTrongTuan.Dock = DockStyle.Fill;
            LichHocTrongTuan.BringToFront();
        }


    }
}