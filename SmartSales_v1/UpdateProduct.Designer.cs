namespace SmartSales_v1
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.minimizedbutton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.productnamedropdown = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.locationdropdown = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.quantityfield = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.descriptionfield = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimizedbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 37);
            this.panel1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageIndex = 1;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(310, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 34);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "minus-symbol.png");
            this.imageList1.Images.SetKeyName(1, "close (1).png");
            this.imageList1.Images.SetKeyName(2, "plus.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Product";
            // 
            // minimizedbutton
            // 
            this.minimizedbutton.FlatAppearance.BorderSize = 0;
            this.minimizedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizedbutton.ImageIndex = 0;
            this.minimizedbutton.ImageList = this.imageList1;
            this.minimizedbutton.Location = new System.Drawing.Point(255, 1);
            this.minimizedbutton.Name = "minimizedbutton";
            this.minimizedbutton.Size = new System.Drawing.Size(41, 34);
            this.minimizedbutton.TabIndex = 1;
            this.minimizedbutton.UseVisualStyleBackColor = true;
            this.minimizedbutton.Click += new System.EventHandler(this.minimizedbutton_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.productnamedropdown);
            this.panel.Location = new System.Drawing.Point(23, 98);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(301, 38);
            this.panel.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(268, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // productnamedropdown
            // 
            this.productnamedropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productnamedropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnamedropdown.FormattingEnabled = true;
            this.productnamedropdown.Location = new System.Drawing.Point(25, 5);
            this.productnamedropdown.Name = "productnamedropdown";
            this.productnamedropdown.Size = new System.Drawing.Size(232, 28);
            this.productnamedropdown.TabIndex = 10;
            this.productnamedropdown.Text = "Product Name";
            this.productnamedropdown.MouseEnter += new System.EventHandler(this.productnamedropdown_MouseEnter);
            this.productnamedropdown.MouseLeave += new System.EventHandler(this.productnamedropdown_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.locationdropdown);
            this.panel2.Location = new System.Drawing.Point(23, 170);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 38);
            this.panel2.TabIndex = 11;
            // 
            // locationdropdown
            // 
            this.locationdropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationdropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationdropdown.FormattingEnabled = true;
            this.locationdropdown.Location = new System.Drawing.Point(25, 5);
            this.locationdropdown.Name = "locationdropdown";
            this.locationdropdown.Size = new System.Drawing.Size(255, 28);
            this.locationdropdown.TabIndex = 11;
            this.locationdropdown.Text = "Location";
            this.locationdropdown.MouseEnter += new System.EventHandler(this.locationdropdown_MouseEnter);
            this.locationdropdown.MouseLeave += new System.EventHandler(this.locationdropdown_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.quantityfield);
            this.panel4.Location = new System.Drawing.Point(23, 239);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 38);
            this.panel4.TabIndex = 12;
            // 
            // quantityfield
            // 
            this.quantityfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.quantityfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.quantityfield.BackColor = System.Drawing.Color.White;
            this.quantityfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantityfield.Location = new System.Drawing.Point(26, 9);
            this.quantityfield.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityfield.Name = "quantityfield";
            this.quantityfield.Size = new System.Drawing.Size(243, 21);
            this.quantityfield.TabIndex = 1;
            this.quantityfield.Text = "Quantity";
            this.quantityfield.TextChanged += new System.EventHandler(this.quantityfield_TextChanged);
            this.quantityfield.MouseEnter += new System.EventHandler(this.currentpricefield_MouseEnter);
            this.quantityfield.MouseLeave += new System.EventHandler(this.currentpricefield_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.descriptionfield);
            this.panel5.Location = new System.Drawing.Point(23, 301);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(301, 158);
            this.panel5.TabIndex = 13;
            // 
            // descriptionfield
            // 
            this.descriptionfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.descriptionfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.descriptionfield.BackColor = System.Drawing.Color.White;
            this.descriptionfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionfield.Location = new System.Drawing.Point(25, 9);
            this.descriptionfield.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionfield.Multiline = true;
            this.descriptionfield.Name = "descriptionfield";
            this.descriptionfield.Size = new System.Drawing.Size(255, 134);
            this.descriptionfield.TabIndex = 1;
            this.descriptionfield.Text = "Description";
            this.descriptionfield.MouseEnter += new System.EventHandler(this.descriptionfield_MouseEnter);
            this.descriptionfield.MouseLeave += new System.EventHandler(this.descriptionfield_MouseLeave);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(23, 482);
            this.addbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(301, 47);
            this.addbutton.TabIndex = 14;
            this.addbutton.Text = "Update Product";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click_1);
            // 
            // textBox13
            // 
            this.textBox13.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox13.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox13.Location = new System.Drawing.Point(23, 77);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(118, 21);
            this.textBox13.TabIndex = 35;
            this.textBox13.Text = "Bar Code";
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 571);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox productnamedropdown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox locationdropdown;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox quantityfield;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox descriptionfield;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button1;
    }
}