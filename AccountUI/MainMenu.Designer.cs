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
            button2 = new Button();
            button_createroom = new Button();
            button_findroom = new Button();
            SuspendLayout();
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
            button_createroom.Location = new Point(370, 167);
            button_createroom.Name = "button_createroom";
            button_createroom.Size = new Size(224, 54);
            button_createroom.TabIndex = 35;
            button_createroom.Text = "Tạo Phòng";
            button_createroom.UseVisualStyleBackColor = false;
            // 
            // button_findroom
            // 
            button_findroom.AutoSize = true;
            button_findroom.BackColor = Color.DarkSlateBlue;
            button_findroom.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button_findroom.ForeColor = Color.White;
            button_findroom.Location = new Point(370, 260);
            button_findroom.Name = "button_findroom";
            button_findroom.Size = new Size(224, 54);
            button_findroom.TabIndex = 37;
            button_findroom.Text = "Tìm Phòng";
            button_findroom.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackGround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 521);
            Controls.Add(button_findroom);
            Controls.Add(button_createroom);
            Controls.Add(button2);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button_createroom;
        private Button button_findroom;
    }
}