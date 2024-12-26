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
    public partial class UC_LichHoc : UserControl
    {
        public UC_LichHoc()
        {
            InitializeComponent();
        }
        public void ChangeTextColor(Color color)
        {
            this.ForeColor = color;
        }
    }
}
