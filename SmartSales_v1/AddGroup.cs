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
    public partial class AddGroup : Form
    {

        SSAddService addService = new SSAddService();
        Hint h = new Hint();
        App app = new App();

        public AddGroup()
        {
            InitializeComponent();
        }


        private void addbutton_Click(object sender, EventArgs e)
        {
            Group group = new Group()
            {
                name = groupNameField.Text
            };

            if (group.name == "Customer Group" || group.name == "")
            {
                app.notifyTo(statusLabel, "Group Name required", "warning");
            }

            else
            {

                if (group.name != "" && group.name != "Customer Group")
                {

                    int response = addService.addCustomerGroup(group);
                    if (response > 0)
                    {
                        groupNameField.Text = "Customer Group";
                        app.notifyTo(statusLabel, "Group Added Successfully", "success");
                    }
                    else
                    {
                        if (response == -2)
                        {
                            app.notifyTo(statusLabel, "Group [" + group.name + "] already exist", "warning");
                        }
                        else
                        {
                            app.notifyTo(statusLabel, "Unable to add the customer group", "error");
                        }

                    }
                }
                else
                {
                    app.notifyTo(statusLabel, "All fields required", "warning");
                }
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

        private void groupNameField_Enter(object sender, EventArgs e)
        {
            h.manageHint(groupNameField, 1, "Customer Group");
        }

        private void groupNameField_Leave(object sender, EventArgs e)
        {
            h.manageHint(groupNameField, 0, "Customer Group");
        }
    }
}
