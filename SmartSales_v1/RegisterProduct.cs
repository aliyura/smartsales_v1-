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
    public partial class RegisterProduct : Form
    {
        Hint h = new Hint();
        public RegisterProduct()
        {
            InitializeComponent();
        }

        private void loginIDField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void productnamefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(productnamefield, 1, "Product Name");
        }

        private void productnamefield_MouseEnter(object sender, EventArgs e)
        {
           
            h.manageHint(productnamefield, 0, "Product Name");
        }

        private void pricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(pricefield, 0, "Price");
        }

        private void pricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(pricefield, 1, "Price");//pricefile hint
        }

        private void reorderlevelfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(reorderlevelfield, 0, "Re-order level");
        }

        private void reorderlevelfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(reorderlevelfield, 1, "Re-order level");
        }

        private void costfield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(costfield, 0, "Cost");
        }

        private void costfield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(costfield, 1, "Cost");
        }

        //private void costfield_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
