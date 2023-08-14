namespace HomePage
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoomLblLink = new System.Windows.Forms.LinkLabel();
            this.CheckOutLblLink = new System.Windows.Forms.LinkLabel();
            this.LoginBtn = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogoff = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 1055);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RoomLblLink
            // 
            this.RoomLblLink.AutoSize = true;
            this.RoomLblLink.BackColor = System.Drawing.Color.DimGray;
            this.RoomLblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLblLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.RoomLblLink.LinkColor = System.Drawing.Color.Black;
            this.RoomLblLink.Location = new System.Drawing.Point(1013, 47);
            this.RoomLblLink.Name = "RoomLblLink";
            this.RoomLblLink.Size = new System.Drawing.Size(112, 39);
            this.RoomLblLink.TabIndex = 49;
            this.RoomLblLink.TabStop = true;
            this.RoomLblLink.Text = "Room";
            this.RoomLblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RoomLblLink_LinkClicked);
            // 
            // CheckOutLblLink
            // 
            this.CheckOutLblLink.AutoSize = true;
            this.CheckOutLblLink.BackColor = System.Drawing.Color.DimGray;
            this.CheckOutLblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutLblLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.CheckOutLblLink.LinkColor = System.Drawing.Color.Black;
            this.CheckOutLblLink.Location = new System.Drawing.Point(1607, 47);
            this.CheckOutLblLink.Name = "CheckOutLblLink";
            this.CheckOutLblLink.Size = new System.Drawing.Size(186, 39);
            this.CheckOutLblLink.TabIndex = 48;
            this.CheckOutLblLink.TabStop = true;
            this.CheckOutLblLink.Text = "Check Out";
            this.CheckOutLblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CheckOutLblLink_LinkClicked);
            // 
            // LoginBtn
            // 
            this.LoginBtn.AutoSize = true;
            this.LoginBtn.BackColor = System.Drawing.Color.DimGray;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LoginBtn.LinkColor = System.Drawing.Color.Black;
            this.LoginBtn.Location = new System.Drawing.Point(1206, 47);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(106, 39);
            this.LoginBtn.TabIndex = 47;
            this.LoginBtn.TabStop = true;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginBtn_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(772, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 50;
            this.label1.Text = "Activity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLogoff
            // 
            this.lblLogoff.AutoSize = true;
            this.lblLogoff.BackColor = System.Drawing.Color.DimGray;
            this.lblLogoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoff.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLogoff.LinkColor = System.Drawing.Color.Black;
            this.lblLogoff.Location = new System.Drawing.Point(1377, 47);
            this.lblLogoff.Name = "lblLogoff";
            this.lblLogoff.Size = new System.Drawing.Size(157, 39);
            this.lblLogoff.TabIndex = 51;
            this.lblLogoff.TabStop = true;
            this.lblLogoff.Text = "Sign Out";
            this.lblLogoff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogoff_LinkClicked);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.lblLogoff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomLblLink);
            this.Controls.Add(this.CheckOutLblLink);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel RoomLblLink;
        private System.Windows.Forms.LinkLabel CheckOutLblLink;
        private System.Windows.Forms.LinkLabel LoginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLogoff;
    }
}

