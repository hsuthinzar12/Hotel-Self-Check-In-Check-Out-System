using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class AdminBookingList : Form
    {

        private Method method = new Method();
        public AdminBookingList(Method values)
        {
            InitializeComponent();
            method = values;
            bookingList.CellMouseClick += bookingList_CellMouseClick;
        }
        private void SearchLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminSearch admin = new AdminSearch(method);
            admin.Show();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage user = new HomePage(method);
            user.Show();
        }

        private void AddLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminUpdate admin = new AdminUpdate();
            admin.Show();
        }

        private void AdminBookingList_Load(object sender, EventArgs e)
        {

            method.Connection();

            string select = "select u.userName, ub.duration, ub.extraBeds, ub.checkIn, ub.checkOut, ub.roomNumber, ub.paymentImage from userbooking ub, user u where ub.id = u.id";
            MySqlCommand selectCommand = new MySqlCommand(select, method.Connection());
            MySqlDataReader selectReader = selectCommand.ExecuteReader();
            while (selectReader.Read())
            {
                bookingList.Rows.Add(selectReader[0], selectReader[1], selectReader[2], selectReader[3], selectReader[4], selectReader[5], selectReader[6]);
            }
        }

        private void bookingList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsrChkOutBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminCheckOut admin = new AdminCheckOut();
            admin.Show();
        }

        private void RightClickBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataGridViewCellMouseEventHandler bookingList_CellMouseClick { get; private set; }

        private int rowIndex = 0;
        private void bookingList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.bookingList.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.bookingList.CurrentCell = this.bookingList.Rows[e.RowIndex].Cells[1];
                    this.UserInfoRClick.Show(this.bookingList, e.Location);
                    UserInfoRClick.Show(Cursor.Position);
                }
            }
            catch
            {
                MessageBox.Show("Click Cell Content");
            }
        }

      /*  private void UsrChkOut_Click(object sender, EventArgs e)
        {
            AdminCheckOut adchkout = new AdminCheckOut();
            adchkout.Show();
        }

        private void UsrUptList_Click(object sender, EventArgs e)
        {
            AdminUpdate adupt = new AdminUpdate();
            adupt.Show();
        }

        private void UsrSercList_Click(object sender, EventArgs e)
        {
            AdminSearch adserc = new AdminSearch(method);
            adserc.Show();
        }*/

        // To show image of payment
        private void bookingList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bookingList.Columns[e.ColumnIndex].Name == "image")
            {
                DataGridViewCell imageName = bookingList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string imgaePath = $"C:/Users/HSU Thinzar/Desktop/HotelProjectC#/image/Payment/{imageName.Value}";
                pbxPayment.Visible = true;
                int height = 750;
                int width = 750;
                pbxPayment.Image = Image.FromFile(imgaePath);
                Size newsize = Calculate(pbxPayment.Size, height, width);
                pbxPayment.Size = newsize;
                pbxPayment.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        // To change Size of the Image
        private Size Calculate(Size imagesize, int height, int width)
        {
            int newWidth = imagesize.Width;
            int newHeight = imagesize.Height;
            if (newWidth > height)
            {
                newHeight = height;
                newWidth = (int)(((double)imagesize.Width / imagesize.Height) * newHeight);
            }
            if (newWidth > width)
            {
                newWidth = width;
                newHeight = (int)(((double)imagesize.Height / imagesize.Width) * newWidth);
            }
            return new Size(newWidth, newHeight);
        }

        private void bookingList_MouseClick(object sender, MouseEventArgs e)
        {
            /*            if(pbxPayment.Visible == true)
                        {
                            pbxPayment.Visible = false;
                        }*/
        }

        private void pbxPayment_Click(object sender, EventArgs e)
        {
            pbxPayment.Visible = false;
        }

        private void UserInfoRClick_Opening(object sender, CancelEventArgs e)
        {

        }

        private void LblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Press Yes to back HomePage", "Are you Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                HomePage hmpage = new HomePage(method);
                hmpage.Show();
            }
        }

        private void UsrActivity_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminActivity admact = new AdminActivity(method);
            admact.Show();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminActivity usractv = new AdminActivity(method);
            usractv.Show();
        }
        private void userBookingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminBookingList admbklist = new AdminBookingList(method);
            admbklist.Show();
        }

        private void updateRoomsPriceAndUserInfromationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUpdate admupt = new AdminUpdate();
            admupt.Show();
        }

        private void searchUsersAndRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSearch admserc = new AdminSearch(method);
            admserc.Show();
        }

        private void userCheckOutListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminCheckOut admchkout = new AdminCheckOut();
            admchkout.Show();
        }

        private void LblLogout_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(LblHome,"Back to Home Page");
        }


        /* private void updateToolStripMenuItem_Click(object sender, EventArgs e)
         {

         }
         private void bookingList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
         {
             try
             {
                 if(e.Button == MouseButtons.Right)
                 {
                     bookingList.ClearSelection();
                     bookingList.CurrentCell = bookingList.Rows[e.RowIndex].Cells[1];
                     bookingList.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                     .Show(MousePosition);

                     DataGridView row = this.bookingList.Rows[e.RowIndex];

                 }
             }
         }*/

    }
}

