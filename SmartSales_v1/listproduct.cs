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
    public partial class listproduct : Form
    {
        Hint h = new Hint();
        public listproduct()
        {
            InitializeComponent();
        }

        private void productnamesearchfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(productnamesearchfield, 1, "Product Name");
        }

        private void productnamesearchfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(productnamesearchfield, 0, "Product Name");
        }
    }
}
