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
    public partial class AddRole : Form
    {
        public Point mouseLocation;
        Hint hint = new Hint();
        SSGetService getService = new SSGetService();
        SSAddService addService = new SSAddService();
        public AddRole()
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void usernamefield_Enter(object sender, EventArgs e)
        {
            hint.manageHint(usernamefield, 1, "User Name");
        }

        private void usernamefield_Leave(object sender, EventArgs e)
        {
            hint.manageHint(usernamefield, 0, "User Name");
        }

        private void rolefield_Enter(object sender, EventArgs e)
        {
            hint.manageComboHint(rolefield, 1, "Role");
        }

        private void rolefield_Leave(object sender, EventArgs e)
        {
            hint.manageComboHint(rolefield, 0, "Role");
        }

        private void usernamefield_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
