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
            Bank bank = new Bank
            {
                name = banknamefield.Text,
            };
            if (bank.name == "" || bank.name == "Bank Name")
                app.notifyTo(statusLabel, "Enter bank name of the Bank", "warning");

            if(bank.name != "" && bank.name != "")
            {
                app.notifyTo(statusLabel, "Processing...", "success");
               
            }
            else
            {
                app.notifyTo(statusLabel, "All fields are required!", "warning");
            }
        }
    }
}
