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
    public partial class AddVoucherCategory : Form
    {

        App app = new App();
        Hint h = new Hint();
        SSAddService addService = new SSAddService();


        public AddVoucherCategory()
        {
            InitializeComponent();
        }

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (voucherCategoryField.Text != "" && voucherCategoryField.Text != "Category")
            {
                VoucherCategory category = new VoucherCategory()
                {
                    name = voucherCategoryField.Text
                };

                addbutton.Enabled =false;
                int response = addService.addVoucherCategory(category);
                addbutton.Enabled = true;
                if (response > 0)
                {
                    voucherCategoryField.Text = "Category";
                    app.notifyTo(statusLabel, voucherCategoryField.Text + " Added Successfully", "success");
                }
                else
                {
                    if (response == -101)
                    {
                        app.notifyTo(statusLabel, "Oops! Voucher category " + voucherCategoryField.Text + " already exist", "warning");

                    }
                    else
                    {
                        app.notifyTo(statusLabel, "Unable to add the new voucher category " + voucherCategoryField.Text, "warning");


                    }
                }
            }
            else
            {
                app.notifyTo(statusLabel, "Enter the voucher category!", "warning");
            }
        }

        private void voucherCategoryField_Enter(object sender, EventArgs e)
        {
            h.manageHint(voucherCategoryField,1,"Category");
        }

        private void voucherCategoryField_Leave(object sender, EventArgs e)
        {
            h.manageHint(voucherCategoryField, 0, "Category");
        }

        private void voucherCategoryField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addbutton.PerformClick();
        }
    }
}
