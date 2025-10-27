namespace AccountUI
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button3 = new Button();
            label4 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            pictureBox3 = new PictureBox();
            button_passwordhide = new Button();
            button_passwordshow = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.DarkSlateBlue;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button2.ForeColor = Color.White;
            button2.Location = new Point(169, 393);
            button2.Name = "button2";
            button2.Size = new Size(224, 54);
            button2.TabIndex = 32;
            button2.Text = "Đăng Nhập Ngay";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(96, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(395, 39);
            textBox1.TabIndex = 33;
            textBox1.Text = "Email";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.DarkSlateBlue;
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button3.ForeColor = Color.White;
            button3.Location = new Point(169, 312);
            button3.Name = "button3";
            button3.Size = new Size(224, 54);
            button3.TabIndex = 38;
            button3.Text = "Xác Nhận ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.White;
            label4.Location = new Point(175, 22);
            label4.Name = "label4";
            label4.Size = new Size(218, 42);
            label4.TabIndex = 39;
            label4.Text = "NETCHESS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.White;
            label2.Location = new Point(73, 75);
            label2.Name = "label2";
            label2.Size = new Size(408, 25);
            label2.TabIndex = 40;
            label2.Text = "Nhập Email Mà Bạn Dùng Để Đăng Ký";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 16.2F);
            textBox3.ForeColor = SystemColors.GrayText;
            textBox3.Location = new Point(96, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(395, 39);
            textBox3.TabIndex = 44;
            textBox3.Text = "Mật Khẩu Mới";
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.Password;
            pictureBox3.Location = new Point(51, 232);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            // 
            // button_passwordhide
            // 
            button_passwordhide.Image = (Image)resources.GetObject("button_passwordhide.Image");
            button_passwordhide.Location = new Point(451, 232);
            button_passwordhide.Name = "button_passwordhide";
            button_passwordhide.Size = new Size(40, 40);
            button_passwordhide.TabIndex = 45;
            button_passwordhide.UseVisualStyleBackColor = true;
            button_passwordhide.Click += button_passwordhide_Click;
            // 
            // button_passwordshow
            // 
            button_passwordshow.Image = (Image)resources.GetObject("button_passwordshow.Image");
            button_passwordshow.Location = new Point(451, 232);
            button_passwordshow.Name = "button_passwordshow";
            button_passwordshow.Size = new Size(40, 40);
            button_passwordshow.TabIndex = 46;
            button_passwordshow.UseVisualStyleBackColor = true;
            button_passwordshow.Click += button_passwordshow_Click;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(966, 488);
            Controls.Add(button_passwordshow);
            Controls.Add(button_passwordhide);
            Controls.Add(textBox3);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Name = "ForgetPassword";
            Text = "Recovery";
            Load += Resetpassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button3;
        private Label label4;
        private Label label2;
        private TextBox textBox3;
        private PictureBox pictureBox3;
        private Button button_passwordhide;
        private Button button_passwordshow;
    }
}