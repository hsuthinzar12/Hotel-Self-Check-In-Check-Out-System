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

        private void btnRUpdate_Click(object sender, EventArgs e)
        {
            method.Connection();
            
            string selectQuery = "select roomType, roomPrice, guest where roomNumber = @roomNumber";
            MySqlCommand SQCommand = new MySqlCommand(selectQuery, method.Connection());
//            SQCommand.Parameters.AddWithValue("@roomNumber", );
        }
    }
}
