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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.namefield = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mobilenumberfield = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.usernamefield = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.passwordfield = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
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
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 37);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Users";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(265, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 34);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(315, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.namefield);
            this.panel2.Location = new System.Drawing.Point(29, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 38);
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
            this.namefield.Location = new System.Drawing.Point(25, 9);
            this.namefield.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(264, 21);
            this.namefield.TabIndex = 1;
            this.namefield.Text = "Name";
            this.namefield.MouseEnter += new System.EventHandler(this.namefield_MouseEnter);
            this.namefield.MouseLeave += new System.EventHandler(this.namefield_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.mobilenumberfield);
            this.panel3.Location = new System.Drawing.Point(29, 128);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 38);
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
            this.mobilenumberfield.Location = new System.Drawing.Point(25, 9);
            this.mobilenumberfield.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mobilenumberfield.Name = "mobilenumberfield";
            this.mobilenumberfield.Size = new System.Drawing.Size(264, 21);
            this.mobilenumberfield.TabIndex = 1;
            this.mobilenumberfield.Text = "Mobile Number";
            this.mobilenumberfield.MouseEnter += new System.EventHandler(this.mobilenumberfield_MouseEnter);
            this.mobilenumberfield.MouseLeave += new System.EventHandler(this.mobilenumberfield_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.usernamefield);
            this.panel4.Location = new System.Drawing.Point(29, 182);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 38);
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
            this.usernamefield.Location = new System.Drawing.Point(25, 9);
            this.usernamefield.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernamefield.Name = "usernamefield";
            this.usernamefield.Size = new System.Drawing.Size(264, 21);
            this.usernamefield.TabIndex = 1;
            this.usernamefield.Text = "Username";
            this.usernamefield.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.usernamefield.MouseEnter += new System.EventHandler(this.usernamefield_MouseEnter);
            this.usernamefield.MouseLeave += new System.EventHandler(this.usernamefield_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.passwordfield);
            this.panel5.Location = new System.Drawing.Point(29, 237);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(318, 38);
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
            this.passwordfield.Location = new System.Drawing.Point(25, 9);
            this.passwordfield.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordfield.Name = "passwordfield";
            this.passwordfield.Size = new System.Drawing.Size(264, 21);
            this.passwordfield.TabIndex = 1;
            this.passwordfield.Text = "Password";
            this.passwordfield.UseSystemPasswordChar = true;
            this.passwordfield.MouseEnter += new System.EventHandler(this.passwordfield_MouseEnter);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(29, 377);
            this.addbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(318, 47);
            this.addbutton.TabIndex = 12;
            this.addbutton.Text = "Add User";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(31, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 27);
            this.button3.TabIndex = 13;
            this.button3.Text = "Browse Picture";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SmartSales_v1.Properties.Resources.profile;
            this.pictureBox10.Location = new System.Drawing.Point(162, 303);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(37, 36);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(28, 440);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 20);
            this.statusLabel.TabIndex = 16;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(382, 480);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox mobilenumberfield;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox usernamefield;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox passwordfield;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label statusLabel;
    }
}