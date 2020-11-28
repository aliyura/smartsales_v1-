﻿using System;
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
    public partial class Profile : Form
    {

        App app = new App();
        SSGetService getService = new SSGetService();

        public Profile()
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
                    nameView.Text = profileData.name;
                    usernameView.Text = profileData.username;
                    mobileView.Text = profileData.mobile_number;
                    addressView.Text = profileData.address;


                    userPictureBox.Image = app.byteArrayToImage(profileData.picture);

                    System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
                    gp2.AddEllipse(0, 0, userPictureBox.Width, userPictureBox.Height);
                    Region rg2 = new Region(gp2);
                    userPictureBox.Region = rg2;
                }
            }

        }

        private void editProfileTrigger_Click(object sender, EventArgs e)
        {
            app.open(new EditProfile());
        }

        private void closedbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizedbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            app.open(new EditProfile());
        }
    }
}
