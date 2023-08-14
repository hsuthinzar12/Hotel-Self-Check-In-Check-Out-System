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
    public partial class RoomsKeyCard : Form
    {
        private Method method = new Method();
        public RoomsKeyCard(Method values)
        {
            InitializeComponent();
            method = values;
        }

        

        private void RoomsKeyCard_Load(object sender, EventArgs e)
        {
            foreach(Button button in Controls.OfType<Button>())
            {
                if(button.Tag.ToString() == method.roomNumber.ToString())
                {
                    button.BackColor = Color.Blue;
                    button.Select();
                }
            }
        }

        private void btnGBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage(method);
            this.Hide();
            home.Show();
        }

        private void BackLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage(method);
            home.Show();
        }
    }
}
