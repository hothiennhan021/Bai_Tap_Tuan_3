namespace AccountUI
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            textBox3 = new TextBox();
            pictureBox4 = new PictureBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            button_passwordhide = new Button();
            button_passwordhide2 = new Button();
            button_passwordshow = new Button();
            button_passwordshow2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Password;
            pictureBox2.Location = new Point(42, 214);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 16.2F);
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Location = new Point(87, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(395, 39);
            textBox2.TabIndex = 15;
            textBox2.Text = "Email";
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 16.2F);
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(87, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(395, 39);
            textBox1.TabIndex = 14;
            textBox1.Text = "Tên Đăng Nhập";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.Password;
            pictureBox3.Location = new Point(42, 277);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 16.2F);
            textBox3.ForeColor = SystemColors.GrayText;
            textBox3.Location = new Point(87, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(395, 39);
            textBox3.TabIndex = 20;
            textBox3.Text = "Mật Khẩu";
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(42, 84);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 16.2F);
            textBox4.ForeColor = SystemColors.GrayText;
            textBox4.Location = new Point(87, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(395, 39);
            textBox4.TabIndex = 23;
            textBox4.Text = "Xác Nhận Mật Khẩu";
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.DarkSlateBlue;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.ForeColor = Color.White;
            button1.Location = new Point(145, 333);
            button1.Name = "button1";
            button1.Size = new Size(224, 54);
            button1.TabIndex = 26;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.DarkSlateBlue;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button2.ForeColor = Color.White;
            button2.Location = new Point(145, 403);
            button2.Name = "button2";
            button2.Size = new Size(224, 54);
            button2.TabIndex = 27;
            button2.Text = "Quay Lại";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.White;
            label4.Location = new Point(111, 24);
            label4.Name = "label4";
            label4.Size = new Size(296, 42);
            label4.TabIndex = 28;
            label4.Text = "CHESS ONLINE";
            // 
            // button_passwordhide
            // 
            button_passwordhide.Image = (Image)resources.GetObject("button_passwordhide.Image");
            button_passwordhide.Location = new Point(442, 214);
            button_passwordhide.Name = "button_passwordhide";
            button_passwordhide.Size = new Size(40, 40);
            button_passwordhide.TabIndex = 29;
            button_passwordhide.UseVisualStyleBackColor = true;
            button_passwordhide.Click += button_passwordhide_Click;
            // 
            // button_passwordhide2
            // 
            button_passwordhide2.Image = (Image)resources.GetObject("button_passwordhide2.Image");
            button_passwordhide2.Location = new Point(442, 276);
            button_passwordhide2.Name = "button_passwordhide2";
            button_passwordhide2.Size = new Size(40, 40);
            button_passwordhide2.TabIndex = 30;
            button_passwordhide2.UseVisualStyleBackColor = true;
            button_passwordhide2.Click += button_passwordhide2_Click;
            // 
            // button_passwordshow
            // 
            button_passwordshow.Image = (Image)resources.GetObject("button_passwordshow.Image");
            button_passwordshow.Location = new Point(442, 213);
            button_passwordshow.Name = "button_passwordshow";
            button_passwordshow.Size = new Size(40, 40);
            button_passwordshow.TabIndex = 31;
            button_passwordshow.UseVisualStyleBackColor = true;
            button_passwordshow.Click += button_passwordshow_Click;
            // 
            // button_passwordshow2
            // 
            button_passwordshow2.Image = (Image)resources.GetObject("button_passwordshow2.Image");
            button_passwordshow2.Location = new Point(442, 276);
            button_passwordshow2.Name = "button_passwordshow2";
            button_passwordshow2.Size = new Size(40, 40);
            button_passwordshow2.TabIndex = 32;
            button_passwordshow2.UseVisualStyleBackColor = true;
            button_passwordshow2.Click += button_passwordshow2_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 468);
            Controls.Add(button_passwordshow2);
            Controls.Add(button_passwordshow);
            Controls.Add(button_passwordhide2);
            Controls.Add(button_passwordhide);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(textBox4);
            Controls.Add(pictureBox3);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Signup";
            Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private TextBox textBox3;
        private PictureBox pictureBox4;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label4;
        private Button button_passwordhide;
        private Button button_passwordhide2;
        private Button button_passwordshow;
        private Button button_passwordshow2;
    }
}