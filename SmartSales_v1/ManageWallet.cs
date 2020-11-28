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
    public partial class ManageWallet : Form
    {

        App app = new App();
        Hint h = new Hint();
        SSUpdateService updateService = new SSUpdateService();

        public ManageWallet()
        {
            InitializeComponent();
        }

        private void addCustomerTrigger_Click(object sender, EventArgs e)
        {
            app.open(new AddCustomer());   
        }

        private void customerNamefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(customerNamefield, 0, "Customer Name");
        }

        private void customerNamefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(customerNamefield, 1, "Customer Name");
        }

        private void operationTypeField_Leave(object sender, EventArgs e)
        {
            h.manageComboHint(operationTypeField, 0, "Operation Type");
        }

        private void operationTypeField_Enter(object sender, EventArgs e)
        {
            h.manageComboHint(operationTypeField, 1, "Operation Type");

        }

        private void transactionAmountfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(transactionAmountfield, 0, "Amount");
        }

        private void transactionAmountfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(transactionAmountfield, 1, "Amount");

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
            if (customerNamefield.Text == "Customer Name" || customerNamefield.Text == "")
            {
                app.notifyTo(statusLabel, "Please enter the customer name!", "warning");
            }
            else if (operationTypeField.Text == "Operation Type" || operationTypeField.Text == "")
            {
                app.notifyTo(statusLabel, "Please select the ajustment type", "warning");
            }
            else
            {

                if (customerNamefield.Text != "" && operationTypeField.Text != ""
                    && customerNamefield.Text != "Customer Name" && operationTypeField.Text != "Operation Type")
                {

                    int transactionAmount = 0;
                    if (app.isAllDigits(transactionAmountfield.Text))
                        transactionAmount = int.Parse(transactionAmountfield.Text);

                        Payment payment = new Payment()
                        {
                            customer_name = customerNamefield.Text,
                            transaction_amount = transactionAmount,
                            payment_mode = operationTypeField.Text,
                            description = "Manage Wallet",
                            transaction_type = "Wallet Adjustment",
                        };

                    int response = updateService.manageWalletBalance(payment);
                    if (response > 0)
                    {
                        customerNamefield.Text = "Customer Name";
                        transactionAmountfield.Text = "Amount";
                        operationTypeField.Text = "Operation type";
                        app.notifyTo(statusLabel, "Transaction Completed", "success");
                    }
                    else
                    {
                        if (response == -404)
                        {
                            app.notifyTo(statusLabel, "Oops! the customer " + customerNamefield.Text + " not found", "warning");
                        }
                        else
                        {
                            app.notifyTo(statusLabel, "Transaction failed, please try latter ", "warning");
                        }
                    }


                }

            }
        }

        private void operationTypeField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operationTypeField.Text == "Reset")
                transactionAmountfield.Enabled = false;
            else
                transactionAmountfield.Enabled = true;
        }
    }
}
