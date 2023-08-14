using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class UserLogin : Form
    {
        private Method method = new Method();
        public UserLogin(Method values)
        {
            InitializeComponent();
            method = values;
        }

        private void Hide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Hide, "Hide Password");
        }
        private void Show_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Show, "Show Password");
        }
        private void Show_Click(object sender, EventArgs e)
        {
            Show.Hide();
            TxtPass.UseSystemPasswordChar = false;
            Hide.Show();
        }
        private void Hide_Click(object sender, EventArgs e)
        {
            Hide.Hide();
            TxtPass.UseSystemPasswordChar = true;
            Show.Show();
        }
        private void LblSignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // for signup label click
        {
            this.Hide();
            UserSignUp user = new UserSignUp();
            user.Show();
        }

        int retrynum;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = TxtUsr.Text;
            password = TxtPass.Text;

            if (username != string.Empty && password != string.Empty)
            {
                string query = "select userName, password, id from user where userName = @UName and password = @Password";
                MySqlCommand command = new MySqlCommand(query, method.Connection());
                command.Parameters.AddWithValue("@UName", username);
                command.Parameters.AddWithValue("@Password", password);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string readerUName = reader.GetValue(0).ToString();
                    if (readerUName == "admin")
                    {
                        MessageBox.Show("Login Successful!!!", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        AdminBookingList adminSeac = new AdminBookingList(method);
                        adminSeac.Show();
                        return;
                    }
                    int userID = reader.GetInt32(2);



                    //for checkout room
                    string checkout = "select roomNumber from userbooking where checkOut = false and id = @userID";
                    MySqlCommand COCommand = new MySqlCommand(checkout, method.Connection());
                    COCommand.Parameters.AddWithValue("@userID", userID);
                    MySqlDataReader CODataReader = COCommand.ExecuteReader();
                    if (CODataReader.Read())
                        method.roomNumber = CODataReader.GetInt32(0);



                    method.userName = username;
                    this.Hide();
                    Rooms rooms = new Rooms(method);
                    rooms.Show();

                }
                else
                {
                    MessageBox.Show("Enter Valid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    retrynum += 1;

                    if (retrynum >= 5)
                    {
                        timer1.Interval = 60000; // 1 minute
                        timer1.Start();
                        MessageBox.Show("Too many attempts: Please wait 1 minutes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtUsr.ReadOnly = true;
                        TxtPass.ReadOnly = true;
                        BtnLogin.Enabled = false;

                    }
                    MessageBox.Show("Login failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUsr.Clear();
                    TxtPass.Clear();
                    TxtUsr.Focus();

                }

            }
            else
            {
                MessageBox.Show("Please Enter Both UserName and Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUsr.Clear();
                TxtPass.Clear();
                TxtUsr.Focus();
            }

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            //this.SuspendLayout();
            method.Connection();

            //this.ResumeLayout();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage(method);
            homePage.Show();
        }
    }
}
