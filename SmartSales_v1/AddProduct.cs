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
    public partial class AddProduct : Form
    {
        Hint h = new Hint();
        App app = new App();
        DatabaseService service = new DatabaseService();
        public string productnamefield;
        public AddProduct()
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
            Product product = new Product
            {
                name = productnamedropdown.Text,
                description = descriptionfield.Text,
                quantity = int.Parse(quantityfield.Text),
                location = locationdropdown.Text
            };

            AddLocation addL=new AddLocation();
            for (int i = 0; i < int.Parse(service.getProducts().Rows[i].ToString()); i++)
            {
                if (productnamedropdown.SelectedItem.ToString() == service.getProducts().Columns[i].ToString())
                {

                    locationdropdown.SelectedItem = "Location";
                    quantityfield.Text = "quantity";

                    //if (product.quantity == int.Parse("") || product.quantity == int.Parse("Price"))
                    //    app.notifyTo(statusLabel, "Enter Price of the Product", "warning");

                    //if (product.location == "" || product.location == ""))
                    //app.notifyTo(statusLabel, "Enter Cost of the Product", "warning");

                    //if (product.description == "" || product.description == "Re-oder Level")
                    //    app.notifyTo(statusLabel, "Enter Re-order Level of the Product", "warning");

                    //if (product.created_date != DateTime.Now && product.name != "Product name" && product.created_date != DateTime.Now && product.cost != int.Parse("Cost") && product.price != int.Parse("") && product.price != int.Parse("Price") && product.reorder_Level != int.Parse("Re-order Level") && product.reorder_Level != int.Parse(""))
                    //{
                    //    app.notifyTo(statusLabel, "Processing...", "success");

                    //    int status = 0;
                    //    //service.registerproduct(product);
                    //    int status = service.registerproduct(product);

                    //    if (status != -1)
                    //    {
                    //        app.notifyTo(statusLabel, "User Created Successfully", "success");
                    //    }
                    //    else
                    //    {
                    //        app.notifyTo(statusLabel, "Failed to create the User", "success");
                    //    }

                    //}
                    //else
                    //{
                    //    app.notifyTo(statusLabel, "All fields are required!", "warning");
                    //}
                }
            }
        }
    }
}
