using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.CodeDom;
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
    public partial class AdminActivity : Form
    {
        private Method method = new Method();
        public AdminActivity(Method values)
        {
            InitializeComponent();
            method = values;
        }
        string userInputPath, imageName, localFilePath;

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
            AdminCheckOut admchkout = new AdminCheckOut();
            admchkout.Show();
        }

        private void userActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminActivity admactv = new AdminActivity(method);
            admactv.Show();
        }

        private void searchUsersAndRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSearch admserc = new AdminSearch(method);
            admserc.Show();
        }

        private void AdminActivity_Load(object sender, EventArgs e)
        {
            takingValue();

            pbxActivity.Visible = false;
        }

        private void takingValue()
        {
            activityTable.Rows.Clear();
            string select = "select * from activity";
            MySqlCommand SCommand = new MySqlCommand(select, method.Connection());
            MySqlDataReader SDataReader = SCommand.ExecuteReader();
            while (SDataReader.Read())
            {
                activityTable.Rows.Add(SDataReader.GetString(0), SDataReader.GetString(1), SDataReader.GetString(2), SDataReader.GetString(3), SDataReader.GetString(4));
            }
        }
        private void activityTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                activityTable.Rows[e.RowIndex].Selected = true;
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
                deleteMenuItem.Click += DeleteMenuItem_Click;
                contextMenuStrip.Items.Add(deleteMenuItem);
                activityTable.ContextMenuStrip = contextMenuStrip;
                cmsDelete.Show(Cursor.Position);

            }
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (activityTable.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = activityTable.SelectedRows[0];

                    string userName = selectedRow.Cells[0].Value.ToString();

                    string delete = "delete from activity where activityname = @userName";
                    MySqlCommand command = new MySqlCommand(delete, method.Connection());
                    command.Parameters.AddWithValue("@userName", userName);
                    MySqlDataReader reader = command.ExecuteReader();
                    takingValue();
                }
            }
        }

        private void activityTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (activityTable.Columns[e.ColumnIndex].Name == "image")
            {
                DataGridViewCell imageName = activityTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string imgaePath = $"C:/Users/HSU Thinzar/Desktop/HotelProjectC#/image/Activity/{imageName.Value}";
                pbxActivity.Visible = true;
                int height = 750;
                int width = 750;
                pbxActivity.Image = Image.FromFile(imgaePath);
                Size newsize = Calculate(pbxActivity.Size, height, width);
                pbxActivity.Size = newsize;
                pbxActivity.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
        // To change Size of the Image
        private Size Calculate(Size imagesize, int height, int width)
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

        private void pbxActivity_Click(object sender, EventArgs e)
        {
            pbxActivity.Visible = false;
        }

        private void btnCEvent_Click(object sender, EventArgs e)
        {
            string activityName = tbxAName.Text;
            DateTime activityDate = tbxDate.Value.Date;
            string activityTimeS = tbxASTime.Text;
            string STime = cbxSTime.SelectedItem.ToString();
            string activitySTime = activityTimeS + STime;
            string activityTimeE = tbxAETime.Text;
            string ETime = cbxETime.SelectedItem.ToString();
            string activityETime = activityTimeE + ETime;
            string insert = "insert into activity values (@activityName,@activityDate, @activitySTime, @activityETime, @activityImage)";
            MySqlCommand insertCommand = new MySqlCommand(insert, method.Connection());
            insertCommand.Parameters.AddWithValue("@activityName", activityName);
            insertCommand.Parameters.AddWithValue("@activityDate", activityDate);
            insertCommand.Parameters.AddWithValue("@activitySTime", activitySTime);
            insertCommand.Parameters.AddWithValue("@activityETime", activityETime);
            insertCommand.Parameters.AddWithValue("@activityImage", imageName);
            MySqlDataReader reader = insertCommand.ExecuteReader();
            tbxAETime.Clear();
            tbxAName.Clear();
            tbxASTime.Clear();
            btnImageInput.Text = "";
            pbxAActivity.Image = null;
            cbxETime.SelectedIndex = 0;
            cbxSTime.SelectedIndex = 0;
            MessageBox.Show("Event Created Successfully");
            File.Copy(userInputPath, localFilePath, true);
            takingValue();
        }

        private void btnImageInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                userInputPath = ofd.FileName;

                //string localFolderPath = "D:\\HotelProjectC#\\image\\Activity\\";
                string localFolderPath = "C:/Users/HSU Thinzar/Desktop/HotelProjectC#/image/Activity/";
                imageName = Path.GetFileName(userInputPath);
                localFilePath = Path.Combine(localFolderPath, imageName);
                btnImageInput.Text = imageName;
                pbxAActivity.Image = Image.FromFile(userInputPath);
                int height = 202;

                int width = 223;
                Size newSize = method.Calculate(pbxAActivity.Size, height, width);
                pbxAActivity.Size = newSize;
                pbxAActivity.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Invalid Photo");
            }
        }
    }
}
