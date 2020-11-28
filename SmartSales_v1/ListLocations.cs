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
    public partial class ListLocations : Form
    {
        public Point mouseLocation;
        Hint hint = new Hint();
        SSGetService getService = new SSGetService();
        App app = new App();
        public ListLocations()
        {
            InitializeComponent();
            loadLocations();
        }
        private void loadLocations()
        {
            DataTable data = getService.getDataFrom(app.objects["locations"]);
            if (data.Rows.Count > 0)
                locationGridView.DataSource = data;
        }
        private void searchLocation(string q)
        {
            DataTable data = getService.searchDataFrom(app.objects["locations"], q);
            if (data.Rows.Count > 0)
                locationGridView.DataSource = data;
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
            hint.manageHint(locationnamesearchfield, 1, "Search");
        }

        private void productnamesearchfield_Leave(object sender, EventArgs e)
        {
            hint.manageHint(locationnamesearchfield, 0, "Search");
        }

        private void locationnamesearchfield_TextChanged(object sender, EventArgs e)
        {
            string question = locationnamesearchfield.Text;
            if (question != "" && question.Length > 2)
                this.searchLocation(question);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string question = locationnamesearchfield.Text;
            if (question != "" && question.Length > 2)
                this.searchLocation(question);
        }
    }
}
