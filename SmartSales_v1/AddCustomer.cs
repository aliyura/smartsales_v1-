using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class AddCustomer : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();
        SSAddService addService = new SSAddService();
        SSGetService getService = new SSGetService();

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void initializeApp()
        {
            //set customer groups
            DataTable locations = getService.getDataFrom(app.objects["groups"]);
            if (locations.Rows.Count > 0)
                foreach (DataRow row in locations.Rows)
                    customergroupCombobox.Items.Add(row.Field<string>("name"));
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            int credit_limit = 0;
            if (creditlimitfield.Text != "Credit Limit")
                credit_limit = int.Parse(creditlimitfield.Text);

            Customer customer = new Customer()
            {
                name = customernamefield.Text,
                address = addressfield.Text,
                phone_number = phonenumberfield.Text,
                altphone_number = altphonenumberfield.Text,
                credit_limit = credit_limit,
                customer_group = customergroupCombobox.Text,
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
            else if (customer.customer_group == "Customer Group" || customer.customer_group == "")
            {
                app.notifyTo(statusLabel, "Customer Group required", "warning");
            }
            else
            {

                if (customer.name != "" && customer.address != "" && customer.phone_number != "" && customer.altphone_number != "" && customer.customer_group != ""
                    && customer.name != "Customer Name" && customer.address != "Address" && customer.phone_number != "Phone Number"
                    && customer.altphone_number != "Alternate Phone Number" && customer.customer_group != "Customer Group")
                {

                    int response = addService.addCustomer(customer);
                    if (response >0)
                    {
                        customernamefield.Text = "Customer Name";
                        addressfield.Text = "Address";
                        phonenumberfield.Text = "Phone Number";
                        altphonenumberfield.Text = "Alternate Phone Number";
                        creditlimitfield.Text = "Credit Limit";
                        customergroupCombobox.Text = "Customer Group";
                        app.notifyTo(statusLabel, "Customer Added Successfully", "success");
                    }
                    else
                    {
                        app.notifyTo(statusLabel, "Unable to add the Customer", "error");
                    }

                }
                else
                {
                    app.notifyTo(statusLabel, "All fields are required", "error");
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

        private void customergroupfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageComboHint(customergroupCombobox, 0, "");
        }

        private void customergroupfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageComboHint(customergroupCombobox, 1, "Customer Group");
        }

        private void addCustomerGroup_Click(object sender, EventArgs e)
        {

           
            AddGroup groupAdd = new AddGroup();
            groupAdd.ShowDialog();
            this.Close();
        }
    }
}