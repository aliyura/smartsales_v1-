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
    public partial class RegisterProduct : Form
    {
        Hint h = new Hint();
        App app = new App();
        DatabaseService service;
        public RegisterProduct()
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
            h.manageHint(productnamefield, 1, "Product Name");
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                productName = productnamefield.Text,
                price = int.Parse(pricefield.Text),
                cost = int.Parse(costfield.Text),
                reorderLevel = int.Parse(reorderlevelfield.Text)
            };
            if (product.productName == "" || product.productName == "Product name")
                app.notifyTo(statusLabel, "Enter Product name of the Product", "warning");

            if (product.price == int.Parse("") || product.price == int.Parse("Price"))
                app.notifyTo(statusLabel, "Enter Price of the Product", "warning");

            if (product.cost == int.Parse("") || product.cost == int.Parse("Cost"))
                app.notifyTo(statusLabel, "Enter Cost of the Product", "warning");

            if (product.reorderLevel == int.Parse("") || product.reorderLevel == int.Parse("Re-oder Level"))
                app.notifyTo(statusLabel, "Enter Re-order Level of the Product", "warning");

            if (product.productName != "" && product.productName != "Product name" && product.cost != int.Parse("") && product.cost != int.Parse("Cost") && product.price != int.Parse("") && product.price != int.Parse("Price") && product.reorderLevel !=int.Parse("Re-order Level") && product.reorderLevel != int.Parse(""))
            {
                app.notifyTo(statusLabel, "Processing...", "success");
                int status = service.registerproduct(product);
                if (status != -1)
                {
                    app.notifyTo(statusLabel, "User Created Successfully", "success");
                }
                else
                {
                    app.notifyTo(statusLabel, "Failed to create the User", "success");
                }

            }
            else
            {
                app.notifyTo(statusLabel, "All fields are required!", "warning");
            }



        }
 
        private void productnamefield_MouseEnter(object sender, EventArgs e)
        {
           
            h.manageHint(productnamefield, 0, "Product Name");
        }

        private void pricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(pricefield, 0, "Price");
        }

        private void pricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(pricefield, 1, "Price");//pricefile hint
        }

        private void reorderlevelfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(reorderlevelfield, 0, "Re-order level");
        }

        private void reorderlevelfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(reorderlevelfield, 1, "Re-order level");
        }

        private void costfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(costfield, 0, "Cost");
        }

        private void costfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(costfield, 1, "Cost");
        }

        //private void costfield_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
