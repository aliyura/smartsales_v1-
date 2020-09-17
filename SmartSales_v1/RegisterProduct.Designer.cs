namespace SmartSales_v1
{
    partial class RegisterProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.productnamefield = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pricefield = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.costfield = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.reorderlevelfield = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(362, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register Product";
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "minus-symbol.png");
            this.imageList1.Images.SetKeyName(1, "close (1).png");
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.productnamefield);
            this.panel4.Location = new System.Drawing.Point(26, 100);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 38);
            this.panel4.TabIndex = 5;
            // 
            // productnamefield
            // 
            this.productnamefield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productnamefield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productnamefield.BackColor = System.Drawing.Color.White;
            this.productnamefield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productnamefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnamefield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productnamefield.Location = new System.Drawing.Point(22, 9);
            this.productnamefield.Margin = new System.Windows.Forms.Padding(2);
            this.productnamefield.Name = "productnamefield";
            this.productnamefield.Size = new System.Drawing.Size(217, 21);
            this.productnamefield.TabIndex = 1;
            this.productnamefield.Text = "Product name";
            this.productnamefield.MouseEnter += new System.EventHandler(this.productnamefield_MouseEnter);
            this.productnamefield.MouseLeave += new System.EventHandler(this.productnamefield_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pricefield);
            this.panel3.Location = new System.Drawing.Point(26, 172);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 38);
            this.panel3.TabIndex = 7;
            // 
            // pricefield
            // 
            this.pricefield.BackColor = System.Drawing.Color.White;
            this.pricefield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricefield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pricefield.Location = new System.Drawing.Point(31, 8);
            this.pricefield.Margin = new System.Windows.Forms.Padding(2);
            this.pricefield.Name = "pricefield";
            this.pricefield.Size = new System.Drawing.Size(217, 21);
            this.pricefield.TabIndex = 1;
            this.pricefield.Text = "Price";
            this.pricefield.MouseEnter += new System.EventHandler(this.pricefield_MouseEnter);
            this.pricefield.MouseLeave += new System.EventHandler(this.pricefield_MouseLeave);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(26, 402);
            this.addbutton.Margin = new System.Windows.Forms.Padding(2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(312, 47);
            this.addbutton.TabIndex = 8;
            this.addbutton.Text = "Add Product";
            this.addbutton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.costfield);
            this.panel2.Location = new System.Drawing.Point(26, 321);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 38);
            this.panel2.TabIndex = 8;
            // 
            // costfield
            // 
            this.costfield.BackColor = System.Drawing.Color.White;
            this.costfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.costfield.Location = new System.Drawing.Point(31, 8);
            this.costfield.Margin = new System.Windows.Forms.Padding(2);
            this.costfield.Name = "costfield";
            this.costfield.Size = new System.Drawing.Size(217, 21);
            this.costfield.TabIndex = 1;
            this.costfield.Text = "Cost";
            this.costfield.MouseEnter += new System.EventHandler(this.costfield_MouseEnter);
            this.costfield.MouseLeave += new System.EventHandler(this.costfield_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.reorderlevelfield);
            this.panel5.Location = new System.Drawing.Point(26, 245);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(312, 38);
            this.panel5.TabIndex = 9;
            // 
            // reorderlevelfield
            // 
            this.reorderlevelfield.BackColor = System.Drawing.Color.White;
            this.reorderlevelfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reorderlevelfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderlevelfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reorderlevelfield.Location = new System.Drawing.Point(31, 9);
            this.reorderlevelfield.Margin = new System.Windows.Forms.Padding(2);
            this.reorderlevelfield.Name = "reorderlevelfield";
            this.reorderlevelfield.Size = new System.Drawing.Size(217, 21);
            this.reorderlevelfield.TabIndex = 1;
            this.reorderlevelfield.Text = "Re-order Level";
            this.reorderlevelfield.MouseEnter += new System.EventHandler(this.reorderlevelfield_MouseEnter);
            this.reorderlevelfield.MouseLeave += new System.EventHandler(this.reorderlevelfield_MouseLeave);
            // 
            // textBox13
            // 
            this.textBox13.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox13.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox13.Location = new System.Drawing.Point(26, 80);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(156, 21);
            this.textBox13.TabIndex = 36;
            this.textBox13.Text = "Bar Code";
            // 
            // RegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 460);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterProduct";
            this.Text = "RegisterProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox productnamefield;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox pricefield;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox costfield;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox reorderlevelfield;
        private System.Windows.Forms.TextBox textBox13;
    }
}