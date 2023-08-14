namespace HomePage
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeLblLink = new System.Windows.Forms.LinkLabel();
            this.CheckOutLblLink = new System.Windows.Forms.LinkLabel();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.lblActivity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1965, 862);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HomeLblLink
            // 
            this.HomeLblLink.AutoSize = true;
            this.HomeLblLink.BackColor = System.Drawing.Color.DimGray;
            this.HomeLblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLblLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.HomeLblLink.LinkColor = System.Drawing.Color.Black;
            this.HomeLblLink.Location = new System.Drawing.Point(1240, 58);
            this.HomeLblLink.Name = "HomeLblLink";
            this.HomeLblLink.Size = new System.Drawing.Size(112, 39);
            this.HomeLblLink.TabIndex = 47;
            this.HomeLblLink.TabStop = true;
            this.HomeLblLink.Text = "Home";
            this.HomeLblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HomeLblLink_LinkClicked);
            // 
            // CheckOutLblLink
            // 
            this.CheckOutLblLink.AutoSize = true;
            this.CheckOutLblLink.BackColor = System.Drawing.Color.DimGray;
            this.CheckOutLblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutLblLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.CheckOutLblLink.LinkColor = System.Drawing.Color.Black;
            this.CheckOutLblLink.Location = new System.Drawing.Point(1567, 58);
            this.CheckOutLblLink.Name = "CheckOutLblLink";
            this.CheckOutLblLink.Size = new System.Drawing.Size(186, 39);
            this.CheckOutLblLink.TabIndex = 46;
            this.CheckOutLblLink.TabStop = true;
            this.CheckOutLblLink.Text = "Check Out";
            this.CheckOutLblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CheckOutLblLink_LinkClicked);
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.BackColor = System.Drawing.Color.DimGray;
            this.flpRoom.Location = new System.Drawing.Point(301, 370);
            this.flpRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(1664, 492);
            this.flpRoom.TabIndex = 49;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.BackColor = System.Drawing.Color.DimGray;
            this.lblActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(952, 58);
            this.lblActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(133, 39);
            this.lblActivity.TabIndex = 51;
            this.lblActivity.Text = "Activity";
            this.lblActivity.Click += new System.EventHandler(this.lblActivity_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1924, 862);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.flpRoom);
            this.Controls.Add(this.HomeLblLink);
            this.Controls.Add(this.CheckOutLblLink);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel HomeLblLink;
        private System.Windows.Forms.LinkLabel CheckOutLblLink;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Label lblActivity;
    }
}