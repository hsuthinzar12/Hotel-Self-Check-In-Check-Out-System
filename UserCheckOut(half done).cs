using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
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

    public partial class UserCheckOut : Form
    {
        private Method method = new Method();
        public UserCheckOut(Method values)
        {
            InitializeComponent();
            method = values;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // If Booking do this
            if (method.isCheckout == 1)
            {
                this.Hide();
                return;
            }
            if (cbxRNumber.Text != "")
            {
                if (tbxUName.Text != "")
                {
                    // Changing Check Out state from userbooking
                    string checkOut = $"update userbooking set checkOut = true where roomNumber = {cbxRNumber.SelectedItem}";
                    MySqlCommand COCommand = new MySqlCommand(checkOut, method.Connection());
                    MySqlDataReader CODataReader = COCommand.ExecuteReader();
                    CODataReader.Read();
                    CODataReader.Close();

                    // Changing available state from rooms
                    string available = $"update rooms set available = true where roomNumber = {cbxRNumber.SelectedItem}";
                    MySqlCommand ACommand = new MySqlCommand(available, method.Connection());
                    MySqlDataReader ADataReader = ACommand.ExecuteReader();
                    ADataReader.Read();
                    ADataReader.Close();

                    MessageBox.Show("Done");
                    this.Hide();
                    Rooms room = new Rooms(method);
                    room.Show();
                }
                else
                {
                    MessageBox.Show("Fill all info");
                    return;
                }
            }
            if(tbxUName.Text == "")
            {
                this.Hide();
                Rooms rooms = new Rooms(method);
                rooms.Show();
            }



        }
        // To Store Each Row of data into list
        List<CheckOut> CO = new List<CheckOut>();
        private void tbxUName_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                method.Connection();

                // Check whether TextBox is empty or not
                if (tbxUName.Text != "")
                {

                    // Retrieving Data From DataBase
                    string select = $"select r.roomPrice, ub.extraBeds, ub.duration, r.roomNumber, r.roomType from rooms r, userbooking ub, user u where u.id = ub.id and ub.roomNumber= r.roomNumber and u.userName = \"{tbxUName.Text}\" and ub.checkout = false";
                    MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
                    MySqlDataReader SDataReader = SCommand.ExecuteReader();

                    while (SDataReader.Read())
                    {
                        CheckOut COut = new CheckOut
                        {
                            RN = SDataReader.GetInt32(3),
                            RP = SDataReader.GetInt32(0),
                            EP = SDataReader.GetInt32(1),
                            D = SDataReader.GetInt32(2),
                            RT = SDataReader.GetString(4)
                        };
                        CO.Add(COut);

                        cbxRNumber.Items.Add(SDataReader.GetInt32(3));
                        cbxRNumber.Text = "Choose Room Number";
                    }
                    SDataReader.Close();
                }
                else
                {
                    lblRCharges.Text = "";
                    lblSCharges.Text = "";
                    lblEPerson.Text = "";

                    lblTotal.Text = "";
                }
            }*/
        }
        // To store Each Rows of data into List
        public class CheckOut
        {
            public int RN { get; set; }
            public int RP { get; set; }
            public int EP { get; set; }
            public int D { get; set; }
            public string RT { get; set; }
        }
        int halfprice;

        private void cbxRNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxRNumber.SelectedIndex;
            CheckOut Data = CO[index];
            halfprice = Data.RP / 2;

            // Showing Info on label
            lblRType.Text = Data.RT;
            lblRCharges.Text = (Data.RP * Data.D).ToString() + $" $ ({Data.D} Days)";
            lblEPerson.Text = (Data.EP * halfprice).ToString() + $" $ ({Data.EP})";
            int service_tax = (Data.RP * 5) / 100;
            lblSCharges.Text = service_tax.ToString() + " $ ";
            int total = Data.RP + (Data.EP * halfprice) + service_tax;
            lblTotal.Text = total.ToString() + " $";
        }

        private void UserCheckOut_Load(object sender, EventArgs e)
        {
            if (method.isCheckout == 1)
            {
                BtnSubmit.Text = "Done";
                BtnHome.Visible = false;
                string select = $"select roomPrice from rooms where roomNumber = {method.roomNumber}";
                MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
                MySqlDataReader SDataReader = SCommand.ExecuteReader();
                if (SDataReader.Read())
                {
                    tbxUName.ReadOnly = true;
                    cbxRNumber.Enabled = false;
                    tbxUName.Text = method.userName;
                    cbxRNumber.Text = method.roomNumber.ToString();
                    lblRType.Text = method.roomType;
                    int charges = SDataReader.GetInt32(0) * method.duration;
                    lblRCharges.Text = (charges).ToString() + $" $ ({method.duration} Days)";
                    int hPrice = SDataReader.GetInt32(0) / 2;
                    int extra = method.extraBed * hPrice * method.duration;
                    lblEPerson.Text = (extra).ToString() + $" $ ({method.extraBed})";
                    int service_tax = (charges * 5) / 100;
                    lblSCharges.Text = service_tax.ToString() + " $ ";
                    int total = charges + extra + service_tax;
                    lblTotal.Text = total.ToString() + " $";
                }
            }
            if(method.isCheckout == 0)
            {
                tbxUName.Text = method.userName;
            }
            

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage usrhmpg = new HomePage(method);
            usrhmpg.Show();
        }

        private void tbxUName_TextChanged(object sender, EventArgs e)
        {
            if (tbxUName.Text != "")
            {

                // Retrieving Data From DataBase
                string select = $"select r.roomPrice, ub.extraBeds, ub.duration, r.roomNumber, r.roomType from rooms r, userbooking ub, user u where u.id = ub.id and ub.roomNumber= r.roomNumber and u.userName = \"{tbxUName.Text}\" and ub.checkout = false";
                MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
                MySqlDataReader SDataReader = SCommand.ExecuteReader();

                while (SDataReader.Read())
                {
                    CheckOut COut = new CheckOut
                    {
                        RN = SDataReader.GetInt32(3),
                        RP = SDataReader.GetInt32(0),
                        EP = SDataReader.GetInt32(1),
                        D = SDataReader.GetInt32(2),
                        RT = SDataReader.GetString(4)
                    };
                    CO.Add(COut);

                    cbxRNumber.Items.Add(SDataReader.GetInt32(3));
                    cbxRNumber.Text = "Choose Room Number";
                }
                SDataReader.Close();
            }
            else
            {
                lblRCharges.Text = "";
                lblSCharges.Text = "";
                lblEPerson.Text = "";

                lblTotal.Text = "";
            }
        }
    }
}
