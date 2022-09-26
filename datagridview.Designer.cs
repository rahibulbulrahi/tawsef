namespace EximBank
{
    partial class datagridview
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
            this.navpanel = new System.Windows.Forms.Panel();
            this.navabrCustomerDetails = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinimizeICon = new System.Windows.Forms.PictureBox();
            this.CloseIcon = new System.Windows.Forms.PictureBox();
            this.navpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeICon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // navpanel
            // 
            this.navpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.navpanel.Controls.Add(this.pictureBox1);
            this.navpanel.Controls.Add(this.navabrCustomerDetails);
            this.navpanel.Controls.Add(this.MinimizeICon);
            this.navpanel.Controls.Add(this.CloseIcon);
            this.navpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navpanel.Location = new System.Drawing.Point(0, 0);
            this.navpanel.Name = "navpanel";
            this.navpanel.Size = new System.Drawing.Size(1280, 40);
            this.navpanel.TabIndex = 1;
            this.navpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navpanel_MouseDown);
            // 
            // navabrCustomerDetails
            // 
            this.navabrCustomerDetails.AutoSize = true;
            this.navabrCustomerDetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navabrCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.navabrCustomerDetails.Location = new System.Drawing.Point(43, 9);
            this.navabrCustomerDetails.Name = "navabrCustomerDetails";
            this.navabrCustomerDetails.Size = new System.Drawing.Size(252, 23);
            this.navabrCustomerDetails.TabIndex = 9;
            this.navabrCustomerDetails.Text = "Customer Detail Grid View";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::EximBank.Properties.Resources.Back_Arrow_35px;
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MinimizeICon
            // 
            this.MinimizeICon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeICon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeICon.Image = global::EximBank.Properties.Resources.icons8_minimize_window_35px;
            this.MinimizeICon.Location = new System.Drawing.Point(1213, 7);
            this.MinimizeICon.Name = "MinimizeICon";
            this.MinimizeICon.Size = new System.Drawing.Size(25, 25);
            this.MinimizeICon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeICon.TabIndex = 7;
            this.MinimizeICon.TabStop = false;
            this.MinimizeICon.Click += new System.EventHandler(this.MinimizeICon_Click);
            // 
            // CloseIcon
            // 
            this.CloseIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseIcon.Image = global::EximBank.Properties.Resources.icons8_close_window_35px;
            this.CloseIcon.Location = new System.Drawing.Point(1244, 7);
            this.CloseIcon.Name = "CloseIcon";
            this.CloseIcon.Size = new System.Drawing.Size(25, 25);
            this.CloseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseIcon.TabIndex = 8;
            this.CloseIcon.TabStop = false;
            this.CloseIcon.Click += new System.EventHandler(this.CloseIcon_Click);
            // 
            // datagridview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.navpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "datagridview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "datagridview";
            this.navpanel.ResumeLayout(false);
            this.navpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeICon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MinimizeICon;
        private System.Windows.Forms.PictureBox CloseIcon;
        private System.Windows.Forms.Panel navpanel;
        private System.Windows.Forms.Label navabrCustomerDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}