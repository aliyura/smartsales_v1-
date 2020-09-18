using System;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class AddUser : Form
    {
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

            

           

        }
          

     
    }
}
