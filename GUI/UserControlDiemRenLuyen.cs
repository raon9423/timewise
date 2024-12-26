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
    public partial class UserControlDiemRenLuyen : UserControl
    {
        public static UserControlDiemRenLuyen _instance;
        public static UserControlDiemRenLuyen Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlDiemRenLuyen();
                return _instance;
            }
        }
        public UserControlDiemRenLuyen()
        {
            InitializeComponent();
        }

        private void UserControlDiemRenLuyen_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}
