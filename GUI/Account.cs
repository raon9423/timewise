using BLL;
using DAL;
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
    public partial class Account : UserControl
    {
        User user;
        ThongTinSV thongTinSV;
        public Account()
        {
            InitializeComponent();
        }
        public Account(User user, ThongTinSV thongTinSV)
        {
            InitializeComponent();
            this.user = user;
            this.thongTinSV = thongTinSV;
        }


        public void SetColor(Color color)
        {
            this.ForeColor = color;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            lblMSSV.Text = thongTinSV.MSSV;
            lblHoTen.Text = thongTinSV.HoTen;
            lblGioiTinh.Text = thongTinSV.GioiTinh;
            lblNgaySinh.Text = thongTinSV.NgaySinh.ToString("dd/MM/yyyy");
            txtUserName.Text = user.userName;
            txtEmail.Text = user.email;
            txtBietDanh.Text = user.nameOfUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThucThiSQL_BLL thucThiSQL = new ThucThiSQL_BLL();
            thucThiSQL.DeleteMusic(user.userID);
            thucThiSQL.DeleteUser_ThongTin(user.userID);
            thucThiSQL.DeleteThongTinSV(thongTinSV.MSSV) ;
            thucThiSQL.DeleteLichHocLichThi(user.userID) ;
            LoginStudentAccount loginStudent = new LoginStudentAccount(user.userID);
            loginStudent.Show();

        }

        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            if (btnChinhSuaThongTin.Text == "Chỉnh sửa thông tin")
            {
                txtUserName.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtBietDanh.ReadOnly = false;
                btnChinhSuaThongTin.Text = "Lưu thông tin";
            }
            else
            {
                user.userName = txtUserName.Text;
                user.email = txtEmail.Text;
                user.nameOfUser = txtBietDanh.Text;
                UserBLL userBLL = new UserBLL();
                bool isUpdated = userBLL.UpdateUser(user);
                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtUserName.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtBietDanh.ReadOnly = true;
                    btnChinhSuaThongTin.Text = "Chỉnh sửa thông tin";
                }
                else
                    MessageBox.Show("Không thể cập nhật thông tin, hãy thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            pnlDoiMatKhau.Visible = true;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {


            User checkUser = user;
            checkUser.userPass = txtMKHienTai.Text;

            UserBLL userBLL = new UserBLL();
            if (userBLL.isUser(checkUser) > 0)
            {
                if (txtMatKhau.Text != txtXNMatKhau.Text)
                {
                    MessageBox.Show("Vui lòng xác nhận đúng mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                user.userPass = txtMatKhau.Text;
                bool ok = userBLL.UpdatePassword(user);
                if (ok)
                {
                    pnlDoiMatKhau.Visible = false;
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    pnlDoiMatKhau.Visible = false;
                    MessageBox.Show("Không thể đổi mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng, vui lòng nhập đúng thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlDoiMatKhau.Visible = false;
            txtMatKhau.Text = "";
            txtXNMatKhau.Text = "";
        }
    }
}
