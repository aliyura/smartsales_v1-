namespace SmartSales_v1
{
    partial class AddPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.addCustomerTrigger = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.customerNamefield = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.transactionAmountfield = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.paymentmodeField = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closedbutton = new System.Windows.Forms.Button();
            this.minimizedbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.paymentDescriptionField = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalBalanceLabel = new System.Windows.Forms.Label();
            this.accountBalancePanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.customerPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.accountBalancePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Payment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerPanel
            // 
            this.customerPanel.BackColor = System.Drawing.Color.White;
            this.customerPanel.Controls.Add(this.addCustomerTrigger);
            this.customerPanel.Controls.Add(this.customerNamefield);
            this.customerPanel.Controls.Add(this.button2);
            this.customerPanel.Location = new System.Drawing.Point(23, 80);
            this.customerPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(356, 47);
            this.customerPanel.TabIndex = 48;
            // 
            // addCustomerTrigger
            // 
            this.addCustomerTrigger.ImageIndex = 2;
            this.addCustomerTrigger.ImageList = this.imageList1;
            this.addCustomerTrigger.Location = new System.Drawing.Point(318, 0);
            this.addCustomerTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomerTrigger.Name = "addCustomerTrigger";
            this.addCustomerTrigger.Size = new System.Drawing.Size(37, 47);
            this.addCustomerTrigger.TabIndex = 37;
            this.addCustomerTrigger.UseVisualStyleBackColor = true;
            this.addCustomerTrigger.Click += new System.EventHandler(this.addCustomerTrigger_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "minus-symbol.png");
            this.imageList1.Images.SetKeyName(1, "close (1).png");
            this.imageList1.Images.SetKeyName(2, "plus.png");
            // 
            // customerNamefield
            // 
            this.customerNamefield.AllowDrop = true;
            this.customerNamefield.AutoCompleteCustomSource.AddRange(new string[] {
            "Aminu",
            "Rabs",
            "Abba",
            "Umar",
            "Someone"});
            this.customerNamefield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customerNamefield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.customerNamefield.BackColor = System.Drawing.Color.White;
            this.customerNamefield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerNamefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNamefield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerNamefield.Location = new System.Drawing.Point(25, 11);
            this.customerNamefield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerNamefield.Multiline = true;
            this.customerNamefield.Name = "customerNamefield";
            this.customerNamefield.Size = new System.Drawing.Size(287, 25);
            this.customerNamefield.TabIndex = 36;
            this.customerNamefield.Text = "Customer Name";
            this.customerNamefield.TextChanged += new System.EventHandler(this.customerNamefield_TextChanged_1);
            this.customerNamefield.Enter += new System.EventHandler(this.customerNamefield_Enter);
            this.customerNamefield.Leave += new System.EventHandler(this.customerNamefield_Leave);
            // 
            // button2
            // 
            this.button2.ImageIndex = 1;
            this.button2.Location = new System.Drawing.Point(476, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 34);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.transactionAmountfield);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(23, 157);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 47);
            this.panel2.TabIndex = 49;
            // 
            // transactionAmountfield
            // 
            this.transactionAmountfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.transactionAmountfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.transactionAmountfield.BackColor = System.Drawing.Color.White;
            this.transactionAmountfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionAmountfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionAmountfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.transactionAmountfield.Location = new System.Drawing.Point(23, 11);
            this.transactionAmountfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transactionAmountfield.Multiline = true;
            this.transactionAmountfield.Name = "transactionAmountfield";
            this.transactionAmountfield.Size = new System.Drawing.Size(304, 25);
            this.transactionAmountfield.TabIndex = 36;
            this.transactionAmountfield.Text = "Transaction Amount";
            this.transactionAmountfield.Enter += new System.EventHandler(this.transactionAmountfield_Enter);
            this.transactionAmountfield.Leave += new System.EventHandler(this.transactionAmountfield_Leave);
            // 
            // button1
            // 
            this.button1.ImageIndex = 1;
            this.button1.Location = new System.Drawing.Point(476, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 34);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.paymentmodeField);
            this.panel4.Location = new System.Drawing.Point(23, 230);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 47);
            this.panel4.TabIndex = 50;
            // 
            // paymentmodeField
            // 
            this.paymentmodeField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentmodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentmodeField.FormattingEnabled = true;
            this.paymentmodeField.Items.AddRange(new object[] {
            "Cash",
            "Transfer",
            "Bank"});
            this.paymentmodeField.Location = new System.Drawing.Point(17, 7);
            this.paymentmodeField.Margin = new System.Windows.Forms.Padding(5);
            this.paymentmodeField.Name = "paymentmodeField";
            this.paymentmodeField.Size = new System.Drawing.Size(323, 33);
            this.paymentmodeField.TabIndex = 12;
            this.paymentmodeField.Text = "Payment Mode";
            this.paymentmodeField.Enter += new System.EventHandler(this.paymentmode_Enter);
            this.paymentmodeField.Leave += new System.EventHandler(this.paymentmode_Leave);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 46);
            this.panel1.TabIndex = 47;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // closedbutton
            // 
            this.closedbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closedbutton.FlatAppearance.BorderSize = 0;
            this.closedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedbutton.ImageIndex = 1;
            this.closedbutton.ImageList = this.imageList1;
            this.closedbutton.Location = new System.Drawing.Point(344, 0);
            this.closedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.closedbutton.Name = "closedbutton";
            this.closedbutton.Size = new System.Drawing.Size(55, 42);
            this.closedbutton.TabIndex = 3;
            this.closedbutton.UseVisualStyleBackColor = true;
            this.closedbutton.Click += new System.EventHandler(this.closedbutton_Click);
            // 
            // minimizedbutton
            // 
            this.minimizedbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizedbutton.FlatAppearance.BorderSize = 0;
            this.minimizedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizedbutton.ImageIndex = 0;
            this.minimizedbutton.ImageList = this.imageList1;
            this.minimizedbutton.Location = new System.Drawing.Point(268, 0);
            this.minimizedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizedbutton.Name = "minimizedbutton";
            this.minimizedbutton.Size = new System.Drawing.Size(55, 42);
            this.minimizedbutton.TabIndex = 1;
            this.minimizedbutton.UseVisualStyleBackColor = true;
            this.minimizedbutton.Click += new System.EventHandler(this.minimizedbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(21, 439);
            this.addbutton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(356, 58);
            this.addbutton.TabIndex = 51;
            this.addbutton.Text = "Add Payment";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(22, 518);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.paymentDescriptionField);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(23, 305);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 108);
            this.panel3.TabIndex = 53;
            // 
            // paymentDescriptionField
            // 
            this.paymentDescriptionField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.paymentDescriptionField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.paymentDescriptionField.BackColor = System.Drawing.Color.White;
            this.paymentDescriptionField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentDescriptionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDescriptionField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paymentDescriptionField.Location = new System.Drawing.Point(25, 11);
            this.paymentDescriptionField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentDescriptionField.Multiline = true;
            this.paymentDescriptionField.Name = "paymentDescriptionField";
            this.paymentDescriptionField.Size = new System.Drawing.Size(304, 85);
            this.paymentDescriptionField.TabIndex = 36;
            this.paymentDescriptionField.Text = "Description";
            this.paymentDescriptionField.Enter += new System.EventHandler(this.paymentDescriptionField_Enter);
            this.paymentDescriptionField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.paymentDescriptionField_KeyDown);
            this.paymentDescriptionField.Leave += new System.EventHandler(this.paymentDescriptionField_Leave);
            // 
            // button3
            // 
            this.button3.ImageIndex = 1;
            this.button3.Location = new System.Drawing.Point(476, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 34);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Outstanding Balance";
            // 
            // totalBalanceLabel
            // 
            this.totalBalanceLabel.AutoSize = true;
            this.totalBalanceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalBalanceLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.totalBalanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.totalBalanceLabel.Location = new System.Drawing.Point(176, 6);
            this.totalBalanceLabel.Name = "totalBalanceLabel";
            this.totalBalanceLabel.Size = new System.Drawing.Size(42, 21);
            this.totalBalanceLabel.TabIndex = 69;
            this.totalBalanceLabel.Text = "0.00";
            // 
            // accountBalancePanel
            // 
            this.accountBalancePanel.BackColor = System.Drawing.Color.White;
            this.accountBalancePanel.Controls.Add(this.panel5);
            this.accountBalancePanel.Controls.Add(this.totalBalanceLabel);
            this.accountBalancePanel.Controls.Add(this.label2);
            this.accountBalancePanel.Location = new System.Drawing.Point(24, 117);
            this.accountBalancePanel.Name = "accountBalancePanel";
            this.accountBalancePanel.Size = new System.Drawing.Size(355, 30);
            this.accountBalancePanel.TabIndex = 71;
            this.accountBalancePanel.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Location = new System.Drawing.Point(2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 2);
            this.panel5.TabIndex = 72;
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 552);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.accountBalancePanel);
            this.Controls.Add(this.customerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPayment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPayment";
            this.TopMost = true;
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.accountBalancePanel.ResumeLayout(false);
            this.accountBalancePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.TextBox customerNamefield;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox transactionAmountfield;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox paymentmodeField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closedbutton;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox paymentDescriptionField;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalBalanceLabel;
        private System.Windows.Forms.Panel accountBalancePanel;
        private System.Windows.Forms.Button addCustomerTrigger;
        private System.Windows.Forms.Panel panel5;
    }
}