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
    public partial class Billing : Form
    {
        string connectionString = @"Server=DESKTOP-QK8CS7Q\SQLEXPRESS01;Database=CarServiceDb;Trusted_Connection=True;Encrypt=False;";
        public Billing()
        {
            InitializeComponent();
            DisplayBills();
        }
        private void DisplayBills()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Bills";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView4.DataSource = dt;
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void addBill_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Bills (customer_name, customer_phone, payment_method, bill_price, fee, total_price) VALUES (@name, @phone, @payment, @billPrice, @fee, @totalPrice)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", custName.Text);
                        cmd.Parameters.AddWithValue("@phone", custPhone.Text);
                        cmd.Parameters.AddWithValue("@payment", payMethod.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@billPrice", Convert.ToDecimal(billPrice.Text));
                        cmd.Parameters.AddWithValue("@fee", Convert.ToDecimal(serviceFee.Text));
                        cmd.Parameters.AddWithValue("@totalPrice", Convert.ToDecimal(totalPrice.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bill added successfully!");
                        DisplayBills(); 
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void editBill_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE Bills SET customer_name = @name, customer_phone = @phone, payment_method = @payment, bill_price = @billPrice, fee = @fee, total_price = @totalPrice WHERE bill_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", GetSelectedBillId());
                        cmd.Parameters.AddWithValue("@name", custName.Text);
                        cmd.Parameters.AddWithValue("@phone", custPhone.Text);
                        cmd.Parameters.AddWithValue("@payment", payMethod.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@billPrice", Convert.ToDecimal(billPrice.Text));
                        cmd.Parameters.AddWithValue("@fee", Convert.ToDecimal(serviceFee.Text));
                        cmd.Parameters.AddWithValue("@totalPrice", Convert.ToDecimal(totalPrice.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bill updated successfully!");
                        DisplayBills(); // Refresh data grid
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void deleteBill_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM Bills WHERE bill_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", GetSelectedBillId());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bill deleted successfully!");
                        DisplayBills(); // Refresh data grid
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private int GetSelectedBillId()
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView4.SelectedRows[0].Cells["bill_id"].Value);
            }
            else
            {
                throw new Exception("Please select a row first!");
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is selected
            {
                DataGridViewRow row = dataGridView4.Rows[e.RowIndex];
                custName.Text = row.Cells["customer_name"].Value.ToString();
                custPhone.Text = row.Cells["customer_phone"].Value.ToString();
                payMethod.SelectedItem = row.Cells["payment_method"].Value.ToString();
                billPrice.Text = row.Cells["bill_price"].Value.ToString();
                serviceFee.Text = row.Cells["fee"].Value.ToString();
                totalPrice.Text = row.Cells["total_price"].Value.ToString();
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearFields()
        {
            custName.Clear();           
            custPhone.Clear();          
            payMethod.SelectedIndex = -1; 
            billPrice.Clear();          
            serviceFee.Clear();         
            totalPrice.Clear();         
        }

    }
}
