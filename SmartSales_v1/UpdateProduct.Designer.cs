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
            this.productNamePanel = new System.Windows.Forms.Panel();
            this.addProductTrigger = new System.Windows.Forms.Button();
            this.productnamefield = new System.Windows.Forms.TextBox();
            this.locationPanel = new System.Windows.Forms.Panel();
            this.addLocationTrigger = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.quantityfield = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.descriptionfield = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.statusLabel1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.costTextField = new System.Windows.Forms.TextBox();
            this.locationDropdown = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.productNamePanel.SuspendLayout();
            this.locationPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 47);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageIndex = 1;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(369, 1);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 42);
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
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
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
            this.minimizedbutton.Location = new System.Drawing.Point(304, 1);
            this.minimizedbutton.Margin = new System.Windows.Forms.Padding(5);
            this.minimizedbutton.Name = "minimizedbutton";
            this.minimizedbutton.Size = new System.Drawing.Size(55, 42);
            this.minimizedbutton.TabIndex = 1;
            this.minimizedbutton.UseVisualStyleBackColor = true;
            this.minimizedbutton.Click += new System.EventHandler(this.minimizedbutton_Click);
            // 
            // productNamePanel
            // 
            this.productNamePanel.BackColor = System.Drawing.Color.White;
            this.productNamePanel.Controls.Add(this.addProductTrigger);
            this.productNamePanel.Controls.Add(this.productnamefield);
            this.productNamePanel.Location = new System.Drawing.Point(22, 76);
            this.productNamePanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.productNamePanel.Name = "productNamePanel";
            this.productNamePanel.Size = new System.Drawing.Size(401, 47);
            this.productNamePanel.TabIndex = 10;
            // 
            // addProductTrigger
            // 
            this.addProductTrigger.ImageIndex = 2;
            this.addProductTrigger.ImageList = this.imageList1;
            this.addProductTrigger.Location = new System.Drawing.Point(357, 0);
            this.addProductTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.addProductTrigger.Name = "addProductTrigger";
            this.addProductTrigger.Size = new System.Drawing.Size(45, 47);
            this.addProductTrigger.TabIndex = 22;
            this.addProductTrigger.UseVisualStyleBackColor = true;
            this.addProductTrigger.Click += new System.EventHandler(this.addProductTrigger_Click);
            // 
            // productnamefield
            // 
            this.productnamefield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productnamefield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productnamefield.BackColor = System.Drawing.Color.White;
            this.productnamefield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productnamefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnamefield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productnamefield.Location = new System.Drawing.Point(40, 10);
            this.productnamefield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productnamefield.Name = "productnamefield";
            this.productnamefield.Size = new System.Drawing.Size(310, 27);
            this.productnamefield.TabIndex = 2;
            this.productnamefield.Text = "Product Name";
            this.productnamefield.TextChanged += new System.EventHandler(this.productnamefield_TextChanged_1);
            this.productnamefield.Enter += new System.EventHandler(this.productnamefield_Enter);
            this.productnamefield.Leave += new System.EventHandler(this.productnamefield_Leave);
            // 
            // locationPanel
            // 
            this.locationPanel.BackColor = System.Drawing.Color.White;
            this.locationPanel.Controls.Add(this.locationDropdown);
            this.locationPanel.Controls.Add(this.addLocationTrigger);
            this.locationPanel.Location = new System.Drawing.Point(22, 145);
            this.locationPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.locationPanel.Name = "locationPanel";
            this.locationPanel.Size = new System.Drawing.Size(401, 47);
            this.locationPanel.TabIndex = 11;
            // 
            // addLocationTrigger
            // 
            this.addLocationTrigger.ImageIndex = 2;
            this.addLocationTrigger.ImageList = this.imageList1;
            this.addLocationTrigger.Location = new System.Drawing.Point(356, 0);
            this.addLocationTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.addLocationTrigger.Name = "addLocationTrigger";
            this.addLocationTrigger.Size = new System.Drawing.Size(46, 47);
            this.addLocationTrigger.TabIndex = 22;
            this.addLocationTrigger.UseVisualStyleBackColor = true;
            this.addLocationTrigger.Click += new System.EventHandler(this.addLocationTrigger_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.quantityfield);
            this.panel4.Location = new System.Drawing.Point(22, 210);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 47);
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
            this.quantityfield.Location = new System.Drawing.Point(35, 11);
            this.quantityfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityfield.Name = "quantityfield";
            this.quantityfield.Size = new System.Drawing.Size(324, 27);
            this.quantityfield.TabIndex = 1;
            this.quantityfield.Text = "Quantity";
            this.quantityfield.Enter += new System.EventHandler(this.quantityfield_Enter);
            this.quantityfield.Leave += new System.EventHandler(this.quantityfield_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.descriptionfield);
            this.panel5.Location = new System.Drawing.Point(22, 342);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 131);
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
            this.descriptionfield.Location = new System.Drawing.Point(34, 18);
            this.descriptionfield.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.descriptionfield.Multiline = true;
            this.descriptionfield.Name = "descriptionfield";
            this.descriptionfield.Size = new System.Drawing.Size(340, 98);
            this.descriptionfield.TabIndex = 1;
            this.descriptionfield.Text = "Description";
            this.descriptionfield.Enter += new System.EventHandler(this.descriptionfield_Enter);
            this.descriptionfield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descriptionfield_KeyDown);
            this.descriptionfield.Leave += new System.EventHandler(this.descriptionfield_Leave);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(22, 502);
            this.addbutton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(401, 58);
            this.addbutton.TabIndex = 14;
            this.addbutton.Text = "Update Product";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click_1);
            // 
            // statusLabel1
            // 
            this.statusLabel1.AutoSize = true;
            this.statusLabel1.Location = new System.Drawing.Point(25, 581);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(0, 17);
            this.statusLabel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.costTextField);
            this.panel2.Location = new System.Drawing.Point(23, 276);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 47);
            this.panel2.TabIndex = 38;
            // 
            // costTextField
            // 
            this.costTextField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.costTextField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.costTextField.BackColor = System.Drawing.Color.White;
            this.costTextField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.costTextField.Location = new System.Drawing.Point(36, 10);
            this.costTextField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costTextField.Name = "costTextField";
            this.costTextField.Size = new System.Drawing.Size(324, 27);
            this.costTextField.TabIndex = 1;
            this.costTextField.Text = "Cost";
            this.costTextField.Enter += new System.EventHandler(this.costTextField_Enter);
            this.costTextField.Leave += new System.EventHandler(this.costTextField_Leave);
            // 
            // locationDropdown
            // 
            this.locationDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.locationDropdown.FormattingEnabled = true;
            this.locationDropdown.Location = new System.Drawing.Point(38, 7);
            this.locationDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.locationDropdown.Name = "locationDropdown";
            this.locationDropdown.Size = new System.Drawing.Size(311, 37);
            this.locationDropdown.TabIndex = 34;
            this.locationDropdown.Text = "Location";
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusLabel1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.locationPanel);
            this.Controls.Add(this.productNamePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UpdateProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStock";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.productNamePanel.ResumeLayout(false);
            this.productNamePanel.PerformLayout();
            this.locationPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel productNamePanel;
        private System.Windows.Forms.Panel locationPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox quantityfield;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox descriptionfield;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label statusLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox costTextField;
        private System.Windows.Forms.TextBox productnamefield;
        private System.Windows.Forms.Button addProductTrigger;
        private System.Windows.Forms.Button addLocationTrigger;
        private System.Windows.Forms.ComboBox locationDropdown;
    }
}