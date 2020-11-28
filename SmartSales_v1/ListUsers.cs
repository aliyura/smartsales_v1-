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
    public partial class ListUsers : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        SSGetService getService = new SSGetService();
        App app = new App();


        public ListUsers()
        {
            InitializeComponent();
            loadUsers();
        }

        private void loadUsers()
        {
            DataTable data = getService.getDataFrom(app.objects["users"]);
            if (data.Rows.Count > 0)
                data.Columns.Remove("password");
                data.Columns.Remove("picture");
                usersGridView.DataSource = data;
        }
        private void searchUser(string q)
        {
            DataTable data = getService.searchDataFrom(app.objects["users"], q);
            if (data.Rows.Count > 0)
                data.Columns.Remove("password");
                data.Columns.Remove("picture");
                usersGridView.DataSource = data;
        }

        private void mobilenumberfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(usersSearchTextField, 1, "Search");
        }

        private void mobilenumberfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(usersSearchTextField, 0, "Search");
        }

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string question = usersSearchTextField.Text;
            if (question != "" && question.Length > 2)
                this.searchUser(question);
        }

        private void usersSearchTextField_TextChanged(object sender, EventArgs e)
        {
            string question = usersSearchTextField.Text;
            if (question != "" && question.Length > 2)
                this.searchUser(question);
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
