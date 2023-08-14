using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class HomePage : Form
    {
        private Method method = new Method();
        public HomePage(Method values)
        {
            InitializeComponent();
            method = values;
            RemoveLinkLabelUnderline(RoomLblLink);
            RemoveLinkLabelUnderline(LoginBtn);
            RemoveLinkLabelUnderline(CheckOutLblLink);
        }

        private void RemoveLinkLabelUnderline(LinkLabel linkLabel)
        {
            linkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
        }
        private bool initialized = false;

        private void LoginBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!initialized)
            {
                ThreadPool.QueueUserWorkItem(state =>
                {
                    Thread.Sleep(1);
                    this.Invoke((Action)delegate
                    {
                        this.Hide();
                        UserLogin user = new UserLogin(method);

                        user.Show();

                    });
                });
            }// this.Hide();
        }

        private void RoomLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Rooms room = new Rooms(method);
            room.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            if (method.userName == null)
            {
                CheckOutLblLink.Visible = false;
            }
            if ((method.userName != null) && (method.userName == ""))
            {
                LoginBtn.Visible = false;
            }
        }

        private void CheckOutLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserCheckOut user = new UserCheckOut(method);
            user.Show();
            method.isCheckout = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ActivityLayOut ALO = new ActivityLayOut(method);
            this.Hide();
            ALO.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminActivity AA = new AdminActivity(method);
            this.Hide();
            AA.Show();
        }

        private void lblLogoff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result =  MessageBox.Show("Do you want to Sing out now?", "Are you Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                method.userName = null;
            }
            

        }
        /*        private void BookingLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
this.Hide();
UserBooking userbooking = new UserBooking(method);
userbooking.Show();
}*/
    }
}
