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
    public partial class UpdatePrice : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        public UpdatePrice()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void productnamedropdown_TextChanged(object sender, EventArgs e)
        {
            currentpricefield.Text = "";
            newpricefield.Text = "";
            currentcostfield.Text = "";
            newcostfield.Text = "";
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

        private void productnamedropdown_Enter(object sender, EventArgs e)
        {
            h.manageComboHint(productnamedropdown, 1, "Product Name");
        }

        private void productnamedropdown_Leave(object sender, EventArgs e)
        {
            h.manageComboHint(productnamedropdown, 0, "Product Name");
        }

        private void currentpricefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 1, "Current Price");
        }

        private void currentpricefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 0, "Current Price");
        }

        private void newpricefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(newpricefield, 1, "New Price");
        }

        private void newpricefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 0, "New Price");
        }

        private void currentcostfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 1, "Current Cost");
        }

        private void currentcostfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 1, "Current Cost");
        }

        private void newcostfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(newcostfield, 1, "New Cost");
        }
    }
}
