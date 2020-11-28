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
            this.productNamePanel = new System.Windows.Forms.Panel();
            this.productNameField = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.priceField = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.accountBalancePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalBalanceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.productNamePanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.accountBalancePanel.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(411, 46);
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
            this.closedbutton.Location = new System.Drawing.Point(340, 1);
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
            this.minimizedbutton.Location = new System.Drawing.Point(277, 1);
            this.minimizedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizedbutton.Name = "minimizedbutton";
            this.minimizedbutton.Size = new System.Drawing.Size(55, 42);
            this.minimizedbutton.TabIndex = 1;
            this.minimizedbutton.UseVisualStyleBackColor = true;
            this.minimizedbutton.Click += new System.EventHandler(this.minimizedbutton_Click);
            // 
            // productNamePanel
            // 
            this.productNamePanel.BackColor = System.Drawing.Color.White;
            this.productNamePanel.Controls.Add(this.productNameField);
            this.productNamePanel.Location = new System.Drawing.Point(25, 88);
            this.productNamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productNamePanel.Name = "productNamePanel";
            this.productNamePanel.Size = new System.Drawing.Size(358, 47);
            this.productNamePanel.TabIndex = 9;
            // 
            // productNameField
            // 
            this.productNameField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productNameField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productNameField.BackColor = System.Drawing.Color.White;
            this.productNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productNameField.Location = new System.Drawing.Point(36, 10);
            this.productNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productNameField.Name = "productNameField";
            this.productNameField.Size = new System.Drawing.Size(307, 27);
            this.productNameField.TabIndex = 2;
            this.productNameField.Text = "Product Name";
            this.productNameField.TextChanged += new System.EventHandler(this.productNameField_TextChanged);
            this.productNameField.Enter += new System.EventHandler(this.productNameField_Enter_1);
            this.productNameField.Leave += new System.EventHandler(this.productNameField_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.priceField);
            this.panel5.Location = new System.Drawing.Point(25, 167);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(358, 47);
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
            this.priceField.Location = new System.Drawing.Point(35, 9);
            this.priceField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(308, 27);
            this.priceField.TabIndex = 1;
            this.priceField.Text = "New Price";
            this.priceField.Enter += new System.EventHandler(this.priceField_Enter);
            this.priceField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceField_KeyDown);
            this.priceField.Leave += new System.EventHandler(this.priceField_Leave);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(25, 241);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(358, 58);
            this.update.TabIndex = 14;
            this.update.Text = "Update Price";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(29, 319);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 37;
            // 
            // accountBalancePanel
            // 
            this.accountBalancePanel.BackColor = System.Drawing.Color.White;
            this.accountBalancePanel.Controls.Add(this.panel2);
            this.accountBalancePanel.Controls.Add(this.totalBalanceLabel);
            this.accountBalancePanel.Controls.Add(this.label2);
            this.accountBalancePanel.Location = new System.Drawing.Point(25, 132);
            this.accountBalancePanel.Name = "accountBalancePanel";
            this.accountBalancePanel.Size = new System.Drawing.Size(357, 30);
            this.accountBalancePanel.TabIndex = 72;
            this.accountBalancePanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 2);
            this.panel2.TabIndex = 72;
            // 
            // totalBalanceLabel
            // 
            this.totalBalanceLabel.AutoSize = true;
            this.totalBalanceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalBalanceLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.totalBalanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.totalBalanceLabel.Location = new System.Drawing.Point(132, 6);
            this.totalBalanceLabel.Name = "totalBalanceLabel";
            this.totalBalanceLabel.Size = new System.Drawing.Size(42, 21);
            this.totalBalanceLabel.TabIndex = 69;
            this.totalBalanceLabel.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(32, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Current Price";
            // 
            // UpdatePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 349);
            this.Controls.Add(this.accountBalancePanel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.update);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.productNamePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdatePrice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePrice";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.productNamePanel.ResumeLayout(false);
            this.productNamePanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.accountBalancePanel.ResumeLayout(false);
            this.accountBalancePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closedbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel productNamePanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox productNameField;
        private System.Windows.Forms.Panel accountBalancePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalBalanceLabel;
        private System.Windows.Forms.Label label2;
    }
}