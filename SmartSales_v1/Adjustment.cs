using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class Adjustment : Form
    {
        public Point mouseLocation;
        App app = new App();
        Hint h = new Hint();
        SSAddService addService = new SSAddService();

        public Adjustment()
        {
            InitializeComponent();
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

        private void customerNamefield_TextChanged(object sender, EventArgs e)
        {
            app.buildDropdown(this, sender, customerNamePanel, "customers");
        }
  
        private void customerNamefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(customerNamefield, 0, "Customer Name");
        }

        private void customerNamefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(customerNamefield, 1, "Customer Name");
        }

        private void paymentmode_Enter(object sender, EventArgs e)
        {
            h.manageComboHint(paymentmodeField, 1, "Adjustment Type");
        }

        private void paymentmode_Leave(object sender, EventArgs e)
        {
            h.manageComboHint(paymentmodeField, 0, "Adjustment Type");
        }

        private void transactionAmountfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(transactionAmountfield, 1, "Amount");
        }

        private void transactionAmountfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(transactionAmountfield, 0, "Amount");
        }

        private void addCustomerTrigger_Click(object sender, EventArgs e)
        {
            app.open(new AddCustomer());
        }

        private void paymentDescriptionField_Enter(object sender, EventArgs e)
        {
            h.manageHint(paymentDescriptionField, 1, "Description");
        }

        private void paymentDescriptionField_Leave(object sender, EventArgs e)
        {
            h.manageHint(paymentDescriptionField, 0, "Description");
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (customerNamefield.Text == "Customer Name" || customerNamefield.Text == "")
            {
                app.notifyTo(statusLabel, "Please enter the customer name!", "warning");
            }
            else if (transactionAmountfield.Text == "Amount" || transactionAmountfield.Text == "")
            {
                app.notifyTo(statusLabel, "Please enter the adjustment amount", "warning");
            }
            else if (paymentmodeField.Text == "Adjustment Type" || paymentmodeField.Text == "")
            {
                app.notifyTo(statusLabel, "Please select the ajustment type", "warning");
            }
            else
            {

                if (customerNamefield.Text != "" && transactionAmountfield.Text != "" && paymentmodeField.Text != ""
                    && customerNamefield.Text != "Customer Name" && transactionAmountfield.Text != "Amount" && paymentmodeField.Text != "Adjustment Type")
                {

                    int transactionAmount = 0;
                    if (app.isAllDigits(transactionAmountfield.Text))
                    {
                        transactionAmount = int.Parse(transactionAmountfield.Text);

                        Payment payment = new Payment()
                        {
                            customer_name = customerNamefield.Text,
                            transaction_amount = transactionAmount,
                            payment_mode = paymentmodeField.Text,
                            description = paymentDescriptionField.Text,
                            transaction_type = "Adjustment",
                        };

                        if (transactionAmount > 0)
                        {
                            addbutton.Enabled = false;
                            int response = addService.addPayment(payment);
                            addbutton.Enabled = true;
                            if (response > 0)
                            {
                                customerNamefield.Text = "Customer Name";
                                transactionAmountfield.Text = "Amount";
                                paymentmodeField.Text = "Transaction type";
                                paymentDescriptionField.Text = "Description";
                                app.notifyTo(statusLabel, "Transaction Completed", "success");
                            }
                            else
                            {
                                if (response == -404)
                                {
                                    app.notifyTo(statusLabel, "Oops! the customer " + customerNamefield.Text + " not found", "warning");
                                }
                                else if (response == -202)
                                {
                                    app.showWarning("The customer " + payment.customer_name + " is no longer Owing!");
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

        private void adjPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paymentmodeField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int i;
        public int assignAmount(int a)
        {
            i = a;
            return i;
        }

        private void transactionAmountfield_TextChanged(object sender, EventArgs e)
        {
            int pv;
            if (int.TryParse(transactionAmountfield.Text,out pv))
            {
                i = int.Parse(transactionAmountfield.Text);
                assignAmount(i);

            }
            else if (!int.TryParse(transactionAmountfield.Text, out pv))
            {

                transactionAmountfield.Text = assignAmount(i).ToString();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paymentDescriptionField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void paymentDescriptionField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addbutton.PerformClick();
        }
    }
}