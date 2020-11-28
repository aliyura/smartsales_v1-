using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class ListCustomers : Form
    {
        public Point mouseLocation;
        Hint hint = new Hint();
        SSGetService getService = new SSGetService();
        App app = new App();
        Range range=new Range();



        public ListCustomers()
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

            loadCustomers();

        }


        private void loadCustomers()
        {
            DataTable data = getService.getDataWithFilter(app.objects["customers"], "CONVERT(VARCHAR(10), created_date, 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                customerGridView.DataSource = data;
        }
        private void searchCustomer(string q)
        {
            DataTable data = getService.searchDataWithFilter(app.objects["customers"], q, "CONVERT(VARCHAR(10), created_date, 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                customerGridView.DataSource = data;
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

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void usersSearchTextField_Enter(object sender, EventArgs e)
        {
            hint.manageHint(customerSearchTextField, 1, "Search");
        }
   
        private void usersSearchTextField_Leave(object sender, EventArgs e)
        {
            hint.manageHint(customerSearchTextField, 0, "Search");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string question = customerSearchTextField.Text;
            if (question != "" && question.Length > 2)
                this.searchCustomer(question);
        }

        private void customerSearchTextField_TextChanged(object sender, EventArgs e)
        {
            string question = customerSearchTextField.Text;
            if (question != "" && question.Length > 2)
                this.searchCustomer(question);
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.to = fromDatePicker.Value;
            loadCustomers();
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.from = fromDatePicker.Value;
            loadCustomers();
        }
    }
}
