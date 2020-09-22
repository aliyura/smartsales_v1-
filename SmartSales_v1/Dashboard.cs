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
    public partial class Dashboard : Form
    {
        public Point mouseLocation;
        App app = new App();
        int isOpen = 0;

        public Dashboard()
        {
            InitializeComponent();
        }


        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            settingDrawer.Hide();
            isOpen = 0;
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            settingDrawer.Hide();
            isOpen = 0;
            app.redirect(this, new LoginForm());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

            if (isOpen==0) {
                settingDrawer.Show();
                isOpen = 1;
            }
            else
            {
                settingDrawer.Hide();
                isOpen = 0;
            }
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            settingDrawer.Hide();
            isOpen = 0;
        }

        private void manageproductbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
