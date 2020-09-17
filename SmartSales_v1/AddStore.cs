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
    public partial class AddStore : Form
    {
        Hint h = new Hint();
        public AddStore()
        {
            InitializeComponent();
        }

        private void currentpricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(currentpricefield, 0, "Store Name");
        }

        private void currentpricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(currentpricefield, 1, "Store Name");
        }

        private void storetypredropdown_MouseEnter(object sender, EventArgs e)
        {
            // h.manageHint(storetypredropdown, 0, "Store Type");
            storetypredropdown.Text = "";
        }

        private void storetypredropdown_MouseLeave(object sender, EventArgs e)
        {
            if(storetypredropdown.Text == "")
            {
                storetypredropdown.Text = "Store Type";
            }
        }
    }
}
