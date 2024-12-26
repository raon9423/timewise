using BLL;
using CefSharp;
using CefSharp.WinForms;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginStudentAccount : Form
    {
        private ChromiumWebBrowser browser;
        private int countLich = 0;
        private int maxCountLich = 10;
        private int userId;
        LoadForm loadForm;
        private bool isLoadTTSV;
        string MSSVV;

        private Timer waitForEnd;
        public LoginStudentAccount()
        {
            InitializeComponent();
            InitializeBrowser();
            CenterToScreen();
            //waitForEnd = new Timer();
        }

        public LoginStudentAccount(int id)
        {
            InitializeComponent();
            InitializeBrowser();
            CenterToScreen();
            this.userId = id;
        }

        private void WaitForEnd_Tick(object sender, EventArgs e)
        {
            if (countLich == maxCountLich)
            {
                waitForEnd.Stop();
                // Kiểm tra xem có cần gọi Invoke không
                if (InvokeRequired)
                {
                    // Gọi phương thức Hide trên luồng giao diện người dùng
                    Invoke(new MethodInvoker(delegate
                    {
                        Hide();
                    }));
                }
                else
                {
                    // Gọi Hide trực tiếp nếu đang ở trong luồng giao diện người dùng
                    Hide();
                }
                MainForm mainForm = new MainForm(true, userId);
                mainForm.Show();
            }
        }

        #region FontEnd Method

        #endregion

        #region Back en support method

        // Tao moi browser
        private void InitializeBrowser()
        {
            try
            {
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);
            }
            catch { }


            browser = new ChromiumWebBrowser("https://phongdaotao.ntt.edu.vn");
            browser.FrameLoadEnd += Browser_FrameLoadEnd;

            pnlBrowser.Controls.Add(browser);
            browser.BringToFront();
            browser.Dock = DockStyle.Fill;
        }
        private async void CheckForScriptContent()
        {
            if (countLich == maxCountLich)
            {
                return;
            }

            string script = @"
                            // Kiểm tra xem trang web có chứa từ 'Ca học' trong script không
                            if (document.documentElement.innerText.indexOf('Ca học') !== -1) {
                                true;
                            } else {
                                false;
                            }
                        ";
            bool scriptLoaded = false;

            while (!scriptLoaded)
            {
                var response = await browser.EvaluateScriptAsync(script);
                if (response.Success && response.Result != null && (bool)response.Result)
                {

                    //MessageBox.Show("Trang web chứa từ 'Ca học' trong script.");
                    countLich++;
                    GetTable();
                    browser.ExecuteScriptAsync("document.getElementById('btn_Tiep').click();");
                    CheckForScriptContent();
                    scriptLoaded = true;
                }
                else
                {
                    await Task.Delay(100);
                }
            }

        }
        private void GetTable()
        {
            string script = @"
                            var element = document.querySelector('.fl-table.table.table-bordered.text-center.no-footer.dtr-inline');
                            if(element) {
                                element.outerHTML;
                            } else {
                                'Element not found';
                            }
                        ";

            browser.EvaluateScriptAsync(script).ContinueWith(y =>
            {
                if (!y.IsFaulted)
                {
                    var response2 = y.Result;
                    if (response2.Success && response2.Result != null)
                    {
                        string elementHtml = response2.Result.ToString();
                        PhanTichHTMLTable(elementHtml);
                    }
                    //else
                    //{
                    //    MessageBox.Show("Failed to get element HTML: " + response2.Message);
                    //}
                }
            });

        }

        private void PhanTichHTMLTable(string html)
        {
            RegexParser parser = new RegexParser();
            var result = parser.PhanTichHtml(html);
            foreach (var ngay in result.NgayTrongTuan)
            {
                NgayTrongTuanBLL ngayTrongTuanBLL = new NgayTrongTuanBLL();
                ngayTrongTuanBLL.AddNgay(ngay);

            }
            foreach (var lich in result.LichHocs)
            {
                lich.UserId = userId;
                LichHocBLL lichHocBLL = new LichHocBLL();
                lichHocBLL.AddLichHoc(lich);
            }
            foreach (var lich in result.LichThis)
            {
                lich.UserId = userId;
                LichThiBLL lichThiBLL = new LichThiBLL();
                lichThiBLL.AddLich(lich);
            }


        }
        private void GetThongTinSV(string html)
        {

            ThongTinSV ttsv = new ThongTinSV();
            Regex_TTSV regexTTSV = new Regex_TTSV();
            ttsv = regexTTSV.DS_ThongTin(html);
            //MessageBox.Show(ttsv.ToString(),"Thông tin sinh viên");
            isLoadTTSV = true;
            ThongTinSVBLL thongTinSVBLL = new ThongTinSVBLL();
            thongTinSVBLL.AddThongTinSV(ttsv);

            User_ThongTinBLL userTTBLL = new User_ThongTinBLL();
            User_ThongTin uctt = new User_ThongTin();
            uctt.IdUser = userId;
            uctt.ThongTinId = thongTinSVBLL.GetThongTinSVByMSSV(ttsv.MSSV).Id;
            userTTBLL.AddUserThongTin(uctt);
            MSSVV = ttsv.MSSV;
        }

        private void GetThongTinKetQuaHocTap(string html)
        {
            Regex_KQHT listKQ = new Regex_KQHT();
            var listDiem = listKQ.DS_Diem(html);

            DiemBLL diemBLL = new DiemBLL();
            foreach (var diem in listDiem)
                if (!string.IsNullOrEmpty(diem.MaMonHoc))
                    diemBLL.AddDiem(diem);

        }

        private void ScrollToElementByClass(string className)
        {
            string script = $"document.querySelector('.{className}').scrollIntoView();";
            browser.ExecuteScriptAsync(script);
        }
        private void DisableScroll()
        {
            string script = @"
                            var style = document.createElement('style');
                            style.innerHTML = 'body { overflow: hidden; }';
                            document.head.appendChild(style);
                        ";
            browser.ExecuteScriptAsync(script);
        }
        private void Browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Frame.IsMain)
            {

                if (browser.Address.Contains("sinh-vien-dang-nhap"))
                {
                    ScrollToElementByClass("form-login");
                    DisableScroll();
                }

                if (browser.Address.Contains("dashboard"))
                {
                    if (InvokeRequired)
                    {
                        // Gọi phương thức Hide trên luồng giao diện người dùng
                        Invoke(new MethodInvoker(delegate
                        {
                            pnlBrowser.Controls.Remove(browser);
                        }));
                    }
                    else
                    {
                        // Gọi Hide trực tiếp nếu đang ở trong luồng giao diện người dùng
                        pnlBrowser.Controls.Remove(browser);

                    }
                    string script = @"
                                        var links = document.querySelectorAll('a[href=""/thong-tin-sinh-vien.html""]');
                                        if (links.length > 0) {
                                            links[0].click();
                                        }";
                    browser.EvaluateScriptAsync(script);


                }
                if (browser.Address.Contains("thong-tin-sinh-vien"))
                {
                    //Uc_LoadForm load = new Uc_LoadForm();
                    //pnlBrowser.Controls.Add(load);
                    if (InvokeRequired)
                    {
                        // Gọi phương thức Hide trên luồng giao diện người dùng

                        Invoke(new MethodInvoker(delegate
                        {
                            timer.Start();
                        }));
                    }
                    else
                    {
                        // Gọi Hide trực tiếp nếu đang ở trong luồng giao diện người dùng
                        timer.Start();


                    }
                    var task = e.Frame.GetSourceAsync();

                    task.ContinueWith(t =>
                    {
                        if (t.IsCompleted && !t.IsFaulted)
                        {
                            string html = t.Result;
                            GetThongTinSV(html);
                        }

                    });
                    string clickScript = @"
                                            var links = document.querySelectorAll('a[href=""/ket-qua-hoc-tap.html""]');
                                            if (links.length > 0) {
                                                links[0].click();
                                            }
                                        ";
                    browser.EvaluateScriptAsync(clickScript);

                }
                if (browser.Address.Contains("ket-qua-hoc-tap"))
                {
                    //Uc_LoadForm load = new Uc_LoadForm();
                    //pnlBrowser.Controls.Add(load);
                    //if (InvokeRequired)
                    //{
                    //    // Gọi phương thức Hide trên luồng giao diện người dùng
                    //    Invoke(new MethodInvoker(delegate
                    //    {
                    //        flpLoad.Controls.Add(new Uc_LoadForm());
                    //    }));
                    //}
                    //else
                    //{
                    //    // Gọi Hide trực tiếp nếu đang ở trong luồng giao diện người dùng
                    //    flpLoad.Controls.Add(new Uc_LoadForm());


                    //}
                    var task = e.Frame.GetSourceAsync();

                    task.ContinueWith(t =>
                    {
                        if (t.IsCompleted && !t.IsFaulted)
                        {
                            string html = t.Result;
                            GetThongTinKetQuaHocTap(html);
                        }

                    });
                    string clickScript = @"
                                            var links = document.querySelectorAll('a[href=""/lich-theo-tuan.html""]');
                                            if (links.length > 0) {
                                                links[0].click();
                                            }
                                        ";
                    browser.EvaluateScriptAsync(clickScript);

                }
                if (browser.Address.Contains("lich-theo-tuan"))
                {
                    CheckForScriptContent();
                    if (InvokeRequired)
                    {
                        // Gọi phương thức Hide trên luồng giao diện người dùng
                        Invoke(new MethodInvoker(delegate
                        {
                            timer.Stop();
                            progressBar1.Value = 300;
                            Hide();
                        }));
                    }
                    else
                    {
                        // Gọi Hide trực tiếp nếu đang ở trong luồng giao diện người dùng
                        timer.Stop();
                        progressBar1.Value = 300;
                        Hide();

                    }
                    //Uc_LoadForm load = new Uc_LoadForm();
                    //pnlBrowser.Controls.Add(load);
                    if (!CheckOpenForm("MainForm"))
                    {
                        MainForm mainForm = new MainForm(true, userId);
                        mainForm.Show();
                    }


                    //if (InvokeRequired)
                    //{
                    //    // Gọi phương thức Hide trên luồng giao diện người dùng
                    //    Invoke(new MethodInvoker(delegate
                    //    {
                    //        browser.Dispose();
                    //    }));
                    //}
                    //else
                    //{
                    //    // Gọi Hide trực tiếp nếu đang ở trong luồng giao diện người dùng
                    //    browser.Dispose();


                    //}


                }

            }
        }

        private bool CheckOpenForm(string formName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "MainForm")
                    return true;

            }
            return false;
        }
        #endregion

        #region Class support get cookies
        private class CookieVisitor : ICookieVisitor
        {
            public bool Visit(Cookie cookie, int count, int total, ref bool deleteCookie)
            {
                // Xử lý cookie ở đây
                MessageBox.Show($"Name: {cookie.Name}, Value: {cookie.Value}");
                return true;
            }

            public void Dispose()
            {
                // Hàm Dispose
            }
        }
        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value == 300)
            {
                progressBar1.Value = 10;
            }
        }
    }

}
