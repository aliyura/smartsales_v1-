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
    public partial class listcustomer : Form
    {
        Hint h = new Hint();
        public listcustomer()
        {
            InitializeComponent();
        }

        private void customerfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(customerfield, 1, "Customer Name");
        }

        private void customerfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(customerfield, 0, "Customer Name");
        }
        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
