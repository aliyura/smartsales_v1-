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
    public partial class listbanks : Form
    {
        SSGetService service = new SSGetService();
        public listbanks()
        {
            InitializeComponent();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void listbanks_Load(object sender, EventArgs e)
        {
            for (j = 1; j <= service.getDataFrom(""); j++)
            {

            }
        }
    }
}
