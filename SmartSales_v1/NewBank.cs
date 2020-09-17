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
    public partial class NewBank : Form
    {
        Hint h = new Hint();
        App app = new App();
        DatabaseService service;
        public NewBank()
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
            Bank bank = new Bank
            {
                bank_name = banknamefield.Text,
            };
            if (bank.bank_name == "" || bank.bank_name == "Bank Name")
                app.notifyTo(statusLabel, "Enter bank name of the Bank", "warning");

            if(bank.bank_name != "" && bank.bank_name != "")
            {
                app.notifyTo(statusLabel, "Processing...", "success");
                int status = service.registerproduct(bank);
                if (status != -1)
                {
                    app.notifyTo(statusLabel, "User Created Successfully", "success");
                }
                else
                {
                    app.notifyTo(statusLabel, "Failed to create the User", "success");
                }
            }
            else
            {
                app.notifyTo(statusLabel, "All fields are required!", "warning");
            }
        }
    }
}
