using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class Report : Form
    {
        public Point mouseLocation;
        int tid = 0;
        int cid = 0;
        string type;
        App app = new App();
        SSGetService getService = new SSGetService();

        public Report(int cid, int tid, string type)
        {
            InitializeComponent();
            this.cid = cid;
            this.tid = tid;
            this.type = type;
            inializeReport();
        }
        private void inializeReport()
        {
            try
            {
                switch (type)
                {
                    case "#invoice": generateInvoice();
                        break;
                    case "#payment": generatePaymentReceipt();
                        break;
                    case "#voucher": generateVoucherReceipt();
                        break;
                }
                this.reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                app.showWarning(ex.Message);
            }
        }
        private void generatePaymentReceipt()
        {
            User session = app.getSession();
            DataTable payment = getService.getDataWithFilter(app.objects["payments"], "id=" + tid);
            DataTable user = getService.getDataWithFilter(app.objects["users"], "id=" + session.id);
            DataTable customer = getService.getDataWithFilter(app.objects["customers"], "id=" + cid);
            DataTable business = getService.getDataWithFilter(app.objects["business"], "id=" + session.bid);
            DataTable debtor = getService.getDataWithFilter(app.objects["debtors"], "cid=" + cid);

            if (payment.Rows.Count > 0 && user.Rows.Count > 0 && business.Rows.Count > 0)
            {
                ReportDataSource paymentRDS = new ReportDataSource("payment", payment);
                ReportDataSource userRDS = new ReportDataSource("user", user);
                ReportDataSource customerRDS = new ReportDataSource("customer", customer);
                ReportDataSource businessRDS = new ReportDataSource("business", business);
                ReportDataSource debtorRDS = new ReportDataSource("debtor", debtor);

                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(paymentRDS);
                this.reportViewer.LocalReport.DataSources.Add(userRDS);
                this.reportViewer.LocalReport.DataSources.Add(customerRDS);
                this.reportViewer.LocalReport.DataSources.Add(businessRDS);
                this.reportViewer.LocalReport.DataSources.Add(debtorRDS);
                this.reportViewer.LocalReport.ReportPath = "../../PaymentReceipt.rdlc";
                this.reportViewer.Refresh();
            }
            else
            {
                app.showWarning("Unable to load the payment receipt, please logout->login and try again");
            }

        }

        private void generateVoucherReceipt()
        {
            User session = app.getSession();
            DataTable voucher = getService.getDataWithFilter(app.objects["vouchers"], "id=" + tid);
            DataTable user = getService.getDataWithFilter(app.objects["users"], "id=" + session.id);
            DataTable customer = getService.getDataWithFilter(app.objects["customers"], "id=" + cid);
            DataTable business = getService.getDataWithFilter(app.objects["business"], "id=" + session.bid);

            if (voucher.Rows.Count > 0 && user.Rows.Count > 0 && business.Rows.Count > 0)
            {
                ReportDataSource paymentRDS = new ReportDataSource("voucher", voucher);
                ReportDataSource userRDS = new ReportDataSource("user", user);
                ReportDataSource customerRDS = new ReportDataSource("customer", customer);
                ReportDataSource businessRDS = new ReportDataSource("business", business);
               


                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(paymentRDS);
                this.reportViewer.LocalReport.DataSources.Add(userRDS);
                this.reportViewer.LocalReport.DataSources.Add(customerRDS);
                this.reportViewer.LocalReport.DataSources.Add(businessRDS);
                this.reportViewer.LocalReport.ReportPath = "../../CashVoucher.rdlc";
                this.reportViewer.Refresh();
            }
            else
            {
                app.showWarning("Unable to load the voucher receipt, please logout->login and try again");
            }
        }
        private void generateInvoice()
        {
            User session = app.getSession();
            DataTable sales = getService.getDataWithFilter(app.objects["sales"], "id=" + tid);
            DataTable details = getService.getDataWithFilter(app.objects["sale_details"], "tid=" + tid);
            DataTable user = getService.getDataWithFilter(app.objects["users"], "id=" + session.id);
            DataTable customer = getService.getDataWithFilter(app.objects["customers"], "id=" + cid);
            DataTable business = getService.getDataWithFilter(app.objects["business"], "id=" + session.bid);
            DataTable debtor = getService.getDataWithFilter(app.objects["debtors"], "cid=" + cid);


            if (sales.Rows.Count > 0 && details.Rows.Count > 0 && user.Rows.Count > 0 && business.Rows.Count > 0)
            {
                ReportDataSource salesRDS = new ReportDataSource("sale", sales);
                ReportDataSource detailsRDS = new ReportDataSource("saleDetails", details);
                ReportDataSource userRDS = new ReportDataSource("user", user);
                ReportDataSource customerRDS = new ReportDataSource("customer", customer);
                ReportDataSource businessRDS = new ReportDataSource("business", business);
                ReportDataSource debtorRDS = new ReportDataSource("debtor", debtor);

                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(salesRDS);
                this.reportViewer.LocalReport.DataSources.Add(detailsRDS);
                this.reportViewer.LocalReport.DataSources.Add(userRDS);
                this.reportViewer.LocalReport.DataSources.Add(customerRDS);
                this.reportViewer.LocalReport.DataSources.Add(businessRDS);
                this.reportViewer.LocalReport.DataSources.Add(debtorRDS);
                this.reportViewer.LocalReport.ReportPath = "../../Invoice.rdlc";
                this.reportViewer.Refresh();
            }
            else
            {
                app.showWarning("Unable to load the invoice, please logout->login and try again");
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
