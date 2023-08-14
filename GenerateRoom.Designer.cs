namespace HomePage
{
    partial class GenerateRoom
    {
        private System.Windows.Forms.PictureBox IPath;
        private System.Windows.Forms.Label RoomType;
        private System.Windows.Forms.Label RoomNumber;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label GuestCount;
        private System.Windows.Forms.Label FPrice;
        private System.Windows.Forms.Button Reserve;
        
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IPath = new System.Windows.Forms.PictureBox();
            this.RoomNumber = new System.Windows.Forms.Label();
            this.RoomType = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.GuestCount = new System.Windows.Forms.Label();
            this.FPrice = new System.Windows.Forms.Label();
            this.Reserve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IPath)).BeginInit();
            this.SuspendLayout();
            // 
            // IPath
            // 
            this.IPath.Location = new System.Drawing.Point(86, 14);
            this.IPath.Name = "IPath";
            this.IPath.Size = new System.Drawing.Size(100, 100);
            this.IPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IPath.TabIndex = 1;
            this.IPath.TabStop = false;
            // 
            // RoomNumber
            // 
            this.RoomNumber.AutoSize = true;
            this.RoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumber.Location = new System.Drawing.Point(142, 163);
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Size = new System.Drawing.Size(0, 17);
            this.RoomNumber.TabIndex = 2;
            // 
            // RoomType
            // 
            this.RoomType.AutoSize = true;
            this.RoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomType.Location = new System.Drawing.Point(142, 189);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(0, 17);
            this.RoomType.TabIndex = 3;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(142, 251);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(0, 17);
            this.Price.TabIndex = 4;
            // 
            // GuestCount
            // 
            this.GuestCount.AutoSize = true;
            this.GuestCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestCount.Location = new System.Drawing.Point(142, 221);
            this.GuestCount.Name = "GuestCount";
            this.GuestCount.Size = new System.Drawing.Size(0, 17);
            this.GuestCount.TabIndex = 5;
            // 
            // FPrice
            // 
            this.FPrice.AutoSize = true;
            this.FPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPrice.Location = new System.Drawing.Point(142, 279);
            this.FPrice.Name = "FPrice";
            this.FPrice.Size = new System.Drawing.Size(0, 17);
            this.FPrice.TabIndex = 6;
            // 
            // Reserve
            // 
            this.Reserve.Location = new System.Drawing.Point(86, 315);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(100, 23);
            this.Reserve.TabIndex = 7;
            this.Reserve.Text = "Reserve Now";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Room Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Room Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Max Person :";
            // 
            // GenerateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Reserve);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.RoomType);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.FPrice);
            this.Controls.Add(this.GuestCount);
            this.Controls.Add(this.IPath);
            this.Name = "GenerateRoom";
            this.Size = new System.Drawing.Size(264, 367);
            this.Load += new System.EventHandler(this.GenerateRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
