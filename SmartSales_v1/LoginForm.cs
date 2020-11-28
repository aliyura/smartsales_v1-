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
    public partial class LoginForm : Form
    {
        public static string userlogged;
        public Point mouseLocation;
        App app = new App();
        SSGetService getService = new SSGetService();
        SSAddService addService = new SSAddService();
        SSUpdateService updateService = new SSUpdateService();

        public LoginForm()
        {
            InitializeComponent();
        }

        public void userlog(string user)
        {
            userlogged = user;
        }
        private void manageHint(TextBox textbox, int eventType,string defaultText)
        {
            string text = textbox.Text;

            if (eventType == 0)
            {
                if (text == "")
                {
                    textbox.Text = defaultText;
                }
            }
            else
            {
                if (text == defaultText)
                {
                    textbox.Clear();
                }
            }

        }



     

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User()
                {
                    username = loginIDField.Text,
                    password = loginPasswordField.Text,
                };

                if (user.username == "" || user.username == "Username")
                    app.notifyTo(statusLabel, "Enter your username", "warning");
                else if (user.password == "" || user.password == "Password")
                    app.notifyTo(statusLabel, "Enter your Password", "warning");

                if (user.username != "" && user.username != "Username" && user.password != "" && user.password != "Password")
                {

                    DataTable response = getService.getDataWithFilter(app.objects["users"], "username='" + user.username + "' and password='" + user.password + "'");
                    if (response.Rows.Count > 0)
                    {
                        DataRow row = response.Rows[0];
                        user.id = row.Field<int>("id");
                        user.name = row.Field<string>("name");
                        user.role = row.Field<string>("role");
                        user.bid = row.Field<int>("bid");
                        updateService.updateLastLoginDate(user);
                        userlog(user.username);
                        app.setSession(user);
                        app.redirect(this, new Dashboard());
                    }
                    else
                    {
                        app.notifyTo(statusLabel, "Invalid Username or Password!", "error");
                    }
                }
            }
            catch(Exception ex)
            {
                app.showError(ex.Message);
            }
          
  
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void closedbutton_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginIDField_Enter(object sender, EventArgs e)
        {
            manageHint(loginPasswordField, 1, "Username");
        }

        private void loginIDField_Leave(object sender, EventArgs e)
        {
            manageHint(loginPasswordField, 0, "Username");
        }

        private void loginPasswordField_Enter(object sender, EventArgs e)
        {
            manageHint(loginPasswordField, 1, "Password");

        }

        private void loginPasswordField_Leave(object sender, EventArgs e)
        {
            manageHint(loginPasswordField, 0, "Password");
        }

        private void registerBusinessNow_Click(object sender, EventArgs e)
        {
            app.redirect(this,new AddBusiness()) ;
        }

        private void loginPasswordField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               loginButton.PerformClick();
        }

        private void loginIDField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               loginButton.PerformClick();
        }
    }
}
