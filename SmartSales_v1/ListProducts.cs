using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class ListProducts : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();
        SSGetService getService = new SSGetService();
        Range range = new Range();

        public ListProducts()
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

            loadProducts();
          
        }
        private void loadProducts()
        {
                DataTable data = getService.getProductWithFilter("#available", "CONVERT(VARCHAR(10), s.created_date, 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
                if (data.Rows.Count > 0)
                    productGridView.DataSource = data;
        }
        private void searchProduct(string q)
        {
            DataTable data = getService.searchProductWithFilter(q, "#available", "CONVERT(VARCHAR(10), s.created_date, 111) BETWEEN  '" + range.from.Date.ToString("yyyy/MM/dd") + "' AND '" + range.to.Date.ToString("yyyy/MM/dd") + "'");
            if (data.Rows.Count > 0)
                productGridView.DataSource = data;
            else
                productGridView.DataSource = null;
        }


        private void productnamesearchfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(productnamesearchfield, 1, "Search");
        }

        private void productnamesearchfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(productnamesearchfield, 0, "Search");
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

        private void productnamesearchfield_TextChanged(object sender, EventArgs e)
        {
            string question = productnamesearchfield.Text;
            if (question != "" && question.Length > 2)
                this.searchProduct(question);
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string question = productnamesearchfield.Text;
            if (question != "" && question.Length > 2)
                this.searchProduct(question);
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.from = fromDatePicker.Value;
            loadProducts();
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            range.to = toDatePicker.Value;
            loadProducts();
        }
    }
}
