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
    public partial class ListSoldProductcs : Form
    {
        Hint hint = new Hint();
        public Point mouseLocation;
        SSGetService getService = new SSGetService();
        App app = new App();
        Range range = new Range();
        public ListSoldProductcs()
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

            loadSold();
        }
        private void loadSold()
        {
            DataTable data = getService.getProductWithFilter("#sold", "CONVERT(VARCHAR(10), s.created_date, 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                soldGridView.DataSource = data;
        }
        private void searchSold(string q)
        {
            DataTable data = getService.searchProductWithFilter(q,"#sold", "CONVERT(VARCHAR(10), s.created_date, 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            app.showSuccess(data.Rows.Count.ToString());
            if (data.Rows.Count > 0)
                soldGridView.DataSource = data;
            else
                soldGridView.DataSource = null;
        }

        private void soldproductnamesearchfield_Enter(object sender, EventArgs e)
        {
            hint.manageHint(soldproductnamesearchfield, 1, "Search");
        }

        private void soldproductnamesearchfield_Leave(object sender, EventArgs e)
        {
            hint.manageHint(soldproductnamesearchfield, 0, "Search");
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

        private void soldproductnamesearchfield_TextChanged(object sender, EventArgs e)
        {
            string question = soldproductnamesearchfield.Text;
            if (question != "" && question.Length > 2)
                this.searchSold(question);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string question = soldproductnamesearchfield.Text;
            if (question != "" && question.Length > 2)
                this.searchSold(question);
        }

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.from = fromDatePicker.Value;
            loadSold();

        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.to = toDatePicker.Value;
            loadSold();
        }
    }
}
