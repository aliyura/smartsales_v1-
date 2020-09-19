using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class UpdatePrice : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();

       SSUpdateService updateService =new SSUpdateService();
       SSGetService getService = new SSGetService();


        public UpdatePrice()
        {
            InitializeComponent();
            initializeApp();
        }

        private void initializeApp()
        {
            //set products
            DataTable products = getService.getDataFrom(app.objects["products"]);
            if (products.Rows.Count > 0)
                foreach (DataRow row in products.Rows)
                    productNameField.Items.Add(row.Field<string>("name"));

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                int price, cost;
                price = cost =  0;

                if (priceField.Text != "Price")
                    price = int.Parse(priceField.Text);
                if (costField.Text != "Cost")
                    cost = int.Parse(costField.Text);
                

                Product product = new Product()
                {
                    name=productNameField.Text,
                    price=price,
                    cost=cost,
                };


                if (productNameField.Text == "Product Name" || productNameField.Text == "")
                {
                    app.notifyTo(statusLabel, "Product Name required", "warning");
                }

                else if (priceField.Text == "Price" || priceField.Text == "")
                {
                    app.notifyTo(statusLabel, "New Price required", "warning");
                }
                else if (costField.Text == "Cost" || costField.Text == "")
                {
                    app.notifyTo(statusLabel, "New Cost required", "warning");
                }
                else
                {

                    if ( productNameField.Text != "" && priceField.Text != "" && costField.Text != ""
                        && productNameField.Text != "Product Name" && priceField.Text != "Price" && costField.Text != "Cost")
                    {

                        int response =updateService.updatePrice(product);
                        if (response > 0)
                        {
                            productNameField.Text = "Product Name";
                            priceField.Text = "Price";
                            costField.Text = "Cost";
                            app.notifyTo(statusLabel, "Price Updated Successfully", "success");
                        }

                        else
                        {
                            if (response == -404)
                            {
                                app.notifyTo(statusLabel, "Product [" + product.name + "] not found", "warning");
                            }
                            else
                            {
                                app.notifyTo(statusLabel, "Unable to update the product price", "warning");
                            }
                        }

                    }
                    else
                    {
                        app.notifyTo(statusLabel, "All fields required", "warning");
                    }
                }
            }
            catch (Exception ex)
            {
                app.notifyTo(statusLabel, ex.Message, "error");

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
    }
}
