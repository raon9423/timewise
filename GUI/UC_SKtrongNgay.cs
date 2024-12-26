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
    public partial class UC_SKtrongNgay : UserControl
    {
        public UC_SKtrongNgay()
        {
            InitializeComponent();
        }

        public void SetForeColor(Color color)
        {
            txtTime.ForeColor = color;
        }
        public void SetBackgroundColor(Color color)
        {
            txtTime.BackColor = color;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
