namespace SmartSales_v1
{
    partial class AddVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVoucher));
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.voucherDescriptionField = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.voucherAmountField = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.addbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closedbutton = new System.Windows.Forms.Button();
            this.minimizedbutton = new System.Windows.Forms.Button();
            this.adjPanel = new System.Windows.Forms.Panel();
            this.voucherTypeField = new System.Windows.Forms.ComboBox();
            this.accountBalancePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalBalanceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.adjPanel.SuspendLayout();
            this.accountBalancePanel.SuspendLayout();
            this.SuspendLayout();
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.voucherDescriptionField);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(23, 238);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 139);
            this.panel4.TabIndex = 65;
            // 
            // voucherDescriptionField
            // 
            this.voucherDescriptionField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.voucherDescriptionField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.voucherDescriptionField.BackColor = System.Drawing.Color.White;
            this.voucherDescriptionField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.voucherDescriptionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucherDescriptionField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.voucherDescriptionField.Location = new System.Drawing.Point(25, 11);
            this.voucherDescriptionField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voucherDescriptionField.Multiline = true;
            this.voucherDescriptionField.Name = "voucherDescriptionField";
            this.voucherDescriptionField.Size = new System.Drawing.Size(304, 112);
            this.voucherDescriptionField.TabIndex = 36;
            this.voucherDescriptionField.Text = "Description";
            this.voucherDescriptionField.Enter += new System.EventHandler(this.voucherDescriptionField_Enter);
            this.voucherDescriptionField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.voucherDescriptionField_KeyDown);
            this.voucherDescriptionField.Leave += new System.EventHandler(this.voucherDescriptionField_Leave);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(20, 475);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 64;
            // 
            // voucherAmountField
            // 
            this.voucherAmountField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.voucherAmountField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.voucherAmountField.BackColor = System.Drawing.Color.White;
            this.voucherAmountField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.voucherAmountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucherAmountField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.voucherAmountField.Location = new System.Drawing.Point(25, 11);
            this.voucherAmountField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voucherAmountField.Multiline = true;
            this.voucherAmountField.Name = "voucherAmountField";
            this.voucherAmountField.Size = new System.Drawing.Size(304, 25);
            this.voucherAmountField.TabIndex = 36;
            this.voucherAmountField.Text = "Amount";
            this.voucherAmountField.Enter += new System.EventHandler(this.voucherAmountField_Enter);
            this.voucherAmountField.Leave += new System.EventHandler(this.voucherAmountField_Leave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "minus-symbol.png");
            this.imageList1.Images.SetKeyName(1, "close (1).png");
            this.imageList1.Images.SetKeyName(2, "plus.png");
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(21, 397);
            this.addbutton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(356, 58);
            this.addbutton.TabIndex = 63;
            this.addbutton.Text = "Process";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.voucherAmountField);
            this.panel2.Location = new System.Drawing.Point(22, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 47);
            this.panel2.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voucher";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.panel1.Size = new System.Drawing.Size(402, 46);
            this.panel1.TabIndex = 59;
            // 
            // closedbutton
            // 
            this.closedbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closedbutton.FlatAppearance.BorderSize = 0;
            this.closedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedbutton.ImageIndex = 1;
            this.closedbutton.ImageList = this.imageList1;
            this.closedbutton.Location = new System.Drawing.Point(343, 0);
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
            this.minimizedbutton.Location = new System.Drawing.Point(267, 0);
            this.minimizedbutton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizedbutton.Name = "minimizedbutton";
            this.minimizedbutton.Size = new System.Drawing.Size(55, 42);
            this.minimizedbutton.TabIndex = 1;
            this.minimizedbutton.UseVisualStyleBackColor = true;
            this.minimizedbutton.Click += new System.EventHandler(this.minimizedbutton_Click);
            // 
            // adjPanel
            // 
            this.adjPanel.BackColor = System.Drawing.Color.White;
            this.adjPanel.Controls.Add(this.voucherTypeField);
            this.adjPanel.Location = new System.Drawing.Point(23, 171);
            this.adjPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.adjPanel.Name = "adjPanel";
            this.adjPanel.Size = new System.Drawing.Size(356, 47);
            this.adjPanel.TabIndex = 66;
            // 
            // voucherTypeField
            // 
            this.voucherTypeField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voucherTypeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucherTypeField.FormattingEnabled = true;
            this.voucherTypeField.Location = new System.Drawing.Point(17, 7);
            this.voucherTypeField.Margin = new System.Windows.Forms.Padding(5);
            this.voucherTypeField.Name = "voucherTypeField";
            this.voucherTypeField.Size = new System.Drawing.Size(323, 33);
            this.voucherTypeField.TabIndex = 12;
            this.voucherTypeField.Text = "Voucher Type";
            this.voucherTypeField.Enter += new System.EventHandler(this.paymentmodeField_Enter);
            this.voucherTypeField.Leave += new System.EventHandler(this.voucherTypeField_Leave);
            // 
            // accountBalancePanel
            // 
            this.accountBalancePanel.BackColor = System.Drawing.Color.White;
            this.accountBalancePanel.Controls.Add(this.panel3);
            this.accountBalancePanel.Controls.Add(this.totalBalanceLabel);
            this.accountBalancePanel.Controls.Add(this.label2);
            this.accountBalancePanel.Location = new System.Drawing.Point(22, 68);
            this.accountBalancePanel.Name = "accountBalancePanel";
            this.accountBalancePanel.Size = new System.Drawing.Size(357, 32);
            this.accountBalancePanel.TabIndex = 72;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(3, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 2);
            this.panel3.TabIndex = 71;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // totalBalanceLabel
            // 
            this.totalBalanceLabel.AutoSize = true;
            this.totalBalanceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalBalanceLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBalanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(91)))), ((int)(((byte)(90)))));
            this.totalBalanceLabel.Location = new System.Drawing.Point(146, 5);
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
            this.label2.Location = new System.Drawing.Point(24, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Current Balance";
            // 
            // AddVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 513);
            this.Controls.Add(this.accountBalancePanel);
            this.Controls.Add(this.adjPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voucher";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.adjPanel.ResumeLayout(false);
            this.accountBalancePanel.ResumeLayout(false);
            this.accountBalancePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox voucherDescriptionField;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox voucherAmountField;
        private System.Windows.Forms.Button closedbutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel adjPanel;
        private System.Windows.Forms.ComboBox voucherTypeField;
        private System.Windows.Forms.Panel accountBalancePanel;
        private System.Windows.Forms.Label totalBalanceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}