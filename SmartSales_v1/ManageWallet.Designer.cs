namespace SmartSales_v1
{
    partial class ManageWallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageWallet));
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.transactionAmountfield = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.operationTypeField = new System.Windows.Forms.ComboBox();
            this.adjPanel = new System.Windows.Forms.Panel();
            this.customerNamefield = new System.Windows.Forms.TextBox();
            this.customerNamePanel = new System.Windows.Forms.Panel();
            this.closedbutton = new System.Windows.Forms.Button();
            this.minimizedbutton = new System.Windows.Forms.Button();
            this.addCustomerTrigger = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.adjPanel.SuspendLayout();
            this.customerNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(21, 381);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.transactionAmountfield);
            this.panel2.Location = new System.Drawing.Point(22, 231);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 47);
            this.panel2.TabIndex = 61;
            // 
            // transactionAmountfield
            // 
            this.transactionAmountfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.transactionAmountfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.transactionAmountfield.BackColor = System.Drawing.Color.White;
            this.transactionAmountfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionAmountfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionAmountfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.transactionAmountfield.Location = new System.Drawing.Point(25, 11);
            this.transactionAmountfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transactionAmountfield.Multiline = true;
            this.transactionAmountfield.Name = "transactionAmountfield";
            this.transactionAmountfield.Size = new System.Drawing.Size(304, 25);
            this.transactionAmountfield.TabIndex = 36;
            this.transactionAmountfield.Text = "Amount";
            this.transactionAmountfield.Enter += new System.EventHandler(this.transactionAmountfield_Enter);
            this.transactionAmountfield.Leave += new System.EventHandler(this.transactionAmountfield_Leave);
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
            this.panel1.Size = new System.Drawing.Size(405, 46);
            this.panel1.TabIndex = 59;
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
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Wallet";
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(22, 303);
            this.addbutton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(356, 58);
            this.addbutton.TabIndex = 63;
            this.addbutton.Text = "Continue";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // operationTypeField
            // 
            this.operationTypeField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operationTypeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationTypeField.FormattingEnabled = true;
            this.operationTypeField.Items.AddRange(new object[] {
            "Credit",
            "Debit",
            "Reset"});
            this.operationTypeField.Location = new System.Drawing.Point(17, 7);
            this.operationTypeField.Margin = new System.Windows.Forms.Padding(5);
            this.operationTypeField.Name = "operationTypeField";
            this.operationTypeField.Size = new System.Drawing.Size(323, 33);
            this.operationTypeField.TabIndex = 12;
            this.operationTypeField.Text = "Operation Type";
            this.operationTypeField.SelectedIndexChanged += new System.EventHandler(this.operationTypeField_SelectedIndexChanged);
            this.operationTypeField.Enter += new System.EventHandler(this.operationTypeField_Enter);
            this.operationTypeField.Leave += new System.EventHandler(this.operationTypeField_Leave);
            // 
            // adjPanel
            // 
            this.adjPanel.BackColor = System.Drawing.Color.White;
            this.adjPanel.Controls.Add(this.operationTypeField);
            this.adjPanel.Location = new System.Drawing.Point(22, 155);
            this.adjPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.adjPanel.Name = "adjPanel";
            this.adjPanel.Size = new System.Drawing.Size(356, 47);
            this.adjPanel.TabIndex = 62;
            // 
            // customerNamefield
            // 
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
            this.customerNamefield.Enter += new System.EventHandler(this.customerNamefield_Enter);
            this.customerNamefield.Leave += new System.EventHandler(this.customerNamefield_Leave);
            // 
            // customerNamePanel
            // 
            this.customerNamePanel.BackColor = System.Drawing.Color.White;
            this.customerNamePanel.Controls.Add(this.addCustomerTrigger);
            this.customerNamePanel.Controls.Add(this.customerNamefield);
            this.customerNamePanel.Location = new System.Drawing.Point(22, 85);
            this.customerNamePanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.customerNamePanel.Name = "customerNamePanel";
            this.customerNamePanel.Size = new System.Drawing.Size(356, 47);
            this.customerNamePanel.TabIndex = 60;
            // 
            // closedbutton
            // 
            this.closedbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closedbutton.FlatAppearance.BorderSize = 0;
            this.closedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedbutton.ImageIndex = 1;
            this.closedbutton.ImageList = this.imageList1;
            this.closedbutton.Location = new System.Drawing.Point(341, 0);
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
            this.minimizedbutton.Location = new System.Drawing.Point(270, 0);
            this.minimizedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizedbutton.Name = "minimizedbutton";
            this.minimizedbutton.Size = new System.Drawing.Size(55, 42);
            this.minimizedbutton.TabIndex = 1;
            this.minimizedbutton.UseVisualStyleBackColor = true;
            this.minimizedbutton.Click += new System.EventHandler(this.minimizedbutton_Click);
            // 
            // addCustomerTrigger
            // 
            this.addCustomerTrigger.ImageIndex = 2;
            this.addCustomerTrigger.ImageList = this.imageList1;
            this.addCustomerTrigger.Location = new System.Drawing.Point(319, 0);
            this.addCustomerTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomerTrigger.Name = "addCustomerTrigger";
            this.addCustomerTrigger.Size = new System.Drawing.Size(37, 47);
            this.addCustomerTrigger.TabIndex = 38;
            this.addCustomerTrigger.UseVisualStyleBackColor = true;
            this.addCustomerTrigger.Click += new System.EventHandler(this.addCustomerTrigger_Click);
            // 
            // ManageWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 414);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.adjPanel);
            this.Controls.Add(this.customerNamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageWallet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageWallet";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.adjPanel.ResumeLayout(false);
            this.customerNamePanel.ResumeLayout(false);
            this.customerNamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox transactionAmountfield;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closedbutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.ComboBox operationTypeField;
        private System.Windows.Forms.Panel adjPanel;
        private System.Windows.Forms.TextBox customerNamefield;
        private System.Windows.Forms.Button addCustomerTrigger;
        private System.Windows.Forms.Panel customerNamePanel;
    }
}