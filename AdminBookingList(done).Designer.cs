namespace HomePage
{
    partial class AdminBookingList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookingList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.UserInfoRClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UsrChkOut = new System.Windows.Forms.ToolStripMenuItem();
            this.UsrUptList = new System.Windows.Forms.ToolStripMenuItem();
            this.UsrSercList = new System.Windows.Forms.ToolStripMenuItem();
            this.UsrActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxPayment = new System.Windows.Forms.PictureBox();
            this.LblHome = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userBookingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRoomsPriceAndUserInfromationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchUsersAndRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userCheckOutListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UserInfoRClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPayment)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingList
            // 
            this.bookingList.BackgroundColor = System.Drawing.Color.Ivory;
            this.bookingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.duration,
            this.extraPerson,
            this.Checkin,
            this.CheckOut,
            this.roomNumber,
            this.image});
            this.bookingList.GridColor = System.Drawing.Color.MidnightBlue;
            this.bookingList.Location = new System.Drawing.Point(277, 299);
            this.bookingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookingList.Name = "bookingList";
            this.bookingList.RowHeadersWidth = 51;
            this.bookingList.RowTemplate.Height = 24;
            this.bookingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingList.Size = new System.Drawing.Size(1407, 689);
            this.bookingList.TabIndex = 8;
            this.bookingList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingList_CellClick);
            this.bookingList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingList_CellContentClick);
            this.bookingList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bookingList_CellMouseUp);
            this.bookingList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bookingList_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(267, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "User Booking Lists";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::HomePage.Properties.Resources.Hotel_Transylvania_logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 57);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HomePage.Properties.Resources.icons8_booking_641;
            this.pictureBox1.Location = new System.Drawing.Point(764, 218);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UserInfoRClick
            // 
            this.UserInfoRClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.UserInfoRClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsrChkOut,
            this.UsrUptList,
            this.UsrSercList,
            this.UsrActivity});
            this.UserInfoRClick.Name = "UserInfoRClick";
            this.UserInfoRClick.Size = new System.Drawing.Size(205, 100);
            this.UserInfoRClick.Opening += new System.ComponentModel.CancelEventHandler(this.UserInfoRClick_Opening);
            // 
            // UsrChkOut
            // 
            this.UsrChkOut.Name = "UsrChkOut";
            this.UsrChkOut.Size = new System.Drawing.Size(204, 24);
            this.UsrChkOut.Text = "User Check Out List";
            // 
            // UsrUptList
            // 
            this.UsrUptList.Name = "UsrUptList";
            this.UsrUptList.Size = new System.Drawing.Size(204, 24);
            this.UsrUptList.Text = "User Update List";
            // 
            // UsrSercList
            // 
            this.UsrSercList.Name = "UsrSercList";
            this.UsrSercList.Size = new System.Drawing.Size(204, 24);
            this.UsrSercList.Text = "User Search List";
            // 
            // UsrActivity
            // 
            this.UsrActivity.Name = "UsrActivity";
            this.UsrActivity.Size = new System.Drawing.Size(204, 24);
            this.UsrActivity.Text = "User Activity";
            this.UsrActivity.Click += new System.EventHandler(this.UsrActivity_Click);
            // 
            // pbxPayment
            // 
            this.pbxPayment.Location = new System.Drawing.Point(797, 453);
            this.pbxPayment.Margin = new System.Windows.Forms.Padding(4);
            this.pbxPayment.Name = "pbxPayment";
            this.pbxPayment.Size = new System.Drawing.Size(336, 389);
            this.pbxPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPayment.TabIndex = 0;
            this.pbxPayment.TabStop = false;
            this.pbxPayment.Visible = false;
            this.pbxPayment.Click += new System.EventHandler(this.pbxPayment_Click);
            // 
            // LblHome
            // 
            this.LblHome.AutoSize = true;
            this.LblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHome.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LblHome.LinkColor = System.Drawing.Color.Black;
            this.LblHome.Location = new System.Drawing.Point(1574, 245);
            this.LblHome.Name = "LblHome";
            this.LblHome.Size = new System.Drawing.Size(93, 33);
            this.LblHome.TabIndex = 12;
            this.LblHome.TabStop = true;
            this.LblHome.Text = "Home";
            this.LblHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLogout_LinkClicked);
            this.LblHome.MouseHover += new System.EventHandler(this.LblLogout_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userBookingListToolStripMenuItem,
            this.updateRoomsPriceAndUserInfromationToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.searchUsersAndRoomsToolStripMenuItem,
            this.userCheckOutListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userBookingListToolStripMenuItem
            // 
            this.userBookingListToolStripMenuItem.Name = "userBookingListToolStripMenuItem";
            this.userBookingListToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.userBookingListToolStripMenuItem.Text = "User Booking List";
            this.userBookingListToolStripMenuItem.Click += new System.EventHandler(this.userBookingListToolStripMenuItem_Click);
            // 
            // updateRoomsPriceAndUserInfromationToolStripMenuItem
            // 
            this.updateRoomsPriceAndUserInfromationToolStripMenuItem.Name = "updateRoomsPriceAndUserInfromationToolStripMenuItem";
            this.updateRoomsPriceAndUserInfromationToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.updateRoomsPriceAndUserInfromationToolStripMenuItem.Text = "Update Rooms Price and User Infromation";
            this.updateRoomsPriceAndUserInfromationToolStripMenuItem.Click += new System.EventHandler(this.updateRoomsPriceAndUserInfromationToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.activitiesToolStripMenuItem.Text = "User Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
            // 
            // searchUsersAndRoomsToolStripMenuItem
            // 
            this.searchUsersAndRoomsToolStripMenuItem.Name = "searchUsersAndRoomsToolStripMenuItem";
            this.searchUsersAndRoomsToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.searchUsersAndRoomsToolStripMenuItem.Text = "Search Users and Rooms";
            this.searchUsersAndRoomsToolStripMenuItem.Click += new System.EventHandler(this.searchUsersAndRoomsToolStripMenuItem_Click);
            // 
            // userCheckOutListToolStripMenuItem
            // 
            this.userCheckOutListToolStripMenuItem.Name = "userCheckOutListToolStripMenuItem";
            this.userCheckOutListToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.userCheckOutListToolStripMenuItem.Text = "User CheckOut List";
            this.userCheckOutListToolStripMenuItem.Click += new System.EventHandler(this.userCheckOutListToolStripMenuItem_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "User Name";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 150;
            // 
            // duration
            // 
            this.duration.HeaderText = "Duration";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Width = 150;
            // 
            // extraPerson
            // 
            this.extraPerson.HeaderText = "Extra Person";
            this.extraPerson.MinimumWidth = 6;
            this.extraPerson.Name = "extraPerson";
            this.extraPerson.ReadOnly = true;
            this.extraPerson.Width = 150;
            // 
            // Checkin
            // 
            this.Checkin.HeaderText = "Check-In";
            this.Checkin.MinimumWidth = 6;
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            this.Checkin.Width = 150;
            // 
            // CheckOut
            // 
            this.CheckOut.HeaderText = "Check-Out";
            this.CheckOut.MinimumWidth = 6;
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.ReadOnly = true;
            this.CheckOut.Width = 150;
            // 
            // roomNumber
            // 
            this.roomNumber.HeaderText = "Room Number";
            this.roomNumber.MinimumWidth = 6;
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.ReadOnly = true;
            this.roomNumber.Width = 150;
            // 
            // image
            // 
            this.image.HeaderText = "Image";
            this.image.MinimumWidth = 6;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 125;
            // 
            // AdminBookingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1924, 1036);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LblHome);
            this.Controls.Add(this.pbxPayment);
            this.Controls.Add(this.bookingList);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminBookingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminBookingList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminBookingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UserInfoRClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPayment)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.ContextMenuStrip UserInfoRClick;
        private System.Windows.Forms.ToolStripMenuItem UsrChkOut;
        private System.Windows.Forms.ToolStripMenuItem UsrUptList;
        private System.Windows.Forms.ToolStripMenuItem UsrSercList;
        private System.Windows.Forms.PictureBox pbxPayment;
        private System.Windows.Forms.LinkLabel LblHome;
        private System.Windows.Forms.ToolStripMenuItem UsrActivity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userBookingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRoomsPriceAndUserInfromationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchUsersAndRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userCheckOutListToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
    }
}