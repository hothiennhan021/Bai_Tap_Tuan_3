namespace DangNhapUI
{
    partial class fmLogin
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
            tb_username = new TextBox();
            tb_pass = new TextBox();
            bt_dangNhap = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(253, 88);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(279, 31);
            tb_username.TabIndex = 0;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(253, 152);
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(279, 31);
            tb_pass.TabIndex = 1;
            // 
            // bt_dangNhap
            // 
            bt_dangNhap.Location = new Point(344, 207);
            bt_dangNhap.Name = "bt_dangNhap";
            bt_dangNhap.Size = new Size(112, 34);
            bt_dangNhap.TabIndex = 2;
            bt_dangNhap.Text = "Đăng Nhập";
            bt_dangNhap.UseVisualStyleBackColor = true;
            bt_dangNhap.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 60);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 124);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(311, 9);
            label3.Name = "label3";
            label3.Size = new Size(169, 41);
            label3.TabIndex = 5;
            label3.Text = "Đăng Nhập";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(204, 270);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(142, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(463, 270);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(156, 25);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Đăng ký tài khoản";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // fmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt_dangNhap);
            Controls.Add(tb_pass);
            Controls.Add(tb_username);
            Name = "fmLogin";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_username;
        private TextBox tb_pass;
        private Button bt_dangNhap;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}
