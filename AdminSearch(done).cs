using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class AdminSearch : Form
    {
        private Method method = new Method();
        public AdminSearch(Method values)
        {
            InitializeComponent();
            method = values;
        }

        private void AdminSearch_Load(object sender, EventArgs e)
        {
            // Room Table
            roomTable.Rows.Clear();
            method.Connection();
            string selectRoom = "select * from userbooking b, rooms r where b.roomNumber = r.roomNumber";
            MySqlCommand sRoomCommand = new MySqlCommand(selectRoom, method.Connection());
            MySqlDataReader CNReader = sRoomCommand.ExecuteReader();
            if (CNReader.Read())
            {
                CNReader.Close();
                // Changing Available State
                int id = method.roomNumber;
                string changeAvailable = "update rooms set available = false where roomNumber = @roomNumber";
                MySqlCommand command = new MySqlCommand(changeAvailable, method.Connection());
                command.Parameters.AddWithValue("@roomNumber", id);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                reader.Close();
            }
            selectRoom = "select * from rooms";
            MySqlCommand selectCommand = new MySqlCommand(selectRoom, method.Connection());
            MySqlDataReader selectReader = selectCommand.ExecuteReader();
            while (selectReader.Read())
            {
                roomTable.Rows.Add(selectReader[0], selectReader[1], selectReader[2], selectReader[3], selectReader[4]);
            }
            selectReader.Close();

            // User Table
            userTable.Rows.Clear();
            string selectUser = "select userName, phoneNumber, password from user";
            MySqlCommand sUCommand = new MySqlCommand(selectUser, method.Connection());
            MySqlDataReader uReader = sUCommand.ExecuteReader();
            while (uReader.Read())
            {
                userTable.Rows.Add(uReader[0], uReader[1], uReader[2]);
            }
            uReader.Close();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminBookingList adbklist = new AdminBookingList(method);
            adbklist.Show();
        }
        private void SearchLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminUpdate AdminUpdate = new AdminUpdate();
            AdminUpdate.Show();
        }

        private void btnRUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUpdate AdminUpdate = new AdminUpdate();
            AdminUpdate.Show();
        }

        private void btnUUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUpdate AdminUpdate = new AdminUpdate();
            AdminUpdate.Show();
        }

        string input;
// Call When the Enter Key is Press for Room's Text Box
        bool isint;
        private void tbxSRoom_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                input = tbxSRoom.Text.ToLower();
                int intvalue;
                isint = int.TryParse(input, out intvalue);
                roomTable.Rows.Clear();
                if (isint == false)
                {
                    SRoomNotInt();
                }
                else if(isint == true)
                {
                    SRoomInt();
                }
            }
            else if(e.KeyCode == Keys.Back)
            {
                SRoomClear();
            }
        }

        string selectquery;
        // Search when input is not integer with Room Type
        private void SRoomNotInt()
        {
            selectquery = "select * from rooms where roomType = @roomType";
            MySqlCommand CTCommand = new MySqlCommand(selectquery, method.Connection());
            CTCommand.Parameters.AddWithValue("@roomType", input);
            MySqlDataReader CTDataReader = CTCommand.ExecuteReader();
            while (CTDataReader.Read())
            {
                roomTable.Rows.Add(CTDataReader[0], CTDataReader[1], CTDataReader[2], CTDataReader[3], CTDataReader[4]);
            }
            CTDataReader.Close();
        }

        // Search when input is integer with Room Number
        private void SRoomInt()
        {
            selectquery = "select * from rooms where roomNumber = @roomNumber";
            MySqlCommand CRCommand = new MySqlCommand(selectquery, method.Connection());
            CRCommand.Parameters.AddWithValue("@roomNumber", input);
            MySqlDataReader CRDataReader = CRCommand.ExecuteReader();
            while (CRDataReader.Read())
            {
                roomTable.Rows.Add(CRDataReader[0], CRDataReader[1], CRDataReader[2], CRDataReader[3], CRDataReader[4]);
            }
            CRDataReader.Close();
        }

        // Do when input is empty
        private void SRoomClear()
        {
            string select = "select * from rooms";
            MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
            MySqlDataReader SDataReader = SCommand.ExecuteReader();

            roomTable.Rows.Clear();
            while (SDataReader.Read())
            {
                roomTable.Rows.Add(SDataReader[0], SDataReader[1], SDataReader[2], SDataReader[3], SDataReader[4]);
            }
        }
