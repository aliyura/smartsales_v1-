using System;
using System.Data;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class AddVoucher : Form
    {

        SSAddService addService = new SSAddService();
        SSGetService getService = new SSGetService();
        Hint h = new Hint();
        App app = new App();

        public AddVoucher()
        {
            InitializeComponent();
            loadVoucherCategory();
            loadAccountBalance();
        }

        private void  loadAccountBalance()
        {
            DataTable data = getService.getDataFrom(app.objects["account"]);
            if (data.Rows.Count > 0)
            {
                int balance = data.Rows[0].Field<int>("balance");
                totalBalanceLabel.Text = app.toMoneyOf(balance);
            }
            else
            {
                totalBalanceLabel.Text = "0.00";
            }
        }

        private void loadVoucherCategory()
        {
            DataTable data = getService.getDataFrom(app.objects["voucher_categories"]);
            if (data.Rows.Count > 0)
                voucherTypeField.Items.Clear();
                foreach (DataRow row in data.Rows)
                    voucherTypeField.Items.Add(row.Field<string>("name"));
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
            if (voucherAmountField.Text == "" || voucherAmountField.Text == "Amount")
                app.notifyTo(statusLabel,"Please enter the amount!","warning");
            if (voucherTypeField.Text == "" || voucherTypeField.Text == "Voucher Type")
                app.notifyTo(statusLabel, "Please select the voucher type!", "warning");
            if (voucherDescriptionField.Text == "" || voucherDescriptionField.Text == "Description")
                app.notifyTo(statusLabel, "Please enter the description!", "warning");

            if(voucherAmountField.Text!="" && voucherTypeField.Text!="" && voucherAmountField.Text != ""
               && voucherAmountField.Text!="Amount" && voucherTypeField.Text!="Voucher Type" && voucherDescriptionField.Text!="Description")
            {

                Voucher voucher = new Voucher()
                {
                    amount = int.Parse(voucherAmountField.Text),
                    type = voucherTypeField.Text,
                    description = voucherDescriptionField.Text
                };

                addbutton.Enabled = false;
                int response = addService.MakeVoucher(voucher);
                addbutton.Enabled = true;
                if (response > 0)
                {
                    User user = app.getSession();
                    Voucher lastVoucher = getService.getLastVoucher(user.id);
                    Report report = new Report(0, lastVoucher.id, "#voucher");
                    report.ShowDialog();

                    voucherAmountField.Text = "Amount";
                    voucherTypeField.Text = "Voucher Type";
                    voucherDescriptionField.Text = "Description";
                    loadAccountBalance();
                }
                else
                {
                    if (response == -404)
                    {
                        app.notifyTo(statusLabel, "Voucher category doesn't exist!", "warning");
                    }
                    else if (response == -402)
                    {
                        app.notifyTo(statusLabel, "Insufficient funds!", "warning");
                    }
                    else if (response == -403)
                    {
                        app.notifyTo(statusLabel, "Oops! the voucher account not found!", "warning");
                    }
                    else
                    {
                        app.notifyTo(statusLabel, "Oops! unable to complete your transaction!", "warning");
                    }
                }
            }
        }

        private void voucherAmountField_Enter(object sender, EventArgs e)
        {
            h.manageHint(voucherAmountField,1,"Amount");
        }

        private void voucherAmountField_Leave(object sender, EventArgs e)
        {
            h.manageHint(voucherAmountField, 0, "Amount");
        }

        private void voucherDescriptionField_Enter(object sender, EventArgs e)
        {
            h.manageHint(voucherDescriptionField, 1, "Description");

        }

        private void voucherDescriptionField_Leave(object sender, EventArgs e)
        {

            h.manageHint(voucherDescriptionField, 0, "Description");
        }

        private void paymentmodeField_Enter(object sender, EventArgs e)
        {
            h.manageHint(voucherDescriptionField, 1, "Voucher Type");
        }

        private void voucherTypeField_Leave(object sender, EventArgs e)
        {
            h.manageHint(voucherDescriptionField, 0, "Voucher Type");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Report report = new Report(2,0, "#voucher");
            report.ShowDialog();
        }

        private void voucherDescriptionField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addbutton.PerformClick();
        }
    }
}
