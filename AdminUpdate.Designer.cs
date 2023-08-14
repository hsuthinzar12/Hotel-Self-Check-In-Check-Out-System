namespace HomePage
{
    partial class AdminUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRUpdate = new System.Windows.Forms.Button();
            this.tbxGuest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRType = new System.Windows.Forms.ComboBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPNumber = new System.Windows.Forms.TextBox();
            this.tbxUName = new System.Windows.Forms.TextBox();
            this.btnUUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserInfoRClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AdmBkList = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmSercList = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmChkOutList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userBookingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRoomsPriceAndUserInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userCheckOutListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchUsersAndRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UserInfoRClick.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnRUpdate);
            this.groupBox1.Controls.Add(this.tbxGuest);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxRType);
            this.groupBox1.Controls.Add(this.tbxPrice);
            this.groupBox1.Location = new System.Drawing.Point(164, 318);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(661, 554);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Room";
            // 
            // btnRUpdate
            // 
            this.btnRUpdate.Location = new System.Drawing.Point(236, 433);
            this.btnRUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRUpdate.Name = "btnRUpdate";
            this.btnRUpdate.Size = new System.Drawing.Size(203, 80);
            this.btnRUpdate.TabIndex = 26;
            this.btnRUpdate.Text = "Update Room Info";
            this.btnRUpdate.UseVisualStyleBackColor = true;
            this.btnRUpdate.Click += new System.EventHandler(this.btnRUpdate_Click);
            // 
            // tbxGuest
            // 
            this.tbxGuest.Location = new System.Drawing.Point(144, 234);
            this.tbxGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxGuest.Name = "tbxGuest";
            this.tbxGuest.ReadOnly = true;
            this.tbxGuest.Size = new System.Drawing.Size(376, 22);
            this.tbxGuest.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Guest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Room Type";
            // 
            // cbxRType
            // 
            this.cbxRType.FormattingEnabled = true;
            this.cbxRType.Items.AddRange(new object[] {
            "small room",
            "sea view room",
            "premium king room",
            "royal room"});
            this.cbxRType.Location = new System.Drawing.Point(144, 108);
            this.cbxRType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxRType.Name = "cbxRType";
            this.cbxRType.Size = new System.Drawing.Size(376, 24);
            this.cbxRType.TabIndex = 3;
            this.cbxRType.SelectedIndexChanged += new System.EventHandler(this.cbxRType_SelectedIndexChanged);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(144, 350);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(376, 22);
            this.tbxPrice.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxPNumber);
            this.groupBox2.Controls.Add(this.tbxUName);
            this.groupBox2.Controls.Add(this.btnUUpdate);
            this.groupBox2.Location = new System.Drawing.Point(1133, 318);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(661, 554);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(137, 351);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(376, 22);
            this.tbxPassword.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 33);
            this.label8.TabIndex = 4;
            this.label8.Text = "User Name";
            // 
            // tbxPNumber
            // 
            this.tbxPNumber.Location = new System.Drawing.Point(131, 234);
            this.tbxPNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPNumber.Name = "tbxPNumber";
            this.tbxPNumber.Size = new System.Drawing.Size(376, 22);
            this.tbxPNumber.TabIndex = 1;
            // 
            // tbxUName
            // 
            this.tbxUName.Location = new System.Drawing.Point(131, 110);
            this.tbxUName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUName.Name = "tbxUName";
            this.tbxUName.Size = new System.Drawing.Size(376, 22);
            this.tbxUName.TabIndex = 0;
            this.tbxUName.TextChanged += new System.EventHandler(this.tbxUName_TextChanged);
            // 
            // btnUUpdate
            // 
            this.btnUUpdate.Location = new System.Drawing.Point(227, 433);
            this.btnUUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUUpdate.Name = "btnUUpdate";
            this.btnUUpdate.Size = new System.Drawing.Size(213, 80);
            this.btnUUpdate.TabIndex = 21;
            this.btnUUpdate.Text = "Update User Info";
            this.btnUUpdate.UseVisualStyleBackColor = true;
            this.btnUUpdate.Click += new System.EventHandler(this.btnUUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomePage.Properties.Resources.Hotel_Transylvania_logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // UserInfoRClick
            // 
            this.UserInfoRClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.UserInfoRClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdmBkList,
            this.AdmSercList,
            this.AdmChkOutList});
            this.UserInfoRClick.Name = "UserInfoRClick";
            this.UserInfoRClick.Size = new System.Drawing.Size(216, 76);
            // 
            // AdmBkList
            // 
            this.AdmBkList.Name = "AdmBkList";
            this.AdmBkList.Size = new System.Drawing.Size(215, 24);
            this.AdmBkList.Text = "Admin Booking List";
            // 
            // AdmSercList
            // 
            this.AdmSercList.Name = "AdmSercList";
            this.AdmSercList.Size = new System.Drawing.Size(215, 24);
            this.AdmSercList.Text = "Admin Search List";
            // 
            // AdmChkOutList
            // 
            this.AdmChkOutList.Name = "AdmChkOutList";
            this.AdmChkOutList.Size = new System.Drawing.Size(215, 24);
            this.AdmChkOutList.Text = "Admin CheckOut List";
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
            // AdminUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1924, 1036);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUpdate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UserInfoRClick.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRType;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxPNumber;
        private System.Windows.Forms.TextBox tbxUName;
        private System.Windows.Forms.Button btnUUpdate;
        private System.Windows.Forms.Button btnRUpdate;
        private System.Windows.Forms.TextBox tbxGuest;
        private System.Windows.Forms.ContextMenuStrip UserInfoRClick;
        private System.Windows.Forms.ToolStripMenuItem AdmBkList;
        private System.Windows.Forms.ToolStripMenuItem AdmSercList;
        private System.Windows.Forms.ToolStripMenuItem AdmChkOutList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userBookingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRoomsPriceAndUserInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userCheckOutListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userActivitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchUsersAndRoomsToolStripMenuItem;
    }
}