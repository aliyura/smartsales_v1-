using System;
using System.Data;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class ListVouchers : Form
    {

        Hint h = new Hint();
        App app = new App();
        SSGetService getService = new SSGetService();
        Range range = new Range();

        public ListVouchers()
        {
            InitializeComponent();

            //set range data
            fromDatePicker.Value = DateTime.Now.Date;
            toDatePicker.Value = DateTime.Now.Date;

            range = new Range()
            {
                from = fromDatePicker.Value,
                to = toDatePicker.Value,
            };


            loadVouchers();
        }


        private void loadVouchers()
        {
            DataTable data = getService.getDataWithFilter(app.objects["vouchers"], "CONVERT(VARCHAR(10), transaction_date , 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                vouchersGridView.DataSource = data;
        }
        private void searchVouchers(string q)
        {
            DataTable data = getService.searchDataWithFilter(app.objects["vouchers"],q, "CONVERT(VARCHAR(10), transaction_date , 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                vouchersGridView.DataSource = data;
            else
                vouchersGridView.DataSource = null;
        }


        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void searchField_Enter(object sender, EventArgs e)
        {
            h.manageHint(searchField, 1, "Search");
        }

        private void searchField_Leave(object sender, EventArgs e)
        {
            h.manageHint(searchField, 0, "Search");
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string question = searchField.Text;
            if (question != "" && question.Length > 2)
                this.searchVouchers(question);
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string question = searchField.Text;
            if (question != "" && question.Length > 2)
                this.searchVouchers(question);
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.from = fromDatePicker.Value;
            loadVouchers();
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.to = toDatePicker.Value;
            loadVouchers();
        }
    }
}
