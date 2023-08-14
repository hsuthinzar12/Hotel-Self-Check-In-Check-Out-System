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
        public Rooms()
        {
            InitializeComponent();
        }

        private void RoomLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Rooms user = new Rooms();
            user.Show();
        }

        private void HomeLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HomePage user = new HomePage();
            user.Show();
        }

        private void BookLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserBooking user = new UserBooking();
            user.Show();
        }

        private void SignUpLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserSignUp user = new UserSignUp();
            user.Show();
        }

        private void LogInLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserLogin user = new UserLogin();
            user.Show();
        }

        private void BookingLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserBooking user = new UserBooking();
            user.Show();
        }

        private void BookingLink2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserBooking user = new UserBooking();
            user.Show();
        }

        private void BookingLink3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserBooking user = new UserBooking();
            user.Show();
        }

        private void BookingLink4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserBooking user = new UserBooking();
            user.Show();
        }
    }
}
