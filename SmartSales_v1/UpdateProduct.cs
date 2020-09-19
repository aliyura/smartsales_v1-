using System;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class UpdateProduct : Form
    {
        Hint h = new Hint();
        App app = new App();
        SSAddService addService = new SSAddService();

        public string productnamefield;
        public UpdateProduct()
        {
            InitializeComponent();
        }



        public void pnfield(string pfn)
        {

            pfn = productnamefield;//store the value of product field here

        }

        private void productnamedropdown_MouseEnter(object sender, EventArgs e)
        {
            productnamedropdown.Text = "";
        }

        private void productnamedropdown_MouseLeave(object sender, EventArgs e)
        {
            if(productnamedropdown.Text == "")
            {
                productnamedropdown.Text = "Product Name";
            }
        }

        private void locationdropdown_MouseEnter(object sender, EventArgs e)
        {
            locationdropdown.Text = "";
        }

        private void locationdropdown_MouseLeave(object sender, EventArgs e)
        {
            if(locationdropdown.Text == "")
            {
                locationdropdown.Text = "Location";
            }
        }

        private void currentpricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(quantityfield, 0, "Current Price");
        }

        private void currentpricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(quantityfield, 1, "Current Cost");
        }

        private void descriptionfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(descriptionfield, 0, "Description");
        }

        private void descriptionfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(descriptionfield, 1, "Description");
        }
        private void quantityfield_TextChanged(object sender, EventArgs e)
        {

        }
        private void addbutton_Click(object sender, EventArgs e)
        {

        }

        private void productnamedropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnfield(productnamedropdown.Text);//store the selected text in the given parameter 
        }

        private void addbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int _quantity;


                if (quantityfield.Text != "Current Cost")
                    _quantity = int.Parse(quantityfield.Text);



                ProductUpdate productUpdate = new ProductUpdate()
                {
                    name = productnamedropdown.Text,
                    quantity = int.Parse(quantityfield.Text),
                    location = locationdropdown.Text,
                    description = descriptionfield.Text,
                };


                if (productUpdate.name == "Product Name" || productUpdate.name == "")
                {
                    app.notifyTo(statusLabel1, "Product Name required", "warning");
                }
                else if (productUpdate.location == "Location" || productUpdate.location == "")
                {
                    app.notifyTo(statusLabel1, "Product Location required", "warning");
                }
                else if (quantityfield.Text == "Quantity" || quantityfield.Text == "")
                {
                    app.notifyTo(statusLabel1, "Quantity required", "warning");
                }

                else
                {

                    if (productUpdate.name != "" && productUpdate.location != "" && quantityfield.Text != "" && productUpdate.name != "Product Name" && productUpdate.location != "Location"
                        && quantityfield.Text != "Quantity")
                    {

                        int response = 1;//addService.addProduct(product);
                        if (response > 0)
                        {
                            productnamedropdown.Text = "Product Name";
                            locationdropdown.Text = "Location";
                            descriptionfield.Text = "Description";
                            quantityfield.Text = "Quantity";
                            barcodefield.Text = "Bar Code";
                            app.notifyTo(statusLabel1, "Product Updated Successfully", "success");
                        }

                        else
                        {
                            if (response == -404)
                            {
                                app.notifyTo(statusLabel1, "Product [" + productUpdate.name + "] not found", "warning");
                            }
                            else
                            {
                                app.notifyTo(statusLabel1, "Unable to update product", "warning");
                            }
                        }

                    }
                    else
                    {
                        app.notifyTo(statusLabel1, "All fields required", "warning");
                    }
                }
            }
            catch (Exception ex)
            {
                app.notifyTo(statusLabel1, ex.Message, "error");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
