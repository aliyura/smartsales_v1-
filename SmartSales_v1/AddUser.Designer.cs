namespace SmartSales_v1
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizedbutton = new System.Windows.Forms.Button();
            this.closedbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.namefield = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mobilenumberfield = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.usernamefield = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.passwordfield = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.browseImageButton = new System.Windows.Forms.Button();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "minus-symbol.png");
            this.imageList1.Images.SetKeyName(1, "close (1).png");
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
            this.panel1.Size = new System.Drawing.Size(441, 46);
            this.panel1.TabIndex = 1;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Users";
            // 
            // minimizedbutton
            // 
            this.minimizedbutton.FlatAppearance.BorderSize = 0;
            this.minimizedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizedbutton.ImageIndex = 0;
            this.minimizedbutton.ImageList = this.imageList1;
            this.minimizedbutton.Location = new System.Drawing.Point(290, 0);
            this.minimizedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizedbutton.Name = "minimizedbutton";
            this.minimizedbutton.Size = new System.Drawing.Size(55, 42);
            this.minimizedbutton.TabIndex = 1;
            this.minimizedbutton.UseVisualStyleBackColor = true;
            this.minimizedbutton.Click += new System.EventHandler(this.minimizedbutton_Click);
            // 
            // closedbutton
            // 
            this.closedbutton.FlatAppearance.BorderSize = 0;
            this.closedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedbutton.ImageIndex = 1;
            this.closedbutton.ImageList = this.imageList1;
            this.closedbutton.Location = new System.Drawing.Point(361, 0);
            this.closedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.closedbutton.Name = "closedbutton";
            this.closedbutton.Size = new System.Drawing.Size(55, 42);
            this.closedbutton.TabIndex = 0;
            this.closedbutton.UseVisualStyleBackColor = true;
            this.closedbutton.Click += new System.EventHandler(this.closedbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.namefield);
            this.panel2.Location = new System.Drawing.Point(22, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 47);
            this.panel2.TabIndex = 8;
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
            this.namefield.Size = new System.Drawing.Size(352, 27);
            this.namefield.TabIndex = 1;
            this.namefield.Text = "Name";
            this.namefield.Enter += new System.EventHandler(this.namefield_Enter);
            this.namefield.Leave += new System.EventHandler(this.namefield_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.mobilenumberfield);
            this.panel3.Location = new System.Drawing.Point(22, 158);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 47);
            this.panel3.TabIndex = 9;
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
            this.mobilenumberfield.Size = new System.Drawing.Size(352, 27);
            this.mobilenumberfield.TabIndex = 1;
            this.mobilenumberfield.Text = "Mobile Number";
            this.mobilenumberfield.Enter += new System.EventHandler(this.mobilenumberfield_Enter);
            this.mobilenumberfield.Leave += new System.EventHandler(this.mobilenumberfield_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.usernamefield);
            this.panel4.Location = new System.Drawing.Point(22, 224);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 47);
            this.panel4.TabIndex = 10;
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
            this.usernamefield.Size = new System.Drawing.Size(352, 27);
            this.usernamefield.TabIndex = 1;
            this.usernamefield.Text = "Username";
            this.usernamefield.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.usernamefield.Enter += new System.EventHandler(this.usernamefield_Enter);
            this.usernamefield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernamefield_KeyDown);
            this.usernamefield.Leave += new System.EventHandler(this.usernamefield_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.passwordfield);
            this.panel5.Location = new System.Drawing.Point(22, 292);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(394, 47);
            this.panel5.TabIndex = 11;
            // 
            // passwordfield
            // 
            this.passwordfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.passwordfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.passwordfield.BackColor = System.Drawing.Color.White;
            this.passwordfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordfield.Location = new System.Drawing.Point(33, 11);
            this.passwordfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordfield.Name = "passwordfield";
            this.passwordfield.PasswordChar = '*';
            this.passwordfield.Size = new System.Drawing.Size(352, 27);
            this.passwordfield.TabIndex = 1;
            this.passwordfield.Text = "Password";
            this.passwordfield.UseSystemPasswordChar = true;
            this.passwordfield.Enter += new System.EventHandler(this.passwordfield_Enter);
            this.passwordfield.Leave += new System.EventHandler(this.passwordfield_Leave);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(22, 464);
            this.addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(394, 58);
            this.addbutton.TabIndex = 12;
            this.addbutton.Text = "Add User";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // browseImageButton
            // 
            this.browseImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.browseImageButton.FlatAppearance.BorderSize = 0;
            this.browseImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseImageButton.ForeColor = System.Drawing.Color.White;
            this.browseImageButton.Location = new System.Drawing.Point(24, 382);
            this.browseImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseImageButton.Name = "browseImageButton";
            this.browseImageButton.Size = new System.Drawing.Size(133, 33);
            this.browseImageButton.TabIndex = 13;
            this.browseImageButton.Text = "Browse Picture";
            this.browseImageButton.UseVisualStyleBackColor = false;
            this.browseImageButton.Click += new System.EventHandler(this.browseImageButton_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::SmartSales_v1.Properties.Resources.profile;
            this.userPictureBox.Location = new System.Drawing.Point(165, 371);
            this.userPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(53, 44);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 15;
            this.userPictureBox.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(27, 544);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 25);
            this.statusLabel.TabIndex = 16;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(441, 591);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.browseImageButton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.Button closedbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox mobilenumberfield;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox usernamefield;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox passwordfield;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button browseImageButton;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label statusLabel;
    }
}