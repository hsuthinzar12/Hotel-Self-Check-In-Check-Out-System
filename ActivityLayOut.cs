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
using MySql.Data.MySqlClient;

namespace HomePage
{
    public partial class ActivityLayOut : Form
    {
        private Method method = new Method();
        public ActivityLayOut(Method values)
        {
            InitializeComponent();
            method = values;
        }
        private BindingList<Activity> activities = new BindingList<Activity>();
        private void ActivityLayOut_Load(object sender, EventArgs e)
        {
            string select = "select * from activity";
            MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
            MySqlDataReader SDataReader = SCommand.ExecuteReader();
            while(SDataReader.Read())
            {
                string AN = SDataReader.GetString(0);
                DateTime DT = DateTime.Now; // datetime
                string AST = SDataReader.GetString(1);
                string AET = SDataReader.GetString(2);
                string AI = SDataReader.GetString(4);

                //string ImagePath = @"D:/HotelProjectC#/image/Activity/" + AI;
                 string ImagePath = "C:/Users/HSU Thinzar/Desktop/HotelProjectC#/image/Activity/" + AI;
                Activity A = new Activity(method)
                {
                    activityImage = ImagePath,
                    activityName = AN,
                    activityDate = DT, //
                    activityStartTime = AST,
                    activityEndTime = AET
                };
                flpActivity.Controls.Add(A);
            }
        }

        private void LblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HomePage hmpg = new HomePage(method);
            hmpg.Show();
        }

        private void RoomLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Rooms usrrm = new Rooms(method);
            usrrm.Show();
        }

        private void LoginBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserLogin usrlogin = new UserLogin(method);
            usrlogin.Show();
        }

        private void CheckOutLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserCheckOut usrchkout = new UserCheckOut(method);
            usrchkout.Show();
        }
    }
}
