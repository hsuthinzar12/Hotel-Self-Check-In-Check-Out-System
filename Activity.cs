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
    public partial class Activity : UserControl
    {
        public string activityImage { get; set; }
        public string activityName { get; set; }
        public DateTime activityDate { get; set; } //
        public string activityStartTime { get; set; }
        public string activityEndTime { get; set; }
        private Method method = new Method();

        public Activity(Method values)
        {
            InitializeComponent();
            method = values;
        }

        private void Activity_Load(object sender, EventArgs e)
        {
            pbxActivity.Image = Image.FromFile(activityImage);
            int height = 202;
            int width = 223;
            Size newSize = method.Calculate(pbxActivity.Size, height, width);
            pbxActivity.Size = newSize;
            pbxActivity.SizeMode = PictureBoxSizeMode.StretchImage;
            lblAName.Text = activityName;
            LblDate.Text = activityDate.ToString("yyyy-MM-dd");            // 
            lblSTime.Text = activityStartTime;
            lblETime.Text = activityEndTime;

        }
    }
}
