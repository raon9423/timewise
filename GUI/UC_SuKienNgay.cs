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
    public partial class UC_SuKienNgay : UserControl
    {
        public UC_SuKienNgay()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            //this.AdjustFormScrollbars(false);

        }
        public void setSoLuong(int numday)
        {
            lblSLSK.Text = numday.ToString();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void flpSuKien_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
