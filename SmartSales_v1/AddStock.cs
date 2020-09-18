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
    public partial class AddStock : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();
       
        public AddStock()
        {
            InitializeComponent();
        }

        private void loginIDField_TextChanged(object sender, EventArgs e)
        {

        }

        private void productnamefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(productnamefield, 1, "Product Name");
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            
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

        private void addbutton_Click(object sender, EventArgs e)
        {

        }

        private void closedbutton_Click(object sender, EventArgs e)
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
    }
}
