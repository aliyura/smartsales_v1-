namespace SmartSales_v1
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizedbutton = new System.Windows.Forms.Button();
            this.closedbutton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.customernamefield = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addressfield = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.phonenumberfield = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.altphonenumberfield = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.creditlimitfield = new System.Windows.Forms.TextBox();
            this.customergroupCombobox = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.addCustomerGroup = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "minus-symbol.png");
            this.imageList1.Images.SetKeyName(1, "close (1).png");
            this.imageList1.Images.SetKeyName(2, "plus.png");
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
            this.panel1.Size = new System.Drawing.Size(413, 46);
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
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // minimizedbutton
            // 
            this.minimizedbutton.FlatAppearance.BorderSize = 0;
            this.minimizedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizedbutton.ImageIndex = 0;
            this.minimizedbutton.ImageList = this.imageList1;
            this.minimizedbutton.Location = new System.Drawing.Point(317, 4);
            this.minimizedbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizedbutton.Name = "minimizedbutton";
            this.minimizedbutton.Size = new System.Drawing.Size(41, 34);
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
            this.closedbutton.Location = new System.Drawing.Point(368, 4);
            this.closedbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closedbutton.Name = "closedbutton";
            this.closedbutton.Size = new System.Drawing.Size(41, 34);
            this.closedbutton.TabIndex = 0;
            this.closedbutton.UseVisualStyleBackColor = true;
            this.closedbutton.Click += new System.EventHandler(this.closedbutton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.customernamefield);
            this.panel4.Location = new System.Drawing.Point(21, 82);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 47);
            this.panel4.TabIndex = 6;
            // 
            // customernamefield
            // 
            this.customernamefield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customernamefield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.customernamefield.BackColor = System.Drawing.Color.White;
            this.customernamefield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customernamefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customernamefield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customernamefield.Location = new System.Drawing.Point(29, 10);
            this.customernamefield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customernamefield.Name = "customernamefield";
            this.customernamefield.Size = new System.Drawing.Size(289, 27);
            this.customernamefield.TabIndex = 1;
            this.customernamefield.Text = "Customer Name";
            this.customernamefield.Enter += new System.EventHandler(this.customernamefield_Enter);
            this.customernamefield.Leave += new System.EventHandler(this.customernamefield_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.addressfield);
            this.panel2.Location = new System.Drawing.Point(21, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 47);
            this.panel2.TabIndex = 7;
            // 
            // addressfield
            // 
            this.addressfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.addressfield.BackColor = System.Drawing.Color.White;
            this.addressfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressfield.Location = new System.Drawing.Point(29, 10);
            this.addressfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressfield.Name = "addressfield";
            this.addressfield.Size = new System.Drawing.Size(289, 27);
            this.addressfield.TabIndex = 1;
            this.addressfield.Text = "Address";
            this.addressfield.Enter += new System.EventHandler(this.addressfield_Enter);
            this.addressfield.Leave += new System.EventHandler(this.addressfield_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.phonenumberfield);
            this.panel3.Location = new System.Drawing.Point(21, 229);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 47);
            this.panel3.TabIndex = 8;
            // 
            // phonenumberfield
            // 
            this.phonenumberfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.phonenumberfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.phonenumberfield.BackColor = System.Drawing.Color.White;
            this.phonenumberfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phonenumberfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumberfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phonenumberfield.Location = new System.Drawing.Point(29, 10);
            this.phonenumberfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phonenumberfield.MaxLength = 11;
            this.phonenumberfield.Name = "phonenumberfield";
            this.phonenumberfield.Size = new System.Drawing.Size(289, 27);
            this.phonenumberfield.TabIndex = 1;
            this.phonenumberfield.Text = "Phone Number";
            this.phonenumberfield.Enter += new System.EventHandler(this.phonenumberfield_Enter);
            this.phonenumberfield.Leave += new System.EventHandler(this.phonenumberfield_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.altphonenumberfield);
            this.panel5.Location = new System.Drawing.Point(21, 307);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 47);
            this.panel5.TabIndex = 9;
            // 
            // altphonenumberfield
            // 
            this.altphonenumberfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.altphonenumberfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.altphonenumberfield.BackColor = System.Drawing.Color.White;
            this.altphonenumberfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.altphonenumberfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altphonenumberfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.altphonenumberfield.Location = new System.Drawing.Point(29, 10);
            this.altphonenumberfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.altphonenumberfield.Name = "altphonenumberfield";
            this.altphonenumberfield.Size = new System.Drawing.Size(289, 27);
            this.altphonenumberfield.TabIndex = 1;
            this.altphonenumberfield.Text = "Alternate Phone Number";
            this.altphonenumberfield.Enter += new System.EventHandler(this.altphonenumberfield_Enter);
            this.altphonenumberfield.Leave += new System.EventHandler(this.altphonenumberfield_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.creditlimitfield);
            this.panel6.Location = new System.Drawing.Point(21, 384);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(365, 47);
            this.panel6.TabIndex = 10;
            // 
            // creditlimitfield
            // 
            this.creditlimitfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.creditlimitfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.creditlimitfield.BackColor = System.Drawing.Color.White;
            this.creditlimitfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creditlimitfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditlimitfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.creditlimitfield.Location = new System.Drawing.Point(29, 10);
            this.creditlimitfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creditlimitfield.Name = "creditlimitfield";
            this.creditlimitfield.Size = new System.Drawing.Size(289, 27);
            this.creditlimitfield.TabIndex = 1;
            this.creditlimitfield.Text = "Credit Limit";
            this.creditlimitfield.Enter += new System.EventHandler(this.creditlimitfield_Enter);
            this.creditlimitfield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.creditlimitfield_KeyDown);
            this.creditlimitfield.Leave += new System.EventHandler(this.creditlimitfield_Leave);
            // 
            // customergroupCombobox
            // 
            this.customergroupCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customergroupCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customergroupCombobox.FormattingEnabled = true;
            this.customergroupCombobox.Items.AddRange(new object[] {
            "Regular",
            "Irregular"});
            this.customergroupCombobox.Location = new System.Drawing.Point(50, 463);
            this.customergroupCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.customergroupCombobox.Name = "customergroupCombobox";
            this.customergroupCombobox.Size = new System.Drawing.Size(285, 33);
            this.customergroupCombobox.TabIndex = 12;
            this.customergroupCombobox.Text = "Customer Group";
            this.customergroupCombobox.Enter += new System.EventHandler(this.customergroupCombobox_Enter);
            this.customergroupCombobox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customergroupCombobox_KeyDown);
            this.customergroupCombobox.Leave += new System.EventHandler(this.customergroupCombobox_Leave);
            this.customergroupCombobox.MouseEnter += new System.EventHandler(this.customergroupfield_MouseEnter);
            this.customergroupCombobox.MouseLeave += new System.EventHandler(this.customergroupfield_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.addCustomerGroup);
            this.panel7.Location = new System.Drawing.Point(21, 457);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(365, 48);
            this.panel7.TabIndex = 13;
            // 
            // addCustomerGroup
            // 
            this.addCustomerGroup.ImageIndex = 2;
            this.addCustomerGroup.ImageList = this.imageList1;
            this.addCustomerGroup.Location = new System.Drawing.Point(324, 6);
            this.addCustomerGroup.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomerGroup.Name = "addCustomerGroup";
            this.addCustomerGroup.Size = new System.Drawing.Size(37, 34);
            this.addCustomerGroup.TabIndex = 0;
            this.addCustomerGroup.UseVisualStyleBackColor = true;
            this.addCustomerGroup.Click += new System.EventHandler(this.addCustomerGroup_Click);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(21, 533);
            this.addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(365, 58);
            this.addbutton.TabIndex = 14;
            this.addbutton.Text = "Add Customer";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(25, 608);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 16;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 644);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.customergroupCombobox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCustomer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_customer";
            this.TopMost = true;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddCustomer_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.Button closedbutton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox customernamefield;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox addressfield;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox phonenumberfield;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox altphonenumberfield;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox creditlimitfield;
        private System.Windows.Forms.ComboBox customergroupCombobox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button addCustomerGroup;
        private System.Windows.Forms.Label statusLabel;
    }
}