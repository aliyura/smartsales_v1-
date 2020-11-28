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

            System.Drawing.Drawing2D.GraphicsPath gp1 = new System.Drawing.Drawing2D.GraphicsPath();
            gp1.AddEllipse(0, 0, userPictureBox.Width , userPictureBox.Height);
            Region rg1 = new Region(gp1);
            userPictureBox.Region = rg1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            passwordfield.Text = usernamefield.Text + "123"; // auto generate password
        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            User session = app.getSession();
            User user = new User()
            {
                name = namefield.Text,
                mobile_number = mobilenumberfield.Text,
                username = usernamefield.Text,
                password = passwordfield.Text,
                bid = session.bid,
             
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


                    if (userPictureBox.Image != null)
                        user.picture = app.imageToByteArray(userPictureBox.Image);

                    addbutton.Enabled = false;
                    int response = addService.addUser(user);
                    addbutton.Enabled = true;
                    if (response >0)
                    {
                        namefield.Text = "Name";
                        mobilenumberfield.Text = "Mobile Number";
                        usernamefield.Text = "Username";
                        passwordfield.Text = "Password";
                        app.notifyTo(statusLabel, "User Created Successfully", "success");
                    }
                    else
                    {
                        if (response == -2)
                        {
                            app.notifyTo(statusLabel, "User " + user.username + " already exist", "warning");
                        }
                        if (response == -3)
                        {
                            app.notifyTo(statusLabel, "User with mobile number " + user.mobile_number + " already exist", "warning");
                        }
                        else
                        {
                            app.notifyTo(statusLabel, "Unable to add the user", "warning");
                        }
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

        private void namefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(namefield, 1, "Name");
        }

        private void namefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(namefield, 0, "Name");
        }

        private void mobilenumberfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(mobilenumberfield, 1, "Mobile Number");
        }

        private void mobilenumberfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(mobilenumberfield, 0, "Mobile Number");
        }

        private void usernamefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(usernamefield, 1, "Username");
        }

        private void usernamefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(usernamefield, 0, "Username");
        }

        private void passwordfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(passwordfield, 1, "Password");
        }

        private void passwordfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(passwordfield, 0, "Password");
        }

        private void browseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                userPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        private void usernamefield_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addbutton.PerformClick();
        }
    }
}
