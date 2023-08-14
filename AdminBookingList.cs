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
    public partial class AdminBookingList : Form
    {
        public AdminBookingList()
        {
            InitializeComponent();
        }

        private void SearchLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminSearch admin = new AdminSearch();
            admin.Show();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage user = new HomePage();
            user.Show();
        }

        private void AddLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminAdd admin = new AdminAdd();
            admin.Show();
        }
    }
}
