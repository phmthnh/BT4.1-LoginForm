using System;
using System.Windows.Forms;

namespace BT4_1_LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Sự kiện click nút Đăng Nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Validate Tên đăng nhập
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Vui lòng nhập tên đăng nhập!");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtUsername, "");
            }

            // Validate Mật khẩu
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Vui lòng nhập mật khẩu!");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtPassword, "");
            }

            if (isValid)
            {
                MessageBox.Show(
                    $"Đăng nhập thành công!\nTài khoản: {txtUsername.Text}",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // Sự kiện click nút Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Checkbox hiện/ẩn mật khẩu
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Tick → hiện mật khẩu, bỏ tick → ẩn (*)
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
