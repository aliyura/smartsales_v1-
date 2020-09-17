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
    public partial class NewBank : Form
    {
        Hint h = new Hint();
        public NewBank()
        {
            InitializeComponent();
        }

        private void currentpricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(currentpricefield, 0, "Bank Name");
        }

        private void currentpricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(currentpricefield, 1, "Bank Name");
        }
    }
}
