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
    public partial class AdminCheckOut : Form
    {
        private Method method = new Method();
        public AdminCheckOut()
        {
            InitializeComponent();
        }

        private void AdminCheckOut_Load(object sender, EventArgs e)
        {
            method.Connection();
            string select = "select u.id, ub.roomNumber, ub.roomType, r.roomPrice, ub.duration, ub.checkOut from user u, rooms r, userbooking ub";
            MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
            MySqlDataReader SDataReader = SCommand.ExecuteReader();
            while (SDataReader.Read())
            {
                COListTable.Rows.Add(SDataReader[0], SDataReader[1], SDataReader[2], SDataReader[3], SDataReader[4], null, SDataReader[5]);
            }
            SDataReader.Close();
        }
        private int rowIndex = 0;
        private void COListTable_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.COListTable.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.COListTable.CurrentCell = this.COListTable.Rows[e.RowIndex].Cells[1];
                    this.UserInfoRClick.Show(this.COListTable, e.Location);
                    UserInfoRClick.Show(Cursor.Position);
                }
            }
            catch
            {
                MessageBox.Show("Click Cell Content");
            }
        }

        /*private void UsrBkList_Click(object sender, EventArgs e)
        {
            AdminBookingList admbklist = new AdminBookingList(method);
            admbklist.Show();
        }

        private void SercUsr_Click(object sender, EventArgs e)
        {
            AdminSearch admserc = new AdminSearch(method);
            admserc.Show();
        }

        private void UpdUsr_Click(object sender, EventArgs e)
        {
            AdminUpdate admupt = new AdminUpdate();
            admupt.Show();
        }*/

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
            AdminCheckOut admcheckout = new AdminCheckOut();
            admcheckout.Show();
        }

        private void userActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminActivity admactvity = new AdminActivity(method);
            admactvity.Show();
        }

        private void searchUsersAndRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSearch admserc = new AdminSearch(method);
            admserc.Show();
        }
    }
}
