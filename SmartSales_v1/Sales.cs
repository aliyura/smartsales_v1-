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
    public partial class Sales : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        public Sales()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
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

        private void quantityfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(quantityfield, 1, "Quantity");
        }

        private void quantityfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(quantityfield, 0, "Quantity");
        }

        private void productNamefield_Enter(object sender, EventArgs e)
        {
            h.manageComboHint(productNamefield, 1, "Product Name");
        }

        private void productNamefield_Leave(object sender, EventArgs e)
        {
            h.manageComboHint(productNamefield, 0, "Product Name");
        }

        private void unitPricefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(unitPricefield, 1, "Unit Price");
        }

        private void unitPricefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(unitPricefield, 0, "Unit Price");
        }

        private void unitDiscountfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(unitDiscountfield, 1, "Unit Discount");
        }

        private void unitDiscountfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(unitDiscountfield, 0, "Unit Discount");
        }

        private void customerNamefield_Enter(object sender, EventArgs e)
        {
            h.manageComboHint(customerNamefield, 1, "Customer Name");
        }

        private void customerNamefield_Leave(object sender, EventArgs e)
        {
            h.manageComboHint(customerNamefield, 0, "Customer Name");
        }

        private void phoneNumberfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(phoneNumberfield, 1, "phone number");
        }

        private void idfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(idfield, 1, "id");
        }

        private void idfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(idfield, 0, "id");
        }

        private void barcodefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(barcodefield, 1, "Bar Code");
        }

        private void barcodefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(barcodefield, 0, "Bar Code");
        }
    }
}
