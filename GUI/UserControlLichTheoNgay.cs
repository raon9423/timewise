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
    public partial class UserControlLichTheoNgay : UserControl
    {
        public static UserControlLichTheoNgay _instance;
        public static UserControlLichTheoNgay Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlLichTheoNgay();
                return _instance;
            }
        }
        public UserControlLichTheoNgay()
        {
            InitializeComponent();
        }

        private void UserControlLichTheoNgay_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
