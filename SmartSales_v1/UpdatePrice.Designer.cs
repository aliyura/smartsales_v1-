namespace SmartSales_v1
{
    partial class UpdatePrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePrice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closedbutton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.minimizedbutton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productNameField = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.priceField = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.costField = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.closedbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimizedbutton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 46);
            this.panel1.TabIndex = 2;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // closedbutton
            // 
            this.closedbutton.FlatAppearance.BorderSize = 0;
            this.closedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedbutton.ImageIndex = 1;
            this.closedbutton.ImageList = this.imageList1;
            this.closedbutton.Location = new System.Drawing.Point(403, 1);
            this.closedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.closedbutton.Name = "closedbutton";
            this.closedbutton.Size = new System.Drawing.Size(55, 42);
            this.closedbutton.TabIndex = 3;
            this.closedbutton.UseVisualStyleBackColor = true;
            this.closedbutton.Click += new System.EventHandler(this.closedbutton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "minus-symbol.png");
            this.imageList1.Images.SetKeyName(1, "close (1).png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Price";
            // 
            // minimizedbutton
            // 
            this.minimizedbutton.FlatAppearance.BorderSize = 0;
            this.minimizedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizedbutton.ImageIndex = 0;
            this.minimizedbutton.ImageList = this.imageList1;
            this.minimizedbutton.Location = new System.Drawing.Point(340, 1);
            this.minimizedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizedbutton.Name = "minimizedbutton";
            this.minimizedbutton.Size = new System.Drawing.Size(55, 42);
            this.minimizedbutton.TabIndex = 1;
            this.minimizedbutton.UseVisualStyleBackColor = true;
            this.minimizedbutton.Click += new System.EventHandler(this.minimizedbutton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.productNameField);
            this.panel3.Location = new System.Drawing.Point(35, 96);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 47);
            this.panel3.TabIndex = 9;
            // 
            // productNameField
            // 
            this.productNameField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameField.FormattingEnabled = true;
            this.productNameField.Location = new System.Drawing.Point(33, 6);
            this.productNameField.Margin = new System.Windows.Forms.Padding(4);
            this.productNameField.Name = "productNameField";
            this.productNameField.Size = new System.Drawing.Size(325, 33);
            this.productNameField.TabIndex = 10;
            this.productNameField.Text = "Product Name";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.priceField);
            this.panel5.Location = new System.Drawing.Point(35, 167);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(387, 47);
            this.panel5.TabIndex = 12;
            // 
            // priceField
            // 
            this.priceField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.priceField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.priceField.BackColor = System.Drawing.Color.White;
            this.priceField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceField.Location = new System.Drawing.Point(35, 10);
            this.priceField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(323, 27);
            this.priceField.TabIndex = 1;
            this.priceField.Text = "Price";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.costField);
            this.panel6.Location = new System.Drawing.Point(35, 240);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(387, 47);
            this.panel6.TabIndex = 13;
            // 
            // costField
            // 
            this.costField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.costField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.costField.BackColor = System.Drawing.Color.White;
            this.costField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.costField.Location = new System.Drawing.Point(35, 10);
            this.costField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costField.Name = "costField";
            this.costField.Size = new System.Drawing.Size(323, 27);
            this.costField.TabIndex = 1;
            this.costField.Text = "Cost";
            
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(35, 315);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(387, 58);
            this.update.TabIndex = 14;
            this.update.Text = "Update Price";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(36, 406);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 37;
            // 
            // UpdatePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 442);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.update);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdatePrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePrice";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closedbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox productNameField;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox costField;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label statusLabel;
    }
}