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
    public partial class UserControlLichThi : UserControl
    {
        public UserControlLichThi()
        {
            InitializeComponent();
        }

        private void UserControlLichThi_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbldays.Text = numday + "";
        }
    }
}
