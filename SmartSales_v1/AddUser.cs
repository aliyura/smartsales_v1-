using System;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class AddUser : Form
    {
        Hint h = new Hint();
        App app = new App();
        DatabaseService service; 

        public AddUser()
        {
            service = new DatabaseService();
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            passwordfield.Text = usernamefield.Text + "123"; // auto generate password
        }

        private void namefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(namefield, 0, "name");
        }

        private void namefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(namefield, 1, "name");
        }

        private void mobilenumberfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(mobilenumberfield, 0, "Mobile Numnber");
        }

        private void mobilenumberfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(mobilenumberfield, 1, "Mobile Number");
        }

        private void usernamefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(usernamefield, 0, "username");
        }

        private void usernamefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(usernamefield, 1, "username");
        }

        private void passwordfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(passwordfield, 0, "Password");
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

            if (user.name == "" || user.name=="Name")
                app.notifyTo(statusLabel, "Enter name of the User","warning");
            if (user.mobile_number == "")
                app.notifyTo(statusLabel, "Enter mobile number of the User", "warning");
            if (user.username == "")
                app.notifyTo(statusLabel, "Enter username of the User", "warning");
            if (user.username == "")
                app.notifyTo(statusLabel, "Enter name of the User", "warning");
            if (user.password == "")
                app.notifyTo(statusLabel, "Enter name of the User", "warning");


            if(user.name!="" && user.name!="Name" && user.mobile_number!="" && user.username!="" && user.password != "")
            {
                app.notifyTo(statusLabel, "Processing...", "success");
                int status = service.addUser(user);
                if (status != -1)
                {
                    app.notifyTo(statusLabel, "Created", "success");
                }
                else
                {
                    app.notifyTo(statusLabel, "Failed", "success");
                }

            }
            else
            {
                app.notifyTo(statusLabel, "All fields are required!", "warning");
            }

           

        }
          

     
    }
}
