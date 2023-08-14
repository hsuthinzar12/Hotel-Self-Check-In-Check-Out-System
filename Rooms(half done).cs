using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class Rooms : Form
    {
        private Method method = new Method();
        public Rooms(Method values)
        {
            InitializeComponent();
            method = values;
            RemoveLinkLabelUnderline(HomeLblLink);
            
            RemoveLinkLabelUnderline(CheckOutLblLink);
        }
        private void RemoveLinkLabelUnderline(LinkLabel linkLabel)
        {
            linkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
        }
        private void BookLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (method.userName == null)
            {
                MessageBox.Show("You must login to reserve the room");
                this.Hide();
                UserLogin login = new UserLogin(method);
                login.Show();
                return;
            }
            this.Hide();
            UserBooking userbooking = new UserBooking(method);

            userbooking.Show();
        }
        private BindingList<GenerateRoom> GRoom = new BindingList<GenerateRoom>();
        private void Rooms_Load(object sender, EventArgs e)
        {
            method.Connection();
            string select = "select * from rooms where available = true";
            MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
            MySqlDataReader SDataReader = SCommand.ExecuteReader();
            while (SDataReader.Read())
            {
                // Retriving Data
                string RT = SDataReader.GetString(1);
                string RN = SDataReader.GetString(0);
                string RP = SDataReader.GetString(2);

                string IP = SDataReader.GetString(3);
                string G = SDataReader.GetString(4);

                // Creating Instance
                GenerateRoom generateRoom = new GenerateRoom
                {
                    ImagePath = IP,
                    RNumber = RN,
                    RType = RT,
                    LPrice = RP + " $",

                    GCount = G

                };

                generateRoom.ButtonCLick += GenereateRoom_ButtonClick;
                flpRoom.Controls.Add(generateRoom);
            }
        }
        private void GenereateRoom_ButtonClick(object sender, EventArgs e)
        {
            GenerateRoom generateroom = (GenerateRoom)sender;
            method.roomNumber = int.Parse(generateroom.RNumber);
            method.roomType = generateroom.RType;
            // Show Event What will Happen
            if (method.userName == null)
            {
                MessageBox.Show("You must login to reserve the room");
                this.Hide();
                UserLogin login = new UserLogin(method);

                login.Show();
                return;
            }
            this.Hide();

            UserBooking userbooking = new UserBooking(method);

            userbooking.Show();
        }
        private void RoomLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Rooms user = new Rooms(method);
            user.Show();
        }

        private void CheckOutLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserCheckOut UCOut = new UserCheckOut(method);
            UCOut.Show();
            method.isCheckout = 0;
        }
        private void HomeLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HomePage user = new HomePage(method);
            user.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblActivity_Click(object sender, EventArgs e)
        {
            ActivityLayOut ALO = new ActivityLayOut(method);
            this.Hide();
            ALO.Show();
        }
    }
}
