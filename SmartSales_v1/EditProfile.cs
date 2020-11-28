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
    public partial class EditProfile : Form
    {
        App app = new App();
        Hint hint = new Hint();
        SSGetService getService = new SSGetService();
        SSUpdateService updateService = new SSUpdateService();

        public EditProfile()
        {
            InitializeComponent();
            loadProfile();
        }



        void loadProfile()
        {
            User user = app.getSession();
            if (user.name != null)
            {

                User profileData = getService.getUserById(user.id);
                if (profileData.picture != null)
                {
                    nameLabel.Text = profileData.name;
                    usernameLabel.Text = profileData.username;
                    mobileLavel.Text = profileData.mobile_number;
                    addressLabel.Text = profileData.address;


                    userPictureBox.Image = app.byteArrayToImage(profileData.picture);

                    System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
                    gp2.AddEllipse(0, 0, userPictureBox.Width, userPictureBox.Height);
                    Region rg2 = new Region(gp2);
                    userPictureBox.Region = rg2;
                }
            }

        }

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                userPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        private void namefield_Enter(object sender, EventArgs e)
        {
            hint.manageHint(namefield,1,"Name");
        }

        private void namefield_Leave(object sender, EventArgs e)
        {
            hint.manageHint(namefield, 0, "Name");
        }

        private void mobilenumberfield_Enter(object sender, EventArgs e)
        {
            hint.manageHint(mobilenumberfield, 1, "Mobile Number");
        }

        private void mobilenumberfield_Leave(object sender, EventArgs e)
        {
            hint.manageHint(mobilenumberfield, 0, "Mobile Number");
        }

        private void usernamefield_Enter(object sender, EventArgs e)
        {
            hint.manageHint(usernamefield, 1, "Username");
        }

        private void usernamefield_Leave(object sender, EventArgs e)
        {
            hint.manageHint(usernamefield, 0, "Username");
        }

        private void addressfield_Enter(object sender, EventArgs e)
        {
            hint.manageHint(addressfield, 1, "Home Address");
        }

        private void addressfield_Leave(object sender, EventArgs e)
        {
            hint.manageHint(addressfield, 0, "Address");
        }
    }
}
