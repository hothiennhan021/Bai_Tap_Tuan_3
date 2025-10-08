namespace Dang_Nhap_Dang_Ky
{
    partial class QuenMatKhau
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button_LayLaiMK = new Button();
            textBox_EmailDK = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(95, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(12, 205);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 2;
            label1.Text = "Email Đăng Ký:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(12, 261);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 4;
            label2.Text = "Kết Quả:";
            // 
            // button_LayLaiMK
            // 
            button_LayLaiMK.AutoSize = true;
            button_LayLaiMK.BackColor = Color.FromArgb(0, 192, 0);
            button_LayLaiMK.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button_LayLaiMK.ForeColor = Color.White;
            button_LayLaiMK.Location = new Point(95, 309);
            button_LayLaiMK.Name = "button_LayLaiMK";
            button_LayLaiMK.Size = new Size(173, 49);
            button_LayLaiMK.TabIndex = 5;
            button_LayLaiMK.Text = "Lấy Lại Mật Khẩu";
            button_LayLaiMK.UseVisualStyleBackColor = false;
            button_LayLaiMK.Click += button1_Click;
            // 
            // textBox_EmailDK
            // 
            textBox_EmailDK.Location = new Point(157, 203);
            textBox_EmailDK.Name = "textBox_EmailDK";
            textBox_EmailDK.Size = new Size(175, 27);
            textBox_EmailDK.TabIndex = 6;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 369);
            Controls.Add(textBox_EmailDK);
            Controls.Add(button_LayLaiMK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "QuenMatKhau";
            Text = "QuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button_LayLaiMK;
        private TextBox textBox_EmailDK;
    }
}