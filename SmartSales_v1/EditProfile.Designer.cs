namespace SmartSales_v1
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusLabel = new System.Windows.Forms.Label();
            this.browseImageButton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.usernamefield = new System.Windows.Forms.TextBox();
            this.mobilenumberfield = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.namefield = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addressfield = new System.Windows.Forms.TextBox();
            this.statusLabel1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mobileLavel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.minimizedbutton = new System.Windows.Forms.Button();
            this.closedbutton = new System.Windows.Forms.Button();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "minus-symbol.png");
            this.imageList1.Images.SetKeyName(1, "close (1).png");
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(27, 612);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 25);
            this.statusLabel.TabIndex = 25;
            // 
            // browseImageButton
            // 
            this.browseImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.browseImageButton.FlatAppearance.BorderSize = 0;
            this.browseImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseImageButton.ForeColor = System.Drawing.Color.White;
            this.browseImageButton.Location = new System.Drawing.Point(128, 224);
            this.browseImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseImageButton.Name = "browseImageButton";
            this.browseImageButton.Size = new System.Drawing.Size(264, 39);
            this.browseImageButton.TabIndex = 23;
            this.browseImageButton.Text = "  Change Picture";
            this.browseImageButton.UseVisualStyleBackColor = false;
            this.browseImageButton.Click += new System.EventHandler(this.browseImageButton_Click);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(32, 643);
            this.addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(463, 58);
            this.addbutton.TabIndex = 22;
            this.addbutton.Text = "Update Profile";
            this.addbutton.UseVisualStyleBackColor = false;
            // 
            // usernamefield
            // 
            this.usernamefield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.usernamefield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.usernamefield.BackColor = System.Drawing.Color.White;
            this.usernamefield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernamefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamefield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernamefield.Location = new System.Drawing.Point(33, 11);
            this.usernamefield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernamefield.Name = "usernamefield";
            this.usernamefield.Size = new System.Drawing.Size(404, 27);
            this.usernamefield.TabIndex = 1;
            this.usernamefield.Text = "Username";
            this.usernamefield.Enter += new System.EventHandler(this.usernamefield_Enter);
            this.usernamefield.Leave += new System.EventHandler(this.usernamefield_Leave);
            // 
            // mobilenumberfield
            // 
            this.mobilenumberfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mobilenumberfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.mobilenumberfield.BackColor = System.Drawing.Color.White;
            this.mobilenumberfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mobilenumberfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilenumberfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mobilenumberfield.Location = new System.Drawing.Point(33, 11);
            this.mobilenumberfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mobilenumberfield.Name = "mobilenumberfield";
            this.mobilenumberfield.Size = new System.Drawing.Size(404, 27);
            this.mobilenumberfield.TabIndex = 1;
            this.mobilenumberfield.Text = "Mobile Number";
            this.mobilenumberfield.Enter += new System.EventHandler(this.mobilenumberfield_Enter);
            this.mobilenumberfield.Leave += new System.EventHandler(this.mobilenumberfield_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.mobilenumberfield);
            this.panel3.Location = new System.Drawing.Point(32, 359);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 47);
            this.panel3.TabIndex = 19;
            // 
            // namefield
            // 
            this.namefield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.namefield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.namefield.BackColor = System.Drawing.Color.White;
            this.namefield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namefield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.namefield.Location = new System.Drawing.Point(33, 11);
            this.namefield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(404, 27);
            this.namefield.TabIndex = 1;
            this.namefield.Text = "Name";
            this.namefield.Enter += new System.EventHandler(this.namefield_Enter);
            this.namefield.Leave += new System.EventHandler(this.namefield_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.namefield);
            this.panel2.Location = new System.Drawing.Point(32, 288);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 47);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimizedbutton);
            this.panel1.Controls.Add(this.closedbutton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 46);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit Profile";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.usernamefield);
            this.panel4.Location = new System.Drawing.Point(32, 428);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 47);
            this.panel4.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.addressfield);
            this.panel6.Location = new System.Drawing.Point(32, 499);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(463, 91);
            this.panel6.TabIndex = 26;
            // 
            // addressfield
            // 
            this.addressfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.addressfield.BackColor = System.Drawing.Color.White;
            this.addressfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressfield.Location = new System.Drawing.Point(33, 12);
            this.addressfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressfield.Multiline = true;
            this.addressfield.Name = "addressfield";
            this.addressfield.Size = new System.Drawing.Size(404, 67);
            this.addressfield.TabIndex = 1;
            this.addressfield.Text = "Home Address";
            this.addressfield.Enter += new System.EventHandler(this.addressfield_Enter);
            this.addressfield.Leave += new System.EventHandler(this.addressfield_Leave);
            // 
            // statusLabel1
            // 
            this.statusLabel1.AutoSize = true;
            this.statusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel1.Location = new System.Drawing.Point(32, 722);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(0, 17);
            this.statusLabel1.TabIndex = 27;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.Gray;
            this.nameLabel.Location = new System.Drawing.Point(64, 336);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 17);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "#name";
            // 
            // mobileLavel
            // 
            this.mobileLavel.AutoSize = true;
            this.mobileLavel.ForeColor = System.Drawing.Color.Gray;
            this.mobileLavel.Location = new System.Drawing.Point(61, 410);
            this.mobileLavel.Name = "mobileLavel";
            this.mobileLavel.Size = new System.Drawing.Size(109, 17);
            this.mobileLavel.TabIndex = 29;
            this.mobileLavel.Text = "#mobile number";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.Color.Gray;
            this.usernameLabel.Location = new System.Drawing.Point(60, 478);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(79, 17);
            this.usernameLabel.TabIndex = 30;
            this.usernameLabel.Text = "#username";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.ForeColor = System.Drawing.Color.Gray;
            this.addressLabel.Location = new System.Drawing.Point(62, 591);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(67, 17);
            this.addressLabel.TabIndex = 31;
            this.addressLabel.Text = "#address";
            // 
            // minimizedbutton
            // 
            this.minimizedbutton.FlatAppearance.BorderSize = 0;
            this.minimizedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizedbutton.ImageIndex = 0;
            this.minimizedbutton.ImageList = this.imageList1;
            this.minimizedbutton.Location = new System.Drawing.Point(383, 0);
            this.minimizedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizedbutton.Name = "minimizedbutton";
            this.minimizedbutton.Size = new System.Drawing.Size(55, 42);
            this.minimizedbutton.TabIndex = 1;
            this.minimizedbutton.UseVisualStyleBackColor = true;
            // 
            // closedbutton
            // 
            this.closedbutton.FlatAppearance.BorderSize = 0;
            this.closedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedbutton.ImageIndex = 1;
            this.closedbutton.ImageList = this.imageList1;
            this.closedbutton.Location = new System.Drawing.Point(454, 0);
            this.closedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.closedbutton.Name = "closedbutton";
            this.closedbutton.Size = new System.Drawing.Size(55, 42);
            this.closedbutton.TabIndex = 0;
            this.closedbutton.UseVisualStyleBackColor = true;
            this.closedbutton.Click += new System.EventHandler(this.closedbutton_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::SmartSales_v1.Properties.Resources.profile;
            this.userPictureBox.Location = new System.Drawing.Point(178, 68);
            this.userPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(160, 153);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 16;
            this.userPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.pictureBox1.Image = global::SmartSales_v1.Properties.Resources.upload;
            this.pictureBox1.Location = new System.Drawing.Point(145, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 751);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.mobileLavel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.statusLabel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.browseImageButton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.userPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button closedbutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button browseImageButton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.TextBox usernamefield;
        private System.Windows.Forms.TextBox mobilenumberfield;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox addressfield;
        private System.Windows.Forms.Label statusLabel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label mobileLavel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}