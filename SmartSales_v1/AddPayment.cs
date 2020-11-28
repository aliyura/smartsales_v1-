using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class AddPayment : Form
    {
        public Point mouseLocation;
        Hint hint = new Hint();
        App app = new App();
        SSAddService addService = new SSAddService();
        SSGetService getService = new SSGetService();
        
        public AddPayment()
        {
            InitializeComponent();
        }


        private void refreshCutsomerBalance(string name)
        {
            DataTable data = getService.getDataWithFilter(app.objects["debtors"]," name ='"+ name + "'");
            if (data.Rows.Count > 0)
            {
                int balance = data.Rows[0].Field<int>("amount");
                if (balance == 0)
                    totalBalanceLabel.Text = "0.00";
                else
                    totalBalanceLabel.Text = app.toMoneyOf(balance);
            }
            else
            {
                totalBalanceLabel.Text = "0.00";
            }
            accountBalancePanel.Show();


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

        private void customerNamefield_Enter(object sender, EventArgs e)
        {
            hint.manageHint(customerNamefield, 1, "Customer Name");
        }

        private void customerNamefield_Leave(object sender, EventArgs e)
        {
            hint.manageHint(customerNamefield, 0, "Customer Name");
        }

        private void transactionAmountfield_Enter(object sender, EventArgs e)
        {
            hint.manageHint(transactionAmountfield, 1, "Transaction Amount");
        }

        private void transactionAmountfield_Leave(object sender, EventArgs e)
        {
            hint.manageHint(transactionAmountfield, 0, "Transaction Amount");
        }

        private void paymentmode_Enter(object sender, EventArgs e)
        {
            hint.manageComboHint(paymentmodeField, 1, "Payment Mode");
        }

        private void paymentmode_Leave(object sender, EventArgs e)
        {
            hint.manageComboHint(paymentmodeField, 0, "Payment Mode");
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            if (customerNamefield.Text == "Customer Name" || customerNamefield.Text == "")
            {
                app.notifyTo(statusLabel, "Please enter the customer name!", "warning");
            }
            else if (transactionAmountfield.Text == "Transaction Amount" || transactionAmountfield.Text == "")
            {
                app.notifyTo(statusLabel, "Please enter the transaction amount", "warning");
            }
            else if (paymentmodeField.Text == "Payment Mode" || paymentmodeField.Text == "")
            {
                app.notifyTo(statusLabel, "Please select the payment mode", "warning");
            }
            else
            {

                if (customerNamefield.Text != "" && transactionAmountfield.Text != "" && paymentmodeField.Text != ""
                    && customerNamefield.Text != "Customer Name" && transactionAmountfield.Text != "Transaction Amount" && paymentmodeField.Text != "Payment Mode")
                {

                    int transactionAmount = 0;
                    if (app.isAllDigits(transactionAmountfield.Text)) {
                        transactionAmount = int.Parse(transactionAmountfield.Text);

                        Payment payment = new Payment()
                        {
                            customer_name = customerNamefield.Text,
                            transaction_amount = transactionAmount,
                            payment_mode = paymentmodeField.Text,
                            description=paymentDescriptionField.Text,
                            transaction_type="Payment",
                        };

                        if (transactionAmount > 0)
                        {
                            addbutton.Enabled = false;
                            int response = addService.addPayment(payment);
                            addbutton.Enabled = true;
                            if (response > 0)
                            {
                                User user = app.getSession();
                                Customer customer = getService.getCustomerByName(customerNamefield.Text);
                                Payment pay = getService.getLastPayment(user.id, customer.id);
                                Report report = new Report(customer.id, pay.id, "#payment");
                                report.ShowDialog();
                                
                                customerNamefield.Text = "Customer Name";
                                transactionAmountfield.Text = "Transaction Amount";
                                paymentmodeField.Text = "Payment Mode";
                                paymentDescriptionField.Text = "Description";
                                refreshCutsomerBalance(customerNamefield.Text);
                            }
                            else
                            {
                                if (response == -404)
                                {
                                    app.notifyTo(statusLabel, "The customer " + customerNamefield.Text + " is  not found", "warning");
                                }
                                else if (response == -202)
                                {
                                    app.showWarning("The customer " + payment.customer_name + " is not Owing!");
                                }
                                else
                                {
                                    app.notifyTo(statusLabel, "Transaction failed, please try latter ", "warning");
                                }
                            }
                        }
                        else
                        {
                            app.notifyTo(statusLabel, "Oops! the Transaction amount can not be Zero ", "warning");

                        }
                    }
                    else
                    {
                        app.notifyTo(statusLabel, "Invalid transaction amount, please type only numbers!", "error");
                    }
                   

                }

            }
        }
        private void addCustomerTrigger_Click_1(object sender, EventArgs e)
        {
            app.open(new AddCustomer());
        }

        private void customerNamefield_TextChanged_1(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            app.buildDropdown(this, sender, customerPanel, "customers");
            refreshCutsomerBalance(customerNamefield.Text);
        }

        private void paymentDescriptionField_Enter(object sender, EventArgs e)
        {
            hint.manageHint(paymentDescriptionField, 1, "Description");
        }

        private void paymentDescriptionField_Leave(object sender, EventArgs e)
        {
            hint.manageHint(paymentDescriptionField, 0, "Description");
        }

        private void label1_Click(object sender, EventArgs e)
        {

       

        }

        private void paymentDescriptionField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addbutton.PerformClick();
        }
    }
}