// Call When the Enter Key is Press for User' Text Box
        private void tbxSUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                input = tbxSUser.Text.ToLower();
                userTable.Rows.Clear();
                User();
            }
            else if (e.KeyCode == Keys.Back)
            {
                UserClear();
            }
        }
        // Search when input is not Integer with User Name
        private void User()
        {
            string selectquery = "select userName, phoneNumber, password from user where userName = @userName";
            MySqlCommand CTCommand = new MySqlCommand(selectquery, method.Connection());
            CTCommand.Parameters.AddWithValue("@userName", input);
            MySqlDataReader CTDataReader = CTCommand.ExecuteReader();
            while (CTDataReader.Read())
            {
                userTable.Rows.Add(CTDataReader[0], CTDataReader[1], CTDataReader[2]);
            }
            CTDataReader.Close();
        }

        // Do when the input is empty
        private void UserClear()
        {
            string select = "select userName, phoneNumber, password from user";
            MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
            MySqlDataReader SDataReader = SCommand.ExecuteReader();
            if (tbxSUser.Text == "")
            {
                userTable.Rows.Clear();
                while (SDataReader.Read())
                {
                    userTable.Rows.Add(SDataReader[0], SDataReader[1], SDataReader[2]);
                }
            }
        }
        private int rowIndex = 0;
        private void roomTable_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.roomTable.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.roomTable.CurrentCell = this.roomTable.Rows[e.RowIndex].Cells[1];
                    this.UsrInfoRClick.Show(this.roomTable, e.Location);
                    UsrInfoRClick.Show(Cursor.Position);
                }
            }
            catch
            {
                MessageBox.Show("Click Cell Content");
            }
        }

     /*   private void userTable_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void AdmBkList_Click(object sender, EventArgs e)
        {
            AdminBookingList admbklist = new AdminBookingList(method);
            admbklist.Show();
        }

        private void AdmUptList_Click(object sender, EventArgs e)
        {
            AdminUpdate admupdlist = new AdminUpdate();
            admupdlist.Show();
        }

        private void AdmChkOutList_Click(object sender, EventArgs e)
        {
            AdminCheckOut admchkout = new AdminCheckOut();
            admchkout.Show();
        }*/

        private void userTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                userTable.Rows[e.RowIndex].Selected = true;
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
                deleteMenuItem.Click += DeleteMenuItem_Click;
                contextMenuStrip.Items.Add(deleteMenuItem);
                userTable.ContextMenuStrip = contextMenuStrip;
                cmsDelete.Show(Cursor.Position);
                
            }

        }
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (userTable.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = userTable.SelectedRows[0];

                    string userName = selectedRow.Cells[0].Value.ToString();

                    string delete = "delete from user where userName = @userName";
                    MySqlCommand command = new MySqlCommand(delete, method.Connection());
                    command.Parameters.AddWithValue("@userName", userName);
                    MySqlDataReader reader = command.ExecuteReader();
                    UserClear();
                }
            }
        }

        private void userBookingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminBookingList admbklist = new AdminBookingList(method);
            admbklist.Show();
        }

        private void updateRoomsPriceAndUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUpdate admupd = new AdminUpdate();
            admupd.Show();
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
            AdminActivity admact = new AdminActivity(method);
            admact.Show();
        }

        private void searchUsersAndRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSearch admserc = new AdminSearch(method);
            admserc.Show();
        }

        private void userTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                if(e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }
    }
}
