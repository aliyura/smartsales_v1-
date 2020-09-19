﻿namespace SmartSales_v1
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closedbutton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.minimizedbutton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.productNameField = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productPriceField = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productCostField = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.productReorderLevelField = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusLabel1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.productBarCodeField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 37);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // closedbutton
            // 
            this.closedbutton.FlatAppearance.BorderSize = 0;
            this.closedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedbutton.ImageIndex = 1;
            this.closedbutton.ImageList = this.imageList1;
            this.closedbutton.Location = new System.Drawing.Point(310, 1);
            this.closedbutton.Name = "closedbutton";
            this.closedbutton.Size = new System.Drawing.Size(41, 34);
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
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Product";
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.productNameField);
            this.panel4.Location = new System.Drawing.Point(34, 128);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 47);
            this.panel4.TabIndex = 12;
            // 
            // productNameField
            // 
            this.productNameField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productNameField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productNameField.BackColor = System.Drawing.Color.White;
            this.productNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productNameField.Location = new System.Drawing.Point(34, 11);
            this.productNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productNameField.Name = "productNameField";
            this.productNameField.Size = new System.Drawing.Size(227, 21);
            this.productNameField.TabIndex = 1;
            this.productNameField.Text = "Product Name";
            this.productNameField.Enter += new System.EventHandler(this.productNameField_Enter);
            this.productNameField.Leave += new System.EventHandler(this.productNameField_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.productPriceField);
            this.panel3.Location = new System.Drawing.Point(34, 189);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 47);
            this.panel3.TabIndex = 7;
            // 
            // productPriceField
            // 
            this.productPriceField.BackColor = System.Drawing.Color.White;
            this.productPriceField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productPriceField.Location = new System.Drawing.Point(36, 11);
            this.productPriceField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productPriceField.Name = "productPriceField";
            this.productPriceField.Size = new System.Drawing.Size(233, 21);
            this.productPriceField.TabIndex = 1;
            this.productPriceField.Text = "Price";
            this.productPriceField.Enter += new System.EventHandler(this.productPriceField_Enter);
            this.productPriceField.Leave += new System.EventHandler(this.productPriceField_Leave);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(34, 387);
            this.addbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(290, 47);
            this.addbutton.TabIndex = 14;
            this.addbutton.Text = "Add Product";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.productCostField);
            this.panel2.Location = new System.Drawing.Point(34, 313);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 47);
            this.panel2.TabIndex = 8;
            // 
            // productCostField
            // 
            this.productCostField.BackColor = System.Drawing.Color.White;
            this.productCostField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productCostField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCostField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productCostField.Location = new System.Drawing.Point(35, 10);
            this.productCostField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productCostField.Name = "productCostField";
            this.productCostField.Size = new System.Drawing.Size(236, 21);
            this.productCostField.TabIndex = 1;
            this.productCostField.Text = "Cost";
            this.productCostField.Enter += new System.EventHandler(this.productCostField_Enter);
            this.productCostField.Leave += new System.EventHandler(this.productCostField_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.productReorderLevelField);
            this.panel5.Location = new System.Drawing.Point(34, 249);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 47);
            this.panel5.TabIndex = 9;
            // 
            // productReorderLevelField
            // 
            this.productReorderLevelField.BackColor = System.Drawing.Color.White;
            this.productReorderLevelField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productReorderLevelField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productReorderLevelField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productReorderLevelField.Location = new System.Drawing.Point(35, 11);
            this.productReorderLevelField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productReorderLevelField.Name = "productReorderLevelField";
            this.productReorderLevelField.Size = new System.Drawing.Size(226, 21);
            this.productReorderLevelField.TabIndex = 1;
            this.productReorderLevelField.Text = "Re-order Level";
            this.productReorderLevelField.Enter += new System.EventHandler(this.productReorderLevelField_Enter);
            this.productReorderLevelField.Leave += new System.EventHandler(this.productReorderLevelField_Leave);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(30, 456);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 20);
            this.statusLabel.TabIndex = 37;
            // 
            // statusLabel1
            // 
            this.statusLabel1.AutoSize = true;
            this.statusLabel1.Location = new System.Drawing.Point(39, 454);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(0, 13);
            this.statusLabel1.TabIndex = 37;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.productBarCodeField);
            this.panel6.Location = new System.Drawing.Point(34, 67);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(188, 47);
            this.panel6.TabIndex = 38;
            // 
            // productBarCodeField
            // 
            this.productBarCodeField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productBarCodeField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productBarCodeField.BackColor = System.Drawing.Color.White;
            this.productBarCodeField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productBarCodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBarCodeField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productBarCodeField.Location = new System.Drawing.Point(42, 11);
            this.productBarCodeField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productBarCodeField.Name = "productBarCodeField";
            this.productBarCodeField.Size = new System.Drawing.Size(131, 21);
            this.productBarCodeField.TabIndex = 1;
            this.productBarCodeField.Text = "Bar Code";
            this.productBarCodeField.Enter += new System.EventHandler(this.productBarCodeField_Enter);
            this.productBarCodeField.Leave += new System.EventHandler(this.productBarCodeField_Leave);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 492);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.statusLabel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProduct";
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox productNameField;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox productPriceField;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox productCostField;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox productReorderLevelField;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusLabel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox productBarCodeField;
    }
}