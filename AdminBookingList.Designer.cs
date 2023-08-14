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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.AddLblLink = new System.Windows.Forms.LinkLabel();
            this.SearchLblLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UsrName,
            this.PhNumber,
            this.Email,
            this.Address,
            this.Checkin,
            this.CheckOut,
            this.Payment});
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(131, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1673, 689);
            this.dataGridView1.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // UsrName
            // 
            this.UsrName.HeaderText = "User Name";
            this.UsrName.MinimumWidth = 6;
            this.UsrName.Name = "UsrName";
            this.UsrName.Width = 200;
            // 
            // PhNumber
            // 
            this.PhNumber.HeaderText = "Phone Number";
            this.PhNumber.MinimumWidth = 6;
            this.PhNumber.Name = "PhNumber";
            this.PhNumber.Width = 200;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 180;
            // 
            // Checkin
            // 
            this.Checkin.HeaderText = "Check-In";
            this.Checkin.MinimumWidth = 6;
            this.Checkin.Name = "Checkin";
            this.Checkin.Width = 150;
            // 
            // CheckOut
            // 
            this.CheckOut.HeaderText = "Check-Out";
            this.CheckOut.MinimumWidth = 6;
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Width = 150;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            this.Payment.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(121, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bookings";
            // 
            // AddLblLink
            // 
            this.AddLblLink.AutoSize = true;
            this.AddLblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLblLink.LinkColor = System.Drawing.Color.Black;
            this.AddLblLink.Location = new System.Drawing.Point(1375, 241);
            this.AddLblLink.Name = "AddLblLink";
            this.AddLblLink.Size = new System.Drawing.Size(268, 29);
            this.AddLblLink.TabIndex = 12;
            this.AddLblLink.TabStop = true;
            this.AddLblLink.Text = "Add Users and Rooms";
            this.AddLblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddLblLink_LinkClicked);
            // 
            // SearchLblLink
            // 
            this.SearchLblLink.AutoSize = true;
            this.SearchLblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLblLink.LinkColor = System.Drawing.Color.Black;
            this.SearchLblLink.Location = new System.Drawing.Point(1375, 183);
            this.SearchLblLink.Name = "SearchLblLink";
            this.SearchLblLink.Size = new System.Drawing.Size(303, 29);
            this.SearchLblLink.TabIndex = 13;
            this.SearchLblLink.TabStop = true;
            this.SearchLblLink.Text = "Search Users and Rooms";
            this.SearchLblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SearchLblLink_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::HomePage.Properties.Resources.Hotel_Transylvania_logo;
            this.pictureBox2.Location = new System.Drawing.Point(849, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HomePage.Properties.Resources.icons8_booking_641;
            this.pictureBox1.Location = new System.Drawing.Point(400, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.Transparent;
            this.BtnReturn.Image = global::HomePage.Properties.Resources.icons8_return_64;
            this.BtnReturn.Location = new System.Drawing.Point(1623, 115);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(55, 50);
            this.BtnReturn.TabIndex = 14;
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // AdminBookingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.SearchLblLink);
            this.Controls.Add(this.AddLblLink);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "AdminBookingList";
            this.Text = "AdminBookingList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel AddLblLink;
        private System.Windows.Forms.LinkLabel SearchLblLink;
        private System.Windows.Forms.Button BtnReturn;
    }
}