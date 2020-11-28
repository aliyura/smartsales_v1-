using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class UpdateProduct : Form
    {
        Hint h = new Hint();
        App app = new App();
        SSAddService addService = new SSAddService();
        SSGetService getService = new SSGetService();
        public Point mouseLocation;

        public UpdateProduct()
        {

            InitializeComponent();

            DataTable locations = getService.getDataFrom(app.objects["locations"]);
            if (locations.Rows.Count > 0)
                foreach (DataRow row in locations.Rows)
                    locationDropdown.Items.Add(row.Field<string>("name"));
        }

        private void addbutton_Click_1(object sender, EventArgs e)
        {
            int quantity, cost;
            quantity = cost = 0;


            if (quantityfield.Text != "Quantity" && app.isAllDigits(quantityfield.Text))
                quantity = int.Parse(quantityfield.Text);
            else
                app.notifyTo(statusLabel1, "Quantity not in a right format", "warning");

            if (costTextField.Text != "Cost" && app.isAllDigits(costTextField.Text))
                cost = int.Parse(costTextField.Text);
            else
                app.notifyTo(statusLabel1, "Cost not in a right format", "warning");

            Stock stock = new Stock()
            {
                name = productnamefield.Text,
                quantity = quantity,
                cost = cost,
                location = locationDropdown.Text,
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
            else if (costTextField.Text == "Cost" || costTextField.Text == "")
            {
                app.notifyTo(statusLabel1, "Cost required", "warning");
            }

            else
            {

                if (stock.name != "" && stock.location != "" && quantityfield.Text != "" && stock.name != "Product Name" && stock.location != "Location"
                    && quantityfield.Text != "Quantity" && costTextField.Text != "Cost" && app.isAllDigits(costTextField.Text) && app.isAllDigits(quantityfield.Text))
                {

                    addbutton.Enabled = false;
                    int response = addService.addStock(stock);
                    addbutton.Enabled = true;
                    if (response > 0)
                    {
                        productnamefield.Text = "Product Name";
                        locationDropdown.Text = "Location";
                        descriptionfield.Text = "Description";
                        quantityfield.Text = "Quantity";
                        costTextField.Text = "Cost";
                        app.notifyTo(statusLabel1, "Product Updated Successfully", "success");
                    }

                    else
                    {
                        if (response == -402)
                        {
                            app.notifyTo(statusLabel1, "Unable to create new batch", "warning");
                        }
                        else if (response == -403)
                        {
                            app.notifyTo(statusLabel1, "Product " + stock.name + " not found", "warning");
                        }
                        else if (response == -500)
                        {
                            app.notifyTo(statusLabel1, "Unable to generate new Batch number", "warning");
                        }
                        else if (response == -404)
                        {
                            app.notifyTo(statusLabel1, "Location " + stock.location + " not found", "warning");
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
        private void quantityfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(quantityfield, 1, "Quantity");
        }

        private void quantityfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(quantityfield, 0, "Quantity");
        }

        private void descriptionfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(descriptionfield, 1, "Description");
        }

        private void descriptionfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(descriptionfield, 0, "Description");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            app.redirect(this, new AddProduct());

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
        private void costTextField_Enter(object sender, EventArgs e)
        {
            h.manageHint(costTextField, 1, "Cost");
        }

        private void costTextField_Leave(object sender, EventArgs e)
        {
            h.manageHint(costTextField, 0, "Cost");
        }

        private void productnamefield_TextChanged_1(object sender, EventArgs e)
        {
            app.buildDropdown(this, sender, productNamePanel, "products");
        }

        private void locationtextfield_TextChanged(object sender, EventArgs e)
        {
            app.buildDropdown(this, sender, locationPanel, "locations");
        }

        private void productnamefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(productnamefield, 0, "Product Name");
        }

        private void productnamefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(productnamefield, 1, "Product Name");
        }

        private void locationtextfield_Leave(object sender, EventArgs e)
        {
            h.manageComboHint(locationDropdown, 0, "Location");
        }

        private void locationtextfield_Enter(object sender, EventArgs e)
        {
            h.manageComboHint(locationDropdown, 1, "Location");
        }

        private void addProductTrigger_Click(object sender, EventArgs e)
        {
            app.open(new AddProduct());
        }

        private void addLocationTrigger_Click(object sender, EventArgs e)
        {
            app.open(new AddLocation());
        }

        private void descriptionfield_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addbutton.PerformClick();
        }
    }
}

