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
    public partial class UpdateStock : Form
    {
        Hint h = new Hint();
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void productnamedropdown_MouseEnter(object sender, EventArgs e)
        {
            productnamedropdown.Text = "";
        }

        private void productnamedropdown_MouseLeave(object sender, EventArgs e)
        {
            if(productnamedropdown.Text == "")
            {
                productnamedropdown.Text = "Product Name";
            }
        }

        private void locationdropdown_MouseEnter(object sender, EventArgs e)
        {
            locationdropdown.Text = "";
        }

        private void locationdropdown_MouseLeave(object sender, EventArgs e)
        {
            if(locationdropdown.Text == "")
            {
                locationdropdown.Text = "Location";
            }
        }

        private void currentpricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(quantityfield, 0, "Current Price");
        }

        private void currentpricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(quantityfield, 1, "Current Cost");
        }

        private void descriptionfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(descriptionfield, 0, "Description");
        }

        private void descriptionfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(descriptionfield, 1, "Description");
        }
    }
}
