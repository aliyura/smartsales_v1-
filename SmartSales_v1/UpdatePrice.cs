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
        Hint h = new Hint();
        public UpdatePrice()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void productnamedropdown_MouseEnter(object sender, EventArgs e)
        {
            this.productnamedropdown.Text = "";
        }

        private void productnamedropdown_MouseLeave(object sender, EventArgs e)
        {
            if(productnamedropdown.Text == "")
            {
                this.productnamedropdown.Text = "Product Name";
            }
        }

        private void currentpricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(currentpricefield, 0, "Current Price");
        }

        private void currentpricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(currentpricefield, 1, "Current Price");
        }

        private void newpricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(newpricefield, 0, "New Price");
        }

        private void newpricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(newpricefield, 1, "New Price");
        }

        private void currentcostfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 0, "Current Cost");
        }

        private void currentcostfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(currentcostfield, 1, "Current Cost");
        }

        private void newcostfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(newcostfield, 0, "New Cost");
        }

        private void newcostfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(newcostfield, 1, "New Cost");
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
    }
}
