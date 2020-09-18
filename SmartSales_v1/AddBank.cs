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
        SSAddService addService = new SSAddService();

        public AddBank()
        {
            InitializeComponent();
        }

        private void currentpricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(bankNameField, 0, "Bank Name");
        }

        private void currentpricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(bankNameField, 1, "Bank Name");
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Bank bank = new Bank()
            {
                name = bankNameField.Text
            };

            if (bank.name == "Bank Name" || bank.name == "")
            {
                app.notifyTo(statusLabel, "Bank name required", "warning");
            }

            else
            {

                if (bank.name != "" && bank.name != "Bank Name")
                {

                    int response = addService.addBank(bank);
                    if (response != -1)
                    {
                        bankNameField.Text = "";
                        app.notifyTo(statusLabel, "Bank Added Successfully", "success");
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
    }
    }
