using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class UC_Ngay : UserControl
    {
        public UC_Ngay()
        {
            InitializeComponent();
        }

        public void SetBackground(Color color)
        {
            this.BackColor = color;
            txtNgay.BackColor = color;
            txtThu.BackColor = color;
        }
        private void txtThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
