using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HomePage
{
    public class Method
    {
        public string userName { get; set; }
        public int roomNumber { get; set; }
        public string roomType { get; set; }   // to hide room card (for room number)
        public int isCheckout { get; set; } // for check out function

        // Only for Receipt
        public int extraBed { get; set; } // for extraBeds ( Check Out )
        public int duration { get; set; } // for duration ( Check Out )
        public int adult { get; set; }
        public int child { get; set; }
        public MySqlConnection Connection() // To get Database Connection
        {
            // Password & Database is changed
            string cnStr = "server = localhost; uid = root; password = root; database = hotelprj";
            MySqlConnection con = new MySqlConnection(cnStr);
            con.Open();
            return con;

        }

        // To show info Error
        public string errorMessage(string type)
        {
            string eMessage;
            if (type == "Room Type")
            {
                eMessage = "Need to fill " + type;
                return eMessage;
            }

            if(type == "Duration")
            {
                eMessage = "Need to fill " + type;
                return eMessage;
            }
            return null;
        }

        // To get Extra Person Count
        public int forExtra(string roomNumber, int adult, int child) 
        {
            int extra, total;
            
            total = adult + child;
            if (roomNumber.ToLower() == "sea view room")
            {
                extra = total - 3;
                if (extra > 0)
                {
                    
                    return extra;
                }
            }
            if (roomNumber.ToLower() == "royal room" || roomNumber.ToLower() == "premium king room")
            {
                extra = total - 5;
                if (extra > 0)
                {
                    return extra;
                }
            }
            if (roomNumber.ToLower() == "small room")
            {
                extra = total - 2;
                if (extra > 0)
                {
                    return extra;
                }
            }
            return 0;
        }

        public Size Calculate(Size imagesize, int height, int width)
        {
            int newWidth = imagesize.Width;
            int newHeight = imagesize.Height;
            if (newWidth > height)
            {
                newHeight = height;
                newWidth = (int)(((double)imagesize.Width / imagesize.Height) * newHeight);
            }
            if (newWidth > width)
            {
                newWidth = width;
                newHeight = (int)(((double)imagesize.Height / imagesize.Width) * newWidth);
            }
            return new Size(newWidth, newHeight);
        }

    }
}

