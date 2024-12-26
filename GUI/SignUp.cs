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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            CenterToScreen();
        }


        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "")
                {
                    return;
                }
                txtUser.ForeColor = Color.White;
                panel16.Visible = false;
            }
            catch { }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "")
                {
                    return;
                }
                txtEmail.ForeColor = Color.White;
                panel20.Visible = false;
            }
            catch { }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "")
                {
                    return;
                }
                txtPassword.ForeColor = Color.White;
                panel28.Visible = false;
            }
            catch { }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "")
                {
                    return;
                }
                txtConfirm.ForeColor = Color.White;
                panel24.Visible = false;
            }
            catch { }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.Black;
            btnRegister.BackColor = Color.FromArgb(192, 0, 192);
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login sistema = new Login();
            sistema.Show();
            this.Hide();
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("Enter your user name"))
            {
                txtUser.Text = "";
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Enter your user name";
            }
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("Enter your email"))
            {
                txtEmail.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Enter your email";
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Enter password"))
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*'; 
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter password";
                txtPassword.PasswordChar = default;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (txtConfirm.Text.Equals("Confirm password"))
            {
                txtConfirm.Text = "";
                txtConfirm.PasswordChar = '*'; 
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "")
            {
                txtConfirm.Text = "Confirm password";
                txtConfirm.PasswordChar = default;

            }
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            txtUser.SelectAll();

        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            //txtEmail.SelectAll();

        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            //txtPassword.SelectAll();

        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            //txtConfirm.SelectAll();

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (txtUser.Text == "Enter your user name")
            {
                panel16.Visible = true;
                txtUser.Focus();
                return;
            }
            if (txtEmail.Text == "Enter your email")
            {
                panel20.Visible = true;
                txtEmail.Focus();
                return;
            }
            if (txtPassword.Text == "Enter password")
            {
                panel28.Visible = true;
                txtPassword.Focus();
                return;
            }
            if (txtConfirm.Text == "Confirm password")
            {
                panel24.Visible = true;
                txtConfirm.Focus();
                return;
            }
            if (!txtPassword.Text.Equals(txtConfirm.Text))
            {
                MessageBox.Show("Vui lòng xác nhận đúng mật khẩu");
                return;
            }

            // Thực hiện đăng ký tài khoản
            User user = new User();
            user.userName = txtUser.Text;
            user.email = txtEmail.Text;
            user.userPass = txtPassword.Text;

            UserBLL userBLL = new UserBLL();
            bool regis = userBLL.AddUser(user);
            if (regis)
            {
                MessageBox.Show("Bạn đã đăng ký tài khoản thành công !");
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                if (userBLL.isUser(user) > 0)
                    MessageBox.Show("Người dùng đã tồn tại");
            }
            
        }

        private void btnRegister_MouseEnter_1(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.Black;

        }

        private void btnRegister_MouseLeave_1(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.White;

        }
    }
}
