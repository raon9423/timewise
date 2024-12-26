using BLL;
using DTO;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FormThemNhacLich : Form
    {
        private List<string> musicList = new List<string>();
        private WaveOutEvent outputDevice;
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        private object selectedPath;
        public static FormThemNhacLich _instance;
        public static FormThemNhacLich Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormThemNhacLich();
                return _instance;
            }
        }
        //private TextBox recordingPathTextBox;
        int userId;

        public FormThemNhacLich()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public FormThemNhacLich(string selectedPath) : this()
        {
            //recordingPathTextBox = new TextBox();
            //recordingPathTextBox.Text = selectedPath;
            txtPath.Text = selectedPath;
            InitializeComponent();
            CenterToScreen();
        }
        public FormThemNhacLich(int id)
        {
            InitializeComponent();
            this.userId = id;
            SetAllValue(id.ToString());
            CenterToScreen();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void SetAllValue(string userId, string value1 = null, string value2 = null, string value3 = null, string value4 = null, string value5 = null, string value6 = null, string value7 = null)
        {
            txtUserId.Text = userId;
            txtTieuDe.Text = value1;
            dtpNgay.Value = value2 == null ? DateTime.Now: Convert.ToDateTime(value2);
            txtGio.Text = value3;
            txtDiaDiem.Text = value4;
            txtDiemRL.Text = value5;
            txtPath.Text = value6;
            txtGhiChu.Text = value7;
            
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtGio.Text.Trim(), @"^([01]?[0-9]|2[0-3]):[0-5][0-9]$"))
            {
                MessageBox.Show("Vui lòng nhập giờ theo định dạng HH:mm", "Lỗi khi chọn giờ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblThemLichNhac_Click(object sender, EventArgs e)
        {

        }

        private void btnThemLich_Click(object sender, EventArgs e)
        {
            EventBLL eventBLL = new EventBLL();
            SuKien ev = new SuKien();
            ev.UserId = userId;
            ev.EventName = txtTieuDe.Text;
            ev.EventDate = dtpNgay.Value;
            ev.EventTime = txtGio.Text;
            ev.Score = string.IsNullOrEmpty(txtDiemRL.Text) ? 0 : Convert.ToInt32(txtDiemRL.Text);
            ev.Location = txtDiaDiem.Text;
            ev.Note = txtGhiChu.Text;
            ev.RecordingPath = txtPath.Text;

            ev.TitleColor = ColorTranslator.ToHtml(lblMauChu.BackColor);
            ev.BackgroundColor = ColorTranslator.ToHtml(lblMauNen.BackColor);
            bool run = eventBLL.AddEvent(ev);
            if (run)
            {
                MessageBox.Show("Thêm sự kiện thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }

        private void lblAmThanh_Click(object sender, EventArgs e)
        {
            //FromAmThanh fromAmThanh = new FromAmThanh();
            //fromAmThanh.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        
        private void lblGhiChu_Click(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }
        //#endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Black;
            lblMauChu.BackColor = colorDlg.Color;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                lblMauChu.BackColor = colorDlg.Color;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.White;
            lblMauNen.BackColor = colorDlg.Color;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                lblMauNen.BackColor = colorDlg.Color;
            }
        }

        private void txtTieuDe_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(FromAmThanh formAmThanh = new FromAmThanh(userId))
            {
                if(formAmThanh.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text= formAmThanh.GetPath();
                    formAmThanh.Close();
                }
            }
        }

        private void FormThemNhacLich_Load(object sender, EventArgs e)
        {

        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDiemRL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiemRL_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtGio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiemRL_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ':'))
            {
                e.Handled = true;
            }
        }
    }
}



