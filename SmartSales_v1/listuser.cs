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
    public partial class listuser : Form
    {
        Hint h = new Hint();
        public listuser()
        {
            InitializeComponent();
        }

        private void mobilenumberfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(mobilenumberfield, 1, "Mobile Number");
        }

        private void mobilenumberfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(mobilenumberfield, 0, "Mobile Number");
        }

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void listuser_Load(object sender, EventArgs e)
        {
            
        }
    }
}
