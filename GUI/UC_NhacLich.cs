using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class UC_NhacLich : UserControl
    {
        private Timer countdownTimer;
        private DateTime targetDateTime;
        int month, year;
        public int userId;
        public static UC_NhacLich _instance;

        public static UC_NhacLich Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_NhacLich();
                return _instance;
            }
        }
        public UC_NhacLich()
        {
            InitializeComponent();
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            InitializeCountdownTimer();
            StartCountdown(DateTime.Now.AddDays(1)); // Ví dụ: Đếm ngược đến ngày tiếp theo
        }
        public UC_NhacLich(int uid)
        {
            InitializeComponent();
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            InitializeCountdownTimer();
            StartCountdown(DateTime.Now.AddDays(1)); // Ví dụ: Đếm ngược đến ngày tiếp theo
            this.userId = uid;
        }

        private void InitializeCountdownTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick;
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = targetDateTime - DateTime.Now;
            //LBCountdown.Text = remainingTime.ToString("dd' ngày 'hh':'mm':'ss");
        }

        private void StartCountdown(DateTime targetTime)
        {
            targetDateTime = targetTime;
            countdownTimer.Start();
            CountdownTimer_Tick(null, EventArgs.Empty); 
        }

        private void StopCountdown()
        {
            countdownTimer.Stop();
        }

        public void Reload()
        {
            daycontainer.Controls.Clear();
            displayDays();
        }

        private void UC_NhacLich_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            if (month > 12)
            {
                month = 1;
                year += 1;
            }
            displayDays();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month -= 1;
            if (month < 1)
            {
                month = 12;
                year -= 1;
            }
            displayDays();
        }
        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        private void daycontainer_Paint(object sender, PaintEventArgs e)
        {

        }
        private void displayDays()
        {
            DateTime currentDate = DateTime.Now;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            DateTime startofthemonth = new DateTime(year, month, 1);
            LBDATE.Text = startofthemonth.ToString("MMMM yyyy");
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek - 1; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                string strDay = month + "/" + i + "/" + this.year;
                DateTime day = Convert.ToDateTime(strDay);
                EventBLL eventBLL = new EventBLL();
                var evs = eventBLL.SuKienTheoNgay(day,userId);
                UC_SuKienNgay ucdays = new UC_SuKienNgay();
                ucdays.lblDate.Text = day.ToString("dd/MM/yyyy");
                ucdays.setSoLuong(evs.Count);
                ucdays.BackColor = Color.White;
                daycontainer.Controls.Add(ucdays);

                if (evs.Count > 0)
                {
                    foreach (var ev in evs)
                    {
                        UC_SKtrongNgay uC_SKtrongNgay = new UC_SKtrongNgay();
                        TimeSpan remainingTime = ev.EventDate - currentDate;

                        if (remainingTime.TotalDays < 0)
                        {
                            string passedTime = $"{(int)Math.Abs(remainingTime.TotalDays)} Ngày Trước";
                            uC_SKtrongNgay.txtTime.Text = passedTime;
                            Color color = ColorTranslator.FromHtml(ev.TitleColor);
                            int lines = uC_SKtrongNgay.txtTime.GetLineFromCharIndex(uC_SKtrongNgay.txtTime.TextLength) + 1;

                            int lineHeight = uC_SKtrongNgay.txtTime.Font.Height;
                            int padding = 5; 
                            int newHeight = lineHeight * lines + padding;

                            uC_SKtrongNgay.txtTime.Height = newHeight;
                            uC_SKtrongNgay.txtTime.ForeColor = Color.Red;
                            ucdays.BackColor = Color.LightYellow;
                            uC_SKtrongNgay.txtTime.BackColor = Color.LightYellow;
                        }
                        else
                        {
                            uC_SKtrongNgay.txtTime.BackColor = ColorTranslator.FromHtml(ev.TitleColor);
                            string countdownTime = $"{(int)remainingTime.TotalDays} ngày {(int)remainingTime.Hours} giờ {(int)remainingTime.Minutes} phút";
                            uC_SKtrongNgay.txtTime.Text = countdownTime;
                            Color color = ColorTranslator.FromHtml(ev.TitleColor);
                            int lines = uC_SKtrongNgay.txtTime.GetLineFromCharIndex(uC_SKtrongNgay.txtTime.TextLength) + 1;

                            int lineHeight = uC_SKtrongNgay.txtTime.Font.Height;
                            int padding = 5;
                            int newHeight = lineHeight * lines + padding;
                            uC_SKtrongNgay.txtTime.Height = newHeight;
                            uC_SKtrongNgay.txtTime.ForeColor = Color.Green ;
                            ucdays.BackColor = Color.LightYellow;
                            uC_SKtrongNgay.txtTime.BackColor = Color.LightYellow;
                        }
                        if (isEqualDate(day, currentDate))
                        {
                            DateTime eventDateTime = Convert.ToDateTime(ev.EventTime);
                            TimeSpan remainingTime2 = eventDateTime - currentDate;
                            ucdays.BackColor = Color.LightBlue;
                            uC_SKtrongNgay.txtTime.BackColor = Color.LightBlue;
                            uC_SKtrongNgay.txtTime.ForeColor = Color.DarkGreen;

                            string countdownTime2 = $"{remainingTime2.Hours} giờ {remainingTime2.Minutes} phút";
                            uC_SKtrongNgay.txtTime.Text = countdownTime2;
                           
                            if (remainingTime2.TotalDays < 0)
                            {
                                uC_SKtrongNgay.txtTime.Text = "";
                                string passedTime = $"Đã qua";
                                uC_SKtrongNgay.txtTime.Text = passedTime;
                                uC_SKtrongNgay.txtTime.ForeColor = Color.Red;

                            }
                            int lines = uC_SKtrongNgay.txtTime.GetLineFromCharIndex(uC_SKtrongNgay.txtTime.TextLength) + 1;

                            int lineHeight = uC_SKtrongNgay.txtTime.Font.Height;
                            int padding = 5;
                            int newHeight = lineHeight * lines + padding;

                            uC_SKtrongNgay.txtTime.Height = newHeight;
                        }
                        ucdays.flpSuKien.Controls.Add(uC_SKtrongNgay);
                    }
                }
            }
        }
    }
}