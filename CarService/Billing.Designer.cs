namespace CarService
{
    partial class Billing
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            custName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            payMethod = new ComboBox();
            custPhone = new TextBox();
            panel7 = new Panel();
            dataGridView4 = new DataGridView();
            totalPrice = new TextBox();
            deleteBill = new Button();
            editBill = new Button();
            addBill = new Button();
            billPrice = new TextBox();
            serviceFee = new TextBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Logout = new Label();
            label9 = new Label();
            BillingMenu = new Label();
            EmployeesMenu = new Label();
            StocksMenu = new Label();
            CarsMenu = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // custName
            // 
            custName.BackColor = Color.Silver;
            custName.Font = new Font("Candara Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custName.ForeColor = Color.Black;
            custName.Location = new Point(1036, 83);
            custName.MaxLength = 12;
            custName.Name = "custName";
            custName.PlaceholderText = "Customer Name";
            custName.Size = new Size(247, 40);
            custName.TabIndex = 5;
            custName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 14);
            label2.Name = "label2";
            label2.Size = new Size(276, 49);
            label2.TabIndex = 4;
            label2.Text = "Bill Information";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(payMethod);
            panel3.Controls.Add(custPhone);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(totalPrice);
            panel3.Controls.Add(deleteBill);
            panel3.Controls.Add(editBill);
            panel3.Controls.Add(addBill);
            panel3.Controls.Add(billPrice);
            panel3.Controls.Add(serviceFee);
            panel3.Controls.Add(custName);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(275, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(1307, 609);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // payMethod
            // 
            payMethod.Cursor = Cursors.Hand;
            payMethod.Font = new Font("Candara Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payMethod.FormattingEnabled = true;
            payMethod.Items.AddRange(new object[] { "Cash", "Card" });
            payMethod.Location = new Point(1036, 248);
            payMethod.Name = "payMethod";
            payMethod.Size = new Size(247, 36);
            payMethod.TabIndex = 21;
            payMethod.Text = "Payment Method";
            // 
            // custPhone
            // 
            custPhone.BackColor = Color.Silver;
            custPhone.Font = new Font("Candara Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custPhone.ForeColor = Color.Black;
            custPhone.Location = new Point(1036, 170);
            custPhone.MaxLength = 12;
            custPhone.Name = "custPhone";
            custPhone.PlaceholderText = "Customer Phone";
            custPhone.Size = new Size(247, 40);
            custPhone.TabIndex = 20;
            custPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(dataGridView4);
            panel7.Location = new Point(18, 83);
            panel7.Name = "panel7";
            panel7.Size = new Size(971, 480);
            panel7.TabIndex = 15;
            panel7.Paint += panel7_Paint;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView4.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView4.Location = new Point(3, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 30;
            dataGridView4.Size = new Size(965, 474);
            dataGridView4.TabIndex = 3;
            dataGridView4.CellClick += dataGridView4_CellClick;
            // 
            // totalPrice
            // 
            totalPrice.BackColor = Color.Silver;
            totalPrice.Font = new Font("Candara Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPrice.ForeColor = Color.Black;
            totalPrice.Location = new Point(1036, 453);
            totalPrice.MaxLength = 12;
            totalPrice.Name = "totalPrice";
            totalPrice.PlaceholderText = "Total Price";
            totalPrice.Size = new Size(247, 40);
            totalPrice.TabIndex = 19;
            totalPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // deleteBill
            // 
            deleteBill.BackColor = Color.Red;
            deleteBill.Cursor = Cursors.Hand;
            deleteBill.FlatAppearance.BorderSize = 0;
            deleteBill.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            deleteBill.FlatStyle = FlatStyle.Flat;
            deleteBill.Font = new Font("Century", 10.2F, FontStyle.Bold);
            deleteBill.ForeColor = Color.White;
            deleteBill.Location = new Point(1106, 554);
            deleteBill.Name = "deleteBill";
            deleteBill.Size = new Size(100, 41);
            deleteBill.TabIndex = 13;
            deleteBill.Text = "DELETE";
            deleteBill.UseVisualStyleBackColor = false;
            deleteBill.Click += deleteBill_Click;
            // 
            // editBill
            // 
            editBill.BackColor = Color.Green;
            editBill.Cursor = Cursors.Hand;
            editBill.FlatAppearance.BorderSize = 0;
            editBill.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            editBill.FlatStyle = FlatStyle.Flat;
            editBill.Font = new Font("Century", 10.2F, FontStyle.Bold);
            editBill.ForeColor = Color.White;
            editBill.Location = new Point(1166, 507);
            editBill.Name = "editBill";
            editBill.Size = new Size(70, 41);
            editBill.TabIndex = 12;
            editBill.Text = "EDIT";
            editBill.UseVisualStyleBackColor = false;
            editBill.Click += editBill_Click;
            // 
            // addBill
            // 
            addBill.BackColor = Color.MediumBlue;
            addBill.Cursor = Cursors.Hand;
            addBill.FlatAppearance.BorderSize = 0;
            addBill.FlatAppearance.MouseOverBackColor = Color.Navy;
            addBill.FlatStyle = FlatStyle.Flat;
            addBill.Font = new Font("Century", 10.2F, FontStyle.Bold);
            addBill.ForeColor = Color.White;
            addBill.Location = new Point(1062, 507);
            addBill.Name = "addBill";
            addBill.Size = new Size(65, 41);
            addBill.TabIndex = 11;
            addBill.Text = "ADD";
            addBill.UseVisualStyleBackColor = false;
            addBill.Click += addBill_Click;
            // 
            // billPrice
            // 
            billPrice.BackColor = Color.Silver;
            billPrice.Font = new Font("Candara Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billPrice.ForeColor = Color.Black;
            billPrice.Location = new Point(1036, 305);
            billPrice.MaxLength = 12;
            billPrice.Name = "billPrice";
            billPrice.PlaceholderText = "Bill Price";
            billPrice.Size = new Size(247, 40);
            billPrice.TabIndex = 7;
            billPrice.TextAlign = HorizontalAlignment.Center;
            billPrice.TextChanged += textBox3_TextChanged;
            // 
            // serviceFee
            // 
            serviceFee.BackColor = Color.Silver;
            serviceFee.Font = new Font("Candara Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceFee.ForeColor = Color.Black;
            serviceFee.Location = new Point(1036, 375);
            serviceFee.MaxLength = 12;
            serviceFee.Name = "serviceFee";
            serviceFee.PlaceholderText = "Service Fees";
            serviceFee.Size = new Size(247, 40);
            serviceFee.TabIndex = 6;
            serviceFee.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(65, 624);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(40, 45);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 22;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(36, 420);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(58, 61);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(36, 351);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(58, 61);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(36, 282);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 61);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(36, 495);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(0, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(30, 801);
            panel6.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(-14, -10);
            panel5.Name = "panel5";
            panel5.Size = new Size(347, 38);
            panel5.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(-58, 789);
            panel4.Name = "panel4";
            panel4.Size = new Size(330, 36);
            panel4.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 215);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 150);
            label4.Name = "label4";
            label4.Size = new Size(97, 36);
            label4.TabIndex = 5;
            label4.Text = "MENU";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 654);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(178, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 47);
            label3.Name = "label3";
            label3.Size = new Size(208, 47);
            label3.TabIndex = 3;
            label3.Text = "AB Garage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 74);
            label1.Name = "label1";
            label1.Size = new Size(119, 49);
            label1.TabIndex = 2;
            label1.Text = "Billing";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1381, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Logout);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(BillingMenu);
            panel2.Controls.Add(EmployeesMenu);
            panel2.Controls.Add(StocksMenu);
            panel2.Controls.Add(CarsMenu);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 821);
            panel2.TabIndex = 0;
            // 
            // Logout
            // 
            Logout.AutoSize = true;
            Logout.Cursor = Cursors.Hand;
            Logout.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            Logout.ForeColor = Color.Black;
            Logout.Location = new Point(103, 635);
            Logout.Name = "Logout";
            Logout.Size = new Size(90, 27);
            Logout.TabIndex = 34;
            Logout.Text = "Log out";
            Logout.Click += Logout_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(103, 504);
            label9.Name = "label9";
            label9.Size = new Size(108, 27);
            label9.TabIndex = 33;
            label9.Text = "Analytics";
            label9.Click += AnalyticsMenu_Click;
            // 
            // BillingMenu
            // 
            BillingMenu.AutoSize = true;
            BillingMenu.Cursor = Cursors.Hand;
            BillingMenu.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            BillingMenu.ForeColor = Color.Blue;
            BillingMenu.Location = new Point(103, 442);
            BillingMenu.Name = "BillingMenu";
            BillingMenu.Size = new Size(81, 27);
            BillingMenu.TabIndex = 32;
            BillingMenu.Text = "Billing";
            BillingMenu.Click += BillingMenu_Click;
            // 
            // EmployeesMenu
            // 
            EmployeesMenu.AutoSize = true;
            EmployeesMenu.Cursor = Cursors.Hand;
            EmployeesMenu.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            EmployeesMenu.ForeColor = Color.Black;
            EmployeesMenu.Location = new Point(103, 371);
            EmployeesMenu.Name = "EmployeesMenu";
            EmployeesMenu.Size = new Size(125, 27);
            EmployeesMenu.TabIndex = 31;
            EmployeesMenu.Text = "Employees";
            EmployeesMenu.Click += EmployeesMenu_Click;
            // 
            // StocksMenu
            // 
            StocksMenu.AutoSize = true;
            StocksMenu.Cursor = Cursors.Hand;
            StocksMenu.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            StocksMenu.ForeColor = Color.Black;
            StocksMenu.Location = new Point(103, 303);
            StocksMenu.Name = "StocksMenu";
            StocksMenu.Size = new Size(70, 27);
            StocksMenu.TabIndex = 30;
            StocksMenu.Text = "Stock";
            StocksMenu.Click += StockMenu_Click;
            // 
            // CarsMenu
            // 
            CarsMenu.AutoSize = true;
            CarsMenu.Cursor = Cursors.Hand;
            CarsMenu.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            CarsMenu.ForeColor = Color.Black;
            CarsMenu.Location = new Point(103, 233);
            CarsMenu.Name = "CarsMenu";
            CarsMenu.Size = new Size(59, 27);
            CarsMenu.TabIndex = 29;
            CarsMenu.Text = "Cars";
            CarsMenu.Click += CarsMenu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1604, 821);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 821);
            Controls.Add(panel1);
            Name = "Billing";
            Text = "Billing";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox custName;
        private Label label2;
        private Panel panel3;
        private Button deleteBill;
        private Button editBill;
        private Button addBill;
        private TextBox billPrice;
        private TextBox serviceFee;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Panel panel1;
        private Label Logout;
        private Label label9;
        private Label BillingMenu;
        private Label EmployeesMenu;
        private Label StocksMenu;
        private Label CarsMenu;
        private Panel panel7;
        private TextBox totalPrice;
        private TextBox custPhone;
        private ComboBox payMethod;
        private DataGridView dataGridView4;
    }
}