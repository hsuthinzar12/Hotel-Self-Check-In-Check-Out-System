using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomePage
{
    public partial class UserBooking : Form
    {
        private Method method = new Method();
        public UserBooking(Method values)
        {
            InitializeComponent();
            method = values;

            cbxAdult.SelectedIndex = 0;
            cbxChild.SelectedIndex = 0;

            RemoveLinkLabelUnderline(HomeLblLink);
            RemoveLinkLabelUnderline(RoomLblLink);
            
            RemoveLinkLabelUnderline(CheckOutLblLink);
            
        }
        private void RemoveLinkLabelUnderline(LinkLabel linkLabel)
        {
            linkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
        }
        private void errorMessage(string type)
        {
            if (type == "roomType")
                MessageBox.Show($"Need to fill {type}");
        }
        // Booking
        int id;

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if(result != DialogResult.OK)
            {
                MessageBox.Show("Upload a Payment slip");
                return;
            }
            string roomType = tbxRType.Text;
            string checkIn = dateCIn.Value.ToString("yyyy-MM-dd");
            string duration = tbxDuration.Text;
            string adult = cbxAdult.Text;
            string child = cbxChild.Text;

            //Inserting into userbooking
            string insert = "insert into userbooking values (@roomType, @roomNumber, @checkIn, @duration, @adult, @child, @id, @extra, false, @paymentImage)";
            MySqlCommand insertCommand = new MySqlCommand(insert, method.Connection());
            insertCommand.Parameters.AddWithValue("@roomType", roomType);
            insertCommand.Parameters.AddWithValue("@roomNumber", method.roomNumber);
            insertCommand.Parameters.AddWithValue("@checkIn", checkIn);
            insertCommand.Parameters.AddWithValue("@duration", duration);
            insertCommand.Parameters.AddWithValue("@adult", adult);
            insertCommand.Parameters.AddWithValue("@child", child);
            insertCommand.Parameters.AddWithValue("@id", id);
            insertCommand.Parameters.AddWithValue("@extra", extra);
            insertCommand.Parameters.AddWithValue("@paymentImage", imageName);
            MySqlDataReader dataReader = insertCommand.ExecuteReader();
            MessageBox.Show("Booking Successful");

            //Changing available state
            string update = "update rooms set available = false where roomNumber = @roomNumber";
            MySqlCommand updateCommand = new MySqlCommand(update, method.Connection());
            updateCommand.Parameters.AddWithValue("@roomNumber", method.roomNumber);
            MySqlDataReader updateReader = updateCommand.ExecuteReader();


            //Copying Image
            File.Copy(userInputPath, localFilePath, true);

            method.isCheckout = 0;
            // Booking Successful
            this.Hide();
            RoomsKeyCard RKC = new RoomsKeyCard(method);
            RKC.Show();
        }
        //Making Connection and Taking ID Value
        private void UserBooking_Load(object sender, EventArgs e)
        {
            
            dateCIn.Text = DateTime.Now.ToString();
            tbxRType.Text = method.roomType.ToString();
            tbxRNumber.Text = method.roomNumber.ToString();
            if (method.isCheckout == 1)
            {
                tbxDuration.Text = method.duration.ToString();
                cbxChild.Text = method.child.ToString();
                cbxAdult.Text = method.adult.ToString();
                cbxPayment.SelectedIndex = 0;
            }
            
            dateCIn.Select();
            string username = method.userName;
            string query = "select id from user where userName = @UName";
            MySqlCommand command = new MySqlCommand(query, method.Connection());
            command.Parameters.AddWithValue("@UName", username);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = int.Parse(reader.GetValue(0).ToString());

            }
            reader.Close();
        }
        // Below 3 Event > To Get Extra Person Count
        int adult, child, extra = 0;


        private void cbxChild_SelectedIndexChanged(object sender, EventArgs e)
        {
            child = int.Parse(cbxChild.SelectedIndex.ToString());
            extra = method.forExtra(method.roomType, adult, child);
            tbxExtra.Text = extra.ToString();
        }
        private void cbxAdult_SelectedIndexChanged(object sender, EventArgs e)
        {
            adult = int.Parse(cbxAdult.SelectedIndex.ToString());
            extra = method.forExtra(method.roomType, adult, child);
            tbxExtra.Text = extra.ToString();
        }
        private void RoomLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Rooms room = new Rooms(method);
            room.Show();
        }
        private void HomeLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage(method);
            home.Show();
        }
        private void cbxRType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        // Header Link Label
        private bool initialized = false;



        // Taking User input image
        string userInputPath, localFilePath, imageName;

        private void cbxPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check whether user input all info
            if (tbxRType.Text == "")
            {
                MessageBox.Show(method.errorMessage("Room Type"));
                tbxRType.Select();
                return;
            }

            if (tbxDuration.Text == "")
            {
                MessageBox.Show(method.errorMessage("Duration"));
                tbxDuration.Select();
                return;
            }

            if (int.Parse(cbxAdult.Text) == 0 && int.Parse(cbxChild.Text) == 0)
            {
                MessageBox.Show("Need to fill Person Count");
                cbxAdult.Select();
                return;
            }
            method.extraBed = extra;
            method.roomNumber = int.Parse(tbxRNumber.Text);
            method.duration = int.Parse(tbxDuration.Text);
            method.roomType = tbxRType.Text;
            method.isCheckout = 1;
            method.adult = cbxAdult.SelectedIndex;
            method.child = cbxChild.SelectedIndex;
            //this.Hide();
            UserCheckOut CO = new UserCheckOut(method);
            CO.Show();
        }
        DialogResult result;
        private void btnPSlip_Click(object sender, EventArgs e)
        { 
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";
            result = ofd.ShowDialog();
            if(result == DialogResult.OK)
            {
                userInputPath = ofd.FileName;
                string localFolderPath = "C:/Users/HSU Thinzar/Desktop/HotelProjectC#/image/Payment/";
                imageName = Path.GetFileName(userInputPath);
                localFilePath = Path.Combine(localFolderPath, imageName);
                btnPSlip.Text = imageName;
            }
            else
            {
                MessageBox.Show("Invalid Photo");
            }
            
        }

        private void LogInLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!initialized)
            {
                ThreadPool.QueueUserWorkItem(state =>
                {
                    Thread.Sleep(50);
                    this.Invoke((Action)delegate
                    {
                        //this.Hide();
                        UserLogin user = new UserLogin(method);
                        user.Show();
                    });
                });
            }
        }

        private void CheckOutLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Press Yes to Check-Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                UserCheckOut user = new UserCheckOut(method);
                user.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
                UserBooking user = new UserBooking(method);
                user.Show();
            }
        }
    }

}
