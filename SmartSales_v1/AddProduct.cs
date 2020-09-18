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

        private void loginIDField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void productnamefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(productNameField, 1, "Product Name");
        }
        private void savebutton_Click(object sender, EventArgs e)
        {

        }


        private void productnamefield_MouseEnter(object sender, EventArgs e)
        {

            h.manageHint(productNameField, 0, "Product Name");
        }

        private void pricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(productPriceField, 0, "Price");
        }

        private void pricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(productPriceField, 1, "Price");//pricefile hint
        }

        private void reorderlevelfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(productReorderLevelField, 0, "Re-order level");
        }

        private void reorderlevelfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(productReorderLevelField, 1, "Re-order level");
        }

        private void costfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(productCostField, 0, "Cost");
        }

        private void costfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(productCostField, 1, "Cost");
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            try
            {
                int price, cost, reorder_level;
                price = cost = reorder_level = 0;


                if (productPriceField.Text != "Price")
                    price = int.Parse(productPriceField.Text);
                if (productCostField.Text != "Cost")
                    cost = int.Parse(productCostField.Text);
                if (productReorderLevelField.Text != "Re-order Level")
                    reorder_level = int.Parse(productReorderLevelField.Text);




                Product product = new Product()
                {
                    name = productNameField.Text,
                    price = price,
                    reorder_level = reorder_level,
                    cost = cost,
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
                else if (productCostField.Text == "Cost" || productCostField.Text == "")
                {
                    app.notifyTo(statusLabel1, "Product cost required", "warning");
                }
                else
                {

                    if (product.name != "" && productPriceField.Text != "" && productCostField.Text != "" && product.name != "Product Name" && productPriceField.Text != "Price" && productCostField.Text != "Cost")
                    {

                        int response = addService.addProduct(product);
                        if (response != -1)
                        {
                            productNameField.Text = "Product Name";
                            productPriceField.Text = "Price";
                            productCostField.Text = "Cost";
                            productReorderLevelField.Text = "Re-order Level";
                            productBarCodeField.Text = "Bar Code";
                            app.notifyTo(statusLabel1, "Product Added Successfully", "success");
                        }

                        else
                        {
                            app.notifyTo(statusLabel1, "Warning", "Unable to add bank");
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
                app.notifyTo(statusLabel1, ex.Message, "warning");
              
            }
        }

        private void costfield_TextChanged(object sender, EventArgs e)
        {
            
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
    }

}
