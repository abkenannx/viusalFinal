using System;
using System.Windows.Forms;

namespace CarService
{
    public partial class Login : Form
    {

        private readonly string validUsername = "admin";
        private readonly string validPassword = "1234";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string enteredUsername = UsernameTb.Text;
            string enteredPassword = PasswordTb.Text;


            if (enteredUsername == validUsername && enteredPassword == validPassword)
            {
                MessageBox.Show("Login Successful!");


                Cars carsForm = new Cars();
                carsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
