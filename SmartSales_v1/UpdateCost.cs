using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class UpdateCost : Form
    {

        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();
        SSGetService getService = new SSGetService();
        SSUpdateService updateService = new SSUpdateService();


        public UpdateCost()
        {
            InitializeComponent();
        }


        private void refreshCurrentBatchCost(string name)
        {

            DataTable data = getService.getData("select  top 1 * from " + app.objects["batches"]+ " b,  " + app.objects["stocks"] + " s  where b.name = '"+name+"'and b.id = s.bid");
            if (data.Rows.Count > 0)
            {
                int balance = data.Rows[0].Field<int>("Cost");
                if (balance == 0)
                    totalBalanceLabel.Text = "0.00";
                else
                    totalBalanceLabel.Text = app.toMoneyOf(balance);
            }
            else
            {
                totalBalanceLabel.Text = "0.00";
            }
            accountBalancePanel.Show();
        }


        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void batchNameField_Leave(object sender, EventArgs e)
        {
            h.manageHint(batchNameField,0, "Batch Number");
        }

        private void batchNameField_Enter(object sender, EventArgs e)
        {
            h.manageHint(batchNameField, 1, "Batch Number");
        }

        private void costField_Enter(object sender, EventArgs e)
        {
            h.manageHint(costField, 1, "New Cost");
        }

        private void costField_Leave(object sender, EventArgs e)
        {
            h.manageHint(costField, 0, "New Cost");
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                int cost;
                cost = 0;

                if (costField.Text != "New Cost")
                    cost = int.Parse(costField.Text);


                Batch batch = new Batch()
                {
                    name = batchNameField.Text,
                    cost = cost
                };


                if (batchNameField.Text == "Batch Number" || batchNameField.Text == "")
                {
                    app.notifyTo(statusLabel, "Batch Number required", "warning");
                }

                else if (costField.Text == "New Cost" || costField.Text == "")
                {
                    app.notifyTo(statusLabel, "New Cost required", "warning");
                }
                else
                {

                    if (batchNameField.Text != "" && costField.Text != ""
                        && batchNameField.Text != "Batch Number" && costField.Text != "New Cost")
                    {

                        update.Enabled = false;
                        int response = updateService.updateCost(batch);
                        update.Enabled = true;
                        if (response > 0)
                        {
                            costField.Text = "New Cost";
                            refreshCurrentBatchCost(batch.name);
                            app.notifyTo(statusLabel, "Cost Updated Successfully", "success");
                        }

                        else
                        {
                            if (response == -404)
                            {
                                app.notifyTo(statusLabel, "Batch [" + batch.name + "] not found", "warning");
                            }
                            else
                            {
                                app.notifyTo(statusLabel, "Unable to update the batch cost", "warning");
                            }
                        }

                    }
                    else
                    {
                        app.notifyTo(statusLabel, "All fields required", "warning");
                    }
                }
            }
            catch (Exception ex)
            {
                app.notifyTo(statusLabel, ex.Message, "error");

            }
        }

        private void batchNameField_TextChanged(object sender, EventArgs e)
        {
            app.buildDropdown(this, sender, batchNamePanel, "batches");
            refreshCurrentBatchCost(batchNameField.Text);
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

        private void costField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                update.PerformClick();
        }
    }
}
