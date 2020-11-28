using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class AddBusiness : Form
    {


        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();

        public AddBusiness()
        {
            InitializeComponent();
        }

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void browseImaeButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    logoPictureBox.Image = new Bitmap(open.FileName);
                }
            }
            catch (Exception ex)
            {
                app.showWarning(ex.Message);
            }
        }

        private void usernameField_Enter(object sender, EventArgs e)
        {
            h.manageHint(usernameField, 1, "Username");

        }

        private void usernameField_Leave(object sender, EventArgs e)
        {
            h.manageHint(usernameField, 0, "Username");
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            h.manageHint(passwordField, 1, "Password");
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            h.manageHint(passwordField, 0, "Password");
        }

        private void confirmPasswordField_Enter(object sender, EventArgs e)
        {
            h.manageHint(confirmPasswordField, 1, "Confirm Password");
        }

        private void confirmPasswordField_Leave(object sender, EventArgs e)
        {
            h.manageHint(confirmPasswordField, 0, "Confirm Password");
        }

        private void fullnameField_Enter(object sender, EventArgs e)
        {
            h.manageHint(fullnameField, 1, "Full Name");
        }

        private void fullnameField_Leave(object sender, EventArgs e)
        {
            h.manageHint(fullnameField, 0, "Full Name");
        }

        private void businessNameField_Enter(object sender, EventArgs e)
        {
            h.manageHint(businessNameField, 1, "Company/Business Name");
        }

        private void businessNameField_Leave(object sender, EventArgs e)
        {
            h.manageHint(businessNameField, 0, "Company/Business Name");
        }

        private void addressField_Enter(object sender, EventArgs e)
        {
            h.manageHint(addressField, 1, "Office/Shop Address");
        }

        private void addressField_Leave(object sender, EventArgs e)
        {
            h.manageHint(addressField, 0, "Office/Shop Address");
        }

        private void telephoneField_Enter(object sender, EventArgs e)
        {
            h.manageHint(telephoneField, 1, "Telephone Number");
        }

        private void telephoneField_Leave(object sender, EventArgs e)
        {
            h.manageHint(telephoneField, 0, "Telephone Number");
        }

        private void emailField_Enter(object sender, EventArgs e)
        {
            h.manageHint(emailField, 1, "Email Address");
        }

        private void emailField_Leave(object sender, EventArgs e)
        {
            h.manageHint(emailField, 0, "Email Address");
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (usernameField.Text == "" || usernameField.Text == "Username")
                app.notifyTo(statusLabel, "Enter the master admin Username", "warning");
            if (passwordField.Text == "" || passwordField.Text == "Password")
                app.notifyTo(statusLabel, "Enter the master admin Password", "warning");
            if (confirmPasswordField.Text == "" || confirmPasswordField.Text == "Confirm Password")
                app.notifyTo(statusLabel, "Please enter confirm password", "warning");
            if (fullnameField.Text == "" || fullnameField.Text == "Full Name")
                app.notifyTo(statusLabel, "Please enter Full Name, we suggest Administrator", "warning");
            if (businessNameField.Text == "" || businessNameField.Text == "Company/Business Name")
                app.notifyTo(statusLabel, "Please enter the Company/Business name", "warning");
            if (addressField.Text == "" || addressField.Text == "Office/Shop Address")
                app.notifyTo(statusLabel, "Please enter the Office/Shop Address", "warning");
            if (telephoneField.Text == "" || telephoneField.Text == "Telephone Number")
                app.notifyTo(statusLabel, "Please enter the Telephone Number", "warning");
            if (emailField.Text == "" || emailField.Text == "Email Address")
                app.notifyTo(statusLabel, "Please enter the Email Address", "warning");
            if (businessMottoField.Text == "" || businessMottoField.Text == "Company/Business Motto")
                app.notifyTo(statusLabel, "Please enter the Company/Business Motto", "warning");

            if (usernameField.Text != "" && passwordField.Text != "" && confirmPasswordField.Text != ""
                && fullnameField.Text != "" && businessNameField.Text != "" && addressField.Text != ""
                && telephoneField.Text != "" && emailField.Text != "" && businessMottoField.Text!=""
                && usernameField.Text != "Username" && passwordField.Text != "Password"
                && confirmPasswordField.Text != "Confirm Password" && fullnameField.Text != "Full Name"
                && businessNameField.Text != "Company/Business Name" && addressField.Text != "Office/Shop Address"
                && telephoneField.Text != "Telephone Number" && emailField.Text != "Email Address"
                && businessMottoField.Text!= "Company/Business Motto")
            {
                if (confirmPasswordField.Text == passwordField.Text)
                {

                    var image164 = Convert.ToBase64String(app.imageToByteArray(defaultLogo.Image));
                    var image264 = Convert.ToBase64String(app.imageToByteArray(logoPictureBox.Image));

                    if (!string.Equals(image164, image264))
                    {

                        Business business = new Business()
                        {
                            username = usernameField.Text,
                            password = passwordField.Text,
                            name = fullnameField.Text,
                            business_name = businessNameField.Text,
                            address = addressField.Text,
                            telephone = telephoneField.Text,
                            motto=businessMottoField.Text,
                            email_address = emailField.Text,
                            logo = app.imageToByteArray(logoPictureBox.Image)
                        };

                        ActivateBusiness activateScreen = new ActivateBusiness(business);
                        activateScreen.ShowDialog();
                    }
                    else
                    {
                        app.notifyTo(statusLabel, "Please add your Company/Business logo", "error");
                    }
                }
                else
                {
                    app.notifyTo(statusLabel, "Oops! Confirm Password not match", "error");
                }

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void businessMottoField_Enter(object sender, EventArgs e)
        {

            h.manageHint(businessMottoField,1, "Company/Business Motto");

        }

        private void businessMottoField_Leave(object sender, EventArgs e)
        {
            h.manageHint(businessMottoField, 0, "Company/Business Motto");
        }
    }
}
