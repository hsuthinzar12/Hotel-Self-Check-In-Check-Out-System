using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
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
            TxtPass.UseSystemPasswordChar = true;
        }

        /*public Boolean validate(string password)
        {
*//*            bool lower = false;
            bool upper = false;
            foreach(char c in password)
            {
                if(Char.IsUpper(c)) lower = true;
                if(char.IsLower(c)) upper = true;
                if(lower == true && upper == true)
                {
                    return true;
                }
            }
            return false;*//*
        }*/
        int userID;
        private int retrynum = 0;
        private int RemainingTm;
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
                    
                    

                    if (reader.Read())
                    {
                        string readerUName = reader.GetValue(0).ToString();
                        string readerPassword = reader.GetString(1);
                        method.userName = username;
                        if (readerUName == "admin")
                        {

                            this.Hide();
                            AdminBookingList adminSeac = new AdminBookingList(method);
                            adminSeac.Show();
                            return;
                        }
                        userID = reader.GetInt32(2);
                        if (method.roomNumber > 100)
                        {
                            this.Hide();
                            UserBooking UB = new UserBooking(method);
                            UB.Show();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    this.Hide();
                    Rooms rooms = new Rooms(method);
                    rooms.Show();

                }
                else
                {
                    MessageBox.Show("Enter Valid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    retrynum++;
                    TxtUsr.Clear();
                    TxtPass.Clear();
                    TxtUsr.Focus();

                    if (retrynum == 5)
                    {
                        RemainingTm = 60;
                        TimerAtmpt.Enabled = true;
                        MessageBox.Show("Too many attempts: Please wait 1 minute", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtUsr.Enabled = false;
                        TxtPass.Enabled = false;
                        BtnLogin.Enabled = false;

                    }
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Both UserName and Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        int countFPassword;
        private void UserLogin_Load(object sender, EventArgs e)
        {
            //this.SuspendLayout();
            method.Connection();
            countFPassword = 0;
            //this.ResumeLayout();
            this.KeyPreview = true;
            this.AcceptButton = BtnLogin;
            this.forgotPanel.Visible = false;
//            this.forgotPanel.Location = new Point(739, 395);
        }
        private void Hide_Click(object sender, EventArgs e)
        {
            Hide.Hide();
            TxtPass.UseSystemPasswordChar = true;
            Show.Show();
        }
        private void Show_Click(object sender, EventArgs e)
        {
            Show.Hide();
            TxtPass.UseSystemPasswordChar = false;
            Hide.Show();
        }
        private void Hide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Hide, "Hide Password");
        }

        private void Show_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Show, "Show Password");
        }

        private void LblSignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserSignUp user = new UserSignUp();
            user.Show();
        }

        private void BtnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage(method);
            homePage.Show();
        }

        private void ForgetLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            countFPassword++;
            if (countFPassword == 1)
            {
                MessageBox.Show("Relax and try to remember your password", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (countFPassword >= 2)
            {
                forgotPanel.Visible = true;
                
            }

        }

        private void TimerAtmpt_Tick(object sender, EventArgs e)
        {
            if (RemainingTm == 0)
            {
                TimerAtmpt.Enabled = false;
                BtnLogin.Enabled = true;
                TxtUsr.Enabled = true;
                TxtPass.Enabled = true;
                retrynum = 0;
                LblAtmptTmr.Text = string.Empty; // after countdown over
            }
            else
            {

                LblAtmptTmr.Text = "Remaining Time: " + RemainingTm + " seconds";
                RemainingTm--;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if(tbxUName.Text == "")
            {
                MessageBox.Show("Enter User Name");
                return;
            }
            if(tbxCPassword.Text == "" && tbxPassword.Text == "")
            {
                MessageBox.Show("Enter Password to Change");
                return;
            }
            string update = "update user set password = @password where userName = @userName";
            MySqlCommand UCommand = new MySqlCommand(update, method.Connection());
            UCommand.Parameters.AddWithValue("@userName", tbxUName.Text);
            UCommand.Parameters.AddWithValue("@password", tbxCPassword.Text);
            MySqlDataReader UDataReader = UCommand.ExecuteReader();
            
            
                MessageBox.Show("Success");
                forgotPanel.Visible = false;
                groupBox1.Show();
            
            
        }

        private void tbxUName_TextChanged(object sender, EventArgs e)
        {
            lblCUName.Visible = true;
            string select = "select * from user where userName = @userName";
            MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
            SCommand.Parameters.AddWithValue("@userName", tbxUName.Text);
            MySqlDataReader SDataReader = SCommand.ExecuteReader();
            if (SDataReader.Read())
            {
                lblCUName.Text = "User Name Exist";
                lblCUName.ForeColor = Color.Green;
            }
            else
            {
                lblCUName.Text = "User Name Doesnt Exist";
                lblCUName.ForeColor = Color.Red;
            }
        }

        private void tbxCPassword_TextChanged(object sender, EventArgs e)
        {
            string password = tbxPassword.Text;
            string cPassword = tbxCPassword.Text;
            if (password != cPassword)
            {
                lblPError.Visible = true;
                lblPError.Text = "Password Doesnt Match";
                lblPError.ForeColor = Color.Red;
            }
            else
            {
                lblPError.Visible = false;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            forgotPanel.Hide();
            groupBox1.Show();
        }
    }
}
