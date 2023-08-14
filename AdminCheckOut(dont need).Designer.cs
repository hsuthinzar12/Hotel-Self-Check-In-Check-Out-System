namespace HomePage
{
    partial class AdminCheckOut
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
            this.COListTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserInfoRClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UsrBkList = new System.Windows.Forms.ToolStripMenuItem();
            this.SercUsr = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdUsr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userBookingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRoomsPriceAndUserInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userCheckOutListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchUsersAndRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.COListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UserInfoRClick.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // COListTable
            // 
            this.COListTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.COListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.COListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RoomNum,
            this.RoomType,
            this.RoomCharge,
            this.Duration,
            this.CheckOut});
            this.COListTable.Location = new System.Drawing.Point(331, 254);
            this.COListTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.COListTable.Name = "COListTable";
            this.COListTable.RowHeadersWidth = 51;
            this.COListTable.RowTemplate.Height = 24;
            this.COListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.COListTable.Size = new System.Drawing.Size(1552, 548);
            this.COListTable.TabIndex = 0;
            this.COListTable.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.COListTable_CellMouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Check Out List";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HomePage.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(737, 126);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UserInfoRClick
            // 
            this.UserInfoRClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.UserInfoRClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsrBkList,
            this.SercUsr,
            this.UpdUsr});
            this.UserInfoRClick.Name = "RightClickBtn";
            this.UserInfoRClick.Size = new System.Drawing.Size(241, 76);
            // 
            // UsrBkList
            // 
            this.UsrBkList.Name = "UsrBkList";
            this.UsrBkList.Size = new System.Drawing.Size(240, 24);
            this.UsrBkList.Text = "User Booking List";
            // 
            // SercUsr
            // 
            this.SercUsr.Name = "SercUsr";
            this.SercUsr.Size = new System.Drawing.Size(240, 24);
            this.SercUsr.Text = "Search Users and Rooms";
            // 
            // UpdUsr
            // 
            this.UpdUsr.Name = "UpdUsr";
            this.UpdUsr.Size = new System.Drawing.Size(240, 24);
            this.UpdUsr.Text = "Update User and Rooms";
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
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userBookingListToolStripMenuItem
            // 
            this.userBookingListToolStripMenuItem.Name = "userBookingListToolStripMenuItem";
            this.userBookingListToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.userBookingListToolStripMenuItem.Text = "User Booking List";
            this.userBookingListToolStripMenuItem.Click += new System.EventHandler(this.userBookingListToolStripMenuItem_Click);
            // 
            // updateRoomsPriceAndUserInformationToolStripMenuItem
            // 
            this.updateRoomsPriceAndUserInformationToolStripMenuItem.Name = "updateRoomsPriceAndUserInformationToolStripMenuItem";
            this.updateRoomsPriceAndUserInformationToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.updateRoomsPriceAndUserInformationToolStripMenuItem.Text = "Update Rooms Price and User Information";
            this.updateRoomsPriceAndUserInformationToolStripMenuItem.Click += new System.EventHandler(this.updateRoomsPriceAndUserInformationToolStripMenuItem_Click);
            // 
            // userCheckOutListToolStripMenuItem
            // 
            this.userCheckOutListToolStripMenuItem.Name = "userCheckOutListToolStripMenuItem";
            this.userCheckOutListToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.userCheckOutListToolStripMenuItem.Text = "User CheckOut List";
            this.userCheckOutListToolStripMenuItem.Click += new System.EventHandler(this.userCheckOutListToolStripMenuItem_Click);
            // 
            // userActivitiesToolStripMenuItem
            // 
            this.userActivitiesToolStripMenuItem.Name = "userActivitiesToolStripMenuItem";
            this.userActivitiesToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.userActivitiesToolStripMenuItem.Text = "User Activities";
            this.userActivitiesToolStripMenuItem.Click += new System.EventHandler(this.userActivitiesToolStripMenuItem_Click);
            // 
            // searchUsersAndRoomsToolStripMenuItem
            // 
            this.searchUsersAndRoomsToolStripMenuItem.Name = "searchUsersAndRoomsToolStripMenuItem";
            this.searchUsersAndRoomsToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.searchUsersAndRoomsToolStripMenuItem.Text = "Search Users and Rooms";
            this.searchUsersAndRoomsToolStripMenuItem.Click += new System.EventHandler(this.searchUsersAndRoomsToolStripMenuItem_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // RoomNum
            // 
            this.RoomNum.HeaderText = "Room Number";
            this.RoomNum.MinimumWidth = 6;
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.Width = 125;
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.MinimumWidth = 6;
            this.RoomType.Name = "RoomType";
            this.RoomType.Width = 150;
            // 
            // RoomCharge
            // 
            this.RoomCharge.HeaderText = "Room Charges";
            this.RoomCharge.MinimumWidth = 6;
            this.RoomCharge.Name = "RoomCharge";
            this.RoomCharge.Width = 175;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.Width = 150;
            // 
            // CheckOut
            // 
            this.CheckOut.HeaderText = "Check Out";
            this.CheckOut.MinimumWidth = 6;
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Width = 125;
            // 
            // AdminCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COListTable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminCheckOut";
            this.Text = "AdminCheckOut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.COListTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UserInfoRClick.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView COListTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip UserInfoRClick;
        private System.Windows.Forms.ToolStripMenuItem UsrBkList;
        private System.Windows.Forms.ToolStripMenuItem SercUsr;
        private System.Windows.Forms.ToolStripMenuItem UpdUsr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userBookingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRoomsPriceAndUserInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userCheckOutListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userActivitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchUsersAndRoomsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
    }
}