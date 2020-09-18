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

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                name = customergroupfield.Text,
                phone_number = phonenumberfield.Text,
                altphone_number = altphonenumberfield.Text,
                address = addressfield.Text,
                credit_limit = creditlimitfield.Text,
                customer_group = customergroupfield.Text,
            };

            if(customer.name == "" || customer.name == "Customer Name" )
                app.notifyTo(statusLabel, "Enter the Customer name ", "warning");

            if (customer.phone_number == "" || customer.phone_number == "Phone Number")
                app.notifyTo(statusLabel, "Enter the Customer Phone Number","warning");

            if (customer.altphone_number == "" || customer.altphone_number == "Alternate Phone Number")
                app.notifyTo(statusLabel, "Enter the Customer Alternative Phone Number", "warning");

            if (customer.address == "" || customer.address == "Address")
                app.notifyTo(statusLabel, "Enter The Customer Address", "warning");

            if (customer.credit_limit == "" || customer.credit_limit == "Credit Limit")
                app.notifyTo(statusLabel, "Enter Customer Credit Limit","warning");

            if (customer.customer_group == "" || customer.customer_group == "Customer Group")
                app.notifyTo(statusLabel, "Enter the Customer of the The Customer registration", "warning");

            if (customer.name !="" && customer.name !="Customer Name" && customer.phone_number !="" && customer.phone_number != "Phone Number" && customer.altphone_number != "Alternate Phone Number" && customer.altphone_number !="" && customer.address !="" && customer.address != "Address" && customer.credit_limit !="" && customer.credit_limit != "Credit Limit" && customer.customer_group != "Customer Group" && customer.customer_group !="")
            {
                app.notifyTo(statusLabel, "Processing...", "success");
                //int status = service.registerproduct(customer);
                //if (status != -1)
                //{
                //    app.notifyTo(statusLabel, "User Created Successfully", "success");
                //}
                //else
                //{
                //    app.notifyTo(statusLabel, "Failed to create the User", "success");
                //}
            }
            else
            {
                app.notifyTo(statusLabel, "All fields are required!", "warning");
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
