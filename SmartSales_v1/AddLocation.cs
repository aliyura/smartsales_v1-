using System;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class AddLocation : Form
    {
        Hint h = new Hint();
        public AddLocation()
        {
            InitializeComponent();
        }

        private void currentpricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(storenamefield, 0, "Store Name");
        }

        private void currentpricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(storenamefield, 1, "Store Name");
        }

        private void storetypredropdown_MouseEnter(object sender, EventArgs e)
        {
            // h.manageHint(storetypredropdown, 0, "Store Type");
            storetypredropdown.Text = "";
        }

        private void storetypredropdown_MouseLeave(object sender, EventArgs e)
        {
            if (storetypredropdown.Text == "")
            {
                storetypredropdown.Text = "Store Type";
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Stores store = new Stores()
            {
                name = storenamefield.Text,
                type = storetypredropdown.Text,
            };
            if (storenamefield.Text != null || panel4.Text != "Store Name")
            {
                if (storetypredropdown.SelectedItem.ToString() == " Virtual Store")
                {
                    MessageBox.Show(storenamefield.Text + " Virtual Store Added");
                }
                if (storetypredropdown.SelectedItem.ToString() == " Mega Store")
                {
                    MessageBox.Show(storenamefield.Text + " Mega Store Added");
                }
                if (storetypredropdown.SelectedItem.ToString() == "Mini Store")
                {
                    MessageBox.Show(storenamefield.Text + " Mini Store Added");
                }
            }
            else
            {
                MessageBox.Show("Enter a Valid Store Name Please");
            }

        }
    }
}