using System;
using System.Data;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class ListAdjustments : Form
    {

        Hint h = new Hint();
        App app = new App();
        SSGetService getService = new SSGetService();
        Range range = new Range();

        public ListAdjustments()
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


            loadAjustments();

        }


        private void searchAdjustment(string q)
        {
            DataTable data = getService.searchDataWithFilter(app.objects["adjustments"], q, "CONVERT(VARCHAR(10), transaction_date, 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                adjustmentsGridView.DataSource = data;
            else
                adjustmentsGridView.DataSource = null;
        }

        private void loadAjustments()
        {
            DataTable data = getService.getDataWithFilter(app.objects["adjustments"], "CONVERT(VARCHAR(10), transaction_date, 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                adjustmentsGridView.DataSource = data;
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

        private void searchButton_Click(object sender, EventArgs e)
        {

            string question = searchField.Text;
            if (question != "" && question.Length > 2)
                this.searchAdjustment(question);
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {

            string question = searchField.Text;
            if (question != "" && question.Length > 2)
                this.searchAdjustment(question);
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.from = fromDatePicker.Value;
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.to = toDatePicker.Value;

        }
    }
}
