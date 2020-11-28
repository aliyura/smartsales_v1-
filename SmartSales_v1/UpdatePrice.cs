using System;
using System.Data;
using System.Drawing;
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
        }

      
        private void refreshCurrentProductPrice(string name)
        {

            DataTable data = getService.getDataWithFilter(app.objects["products"], " name ='" + name + "'");
            if (data.Rows.Count > 0)
            {
                int balance = data.Rows[0].Field<int>("price");
                if (balance == 0)
                    totalBalanceLabel.Text = "0.00";
                else
                    totalBalanceLabel.Text = app.toMoneyOf(balance);
            }
            else
            {
                totalBalanceLabel.Text = "0.00";
            }
            accountBalancePanel.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                int price;
                price=0;

                if (priceField.Text != "New Price")
                    price = int.Parse(priceField.Text);
             

                Product product = new Product()
                {
                    name=productNameField.Text,
                    price=price,
                };


                if (productNameField.Text == "Product Name" || productNameField.Text == "")
                {
                    app.notifyTo(statusLabel, "Product Name required", "warning");
                }

                else if (priceField.Text == "New Price" || priceField.Text == "")
                {
                    app.notifyTo(statusLabel, "New Price required", "warning");
                }
                else
                {

                    if ( productNameField.Text != "" && priceField.Text != ""
                        && productNameField.Text != "Product Name" && priceField.Text != "New Price")
                    {

                        update.Enabled = false;
                        int response =updateService.updatePrice(product);
                        update.Enabled = true;
                        if (response > 0)
                        {
                            priceField.Text = "New Price";
                            refreshCurrentProductPrice(product.name);
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

        private void priceField_Enter(object sender, EventArgs e)
        {
            h.manageHint(priceField, 1, "New Price");
        }

        private void priceField_Leave(object sender, EventArgs e)
        {
            h.manageHint(priceField, 0, "New Price");
        }

        private void productNameField_Enter_1(object sender, EventArgs e)
        {
            h.manageHint(productNameField, 1, "Product Name");
        }

        private void productNameField_Leave(object sender, EventArgs e)
        {

            h.manageHint(productNameField, 0, "Product Name");

        }

        private void productNameField_TextChanged(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            app.buildDropdown(this, sender, productNamePanel, "products");
            refreshCurrentProductPrice(productNameField.Text);

        }

        private void priceField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                update.PerformClick();
        }
    }
}
