using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class GenerateRoom : UserControl
    {
        public string ImagePath { get; set; }
        public string RNumber { get; set; }
        public string RType { get; set; }
        public string LPrice { get; set; }
        
        public string GCount { get; set; }
        public int Id { get; set; }

        // Handler For Button CLick Event 
        public event EventHandler ButtonCLick;
        public GenerateRoom()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ButtonCLick?.Invoke(this, EventArgs.Empty);
        }

        private void GenerateRoom_Load(object sender, EventArgs e)
        {
            // value of the controls
            IPath.Image = Image.FromFile(ImagePath);
            RoomNumber.Text = RNumber;
            RoomType.Text = RType;
            Price.Text = LPrice;
            GuestCount.Text = GCount;
            Id = Id;
        }
    }
}
