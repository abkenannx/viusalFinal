using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CarService
{
    public partial class Cars : Form
    {
        string connectionString = @"Server=DESKTOP-QK8CS7Q\SQLEXPRESS01;Database=CarServiceDb;Trusted_Connection=True;Encrypt=False;";


        public Cars()
        {
            InitializeComponent();
            DisplayCars(); // Display data in DataGridView on form load
        }
        // READ: Display cars in DataGridView
        private void DisplayCars()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Cars";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawString("Welcome to Panel 1", this.Font, Brushes.Black, new PointF(10, 10));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // CREATE: Add a new car
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CarNumbTb.Text == "" || CarBrandTb.Text == "" || CarModelTb.Text == "" || ColorTb.Text == "" || OwnerNameTb.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Cars (car_number, car_brand, car_model, service_date, car_color, owner_name) VALUES (@CarNumber, @CarBrand, @CarModel, @ServiceDate, @CarColor, @OwnerName)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CarNumber", CarNumbTb.Text);
                cmd.Parameters.AddWithValue("@CarBrand", CarBrandTb.Text);
                cmd.Parameters.AddWithValue("@CarModel", CarModelTb.Text);
                cmd.Parameters.AddWithValue("@ServiceDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@CarColor", ColorTb.Text);
                cmd.Parameters.AddWithValue("@OwnerName", OwnerNameTb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Car added successfully!");
                DisplayCars();
                ClearFields();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CarsMenu_Click(object sender, EventArgs e)
        {
            Cars page = new Cars();
            page.Show();
            this.Hide();
        }
        private void StockMenu_Click(object sender, EventArgs e)
        {
            Stocks page = new Stocks();
            page.Show();
            this.Hide();
        }
        private void EmployeesMenu_Click(object sender, EventArgs e)
        {
            Employees page = new Employees();
            page.Show();
            this.Hide();
        }
        private void BillingMenu_Click(object sender, EventArgs e)
        {
            Billing page = new Billing();
            page.Show();
            this.Hide();
        }
        private void AnalyticsMenu_Click(object sender, EventArgs e)
        {
            Analytics page = new Analytics();
            page.Show();
            this.Hide();
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            Login page = new Login();
            page.Show();
            this.Hide();
        }

        private void CarBrandTb_TextChanged(object sender, EventArgs e)
        {

        }

        // UPDATE: Edit an existing car
        private void button2_Click(object sender, EventArgs e)
        {
            if (CarNumbTb.Text == "" || CarBrandTb.Text == "" || CarModelTb.Text == "" || ColorTb.Text == "" || OwnerNameTb.Text == "")
            {
                MessageBox.Show("Please select a car to update!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Cars SET car_number = @CarNumber, car_brand = @CarBrand, car_model = @CarModel, service_date = @ServiceDate, car_color = @CarColor, owner_name = @OwnerName WHERE car_id = @CarId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CarId", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@CarNumber", CarNumbTb.Text);
                cmd.Parameters.AddWithValue("@CarBrand", CarBrandTb.Text);
                cmd.Parameters.AddWithValue("@CarModel", CarModelTb.Text);
                cmd.Parameters.AddWithValue("@ServiceDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@CarColor", ColorTb.Text);
                cmd.Parameters.AddWithValue("@OwnerName", OwnerNameTb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Car updated successfully!");
                DisplayCars();
                ClearFields();
            }
        }

        // DELETE: Delete a car
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a car to delete!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Cars WHERE car_id = @CarId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CarId", dataGridView1.CurrentRow.Cells[0].Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Car deleted successfully!");
                DisplayCars();
                ClearFields();
            }
        }
        private void ClearFields()
        {
            CarNumbTb.Clear();
            CarBrandTb.Clear();
            CarModelTb.Clear();
            ColorTb.Clear();
            OwnerNameTb.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

           // Handle row selection in DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                CarNumbTb.Text = row.Cells["car_number"].Value.ToString();
                CarBrandTb.Text = row.Cells["car_brand"].Value.ToString();
                CarModelTb.Text = row.Cells["car_model"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["service_date"].Value);
                ColorTb.Text = row.Cells["car_color"].Value.ToString();
                OwnerNameTb.Text = row.Cells["owner_name"].Value.ToString();
            }
        }

    }
}
