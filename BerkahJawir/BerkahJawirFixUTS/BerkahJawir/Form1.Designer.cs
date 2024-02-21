namespace BerkahJawir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_username = new TextBox();
            tb_pass = new TextBox();
            btn_login = new Button();
            btn_loginCash = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(303, 26);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(546, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 26);
            label1.TabIndex = 1;
            label1.Text = "Aladin's Shop";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(94, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 13);
            label2.TabIndex = 2;
            label2.Text = "Shoping in the desert!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 134);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 14);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 187);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 14);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // tb_username
            // 
            tb_username.BorderStyle = BorderStyle.FixedSingle;
            tb_username.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_username.Location = new Point(37, 152);
            tb_username.Margin = new Padding(2);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(217, 22);
            tb_username.TabIndex = 5;
            // 
            // tb_pass
            // 
            tb_pass.BorderStyle = BorderStyle.FixedSingle;
            tb_pass.Location = new Point(37, 205);
            tb_pass.Margin = new Padding(2);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(217, 23);
            tb_pass.TabIndex = 6;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkSlateBlue;
            btn_login.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.ControlLightLight;
            btn_login.Location = new Point(37, 266);
            btn_login.Margin = new Padding(2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(216, 34);
            btn_login.TabIndex = 7;
            btn_login.Text = "Login as Admin";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_loginCash
            // 
            btn_loginCash.BackColor = Color.MidnightBlue;
            btn_loginCash.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loginCash.ForeColor = SystemColors.ControlLightLight;
            btn_loginCash.Location = new Point(37, 304);
            btn_loginCash.Margin = new Padding(2);
            btn_loginCash.Name = "btn_loginCash";
            btn_loginCash.Size = new Size(216, 34);
            btn_loginCash.TabIndex = 8;
            btn_loginCash.Text = "Login as Cashier";
            btn_loginCash.UseVisualStyleBackColor = false;
            btn_loginCash.Click += btn_loginCash_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 395);
            Controls.Add(btn_loginCash);
            Controls.Add(btn_login);
            Controls.Add(tb_pass);
            Controls.Add(tb_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_username;
        private TextBox tb_pass;
        private Button btn_login;
        private Button btn_loginCash;
    }
}