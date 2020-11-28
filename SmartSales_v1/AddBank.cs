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
    public partial class AddBank : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();
        SSAddService addService = new SSAddService();

        public AddBank()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Bank bank = new Bank()
            {
                name = bankNameField.Text
            };

            if (bank.name == "Bank Name" || bank.name == "")
            {
                app.notifyTo(statusLabel, "Bank name required", "warning");
            }

            else
            {

                if (bank.name != "" && bank.name != "Bank Name")
                {

                    int response = addService.addBank(bank);
                    if (response > 0)
                    {
                        bankNameField.Text = "Bank Name";
                        app.notifyTo(statusLabel, "Bank Added Successfully", "success");
                    }
                    else
                    {
                        if (response == -2)
                        {
                            app.notifyTo(statusLabel, "Bank ["+bank.name+"] already exist", "warning");
                        }
                        else
                        {
                            app.notifyTo(statusLabel, "Unable to add bank", "warning");
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void banknamefield_Enter(object sender, EventArgs e)
        {
            h.manageHint(bankNameField, 1, "Bank Name");
        }

        private void banknamefield_Leave(object sender, EventArgs e)
        {
            h.manageHint(bankNameField, 0, "Bank Name");
        }

        private void bankNameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addbutton.PerformClick();
        }
    }
  }
