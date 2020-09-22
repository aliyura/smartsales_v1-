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
    public partial class ListProducts : Form
    {
        Hint h = new Hint();
        SSGetService service = new SSGetService();
        public ListProducts()
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

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void listproduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.getDataFrom("");
        }
    }
}
