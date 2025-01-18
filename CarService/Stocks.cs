using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 


namespace CarService
{
    public partial class Stocks : Form
    {
        string connectionString = @"Server=DESKTOP-QK8CS7Q\SQLEXPRESS01;Database=CarServiceDb;Trusted_Connection=True;Encrypt=False;";
        public Stocks()
        {
            InitializeComponent();
            DisplayStocks();
        }

        private void DisplayStocks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Stocks";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Stocks_Load(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addStock_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Stocks (detal_name, quantity, detal_price) VALUES (@detalName, @quantity, @detalPrice)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@detalName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(textBox2.Text));
                        cmd.Parameters.AddWithValue("@detalPrice", decimal.Parse(textBox3.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stock added successfully!");
                        DisplayStocks(); // Refresh data grid
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void editStock_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE Stocks SET detal_name = @detalName, quantity = @quantity, detal_price = @detalPrice WHERE stock_id = @stockId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@stockId", GetSelectedStockId());
                        cmd.Parameters.AddWithValue("@detalName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(textBox2.Text));
                        cmd.Parameters.AddWithValue("@detalPrice", decimal.Parse(textBox3.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stock updated successfully!");
                        DisplayStocks(); // Refresh data grid
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void deleteStock_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM Stocks WHERE stock_id = @stockId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@stockId", GetSelectedStockId());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stock deleted successfully!");
                        DisplayStocks(); // Refresh data grid
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private int GetSelectedStockId()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["stock_id"].Value);
            }
            else
            {
                throw new Exception("Please select a row first!");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is selected
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBox1.Text = row.Cells["detal_name"].Value.ToString();
                textBox2.Text = row.Cells["quantity"].Value.ToString();
                textBox3.Text = row.Cells["detal_price"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            textBox1.Clear(); 
            textBox2.Clear();
            textBox3.Clear();
        }

    }
}
