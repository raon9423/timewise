using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class UserControlLichHoc : UserControl
    {
        public UserControlLichHoc()
        {
            InitializeComponent();
        }
        private void ChangeBackColor(Color color)
        {
            txtChiTiet.BackColor = color;
            txtMon.BackColor = color;
        }
        public void ChangeTextColor(Color color)
        {
            this.ForeColor = color;
            if(color == Color.White)
            {
                ChangeBackColor(Color.FromArgb(33, 25, 41));
            }    
        }
        private void UserControlLichHoc_Load(object sender, EventArgs e)
        {

        }
        //public void days(int numday)
        //{
        //    lbldays.Text = numday + "";
        //}

        private void txtBox_CLick(object sender, EventArgs e)
        {
            // Di chuyển caret (dấu IBeam) tới cuối văn bản
            txtChiTiet.SelectionStart = txtChiTiet.TextLength;
            txtChiTiet.SelectionLength = 0; 
            txtMon.SelectionStart = txtMon.TextLength;
            txtMon.SelectionLength = 0;
        }
    }
}
