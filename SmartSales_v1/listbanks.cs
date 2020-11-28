using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class ListBanks : Form
    {
        SSGetService getService = new SSGetService();
        public Point mouseLocation;
        Hint hint = new Hint();
        App app = new App();
        public ListBanks()
        {
            InitializeComponent();
            loadBanks();
        }
        private void loadBanks()
        {
            DataTable data = getService.getDataFrom(app.objects["banks"]);
            if (data.Rows.Count > 0)
                bankdataGridView.DataSource = data;
        }
        private void searchBanks(string q)
        {
            DataTable data = getService.searchDataFrom(app.objects["banks"], q);
            if (data.Rows.Count > 0)
                bankdataGridView.DataSource = data;
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
            hint.manageHint(banknamesearchfield, 1, "Search");
        }

        private void productnamesearchfield_Leave(object sender, EventArgs e)
        {
            hint.manageHint(banknamesearchfield, 0, "Search");
        }

        private void ListBanks_Load(object sender, EventArgs e)
        {

        }

        private void banknamesearchfield_TextChanged(object sender, EventArgs e)
        {
            string question = banknamesearchfield.Text;
            if (question != "" && question.Length > 2)
                this.searchBanks(question);

            app.buildDropdown(this, sender, bankPanel, "banks");
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string question = banknamesearchfield.Text;
            if (question != "" && question.Length > 2)
                this.searchBanks(question);
        }
    }
}
