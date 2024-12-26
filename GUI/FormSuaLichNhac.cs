using BLL;
using CefSharp.DevTools.Debugger;
using CefSharp.DevTools.DOM;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSuaLichNhac : Form
    {
        int userId;
        Color titlecolor;
        Color backgroundColor;

        public FormSuaLichNhac()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public FormSuaLichNhac(int ueserid, string id, string tieuDe, DateTime ngay, string gio, string location, string diem, string note, string record,string titleColor, string backColor)
        {
            InitializeComponent();
            txtId.Text = id;
            txtTieuDe.Text = tieuDe;
            dtpNgay.Value = ngay;
            txtGio.Text = gio;
            txtDiaDiem.Text = location;
            txtDiemRL.Text = diem;
            txtGhiChu.Text = note;
            txtPath.Text = record;
            this.titlecolor = ColorTranslator.FromHtml(titleColor) ;
            this.backgroundColor = ColorTranslator.FromHtml(backColor);
            lblMauNen.BackColor = backgroundColor;
            lblMauChu.BackColor = titlecolor;
            this.userId = ueserid;
            CenterToScreen();
        }




        private void btnThemLich_Click(object sender, EventArgs e)
        {
            
            var id = txtId.Text;
            var TieuDe = txtTieuDe.Text;
            var Ngay = dtpNgay.Value;
            var Gio = txtGio.Text;
            var DiaDiem = txtDiaDiem.Text;
            var Diem = txtDiemRL.Text;
            var GhiChu = txtGhiChu.Text;
            var record = txtPath.Text;
            
            SuKien suKien = new SuKien();
            suKien.UserId = userId;
            suKien.EventId = Convert.ToInt32(id);
            suKien.EventName = TieuDe;
            suKien.EventDate = Ngay;
            suKien.EventTime = Gio;
            suKien.Location = DiaDiem;
            suKien.Score = Convert.ToInt32(Diem);
            suKien.Note = GhiChu;
            suKien.RecordingPath = record;
            suKien.TitleColor = ColorTranslator.ToHtml(lblMauChu.BackColor);
            suKien.BackgroundColor = ColorTranslator.ToHtml(lblMauNen.BackColor);
            EventBLL eventBLL = new EventBLL();
            bool ok = eventBLL.UpdateEvent(suKien);
            if (ok)
            {
                MessageBox.Show("Sửa sự kiện thành công!","Thông báo");

                this.Close();
            }
        }

        public void Clear()
        {
            txtTieuDe.Text = "";
            dtpNgay.Value = DateTime.Now;
            txtGio.Text = "";
            txtDiaDiem.Text = "";
            txtDiemRL.Text = "";
            txtGhiChu.Text = "";
            lblMauNen.BackColor = Color.White;
            lblMauChu.BackColor = Color.Black;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sự kiện này không?", "Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return ;
            var id = txtId.Text;
            
            SuKien suKien = new SuKien();
            suKien.EventId = Convert.ToInt32(id);
            //suKien.UserId = ;
            EventBLL eventBLL =new EventBLL();
            bool ok = eventBLL.DeleteEvent(suKien);
            if (ok)
            {
                MessageBox.Show("Xóa sự kiện thành công");
                this.Close();
            }


        }

        private void FormSuaLichNhac_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            using (FromAmThanh formAmThanh = new FromAmThanh(userId))
            {
                if (formAmThanh.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = formAmThanh.GetPath();
                    formAmThanh.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = this.titlecolor;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                //txtTieuDe.ForeColor = colorDlg.Color;
                txtGhiChu.ForeColor = colorDlg.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = this.backgroundColor;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                txtGhiChu.BackColor = colorDlg.Color;
            }
        }

        private void txtGio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ':'))
            {
                e.Handled = true;
            }
        }

        private void txtDiemRL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
    }
}
