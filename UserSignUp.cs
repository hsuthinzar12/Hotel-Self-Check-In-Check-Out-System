using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class UserSignUp : Form
    {
        private Method method = new Method();
        public UserSignUp(Method values)
        {
            InitializeComponent();
            method = values;
            TxtPass.UseSystemPasswordChar = true;
            TxtConfirmPw.UseSystemPasswordChar = true;
        }
        public UserSignUp()
        {
            InitializeComponent();
            TxtPass.UseSystemPasswordChar = true;
            TxtConfirmPw.UseSystemPasswordChar = true; // password hide and show
        }
        private void LoginLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserLogin usrlogin = new UserLogin(method);
            usrlogin.Show();
        }
        private bool ExistUsr(string username) // Restrict existing user name to signup
        {
            try
            {
                string cn = "server=localhost;uid=root;pwd=root;database=hotelprj";
                using (MySqlConnection cd = new MySqlConnection(cn))
                {
                    cd.Open();

                    string query = "SELECT * FROM user WHERE userName = @Username";
                    MySqlCommand command = new MySqlCommand(query, cd);
                    command.Parameters.AddWithValue("@Username", username);

                    int count = Convert.ToInt32(command.ExecuteScalar()); // execute query and return count as int
                    cd.Close();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string username = TxtUsr.Text.Trim();
            string phoneNumber = TxtPhNum.Text.Trim();
            string dob = TxtDob.Text.Trim();
            string address = TxtAddr.Text.Trim();
            string password = TxtPass.Text;
            string confirmPassword = TxtConfirmPw.Text;
            if (ExistUsr(username)) // Restrict existing user
            {
                MessageBox.Show("Username already exists. Please choose another different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword) // validate to equal password and confirmpassword
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8 || password.Length > 16) // validate password length
            {
                MessageBox.Show("Password must be between 8-16 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var hasUpperChar = new Regex(@"[A-Z]+"); //Upper Case letter
            var hasLowerChar = new Regex(@"[a-z]+"); // Lower Case letter
            var hasNumber = new Regex(@"\d.*\d.*\d"); // number
            var phnum = new Regex(@"^(?:\+?)[0-9]{10,14}$");

            if (!hasUpperChar.IsMatch(password) || !hasLowerChar.IsMatch(password) || !hasNumber.IsMatch(password))
            {
                MessageBox.Show("Password must contain at least one uppercase, lowercase character, and 3 numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!phnum.IsMatch(phoneNumber)) // phone number validation
            {
                MessageBox.Show("Invalid Phone Number, Phone Number must have 11 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            try
            {
                string cn = "server=localhost;uid=root;pwd=root;database=hotelprj";  // connect with database

                using (MySqlConnection cd = new MySqlConnection(cn))
                {
                    cd.Open();

                    string query = "INSERT INTO user (userName, phoneNumber, DOB, address, password) VALUES (@Username, @PhoneNumber, @DOB, @Address, @Password)"; // Insert into database 
                    MySqlCommand command = new MySqlCommand(query, cd);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@DOB", dob);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Password", password);

                    MySqlDataReader read = command.ExecuteReader();
                    read.Read();
                    cd.Close();
                }

                MessageBox.Show("Your account has been created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                UserLogin usrlogin = new UserLogin(method);
                usrlogin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUsr.Clear();
                TxtPhNum.Clear();
                TxtPass.Clear();
                TxtAddr.Clear();
                TxtUsr.Focus();
            }
        }

        private void TxtDob_ValueChanged(object sender, EventArgs e)
        {
            TxtDob.Format = DateTimePickerFormat.Custom;
            TxtDob.CustomFormat = "yyyy,MM,dd";
        }

        private void HidePw_Click(object sender, EventArgs e)
        {
            HidePw.Hide();
            TxtConfirmPw.UseSystemPasswordChar = true;
            ShowPw.Show();
        }

        private void ShowPw_Click(object sender, EventArgs e)
        {
            ShowPw.Hide();
            TxtConfirmPw.UseSystemPasswordChar = false;
            HidePw.Show();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            Hide.Hide();
            TxtPass.UseSystemPasswordChar = true;
            Show.Show();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            Show.Show();
            TxtPass.UseSystemPasswordChar = false;
            Hide.Show();
        }

        private void SignUpBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignUpBtn.PerformClick();
            }
        }
    }
}
