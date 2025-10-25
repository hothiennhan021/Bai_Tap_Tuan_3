namespace AccountUI
{
    partial class MainMenu
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
            button_playwithai = new Button();
            button2 = new Button();
            button_createroom = new Button();
            button_logout = new Button();
            button_findroom = new Button();
            textBox_tentaikhoan = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button_playwithai
            // 
            button_playwithai.AutoSize = true;
            button_playwithai.BackColor = Color.DarkSlateBlue;
            button_playwithai.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button_playwithai.ForeColor = Color.White;
            button_playwithai.Location = new Point(370, 356);
            button_playwithai.Name = "button_playwithai";
            button_playwithai.Size = new Size(224, 54);
            button_playwithai.TabIndex = 33;
            button_playwithai.Text = "Chơi Với AI";
            button_playwithai.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(789, 368);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 34;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button_createroom
            // 
            button_createroom.AutoSize = true;
            button_createroom.BackColor = Color.DarkSlateBlue;
            button_createroom.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button_createroom.ForeColor = Color.White;
            button_createroom.Location = new Point(370, 116);
            button_createroom.Name = "button_createroom";
            button_createroom.Size = new Size(224, 54);
            button_createroom.TabIndex = 35;
            button_createroom.Text = "Tạo Phòng";
            button_createroom.UseVisualStyleBackColor = false;
            // 
            // button_logout
            // 
            button_logout.AutoSize = true;
            button_logout.BackColor = Color.DarkSlateBlue;
            button_logout.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button_logout.ForeColor = Color.White;
            button_logout.Location = new Point(801, 451);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(138, 44);
            button_logout.TabIndex = 36;
            button_logout.Text = "Đăng Xuất";
            button_logout.UseVisualStyleBackColor = false;
            // 
            // button_findroom
            // 
            button_findroom.AutoSize = true;
            button_findroom.BackColor = Color.DarkSlateBlue;
            button_findroom.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button_findroom.ForeColor = Color.White;
            button_findroom.Location = new Point(369, 233);
            button_findroom.Name = "button_findroom";
            button_findroom.Size = new Size(224, 54);
            button_findroom.TabIndex = 37;
            button_findroom.Text = "Tìm Phòng";
            button_findroom.UseVisualStyleBackColor = false;
            // 
            // textBox_tentaikhoan
            // 
            textBox_tentaikhoan.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_tentaikhoan.Location = new Point(23, 12);
            textBox_tentaikhoan.Name = "textBox_tentaikhoan";
            textBox_tentaikhoan.Size = new Size(239, 34);
            textBox_tentaikhoan.TabIndex = 38;
            textBox_tentaikhoan.TextChanged += textBox_tentaikhoan_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox1.Location = new Point(23, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 34);
            textBox1.TabIndex = 39;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackGround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 521);
            Controls.Add(textBox1);
            Controls.Add(textBox_tentaikhoan);
            Controls.Add(button_findroom);
            Controls.Add(button_logout);
            Controls.Add(button_createroom);
            Controls.Add(button2);
            Controls.Add(button_playwithai);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_playwithai;
        private Button button2;
        private Button button_createroom;
        private Button button_logout;
        private Button button_findroom;
        private TextBox textBox_tentaikhoan;
        private TextBox textBox1;
    }
}