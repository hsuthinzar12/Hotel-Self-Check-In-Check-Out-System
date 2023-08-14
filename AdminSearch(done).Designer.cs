namespace HomePage
{
    partial class AdminSearch
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
            this.btnUUpdate = new System.Windows.Forms.Button();
            this.btnRUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomTable = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxSRoom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxSUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UsrInfoRClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AdmBkList = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmUptList = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmChkOutList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userBookingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRoomsPriceAndUserInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userCheckOutListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchUsersAndRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UsrInfoRClick.SuspendLayout();
            this.cmsDelete.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUUpdate
            // 
            this.btnUUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUUpdate.Location = new System.Drawing.Point(1389, 855);
            this.btnUUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUUpdate.Name = "btnUUpdate";
            this.btnUUpdate.Size = new System.Drawing.Size(183, 63);
            this.btnUUpdate.TabIndex = 15;
            this.btnUUpdate.Text = "Update User Info";
            this.btnUUpdate.UseVisualStyleBackColor = true;
            this.btnUUpdate.Click += new System.EventHandler(this.btnUUpdate_Click);
            // 
            // btnRUpdate
            // 
            this.btnRUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRUpdate.Location = new System.Drawing.Point(367, 855);
            this.btnRUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRUpdate.Name = "btnRUpdate";
            this.btnRUpdate.Size = new System.Drawing.Size(183, 63);
            this.btnRUpdate.TabIndex = 14;
            this.btnRUpdate.Text = "Update Room Info";
            this.btnRUpdate.UseVisualStyleBackColor = true;
            this.btnRUpdate.Click += new System.EventHandler(this.btnRUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.roomTable);
            this.groupBox2.Controls.Add(this.tbxSRoom);
            this.groupBox2.Location = new System.Drawing.Point(29, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(899, 642);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Room";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HomePage.Properties.Resources.icons8_room_26;
            this.pictureBox2.Location = new System.Drawing.Point(291, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Number ";
            // 
            // roomTable
            // 
            this.roomTable.BackgroundColor = System.Drawing.Color.Ivory;
            this.roomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.type,
            this.Price,
            this.guest,
            this.available});
            this.roomTable.Location = new System.Drawing.Point(61, 156);
            this.roomTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomTable.Name = "roomTable";
            this.roomTable.RowHeadersWidth = 51;
            this.roomTable.RowTemplate.Height = 24;
            this.roomTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomTable.Size = new System.Drawing.Size(789, 452);
            this.roomTable.TabIndex = 2;
            this.roomTable.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.roomTable_CellMouseUp);
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Room Number";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Width = 110;
            // 
            // type
            // 
            this.type.HeaderText = "Room Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 110;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 110;
            // 
            // guest
            // 
            this.guest.HeaderText = "Guest";
            this.guest.MinimumWidth = 6;
            this.guest.Name = "guest";
            this.guest.Width = 110;
            // 
            // available
            // 
            this.available.HeaderText = "Available";
            this.available.MinimumWidth = 6;
            this.available.Name = "available";
            this.available.Width = 110;
            // 
            // tbxSRoom
            // 
            this.tbxSRoom.Location = new System.Drawing.Point(61, 98);
            this.tbxSRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSRoom.Name = "tbxSRoom";
            this.tbxSRoom.Size = new System.Drawing.Size(260, 22);
            this.tbxSRoom.TabIndex = 1;
            this.tbxSRoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSRoom_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.userTable);
            this.groupBox1.Controls.Add(this.tbxSUser);
            this.groupBox1.Location = new System.Drawing.Point(1049, 208);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(839, 642);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search User";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HomePage.Properties.Resources.user1;
            this.pictureBox3.Location = new System.Drawing.Point(205, 33);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            // 
            // userTable
            // 
            this.userTable.BackgroundColor = System.Drawing.Color.Ivory;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.PhoneNum,
            this.Password});
            this.userTable.Location = new System.Drawing.Point(43, 156);
            this.userTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTable.Name = "userTable";
            this.userTable.RowHeadersWidth = 51;
            this.userTable.RowTemplate.Height = 24;
            this.userTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userTable.Size = new System.Drawing.Size(756, 452);
            this.userTable.TabIndex = 0;
            this.userTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.userTable_CellFormatting);
            this.userTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userTable_CellMouseClick);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 175;
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "Phone Number";
            this.PhoneNum.MinimumWidth = 6;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Width = 175;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 175;
            // 
            // tbxSUser
            // 
            this.tbxSUser.Location = new System.Drawing.Point(43, 98);
            this.tbxSUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSUser.Name = "tbxSUser";
            this.tbxSUser.Size = new System.Drawing.Size(260, 22);
            this.tbxSUser.TabIndex = 3;
            this.tbxSUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSUser_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomePage.Properties.Resources.Hotel_Transylvania_logo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UsrInfoRClick
            // 
            this.UsrInfoRClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.UsrInfoRClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdmBkList,
            this.AdmUptList,
            this.AdmChkOutList});
            this.UsrInfoRClick.Name = "UsrInfoRClick";
            this.UsrInfoRClick.Size = new System.Drawing.Size(205, 76);
            // 
            // AdmBkList
            // 
            this.AdmBkList.Name = "AdmBkList";
            this.AdmBkList.Size = new System.Drawing.Size(204, 24);
            this.AdmBkList.Text = "User Booking List";
            // 
            // AdmUptList
            // 
            this.AdmUptList.Name = "AdmUptList";
            this.AdmUptList.Size = new System.Drawing.Size(204, 24);
            this.AdmUptList.Text = "User Update List";
            // 
            // AdmChkOutList
            // 
            this.AdmChkOutList.Name = "AdmChkOutList";
            this.AdmChkOutList.Size = new System.Drawing.Size(204, 24);
            this.AdmChkOutList.Text = "User Check Out List";
            // 
            // cmsDelete
            // 
            this.cmsDelete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userBookingListToolStripMenuItem,
            this.updateRoomsPriceAndUserInformationToolStripMenuItem,
            this.userCheckOutListToolStripMenuItem,
            this.userActivitiesToolStripMenuItem,
            this.searchUsersAndRoomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 30);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userBookingListToolStripMenuItem
            // 
            this.userBookingListToolStripMenuItem.Name = "userBookingListToolStripMenuItem";
            this.userBookingListToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.userBookingListToolStripMenuItem.Text = "User Booking List";
            this.userBookingListToolStripMenuItem.Click += new System.EventHandler(this.userBookingListToolStripMenuItem_Click);
            // 
            // updateRoomsPriceAndUserInformationToolStripMenuItem
            // 
            this.updateRoomsPriceAndUserInformationToolStripMenuItem.Name = "updateRoomsPriceAndUserInformationToolStripMenuItem";
            this.updateRoomsPriceAndUserInformationToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.updateRoomsPriceAndUserInformationToolStripMenuItem.Text = "Update Rooms Price and User Information";
            this.updateRoomsPriceAndUserInformationToolStripMenuItem.Click += new System.EventHandler(this.updateRoomsPriceAndUserInformationToolStripMenuItem_Click);
            // 
            // userCheckOutListToolStripMenuItem
            // 
            this.userCheckOutListToolStripMenuItem.Name = "userCheckOutListToolStripMenuItem";
            this.userCheckOutListToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.userCheckOutListToolStripMenuItem.Text = "User CheckOut List";
            this.userCheckOutListToolStripMenuItem.Click += new System.EventHandler(this.userCheckOutListToolStripMenuItem_Click);
            // 
            // userActivitiesToolStripMenuItem
            // 
            this.userActivitiesToolStripMenuItem.Name = "userActivitiesToolStripMenuItem";
            this.userActivitiesToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.userActivitiesToolStripMenuItem.Text = "User Activities";
            this.userActivitiesToolStripMenuItem.Click += new System.EventHandler(this.userActivitiesToolStripMenuItem_Click);
            // 
            // searchUsersAndRoomsToolStripMenuItem
            // 
            this.searchUsersAndRoomsToolStripMenuItem.Name = "searchUsersAndRoomsToolStripMenuItem";
            this.searchUsersAndRoomsToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.searchUsersAndRoomsToolStripMenuItem.Text = "Search Users and Rooms";
            this.searchUsersAndRoomsToolStripMenuItem.Click += new System.EventHandler(this.searchUsersAndRoomsToolStripMenuItem_Click);
            // 
            // AdminSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1924, 1036);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnUUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSearch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminSearch_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UsrInfoRClick.ResumeLayout(false);
            this.cmsDelete.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUUpdate;
        private System.Windows.Forms.Button btnRUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView roomTable;
        private System.Windows.Forms.TextBox tbxSRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.TextBox tbxSUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn guest;
        private System.Windows.Forms.DataGridViewTextBoxColumn available;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip UsrInfoRClick;
        private System.Windows.Forms.ToolStripMenuItem AdmBkList;
        private System.Windows.Forms.ToolStripMenuItem AdmUptList;
        private System.Windows.Forms.ToolStripMenuItem AdmChkOutList;
        private System.Windows.Forms.ContextMenuStrip cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userBookingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRoomsPriceAndUserInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userCheckOutListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userActivitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchUsersAndRoomsToolStripMenuItem;
    }
}