using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class Rooms : Form
    {
        private Method method = new Method();
        public Rooms(Method values)
        {
            InitializeComponent();
            method = values;
        }
        private void RoomLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Rooms user = new Rooms(method);
            user.Show();
        }

        private void HomeLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HomePage user = new HomePage(method);
            user.Show();
        }

        private void BookLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(method.userName == null)
            {
                MessageBox.Show("You must login to reserve the room");
                this.Hide();
                UserLogin login = new UserLogin(method);
                login.Show();
                return;
            }
            this.Hide();
            UserBooking userbooking = new UserBooking(method);
            
            userbooking.Show();
        }


/*        private void LogInLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserLogin user = new UserLogin(method);
            user.Show();
        }*/

        private void Rooms_Load(object sender, EventArgs e)
        {


            //to show or hide room card
            SVRCard.Visible = true;
            PKRCard.Visible = true;
            RRCard.Visible = true;
            SRCard.Visible = true;
            string selectAvailable = "select roomNumber from rooms where available = 0";
            MySqlCommand SACommand = new MySqlCommand(selectAvailable, method.Connection());
            MySqlDataReader SADataReader = SACommand.ExecuteReader();
            while (SADataReader.Read())
            {
                int roomNumber = int.Parse(SADataReader.GetValue(0).ToString());
                switch (roomNumber)
                {
                    case 203:
                        SVRCard.Visible = false;
                        break;
                    case 302:
                        PKRCard.Visible = false;
                        break;
                    case 403:
                        RRCard.Visible = false;
                        break;
                    case 101:
                        SRCard.Visible = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void SeaVR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //checking user is login or not
            if (method.userName == null)
            {
                MessageBox.Show("You must login to reserve the room");
                this.Hide();
                UserLogin login = new UserLogin(method);
                login.Show();
                return;
            }

            this.Hide();
            UserBooking user = new UserBooking(method);
            method.roomType = 1;
            user.Show();
        }

        private void PremiumKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //checking user is login or not
            if (method.userName == null)
            {
                MessageBox.Show("You must login to reserve the room");
                this.Hide();
                UserLogin login = new UserLogin(method);
                login.Show();
            }

            this.Hide();
            UserBooking user = new UserBooking(method);
            method.roomType = 2;
            user.Show();
            return;
        }

        private void RoyalR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //checking user is login or not
            if (method.userName == null)
            {
                MessageBox.Show("You must login to reserve the room");
                this.Hide();
                UserLogin login = new UserLogin(method);
                login.Show();
                return;
            }

            this.Hide();
            UserBooking user = new UserBooking(method);
            method.roomType = 3;
            user.Show();
        }

        private void SamllR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //checking user is login or not
            if (method.userName == null)
            {
                MessageBox.Show("You must login to reserve the room");
                this.Hide();
                UserLogin login = new UserLogin(method);
                login.Show();
                return;
            }

            this.Hide();
            UserBooking user = new UserBooking(method);
            method.roomType = 4;
            user.Show();
        }

        private void CheckOutLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserCheckOut UCOut = new UserCheckOut(method);
            UCOut.Show();
        }


        // My check out
        /*        private void CheckOutLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                    HomePage home = new HomePage(method);
                    MessageBox.Show("Check Out Now"); // will be with Yes NO option

                    //changing check out state from userbooking
                    string checkOut = "update userbooking set checkOut = 1 where roomNumber = @roomNumber";
                    MySqlCommand COCommand = new MySqlCommand(checkOut, method.Connection());
                    COCommand.Parameters.AddWithValue("@roomNumber", method.roomNumber);
                    MySqlDataReader UBDataReader = COCommand.ExecuteReader();
                    UBDataReader.Read();
                    UBDataReader.Close();

                    //changing available state from rooms
                    string available = "update rooms set available = true where roomNumber = @roomNumber";
                    MySqlCommand ACommand = new MySqlCommand(available, method.Connection());
                    ACommand.Parameters.AddWithValue("@roomNumber", method.roomNumber);
                    MySqlDataReader ADataReader = ACommand.ExecuteReader();
                    ADataReader.Read();
                    ADataReader.Close();

                    method.userName = null;
                    this.Hide();
                    home.Show();
                }*/
    }
}
