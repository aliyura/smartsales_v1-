using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class AddUser : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();
        SSAddService addService= new SSAddService();

        public AddUser()
        {         
            
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            passwordfield.Text = usernamefield.Text + "123"; // auto generate password
        }

        private void namefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(namefield, 0, "");
        }

        private void namefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(namefield, 1, "name");
        }

        private void mobilenumberfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(mobilenumberfield, 0, "");
        }

        private void mobilenumberfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(mobilenumberfield, 1, "Mobile Number");
        }

        private void usernamefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(usernamefield, 0, "");
        }

        private void usernamefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(usernamefield, 1, "username");
        }

        private void passwordfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(passwordfield, 0, "");
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                name = namefield.Text,
                mobile_number = mobilenumberfield.Text,
                username = usernamefield.Text,
                password = passwordfield.Text,
            };


            if (user.name == "Name" || user.name == "")
            {
                app.notifyTo(statusLabel, "User name is required", "warning");
            }
            else if (user.mobile_number == "Mobile Number" || user.mobile_number == "")
            {
                app.notifyTo(statusLabel, "User mobile number is required", "warning");
            }
            else if (user.username == "Username" || user.username == "")
            {
                app.notifyTo(statusLabel, "Username is required", "warning");
            }
            else if (user.password == "Password" || user.password == "")
            {
                app.notifyTo(statusLabel, "User Password is required", "warning");
            }
            else
            {

                if (user.name != "" && user.mobile_number != "" && user.username != "" && user.password != ""
                    && user.name != "Name" && user.mobile_number != "Mobile Number" && user.username != "Username" && user.password != "Password")
                {

                    int response = addService.addUser(user);
                    if (response != -1)
                    {
                        namefield.Text = "Name";
                        mobilenumberfield.Text = "Mobile Number";
                        usernamefield.Text = "Username";
                        passwordfield.Text = "Password";

                        app.notifyTo(statusLabel, "User Created Successfully", "success");
                    }
                    else
                    {
                        app.notifyTo(statusLabel, "Success", "Unable to create this User");
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
