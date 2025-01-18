using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Ensure you include this


namespace CarService
{
    public partial class Employees : Form
    {
        string connectionString = @"Server=DESKTOP-QK8CS7Q\SQLEXPRESS01;Database=CarServiceDb;Trusted_Connection=True;Encrypt=False;";
        public Employees()
        {
            InitializeComponent();
            DisplayEmployees();
        }

        private void DisplayEmployees()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Employees";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView3.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
        private void Logout_Click(object sender, EventArgs e)
        {
            Login page = new Login();
            page.Show();
            this.Hide();
        }
        private void AnalyticsMenu_Click(object sender, EventArgs e)
        {
            Analytics page = new Analytics();
            page.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void addEmp_Click(object sender, EventArgs e)
{
    try
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            string query = "INSERT INTO Employees (employee_name, employee_adress, employee_gender) VALUES (@name, @address, @gender)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@name", empName.Text);
                cmd.Parameters.AddWithValue("@address", empAdress.Text);
                cmd.Parameters.AddWithValue("@gender", empGender.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee added successfully!");
                DisplayEmployees(); // Refresh data grid
                ClearFields();
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("An error occurred: " + ex.Message);
    }
}

        private void editEmp_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE Employees SET employee_name = @name, employee_adress = @address, employee_gender = @gender WHERE employee_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", GetSelectedEmployeeId());
                        cmd.Parameters.AddWithValue("@name", empName.Text);
                        cmd.Parameters.AddWithValue("@address", empAdress.Text);
                        cmd.Parameters.AddWithValue("@gender", empGender.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee updated successfully!");
                        DisplayEmployees(); // Refresh data grid
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void deleteEmp_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM Employees WHERE employee_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", GetSelectedEmployeeId());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee deleted successfully!");
                        DisplayEmployees(); // Refresh data grid
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private int GetSelectedEmployeeId()
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["employee_id"].Value);
            }
            else
            {
                throw new Exception("Please select a row first!");
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is selected
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                empName.Text = row.Cells["employee_name"].Value.ToString();
                empAdress.Text = row.Cells["employee_adress"].Value.ToString();
                empGender.SelectedItem = row.Cells["employee_gender"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            empName.Clear();             // Clear Employee Name
            empAdress.Clear();           // Clear Employee Address
            empGender.SelectedIndex = -1; // Reset ComboBox (Gender) to no selection
        }

    }
}
