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
    public partial class AddBank : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();

        public AddBank()
        {
            InitializeComponent();
        }

        private void currentpricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(banknamefield, 0, "Bank Name");
        }

        private void currentpricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(banknamefield, 1, "Bank Name");
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Bank bank = new Bank()
            {
                name = banknamefield.Text
            };

            if (bank.name == "Bank Name" || bank.name == "")
            {
                app.notifyTo(statusLabel, "Bank name required", "Warning");
            }

            else
            {

                if (bank.name != "" && bank.name != "Bank Name")
                {

                    int response = 1; //addService.addLocation(location);
                    if (response != -1)
                    {
                        banknamefield.Text = "";
                        app.notifyTo(statusLabel, "Bank Added Successfully", "Success");
                    }

                    else
                    {
                        app.notifyTo(statusLabel, "Warning", "Unable to add bank");
                    }

                }
                else
                {
                    app.notifyTo(statusLabel, "All fields required", "warning");
                }
            }
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
