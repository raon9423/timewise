using BLL;
using DTO;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void txtMssv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "")
                {
                    return;
                }
                txtUserName.ForeColor = Color.White;
                panel4.Visible = false;
            }
            catch { }
        }

        private void txtLoginPass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtLoginPass.Text == "")
                {
                    return;
                }
                txtLoginPass.ForeColor = Color.White;
                panel6.Visible = false;

            }
            catch { }
        }



        private void txtMssv_Click(object sender, EventArgs e)
        {
            //txtUserName.SelectAll();
        }

        private void txtLoginPass_Click(object sender, EventArgs e)
        {
            //txtLoginPass.SelectAll();
        }



        private void btnLoGin_MouseEnter(object sender, EventArgs e)
        {
            btnLoGin.ForeColor = Color.Black;
        }

        private void btnLoGin_MouseLeave(object sender, EventArgs e)
        {
            btnLoGin.ForeColor = Color.White;

        }

        private void btnLoGin_Click(object sender, EventArgs e)
        {
            //Tiền Xử lý dữ liệu 
            if (txtUserName.Text == "Enter username")
            {
                panel4.Visible = true;
                txtUserName.Focus();
                return;
            }
            if (txtLoginPass.Text == "Enter password")
            {
                panel6.Visible = true;
                txtLoginPass.Focus();
                return;
            }

            //Kiểm tra dữ hiệu hợp lệ, thực hiện login
            string userName = txtUserName.Text;
            string password = txtLoginPass.Text;
            User user = new User();
            user.userName = userName;
            user.userPass = password;
            UserBLL userBLL = new UserBLL();
            int isUser = userBLL.isUser(user);
            if (isUser > 0)
            {
                if (!userBLL.isUserLogin(user))
                {
                    LoginStudentAccount loginStudent = new LoginStudentAccount(isUser);
                    loginStudent.Show();
                    this.Hide();
                    user.isLogin = true;
                    userBLL.UpdateUserLogin(user);

                }
                else
                {
                    MainForm main = new MainForm(true,isUser);
                    main.Show();    
                    this.Hide();

                }
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");

        }

        private void lblText3_Click(object sender, EventArgs e)
        {
        }

        private void txtMssv_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("Enter username"))
            {
                txtUserName.Text = "";
            }
        }

        private void txtMssv_Leave(object sender, EventArgs e)
        {
            if(txtUserName.Text == "")
            {
                txtUserName.Text = "Enter username";
            }
        }

        private void txtLoginPass_Enter(object sender, EventArgs e)
        {
            if(txtLoginPass.Text.Equals("Enter password"))
            {
                txtLoginPass.Text = "";
                txtLoginPass.PasswordChar = '*';
            }
        }

        private void txtLoginPass_Leave(object sender, EventArgs e)
        {
            if (txtLoginPass.Text == "")
            {
                txtLoginPass.Text = "Enter password";
                txtLoginPass.PasswordChar = default;
            }
        }



        private void lnkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sistema = new SignUp();
            sistema.Show();

            this.Hide();
        }

        private void pnLoGin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
