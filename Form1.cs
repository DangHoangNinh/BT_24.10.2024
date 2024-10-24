namespace FormDangnhap_21._10._2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TxtPassword.PasswordChar = '*';
        }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                // Lấy tên đăng nhập và mật khẩu từ TextBox
                string username = TxtUsername.Text;
                string password = TxtPassword.Text;

                // Kiểm tra tên đăng nhập và mật khẩu
                if (username == "admin" && password == "1234")
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                // Đóng ứng dụng
                Application.Exit();
            }
        }
 }