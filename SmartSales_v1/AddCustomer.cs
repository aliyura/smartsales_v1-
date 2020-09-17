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
    public partial class AddCustomer : Form
    {
        Hint h = new Hint();
        App app = new App();
        DatabaseService service;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                customername = customergroupfield.Text,
                phonenumber = phonenumberfield.Text,
                altphonenumber = altphonenumberfield.Text,
                address = addressfield.Text,
                creditlimit = creditlimitfield.Text,
                customergroup = customergroupfield.Text,
            };

            if(customer.customername == "" || customer.customername == "Customer Name" )
                app.notifyTo(statusLabel, "Enter the Customer name ", "warning");

            if (customer.phonenumber == "" || customer.phonenumber == "Phone Number")
                app.notifyTo(statusLabel, "Enter the Customer Phone Number","warning");

            if (customer.altphonenumber == "" || customer.altphonenumber == "Alternate Phone Number")
                app.notifyTo(statusLabel, "Enter the Customer Alternative Phone Number", "warning");

            if (customer.address == "" || customer.address == "Address")
                app.notifyTo(statusLabel, "Enter The Customer Address", "warning");

            if (customer.creditlimit == "" || customer.creditlimit == "Credit Limit")
                app.notifyTo(statusLabel, "Enter Customer Credit Limit","warning");

            if (customer.customergroup == "" || customer.customergroup == "Customer Group")
                app.notifyTo(statusLabel, "Enter the Customer of the The Customer registration", "warning");

            if (customer.customername !="" && customer.customername !="Customer Name" && customer.phonenumber !="" && customer.phonenumber != "Phone Number" && customer.altphonenumber != "Alternate Phone Number" && customer.altphonenumber !="" && customer.address !="" && customer.address != "Address" && customer.creditlimit !="" && customer.creditlimit != "Credit Limit" && customer.customergroup != "Customer Group" && customer.customergroup !="")
            {
                app.notifyTo(statusLabel, "Processing...", "success");
                int status = service.registerproduct(customer);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
