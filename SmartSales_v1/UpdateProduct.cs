using System;
using System.Data;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class UpdateProduct : Form
    {
        Hint h = new Hint();
        App app = new App();
        SSAddService addService = new SSAddService();
        SSGetService getService = new SSGetService();

        public UpdateProduct()
        {
           
            InitializeComponent();
            initializeApp();

        }

        private void  initializeApp()
        {
            //set locations
            DataTable locations = getService.getDataFrom(app.objects["locations"]);
            if (locations.Rows.Count > 0)
                foreach(DataRow row in locations.Rows)
                    locationdropdown.Items.Add(row.Field<string>("name"));

            //set products
            DataTable products = getService.getDataFrom(app.objects["products"]);
            if (products.Rows.Count > 0)
                foreach (DataRow row in products.Rows)
                    productnamedropdown.Items.Add(row.Field<string>("name"));

        }

        private void addbutton_Click_1(object sender, EventArgs e)
        {
                int quantity;
                quantity = 0;


                if (quantityfield.Text != "Quantity" && app.isAllDigits(quantityfield.Text))
                    quantity = int.Parse(quantityfield.Text);
                else
                     app.notifyTo(statusLabel1, "Quantity not in a right format", "warning");

            Stock stock = new Stock()
                {
                    name = productnamedropdown.Text,
                    quantity = quantity,
                    location = locationdropdown.Text,
                    description = descriptionfield.Text,
                };
                 

                if (stock.name == "Product Name" || stock.name == "")
                {
                    app.notifyTo(statusLabel1, "Product Name required", "warning");
                }
                else if (stock.location == "Location" || stock.location == "")
                {
                    app.notifyTo(statusLabel1, "Product Location required", "warning");
                }
                else if (quantityfield.Text == "Quantity" || quantityfield.Text == "")
                {
                    app.notifyTo(statusLabel1, "Quantity required", "warning");
                }

                else
                {

                    if (stock.name != "" && stock.location != "" && quantityfield.Text != "" && stock.name != "Product Name" && stock.location != "Location"
                        && quantityfield.Text != "Quantity")
                    {

                        int response = addService.addStock(stock);
                        if (response > 0)
                        {
                            productnamedropdown.Text = "Product Name";
                            locationdropdown.Text = "Location";
                            descriptionfield.Text = "Description";
                            quantityfield.Text = "Quantity";
                            app.notifyTo(statusLabel1, "Product Updated Successfully", "success");
                        }

                        else
                        {
                            if (response == -403)
                            {
                                app.notifyTo(statusLabel1, "Product [" + stock.name + "] not found", "warning");
                            }
                            else if (response == -404)
                            {
                                app.notifyTo(statusLabel1, "Location [" + stock.location + "] not found", "warning");
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            app.redirect(this, new AddProduct());
        }
    }
}
