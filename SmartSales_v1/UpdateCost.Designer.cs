namespace SmartSales_v1
{
    partial class UpdateCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCost));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closedbutton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.minimizedbutton = new System.Windows.Forms.Button();
            this.batchNamePanel = new System.Windows.Forms.Panel();
            this.batchNameField = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.costField = new System.Windows.Forms.TextBox();
            this.accountBalancePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalBalanceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.batchNamePanel.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(408, 46);
            this.panel1.TabIndex = 73;
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
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Cost";
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
            // batchNamePanel
            // 
            this.batchNamePanel.BackColor = System.Drawing.Color.White;
            this.batchNamePanel.Controls.Add(this.batchNameField);
            this.batchNamePanel.Location = new System.Drawing.Point(25, 71);
            this.batchNamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.batchNamePanel.Name = "batchNamePanel";
            this.batchNamePanel.Size = new System.Drawing.Size(358, 47);
            this.batchNamePanel.TabIndex = 74;
            // 
            // batchNameField
            // 
            this.batchNameField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.batchNameField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.batchNameField.BackColor = System.Drawing.Color.White;
            this.batchNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.batchNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.batchNameField.Location = new System.Drawing.Point(36, 10);
            this.batchNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.batchNameField.Name = "batchNameField";
            this.batchNameField.Size = new System.Drawing.Size(307, 27);
            this.batchNameField.TabIndex = 2;
            this.batchNameField.Text = "Batch Number";
            this.batchNameField.TextChanged += new System.EventHandler(this.batchNameField_TextChanged);
            this.batchNameField.Enter += new System.EventHandler(this.batchNameField_Enter);
            this.batchNameField.Leave += new System.EventHandler(this.batchNameField_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.costField);
            this.panel5.Location = new System.Drawing.Point(25, 150);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(358, 47);
            this.panel5.TabIndex = 75;
            // 
            // costField
            // 
            this.costField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.costField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.costField.BackColor = System.Drawing.Color.White;
            this.costField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.costField.Location = new System.Drawing.Point(35, 9);
            this.costField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costField.Name = "costField";
            this.costField.Size = new System.Drawing.Size(308, 27);
            this.costField.TabIndex = 1;
            this.costField.Text = "New Cost";
            this.costField.Enter += new System.EventHandler(this.costField_Enter);
            this.costField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.costField_KeyDown);
            this.costField.Leave += new System.EventHandler(this.costField_Leave);
            // 
            // accountBalancePanel
            // 
            this.accountBalancePanel.BackColor = System.Drawing.Color.White;
            this.accountBalancePanel.Controls.Add(this.panel2);
            this.accountBalancePanel.Controls.Add(this.totalBalanceLabel);
            this.accountBalancePanel.Controls.Add(this.label2);
            this.accountBalancePanel.Location = new System.Drawing.Point(25, 115);
            this.accountBalancePanel.Name = "accountBalancePanel";
            this.accountBalancePanel.Size = new System.Drawing.Size(357, 30);
            this.accountBalancePanel.TabIndex = 78;
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
            this.totalBalanceLabel.Location = new System.Drawing.Point(137, 6);
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
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Current Cost";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(29, 302);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 77;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(25, 224);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(358, 58);
            this.update.TabIndex = 76;
            this.update.Text = "Update Cost";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // UpdateCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 332);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.batchNamePanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.accountBalancePanel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateCost";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCoast";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.batchNamePanel.ResumeLayout(false);
            this.batchNamePanel.PerformLayout();
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.Panel batchNamePanel;
        private System.Windows.Forms.TextBox batchNameField;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox costField;
        private System.Windows.Forms.Panel accountBalancePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalBalanceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button update;
    }
}