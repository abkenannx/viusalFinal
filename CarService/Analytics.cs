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
    public partial class Analytics : Form
    {

        string connectionString = @"Server=DESKTOP-QK8CS7Q\SQLEXPRESS01;Database=CarServiceDb;Trusted_Connection=True;Encrypt=False;";

        public Analytics()
        {
            InitializeComponent();
            GetCarsTotal();
            GetStocksTotal();
            GetEmployeesTotal();
            GetPriceTotal();
        }

        private void GetCarsTotal()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Cars";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int totalCars = (int)cmd.ExecuteScalar();
                    carsTotal.Text = totalCars.ToString(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching cars total: " + ex.Message);
                }
            }
        }

        private void GetStocksTotal()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Stocks";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int totalStocks = (int)cmd.ExecuteScalar();
                    stocksTotal.Text = totalStocks.ToString(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching stocks total: " + ex.Message);
                }
            }
        }

        private void GetEmployeesTotal()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Employees";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int totalEmployees = (int)cmd.ExecuteScalar();
                    employeesTotal.Text = totalEmployees.ToString(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching employees total: " + ex.Message);
                }
            }
        }

        private void GetPriceTotal()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT SUM(total_price) FROM Bills";
                    SqlCommand cmd = new SqlCommand(query, con);
                    object result = cmd.ExecuteScalar();
                    decimal totalPrice = result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                    priceTotal.Text = totalPrice.ToString("F2"); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching total price: " + ex.Message);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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
    }
}
