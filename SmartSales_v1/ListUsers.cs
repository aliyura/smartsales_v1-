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
                usersGridView.DataSource = data;
        }
        private void searchUser(string q)
        {
            DataTable data = getService.searchDataFrom(app.objects["users"], q);
            if (data.Rows.Count > 0)
                usersGridView.DataSource = data;
        }

        private void mobilenumberfield_Enter(object sender, EventArgs e)
        {
            h.manageHint(usersSearchTextField, 1, "Search user e.g Aliyura");
        }

        private void mobilenumberfield_Leave(object sender, EventArgs e)
        {
            h.manageHint(usersSearchTextField, 0, "Search user e.g Aliyura");
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
    }
}
