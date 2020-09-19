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
        public UpdatePrice()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                int current_price, current_cost, new_price, new_cost;


                if (currentcostfield.Text != "Current Cost")
                    current_cost = int.Parse(currentcostfield.Text);
                if (currentpricefield.Text != "Current Price")
                    current_price = int.Parse(currentpricefield.Text);
                if (newpricefield.Text != "New Price")
                    new_price = int.Parse(newpricefield.Text);
                if (newcostfield.Text != "New Cost")
                    new_cost = int.Parse(newcostfield.Text);




                PriceUpdate priceUpdate = new PriceUpdate()
                {
                    name = productnamedropdown.Text,
                    current_cost = int.Parse(currentcostfield.Text),
                    current_price = int.Parse(currentpricefield.Text),
                    new_price = int.Parse(newcostfield.Text),
                    new_cost = int.Parse(newpricefield.Text)
                };


                if (priceUpdate.name == "Product Name" || priceUpdate.name == "")
                {
                    app.notifyTo(statusLabel, "Product Name required", "warning");
                }
                else if (currentcostfield.Text == "Current Cost" || currentcostfield.Text == "")
                {
                    app.notifyTo(statusLabel, "Current Cost required", "warning");
                }
                else if (currentpricefield.Text == "Current Price" || currentpricefield.Text == "")
                {
                    app.notifyTo(statusLabel, "Current Price required", "warning");
                }

                else if (newpricefield.Text == "New Price" || newpricefield.Text == "")
                {
                    app.notifyTo(statusLabel, "New Price required", "warning");
                }

                else if (newcostfield.Text == "New Cost" || newcostfield.Text == "")
                {
                    app.notifyTo(statusLabel, "New Cost required", "warning");
                }
                else
                {

                    if (priceUpdate.name != "" && currentcostfield.Text != "" && currentpricefield.Text != "" && newpricefield.Text != "" && newcostfield.Text != ""
                        && priceUpdate.name != "Product Name" && currentcostfield.Text != "Current Cost" && currentpricefield.Text != "Current Price" && newpricefield.Text != "New Price"
                        && newcostfield.Text != "New Cost")
                    {

                        int response = 1;//addService.addProduct(product);
                        if (response > 0)
                        {
                            productnamedropdown.Text = "Product Name";
                            currentpricefield.Text = "Current Price";
                            currentcostfield.Text = "Current Cost";
                            newpricefield.Text = "New Price";
                            newcostfield.Text = "New Cost";
                            app.notifyTo(statusLabel, "Price Updated Successfully", "success");
                        }

                        else
                        {
                            if (response == -404)
                            {
                                app.notifyTo(statusLabel, "Product [" + priceUpdate.name + "] not found", "warning");
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

        private void productnamedropdown_TextChanged(object sender, EventArgs e)
        {
            currentpricefield.Text = "";
            newpricefield.Text = "";
            currentcostfield.Text = "";
            newcostfield.Text = "";
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

        private void productnamedropdown_Enter(object sender, EventArgs e)
        {
            h.manageComboHint(productnamedropdown, 1, "Product Name");
        }

        private void productnamedropdown_Leave(object sender, EventArgs e)
        {
            h.manageComboHint(productnamedropdown, 0, "Product Name");
        }

        private void currentpricefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 1, "Current Price");
        }

        private void currentpricefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 0, "Current Price");
        }

        private void newpricefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(newpricefield, 1, "New Price");
        }

        private void newpricefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 0, "New Price");
        }

        private void currentcostfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 1, "Current Cost");
        }

        private void currentcostfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 1, "Current Cost");
        }

        private void newcostfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(newcostfield, 1, "New Cost");
        }
    }
}
