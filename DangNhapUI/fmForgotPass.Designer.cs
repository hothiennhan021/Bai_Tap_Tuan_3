namespace DangNhapUI
{
    partial class fmForgotPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_mailStd = new TextBox();
            tb_mk = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bt_layMk = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // tb_mailStd
            // 
            tb_mailStd.Location = new Point(153, 97);
            tb_mailStd.Name = "tb_mailStd";
            tb_mailStd.Size = new Size(524, 31);
            tb_mailStd.TabIndex = 0;
            // 
            // tb_mk
            // 
            tb_mk.Location = new Point(153, 218);
            tb_mk.Multiline = true;
            tb_mk.Name = "tb_mk";
            tb_mk.Size = new Size(252, 51);
            tb_mk.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 69);
            label1.Name = "label1";
            label1.Size = new Size(360, 25);
            label1.TabIndex = 2;
            label1.Text = "Nhập mail hoặc số điện thoại đã đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 166);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 3;
            // 
            // bt_layMk
            // 
            bt_layMk.Location = new Point(153, 178);
            bt_layMk.Name = "bt_layMk";
            bt_layMk.Size = new Size(153, 34);
            bt_layMk.TabIndex = 4;
            bt_layMk.Text = "Lấy lại mật khẩu";
            bt_layMk.UseVisualStyleBackColor = true;
            bt_layMk.Click += bt_layMk_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(302, 9);
            label3.Name = "label3";
            label3.Size = new Size(230, 41);
            label3.TabIndex = 5;
            label3.Text = "Lấy lại mật khẩu";
            // 
            // fmForgotPass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(bt_layMk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_mk);
            Controls.Add(tb_mailStd);
            Name = "fmForgotPass";
            Text = "fmForgotPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_mailStd;
        private TextBox tb_mk;
        private Label label1;
        private Label label2;
        private Button bt_layMk;
        private Label label3;
    }
}