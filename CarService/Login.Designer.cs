namespace CarService
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            LoginBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            PasswordTb = new TextBox();
            UsernameTb = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(LoginBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PasswordTb);
            panel1.Controls.Add(UsernameTb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 593);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(164, 454);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 7;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Gray;
            LoginBtn.FlatAppearance.BorderColor = Color.Gray;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            LoginBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(243, 445);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(94, 35);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(176, 317);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(176, 234);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(176, 350);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(222, 27);
            PasswordTb.TabIndex = 3;
            PasswordTb.UseSystemPasswordChar = true;
            // 
            // UsernameTb
            // 
            UsernameTb.Location = new Point(176, 267);
            UsernameTb.Name = "UsernameTb";
            UsernameTb.Size = new Size(222, 27);
            UsernameTb.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(198, 161);
            label1.Name = "label1";
            label1.Size = new Size(175, 35);
            label1.TabIndex = 1;
            label1.Text = "AB Garage";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 593);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox PasswordTb;
        private TextBox UsernameTb;
        private Label label3;
        private Label label2;
        private Button LoginBtn;
        private LinkLabel linkLabel1;
    }
}