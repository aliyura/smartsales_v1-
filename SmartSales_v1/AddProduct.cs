using System;
using System.Windows.Forms;
using System.Drawing;

namespace SmartSales_v1
{
    public partial class AddProduct : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();
        SSAddService addService = new SSAddService();


        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            try
            {
                int price, reorder_level;
                price = reorder_level = 0;


                if (productPriceField.Text != "Price")
                    price = int.Parse(productPriceField.Text);
                if (productReorderLevelField.Text != "Re-order Level")
                    reorder_level = int.Parse(productReorderLevelField.Text);

                Product product = new Product()
                {
                    name = productNameField.Text,
                    price = price,
                    reorder_level = reorder_level,
                    barqr_code = productBarCodeField.Text,
                };

                if (product.name == "Product Name" || product.name == "")
                {
                    app.notifyTo(statusLabel1, "Product Name required", "warning");
                }
                else if (productPriceField.Text == "Price" || productPriceField.Text == "")
                {
                    app.notifyTo(statusLabel1, "Product price required", "warning");
                }
                else
                {

                    if (product.name != "" && productPriceField.Text != "" && product.name != "Product Name" && productPriceField.Text != "Price")
                    {

                        addbutton.Enabled = false;
                        int response = addService.addProduct(product);
                        addbutton.Enabled = true;
                        if (response >0)
                        {
                            productNameField.Text = "Product Name";
                            productPriceField.Text = "Price";
                            productReorderLevelField.Text = "Re-order Level";
                            productBarCodeField.Text = "Bar Code";
                            app.notifyTo(statusLabel1, "Product Added Successfully", "success");
                        }
                        else
                        {
                            if (response == -2)
                            {
                                app.notifyTo(statusLabel1, "Product with name " + product.name +" already exist", "warning");
                            }
                            else
                            {
                                app.notifyTo(statusLabel1, "Unable to add the product", "warning");
                            }
                        }

                    }
                    else
                    {
                        app.notifyTo(statusLabel1, "All fields required", "warning");
                    }
                }
            }
            catch(Exception ex)
            {
                app.notifyTo(statusLabel1, ex.Message, "error");
              
            }
        }

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void productBarCodeField_Enter(object sender, EventArgs e)
        {
            h.manageHint(productBarCodeField, 1, "Bar Code");
        }

        private void productBarCodeField_Leave(object sender, EventArgs e)
        {
            h.manageHint(productBarCodeField, 0, "Bar Code");
        }

        private void productNameField_Enter(object sender, EventArgs e)
        {
            h.manageHint(productNameField, 1, "Product Name");
        }

        private void productNameField_Leave(object sender, EventArgs e)
        {
            h.manageHint(productNameField, 0, "Product Name");
        }

        private void productPriceField_Enter(object sender, EventArgs e)
        {
            h.manageHint(productPriceField, 1, "Price");
        }

        private void productPriceField_Leave(object sender, EventArgs e)
        {
            h.manageHint(productPriceField, 0, "Price");
        }

        private void productReorderLevelField_Enter(object sender, EventArgs e)
        {
            h.manageHint(productReorderLevelField, 1, "Re-order Level");
        }

        private void productReorderLevelField_Leave(object sender, EventArgs e)
        {
            h.manageHint(productReorderLevelField, 0, "Re-order Level");
        }

        private void productReorderLevelField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addbutton.PerformClick();
        }
    }

}
