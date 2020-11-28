using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class ListSales : Form
    {
        public Point mouseLocation;
        Hint hint = new Hint();
        App app = new App();
        SSGetService getService = new SSGetService();
        Range range = new Range();

        public ListSales()
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



            loadSales();
        }
        private void loadSales()
        {
            DataTable data = getService.getSaleWithFilter("CONVERT(VARCHAR(10), transaction_date, 111) BETWEEN '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                salesGridView.DataSource = data;
        }
        private void searchSales(string q)
        {
            DataTable data = getService.searchSaleWithFilter(q, "CONVERT(VARCHAR(10), transaction_date, 111) BETWEEN '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                salesGridView.DataSource = data;
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

        private void productnamesearchfield_Enter(object sender, EventArgs e)
        {
            hint.manageHint(productnamesearchfield, 1, "Search");
        }

        private void productnamesearchfield_Leave(object sender, EventArgs e)
        {
            hint.manageHint(productnamesearchfield, 0, "Search");
        }

        private void productnamesearchfield_TextChanged(object sender, EventArgs e)
        {
            string question = productnamesearchfield.Text;
            if (question != "" && question.Length > 2)
                this.searchSales(question);
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            string question = productnamesearchfield.Text;
            if (question != "" && question.Length > 2)
                this.searchSales(question);
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.from = fromDatePicker.Value;
            loadSales();
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.to = toDatePicker.Value;
            loadSales();
        }
    }
}
