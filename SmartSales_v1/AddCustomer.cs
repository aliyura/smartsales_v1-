using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class AddCustomer : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            customergroupfield.Items[0] = "Regular";
            customergroupfield.Items[1] = "Irregular";
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                name = customernamefield.Text,
                address = addressfield.Text,
                phone_number = phonenumberfield.Text,
                altphone_number = altphonenumberfield.Text,
                credit_limit = creditlimitfield.Text,
                customer_group = customergroupfield.Text,
                created_date = DateTime.Now
            };

            if (customer.name == "Customer Name" || customer.name == "")
            {
                app.notifyTo(statusLabel, "Customer name required", "warning");
            }
            else if (customer.address == "Address" || customer.address == "")
            {
                app.notifyTo(statusLabel, "Address required", "warning");
            }
            else if (customer.address == "Address" || customer.address == "")
            {
                app.notifyTo(statusLabel, "Address required", "warning");
            }
            else if (customer.phone_number == "Phone Number" || customer.phone_number == "")
            {
                app.notifyTo(statusLabel, "Phone Number required", "warning");
            }
            else if (customer.altphone_number == "Alternate Phone Number" || customer.altphone_number == "")
            {
                app.notifyTo(statusLabel, "Alternate Phone Number required", "warning");
            }
            else if (customer.credit_limit == "Credit Limit" || customer.credit_limit == "")
            {
                app.notifyTo(statusLabel, "Credit Limit required", "warning");
            }
            else if (customer.customer_group == "Customer Group" || customer.customer_group == "")
            {
                app.notifyTo(statusLabel, "Customer Group required", "warning");
            }
            else
            {

                if (customer.name != "" && customer.address != "" && customer.phone_number != "" && customer.altphone_number != "" && customer.credit_limit != "" && customer.customer_group != ""
                    && customer.name != "Customer Name" && customer.address != "Address" && customer.phone_number != "Phone Number"
                    && customer.altphone_number != "Alternate Phone Number" && customer.credit_limit != "Credit Limit" && customer.customer_group != "Customer Group")
                {

                    int response = 1; //addService.addLocation(location);
                    if (response != -1)
                    {
                        customernamefield.Text = "Customer Name";
                        addressfield.Text = "Address";
                        phonenumberfield.Text = "Phone Number";
                        altphonenumberfield.Text = "Alternate Phone Number";
                        creditlimitfield.Text = "Credit Limit";
                        customergroupfield.Text = "Customer Group";
                        app.notifyTo(statusLabel, "Customer Added Successfully", "success");
                    }
                    else
                    {
                        app.notifyTo(statusLabel, "Unable to add this Customer", "success");
                    }

                }
                else
                {
                    app.notifyTo(statusLabel, "All fields are required", "warning");
                }
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