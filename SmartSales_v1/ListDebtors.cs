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
    public partial class ListDebtors : Form
    {
        Hint hint = new Hint();
        public Point mouseLocation;
        SSGetService getService = new SSGetService();
        App app = new App();
        Range range = new Range();

        public ListDebtors()
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
            loadDebtors();
        }
        private void loadDebtors()
        {
            DataTable data = getService.getDataWithFilter(app.objects["debtors"], "amount>0 and CONVERT(VARCHAR(10), created_date, 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                debtorGridView.DataSource = data;
        }
        private void searchDebtors(string q)
        {
            DataTable data = getService.searchDataWithFilter(app.objects["debtors"], q, "amount>0 and CONVERT(VARCHAR(10), created_date, 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                debtorGridView.DataSource = data;
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

        private void usersSearchTextField_Enter(object sender, EventArgs e)
        {
            hint.manageHint(debtorsSearchTextField, 1, "Search");
        }

        private void usersSearchTextField_Leave(object sender, EventArgs e)
        {
            hint.manageHint(debtorsSearchTextField, 0, "Search");
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string question = debtorsSearchTextField.Text;
            if (question != "" && question.Length > 2)
                this.searchDebtors(question);
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.from = fromDatePicker.Value;
            loadDebtors();
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.to = toDatePicker.Value;
            loadDebtors();
        }

        private void debtorsSearchTextField_TextChanged(object sender, EventArgs e)
        {
            string question = debtorsSearchTextField.Text;
            if (question != "" && question.Length > 2)
                this.searchDebtors(question);

        }
    }
}
