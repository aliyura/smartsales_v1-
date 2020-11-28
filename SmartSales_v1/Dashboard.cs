using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace SmartSales_v1
{
    public partial class Dashboard : Form
    {
        public Point mouseLocation;
        App app = new App();
        SSGetService getService = new SSGetService();
        SSService service = new SSService();
        int isOpen = 0;

        public Dashboard()
        {
            InitializeComponent();
            InitilizeCurrentUser();
            InitializePercentges();
        }


        private void resetDrawers()
        {
            manageProductDrawer.Hide();
            manageSalesDrawer.Hide();
            manageCustomersDrawer.Hide();
            manageUsersDrawer.Hide();
            managePaymentDrawer.Hide();
            manageStoresDrawer.Hide();
            manageBankDrawer.Hide();
            manageVoucherDrawer.Hide();
        }
        private void InitializePercentges()
        {
            try
            {
                if (service.isConnencted())
                {
                    //get and set prouct percentage
                    Percentage productPercent = getService.getProductPercentage();
                    productPercentageLabel.Text = productPercent.percentage + "%";
                    productPercentageTotal.Text = app.toMoneyOf(productPercent.total);
                    productPercentageLeft.Text = app.toMoneyOf(productPercent.left);
                    if (productPercent.percentage > 100)
                        debtorsPercentageBar.Value = 100;
                    else
                       if (productPercent.percentage < 0)
                        debtorsPercentageBar.Value = 0;
                    else
                        debtorsPercentageBar.Value = productPercent.percentage;

                    //get and set debtors percentage
                    Percentage debtorPercent = getService.getDebtorsPercentage();
                    debtorsPercentageLabel.Text = debtorPercent.percentage + "%";
                    debtorsPercentageTotal.Text = app.toMoneyOf(debtorPercent.total);
                    debtorsPercentagePaid.Text = app.toMoneyOf(debtorPercent.left);
                    if (debtorPercent.percentage > 100)
                        debtorsPercentageBar.Value = 100;
                    else
                        if (debtorPercent.percentage < 0)
                        debtorsPercentageBar.Value = 0;
                    else
                        debtorsPercentageBar.Value = debtorPercent.percentage;

                    //get and set balances percentage
                    Percentage balancePercent = getService.getBalancesPercentage();
                    balancesPercentageLabel.Text = balancePercent.percentage + "%";
                    balancesPercentageTotal.Text = app.toMoneyOf(balancePercent.total);
                    balancesPercentagePaid.Text = app.toMoneyOf(balancePercent.left);
                    if (balancePercent.percentage > 100)
                        balancesPercentageBar.Value = 100;
                    else
                        if (balancePercent.percentage < 0)
                        balancesPercentageBar.Value = 0;
                    else
                        balancesPercentageBar.Value = balancePercent.percentage;




                    //get and set balances percentage
                    DataSet productDataset = getService.getProductDataset("#available");
                    productsChart.DataSource = productDataset;

                    productsChart.Series["Products"].XValueMember = "product_name";
                    productsChart.Series["Products"].YValueMembers = "quantity_balance";
                    productsChart.Titles.Add("Available Products");


                    //get and set sales percentage
                    DataSet salesDataset = getService.getSalesDataset();
                    salesChart.DataSource = salesDataset;

                    salesChart.Series["Sales"].XValueMember = "name";
                    salesChart.Series["Sales"].YValueMembers = "total";
                    salesChart.Titles.Add("Current Sales");

                }
                else
                {
                    app.showWarning("Oops! Unable to connect to the database");
                }


            }
            catch(Exception ex)
            {
                app.showWarning(ex.StackTrace);
            }
        }

        private void  InitilizeCurrentUser()
        {

            if (service.isConnencted())
            {
                System.Drawing.Drawing2D.GraphicsPath gp1 = new System.Drawing.Drawing2D.GraphicsPath();
                gp1.AddEllipse(0, 0, userProfilePicture1.Width - 3, userProfilePicture1.Height - 3);
                Region rg1 = new Region(gp1);
                userProfilePicture1.Region = rg1;


                System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
                gp2.AddEllipse(0, 0, userProfilePicture1.Width + 60, userProfilePicture1.Height + 60);
                Region rg2 = new Region(gp2);
                userProfilePicture2.Region = rg2;



                try
                {
                    User session = app.getSession();
                    if (session.name.Contains(" "))
                    {
                        usernameLabel1.Text = session.name.Substring(0, session.name.IndexOf(" "));
                        usernameLabel2.Text = session.name.Substring(0, session.name.IndexOf(" "));
                    }
                    else
                    {
                        usernameLabel1.Text = session.name;
                        usernameLabel2.Text = session.name;

                    }

                    User user = getService.getUserByUsername(session.username);
                    if (user.picture != null && user.picture.Length > 0)
                    {
                        userProfilePicture1.Image = app.byteArrayToImage(user.picture);
                        userProfilePicture2.Image = app.byteArrayToImage(user.picture);
                    }
                }
                catch (Exception ex)
                {
                    app.showWarning(ex.Message);
                }

            }
            else
            {
                app.showWarning("Oops! Unable to connect to the database");

            }

        }
        private void showDrawer(Panel drawer, Button button)
        {
            drawer.Location = new System.Drawing.Point(button.Location.X + navigationDrawer.Width, button.Location.Y - button.Height);
            this.resetDrawers();
            drawer.Show();
        }

        private void onMouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Gray;

        }

        private void onMouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Black;
        }



        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            isOpen = 0;
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            isOpen = 0;
            app.redirect(this, new LoginForm());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

            if (isOpen==0) {
                settingsDrawer.Show();
                isOpen = 1;
            }
            else
            {
                settingsDrawer.Hide();
                isOpen = 0;
            }
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            settingsDrawer.Hide();
            isOpen = 0;
        }

        private void manageproductbutton_MouseEnter(object sender, EventArgs e)
        {
            this.showDrawer(manageProductDrawer, manageproductbutton);
        }

        private void managesalesbutton_MouseEnter(object sender, EventArgs e)
        {
            this.showDrawer(manageSalesDrawer, managesalesbutton);
        }

        private void managecustomersbutton_MouseEnter(object sender, EventArgs e)
        {
            this.showDrawer(manageCustomersDrawer, managecustomersbutton);
        }

        private void manageusersbutton_MouseEnter(object sender, EventArgs e)
        {
            this.showDrawer(manageUsersDrawer, manageusersbutton);
        }

        private void managepaymentbutton_MouseEnter(object sender, EventArgs e)
        {
            this.showDrawer(managePaymentDrawer, managepaymentbutton);
        }

        private void managestoresbutton_MouseEnter(object sender, EventArgs e)
        {
            this.showDrawer(manageStoresDrawer, managestoresbutton);
        }

        private void managebanksbutton_MouseEnter(object sender, EventArgs e)
        {
            this.showDrawer(manageBankDrawer, managebanksbutton);
        }

        private void logouttrigger_Click(object sender, EventArgs e)
        {
            app.redirect(this, new LoginForm());
        }

        private void Dashboard_Enter(object sender, EventArgs e)
        {
            this.resetDrawers();
        }

        private void productsChart_DragEnter(object sender, DragEventArgs e)
        {
            this.resetDrawers();
        }

        private void salesChart_MouseEnter(object sender, EventArgs e)
        {
            this.resetDrawers();
        }

        private void produvtListTrigger_Click(object sender, EventArgs e)
        {
            app.open(new ListProducts());
        }

        private void addProductTrigger_Click(object sender, EventArgs e)
        {
            app.open(new AddProduct());
        }

        private void updateButtonTrigger_Click(object sender, EventArgs e)
        {
            app.open(new UpdateProduct());
        }

        private void updatePriceTrigger_Click(object sender, EventArgs e)
        {
            app.open(new UpdatePrice());
        }

        private void soldProductsTrigger_Click(object sender, EventArgs e)
        {
            app.open(new ListSoldProductcs());
        }

        private void addStoreTrigger_Click(object sender, EventArgs e)
        {
            app.open(new ListLocations());
        }

        private void addStore_Click(object sender, EventArgs e)
        {
            app.open(new AddLocation());
        }

        private void salesTrigger_Click(object sender, EventArgs e)
        {
            app.open(new ListSales());
        }

        private void sellProductTrigger_Click(object sender, EventArgs e)
        {
            app.open(new MakeSales());
        }

        private void listUsersTrigger_Click(object sender, EventArgs e)
        {
            app.open(new ListUsers());
        }

        private void addUserTrigger_Click(object sender, EventArgs e)
        {
            app.open(new AddUser());
        }

        private void takepaymenttrigger_Click(object sender, EventArgs e)
        {
            app.open(new AddPayment());
        }

        private void listCUstomersTrigger_Click(object sender, EventArgs e)
        {
            app.open(new ListCustomers());

        }

        private void debtorstrigger_Click(object sender, EventArgs e)
        {
            app.open(new ListDebtors());
        }

        private void Dashboard_MouseEnter(object sender, EventArgs e)
        {
            this.resetDrawers();
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            this.resetDrawers();
        }

        private void headerPanel_MouseEnter(object sender, EventArgs e)
        {
            this.resetDrawers();
        }

        private void productsChart_MouseEnter(object sender, EventArgs e)
        {
            this.resetDrawers();
        }

        private void addproductnamebutton_Click(object sender, EventArgs e)
        {
            app.open(new AddProduct());
        }

        private void updateProductnamebutton_Click(object sender, EventArgs e)
        {
            app.open(new UpdateProduct());
        }

        private void sellproductnamebutton_Click(object sender, EventArgs e)
        {
            app.open(new MakeSales());
        }

        private void modifyusersroleLabel_Click(object sender, EventArgs e)
        {
            app.open(new AddRole());
        }

        private void exittrigger_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutstrigger_Click(object sender, EventArgs e)
        {
            app.redirect(this, new LoginForm());
        }

        private void adjustmentTrigger_Click(object sender, EventArgs e)
        {
            app.open(new Adjustment());
        }

        private void bankslistTrigger_Click(object sender, EventArgs e)
        {
            app.open(new ListBanks()) ;
        }

        private void addCustomertrigger_Click(object sender, EventArgs e)
        {
            app.open(new AddCustomer());
        }

        private void addbanktrigger_Click(object sender, EventArgs e)
        {
            app.open(new AddBank());
        }
        private void paymentsList_Click(object sender, EventArgs e)
        {
            app.open(new ListPayments());
        }
        private void manageWalletTrigger_Click(object sender, EventArgs e)
        {
            app.open(new ManageWallet());
        }
        private void makePayment_Click(object sender, EventArgs e)
        {
            app.open(new AddPayment());
        }
        private void adjustmentsTrigger_Click(object sender, EventArgs e)
        {
            app.open(new ListAdjustments());
        }


        private void vaucherTrigger_MouseEnter(object sender, EventArgs e)
        {
            this.showDrawer(manageVoucherDrawer, vaucherTrigger);
        }

   
        private void makeVoucherButton_Click(object sender, EventArgs e)
        {
            app.open(new AddVoucher());
        }

        private void voucherCategoryTrigger_Click(object sender, EventArgs e)
        {
            app.open(new AddVoucherCategory());
        }

        private void vouchersTrigger_Click(object sender, EventArgs e)
        {
            app.open(new ListVouchers());
        }

        private void updateCostTrigger_Click(object sender, EventArgs e)
        {
            app.open(new UpdateCost());
        }

        private void profileOpenTrigger_Click(object sender, EventArgs e)
        {
            app.open(new Profile());
        }

        private void editProfileTrigger_Click(object sender, EventArgs e)
        {
            app.open(new EditProfile());
        }

        private void editProfileTrigger_Click_1(object sender, EventArgs e)
        {
            app.open(new EditProfile());
        }
    }
}
