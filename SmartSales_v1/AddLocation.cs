using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class AddLocation : Form
    {
        public Point mouseLocation;
        Hint h = new Hint();
        App app = new App();
        SSAddService addService = new SSAddService();

        public AddLocation()
        {
            InitializeComponent();
        }

        private void currentpricefield_MouseEnter(object sender, EventArgs e)
        {
            h.manageHint(locationName, 0, "Location Name");
        }

        private void currentpricefield_MouseLeave(object sender, EventArgs e)
        {
            h.manageHint(locationName, 1, "Location Name");
        }

        private void storetypredropdown_MouseEnter(object sender, EventArgs e)
        {
            locationType.Text = "";
        }

        private void storetypredropdown_MouseLeave(object sender, EventArgs e)
        {
            if (locationType.Text == "")
            {
                locationType.Text = "Location Type";
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Location location = new Location()
            {
                name = locationName.Text,
                type = locationType.Text,
            };

            if (location.name == "Location Name" || location.name == "")
            {
                app.notifyTo(statusLabel, "Location name is required", "warning");
            }
            else if (location.type == "Location Type" || location.type == "")
            {
                app.notifyTo(statusLabel, "Location type is required", "warning");
            }
            else
            {

                if (location.name != "" && location.type != "" && location.name != "Location Name" && location.name != "Location Type")
                {

                    int response = addService.addLocation(location);
                    if (response != -1)
                    {
                        locationName.Text = "";
                        locationType.Text = "";
                        app.notifyTo(statusLabel, "Location Added Successfully", "success");
                    }
                    else
                    {
                        app.notifyTo(statusLabel, "Success", "Unable to add this Location");
                    }

                }
                else
                {
                    app.notifyTo(statusLabel, "All fields are required", "warning");
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
    }
}