using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class ActivateBusiness : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();
        SSAddService addService = new SSAddService();
        Business business;
        

        public ActivateBusiness(Business business)
        {
            InitializeComponent();
            this.business = business;
            computerNameField.Text = app.GetMacAddress();
            computerNameField.Enabled = false;
        }

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void productKeyField_Enter(object sender, EventArgs e)
        {
            h.manageHint(productKeyField, 1, "Product Key");
        }

        private void productKeyField_Leave(object sender, EventArgs e)
        {
            h.manageHint(productKeyField, 0, "Product Key");
        }

        private void activatebutton_Click(object sender, EventArgs e)
        {
            
            if (productKeyField.Text == "" || productKeyField.Text == "Product Key")
                app.notifyTo(statusLabel,"Enter the product key", "warning");
            if (computerNameField.Text == "" || computerNameField.Text == "Computer Name")
                app.notifyTo(statusLabel, "Enter the computer mac address", "warning");

            if (productKeyField.Text != "" && computerNameField.Text != "" && productKeyField.Text != "Product Key" && computerNameField.Text != "Computer Name")
            {
                app.showWarning(app.Connected().ToString());
                if (app.Connected())
                {
                    if (business != null && business.name != null)
                    {


                        business.product_key = productKeyField.Text;
                        business.machine_name = computerNameField.Text;
                        int response = addService.addBusiness(business);

                        if (response > 0)
                        {
                            app.redirect(this, new LoginForm());
                        }
                        else
                        {
                            if (response == -404)
                            {
                                app.notifyTo(statusLabel, "Product key not valid", "warning");
                                app.showWarning("Invalid Product Key!");
                            }
                            else if (response == -200)
                            {
                                app.notifyTo(statusLabel, "Oops! the business is already registered", "error");
                                app.showError("Oops! the business is already registered");
                            }
                            else if (response == -201)
                            {
                                app.notifyTo(statusLabel, "Oops! the product key is already active", "error");
                                app.showError("Oops! Th product key is already active");
                            }
                            else if (response == -202)
                            {
                                app.notifyTo(statusLabel, "Oops! Your licence key expired", "warning");
                                app.showWarning("Oops! The Licence expired, you need to renew your licence");
                            }
                            else
                            {
                                app.notifyTo(statusLabel, "Unable to complete your transaction", "warning");
                            }
                        }


                    }
                    else
                    {
                        app.notifyTo(statusLabel, "Oops! Business not found", "warning");
                    }

                }
                else
                {
                    app.showWarning("No Internet connection detected, please connect and try again");
                }
            }
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

        private void productKeyField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               activatebutton.PerformClick();
        }

        private void computerNameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                activatebutton.PerformClick();
        }
    }
}
