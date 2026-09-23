namespace BT4_1_LoginForm
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // --- Controls ---
            lblTitle      = new System.Windows.Forms.Label();
            lblUsername   = new System.Windows.Forms.Label();
            lblPassword   = new System.Windows.Forms.Label();
            txtUsername   = new System.Windows.Forms.TextBox();
            txtPassword   = new System.Windows.Forms.TextBox();
            chkShowPassword = new System.Windows.Forms.CheckBox();
            btnLogin      = new System.Windows.Forms.Button();
            btnExit       = new System.Windows.Forms.Button();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();

            // Form
            Text            = "Đăng Nhập Hệ Thống";
            Size            = new System.Drawing.Size(400, 300);
            StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox     = false;
            AcceptButton    = btnLogin;   // Enter → btnLogin
            CancelButton    = btnExit;    // Esc   → btnExit

            // lblTitle
            lblTitle.Text      = "ĐĂNG NHẬP HỆ THỐNG";
            lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTitle.Location  = new System.Drawing.Point(50, 20);
            lblTitle.Size      = new System.Drawing.Size(290, 35);

            // lblUsername
            lblUsername.Text     = "Tên đăng nhập:";
            lblUsername.Location = new System.Drawing.Point(40, 75);
            lblUsername.Size     = new System.Drawing.Size(120, 23);

            // txtUsername
            txtUsername.Location = new System.Drawing.Point(170, 72);
            txtUsername.Size     = new System.Drawing.Size(170, 23);
            txtUsername.TabIndex = 0;

            // lblPassword
            lblPassword.Text     = "Mật khẩu:";
            lblPassword.Location = new System.Drawing.Point(40, 115);
            lblPassword.Size     = new System.Drawing.Size(120, 23);

            // txtPassword
            txtPassword.Location             = new System.Drawing.Point(170, 112);
            txtPassword.Size                 = new System.Drawing.Size(170, 23);
            txtPassword.UseSystemPasswordChar = true;   // Mặc định ẩn mật khẩu
            txtPassword.TabIndex             = 1;

            // chkShowPassword
            chkShowPassword.Text             = "Hiển thị mật khẩu";
            chkShowPassword.Location         = new System.Drawing.Point(170, 143);
            chkShowPassword.Size             = new System.Drawing.Size(160, 23);
            chkShowPassword.TabIndex         = 2;
            chkShowPassword.CheckedChanged  += chkShowPassword_CheckedChanged;

            // btnLogin
            btnLogin.Text     = "Đăng Nhập";
            btnLogin.Location = new System.Drawing.Point(90, 190);
            btnLogin.Size     = new System.Drawing.Size(100, 35);
            btnLogin.TabIndex = 3;
            btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Click   += btnLogin_Click;

            // btnExit
            btnExit.Text     = "Thoát";
            btnExit.Location = new System.Drawing.Point(210, 190);
            btnExit.Size     = new System.Drawing.Size(100, 35);
            btnExit.TabIndex = 4;
            btnExit.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Click   += btnExit_Click;

            // errorProvider
            errorProvider.ContainerControl = this;

            Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, lblUsername, txtUsername,
                lblPassword, txtPassword, chkShowPassword,
                btnLogin, btnExit
            });

            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        // --- Fields ---
        private System.Windows.Forms.Label    lblTitle;
        private System.Windows.Forms.Label    lblUsername;
        private System.Windows.Forms.Label    lblPassword;
        private System.Windows.Forms.TextBox  txtUsername;
        private System.Windows.Forms.TextBox  txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button   btnLogin;
        private System.Windows.Forms.Button   btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
