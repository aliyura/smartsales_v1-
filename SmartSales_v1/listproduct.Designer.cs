namespace SmartSales_v1
{
    partial class listproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listproduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closedbutton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.minimizedbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addbutton = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.productnamesearchfield = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel12.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(640, 37);
            this.panel1.TabIndex = 4;
            // 
            // closedbutton
            // 
            this.closedbutton.FlatAppearance.BorderSize = 0;
            this.closedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedbutton.ImageIndex = 1;
            this.closedbutton.ImageList = this.imageList1;
            this.closedbutton.Location = new System.Drawing.Point(592, 3);
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
            this.imageList1.Images.SetKeyName(2, "add.png");
            this.imageList1.Images.SetKeyName(3, "cancel.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "List product";
            // 
            // minimizedbutton
            // 
            this.minimizedbutton.FlatAppearance.BorderSize = 0;
            this.minimizedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizedbutton.ImageIndex = 0;
            this.minimizedbutton.ImageList = this.imageList1;
            this.minimizedbutton.Location = new System.Drawing.Point(537, 3);
            this.minimizedbutton.Name = "minimizedbutton";
            this.minimizedbutton.Size = new System.Drawing.Size(41, 34);
            this.minimizedbutton.TabIndex = 1;
            this.minimizedbutton.UseVisualStyleBackColor = true;
            this.minimizedbutton.Click += new System.EventHandler(this.minimizedbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 306);
            this.dataGridView1.TabIndex = 8;
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(518, 60);
            this.addbutton.Margin = new System.Windows.Forms.Padding(2);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(122, 31);
            this.addbutton.TabIndex = 43;
            this.addbutton.Text = "Search";
            this.addbutton.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel12.Controls.Add(this.productnamesearchfield);
            this.panel12.Location = new System.Drawing.Point(249, 60);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(264, 31);
            this.panel12.TabIndex = 42;
            // 
            // productnamesearchfield
            // 
            this.productnamesearchfield.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productnamesearchfield.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productnamesearchfield.BackColor = System.Drawing.Color.White;
            this.productnamesearchfield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productnamesearchfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnamesearchfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productnamesearchfield.Location = new System.Drawing.Point(19, 2);
            this.productnamesearchfield.Margin = new System.Windows.Forms.Padding(2);
            this.productnamesearchfield.Multiline = true;
            this.productnamesearchfield.Name = "productnamesearchfield";
            this.productnamesearchfield.Size = new System.Drawing.Size(230, 27);
            this.productnamesearchfield.TabIndex = 14;
            this.productnamesearchfield.Text = "Product Name";
            this.productnamesearchfield.Enter += new System.EventHandler(this.productnamesearchfield_Enter);
            this.productnamesearchfield.Leave += new System.EventHandler(this.productnamesearchfield_Leave);
            // 
            // listproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 402);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listproduct";
            this.Load += new System.EventHandler(this.listproduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closedbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizedbutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox productnamesearchfield;
    }
}