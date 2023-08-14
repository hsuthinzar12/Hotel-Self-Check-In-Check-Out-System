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
    public partial class AdminUpdate : Form
    {
        Method method = new Method();
        public AdminUpdate()
        {
            InitializeComponent();
        }

        private void SearchLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminSearch adminSearch = new AdminSearch(method);
            adminSearch.Show();
        }

        // Update Room Info
        private void btnRUpdate_Click(object sender, EventArgs e)
        {
            method.Connection();
            
            string select = "update rooms set roomPrice = @RoomPrice where roomType = @RoomType";
            MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
            SCommand.Parameters.AddWithValue("@RoomPrice", tbxPrice.Text);
            SCommand.Parameters.AddWithValue("@RoomType", cbxRType.Text);
            MySqlDataReader SDataReader = SCommand.ExecuteReader();
            SDataReader.Read();
            MessageBox.Show("Done");
            SDataReader.Close();
            cbxRType.SelectedIndex = 0;
        }

        // Auto Fill info for rooms
        private void cbxRType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string RType = cbxRType.Text;
            method.Connection();
            string select = "select guest, roomPrice from rooms where roomType = @RType";
            MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
            SCommand.Parameters.AddWithValue("@RType", RType);
            MySqlDataReader SDataReader = SCommand.ExecuteReader();
            SDataReader.Read();
            tbxGuest.Text = SDataReader.GetString(0);
            tbxPrice.Text = SDataReader.GetString(1);
            SDataReader.Close();
            
        }

        private void AdminUpdate_Load(object sender, EventArgs e)
        {
            cbxRType.SelectedIndex = 0;
            cbxRType.Select();
        }
        int id;

        // Auto Fill Info for user
        private void tbxUName_TextChanged(object sender, EventArgs e)
        {
            method.Connection();
            string name = tbxUName.Text;
            
                string select = "select id, phoneNumber, password from user where userName = @UserName";
                MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
                SCommand.Parameters.AddWithValue("@UserName", name);
                MySqlDataReader SDataReader = SCommand.ExecuteReader();
                if (SDataReader.Read())
                {
                    id = SDataReader.GetInt32(0);
                    tbxPNumber.Text = SDataReader.GetString(1);
                    string password = SDataReader.GetString(2);
                    if(password != null)
                {
                    password = new string('*', password.Length);
                    tbxPassword.Text = password;
                }
                }
                else
                {
                    return;
                }
                SDataReader.Close();
            
            
        }

        // Update User Info
        private void btnUUpdate_Click(object sender, EventArgs e)
        {
            method.Connection();
            string update = "update user set userName = @UserName, phoneNumber = @PNumber, password = @Password where id = @id";
            MySqlCommand UCommand = new MySqlCommand(update, method.Connection());
            UCommand.Parameters.AddWithValue("@UserName", tbxUName.Text);
            UCommand.Parameters.AddWithValue("@PNumber", tbxPNumber.Text);
            UCommand.Parameters.AddWithValue("@Password", tbxPassword.Text);
            UCommand.Parameters.AddWithValue("@id", id);
            MySqlDataReader UDataReader = UCommand.ExecuteReader();
            UDataReader.Read();
            MessageBox.Show("Done");
            UDataReader.Close();
            tbxUName.Clear();
            tbxPNumber.Clear();
            tbxPassword.Clear();
        }

     /*   private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminBookingList admbklist = new AdminBookingList(method);
            admbklist.Show();
        }*/
        private void updateRoomsPriceAndUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUpdate admupd = new AdminUpdate();
            admupd.Show();
        }

        private void userBookingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminBookingList admbklist = new AdminBookingList(method);
            admbklist.Show();
        }

        private void userCheckOutListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminCheckOut admchkout = new AdminCheckOut();
            admchkout.Show();
        }

        private void userActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminActivity admavtvty = new AdminActivity(method);
            admavtvty.Show();
        }

        private void searchUsersAndRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSearch admserc = new AdminSearch(method);
            admserc.Show();
        }

        
    }
}
