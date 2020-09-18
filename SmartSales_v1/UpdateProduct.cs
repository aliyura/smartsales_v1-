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
    public partial class UpdateProduct : Form
    {
        Hint h = new Hint();
        App app = new App();
        SSAddService addService = new SSAddService();

        public string productnamefield;
        public UpdateProduct()
        {
            InitializeComponent();
        }



        public void pnfield(string pfn)
        {

            pfn = productnamefield;//store the value of product field here

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
        private void quantityfield_TextChanged(object sender, EventArgs e)
        {

        }
        private void addbutton_Click(object sender, EventArgs e)
        {

        }

        private void productnamedropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnfield(productnamedropdown.Text);//store the selected text in the given parameter 
        }

        private void addbutton_Click_1(object sender, EventArgs e)
        {
            Stock product = new Stock()
            {
                name = productnamedropdown.Text,
                description = descriptionfield.Text,
                quantity = int.Parse(quantityfield.Text),
                location = locationdropdown.Text
            };

           




        }
    }
}
