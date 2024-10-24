namespace FormDangnhap_21._10._2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            BtnExit = new Button();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(197, 295);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(94, 29);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "Đăng nhập";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 135);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 211);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(396, 295);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(94, 29);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "Thoát";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += btnExit_Click;
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(286, 132);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(230, 27);
            TxtUsername.TabIndex = 4;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(286, 204);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(230, 27);
            TxtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(275, 46);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 6;
            label3.Text = "Đăng Nhập";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 374);
            Controls.Add(label3);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(BtnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnLogin);
            Name = "Form1";
            Text = "FormDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLogin;
        private Label label1;
        private Label label2;
        private Button BtnExit;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Label label3;
    }
}
