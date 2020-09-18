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
                        app.notifyTo(statusLabel, "Bank Added Successfully", "success");
                    }

                    else
                    {
                        app.notifyTo(statusLabel, "Unable to add bank", "Warning");
                    }
                }
                else
                {
                    app.notifyTo(statusLabel, "All fields required", "warning");
                }
            }
        }
    }
}
