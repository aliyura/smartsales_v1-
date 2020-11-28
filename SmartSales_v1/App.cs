using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Globalization;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace SmartSales_v1
{
    class App
    {

        private readonly Random _random = new Random();
        public Dictionary<string, string> objects = new Dictionary<string, string>();
        string  session = "session.st";
        List<string> listedItems= new List<string>();
        ListView customDropdown = new ListView();
        TextBox currentTextBox;

        public App()
        {

            try
            {
                //register all database objects
                objects.Add("logs", "ss_logs");
                objects.Add("users", "ss_users");
                objects.Add("banks", "ss_banks");
                objects.Add("batches", "ss_batches");
                objects.Add("products", "ss_products");
                objects.Add("stocks", "ss_stocks");
                objects.Add("locations", "ss_locations");
                objects.Add("customers", "ss_customers");
                objects.Add("groups", "ss_customer_groups");
                objects.Add("sales", "ss_sales");
                objects.Add("sale_details", "ss_sale_details");
                objects.Add("cart", "ss_cart");
                objects.Add("debtors", "ss_debtors");
                objects.Add("payments", "ss_payments");
                objects.Add("adjustments", "ss_adjustments");
                objects.Add("vouchers", "ss_vouchers");
                objects.Add("voucher_categories", "ss_voucher_categories");
                objects.Add("account", "ss_account");
                objects.Add("business", "ss_business");



            }
            catch (Exception ex)
            {
                this.showError(ex.Message);
            }
        }


        public  bool Connected()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetMacAddress()
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                string tempMac = nic.GetPhysicalAddress().ToString();
                if (nic.Speed > maxSpeed &&
                    !string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                {
                    maxSpeed = nic.Speed;
                    macAddress = tempMac;
                }
            }

            return macAddress;
        }
        public  string toWordsOf(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + toWordsOf(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += toWordsOf(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += toWordsOf(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += toWordsOf(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public  string toMoneyOf(int value)
        {
            string val = value.ToString("C", CultureInfo.CurrentCulture);
            val = val.Replace("$", "");
            val = val.Substring(0, val.IndexOf("."));
            return val.Replace(".",",");
        }

        public int toDecimalOf(string value)
        {
            value= String.Concat(value.Split(','));
            return int.Parse(value);
        }

        private void onMouseLeave(object sender, EventArgs e)
        {
            ListView soggestedList = (sender as ListView);
            soggestedList.Clear();
            soggestedList.Hide();

        }
         private void onSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                ListView soggestedList = (sender as ListView);
                if (soggestedList.SelectedItems.Count > 0)
                {
                    if (currentTextBox != null)
                    {
                        currentTextBox.Text = soggestedList.SelectedItems[0].Text;
                        soggestedList.Hide();
                    }

                }
                else
                {
                    soggestedList.Hide();
                }
            }catch(Exception ex)
            {
                this.showWarning(ex.Message);
            }

        }

        public void buildDropdown( Form currentForm, Object sender, Panel panel, string source)
        {
            TextBox textBox = (sender as TextBox);
            SSGetService getService = new SSGetService();
           
            currentTextBox = textBox;


            if (!listedItems.Contains(textBox.Text) && textBox.Text.Length > 1)
            {
                customDropdown.HideSelection = false;
                customDropdown.Margin = new Padding(5);
                customDropdown.Size = new Size(panel.Width, 97);
                customDropdown.Sorting = SortOrder.Ascending;
                customDropdown.TabIndex = 58;
                customDropdown.TileSize = new Size(panel.Width, 25);
                customDropdown.UseCompatibleStateImageBehavior = false;
                customDropdown.View = View.Tile;
                customDropdown.Location = new Point(panel.Location.X, panel.Location.Y + (panel.Height));
                customDropdown.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(onSelectedIndexChanged);
                customDropdown.MouseLeave += new EventHandler(onMouseLeave);
                customDropdown.Hide();
               

                if (textBox.Text != "" && textBox.Text != null)
                {
                    try
                    {
                        DataTable data = getService.searchDataFrom(this.objects[source], textBox.Text);
                       
                        if (data.Rows.Count > 0)
                        {
                            customDropdown.Clear();
                            currentForm.Controls.Add(customDropdown);
                            customDropdown.BringToFront();
                            customDropdown.Show();

                            foreach (DataRow row in data.Rows)
                            {
                                string name = row.Field<string>("name");
                                listedItems.Add(name);
                                customDropdown.Items.Add(name);
                            }
    
                        }
                        else
                        {
                            customDropdown.Hide();
                            currentForm.Controls.Remove(customDropdown);

                        }
                    }
                    catch (Exception ex)
                    {
                        this.showError(ex.Message);
                    }
                }
                else
                {
                    customDropdown.Hide();
                    currentForm.Controls.Remove(customDropdown);
                }
            }
            else
            {
                customDropdown.Hide();
                currentForm.Controls.Remove(customDropdown);
            }
        }

        public void buildSalesDropdown(Form currentForm, Object sender, Panel panel, string source)
        {
            TextBox textBox = (sender as TextBox);
            SSGetService getService = new SSGetService();
            currentTextBox = textBox;


            if (!listedItems.Contains(textBox.Text) && textBox.Text.Length > 1)
            {
                customDropdown.HideSelection = false;
                customDropdown.Margin = new Padding(5);
                customDropdown.Size = new Size(panel.Width, 97);
                customDropdown.Sorting = SortOrder.Ascending;
                customDropdown.TabIndex = 58;
                customDropdown.TileSize = new Size(panel.Width, 25);
                customDropdown.UseCompatibleStateImageBehavior = false;
                customDropdown.View = View.Tile;
                customDropdown.Location = new Point(panel.Location.X + 18, panel.Location.Y + (panel.Height * 3) - 11);
                customDropdown.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(onSelectedIndexChanged);
                customDropdown.MouseLeave += new EventHandler(onMouseLeave);
                customDropdown.Hide();


                if (textBox.Text != "" && textBox.Text != null)
                {
                    try
                    {
                        DataTable data = getService.searchDataFrom(this.objects[source], textBox.Text);

                        if (data.Rows.Count > 0)
                        {
                            customDropdown.Clear();
                            currentForm.Controls.Add(customDropdown);
                            customDropdown.BringToFront();
                            customDropdown.Show();

                            foreach (DataRow row in data.Rows)
                            {
                                string name = row.Field<string>("name");
                                listedItems.Add(name);
                                customDropdown.Items.Add(name);
                            }

                        }
                        else
                        {
                            customDropdown.Hide();
                            currentForm.Controls.Remove(customDropdown);

                        }
                    }
                    catch (Exception ex)
                    {
                        this.showError(ex.Message);
                    }
                }
                else
                {
                    customDropdown.Hide();
                    currentForm.Controls.Remove(customDropdown);
                }
            }
            else
            {
                customDropdown.Hide();
                currentForm.Controls.Remove(customDropdown);
            }
        }
        public void setSession(User user)
        {
            try
            {
                string sessionData=  user.id+"," + user.bid + "," + user.name+","+ user.username + "," + user.role+ "," + user.picture;
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                File.WriteAllText(path+"/"+this.session, sessionData.Trim());
            }
            catch(Exception ex)
            {
                this.showError(ex.Message);
            }
        }

        public User getSession()
        {

            User user = new User();

            try
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string userData = File.ReadAllText(path + "/" + this.session);
                string []sessionData = userData.Split(',');

                user.id = int.Parse(sessionData[0]);
                user.bid = int.Parse(sessionData[1]);
                user.name = sessionData[2];
                user.username = sessionData[3];
                user.role = sessionData[4];
                user.password = "********";

                if (sessionData[5] != null && sessionData[5] != "") {
                    byte[] bytes = Encoding.ASCII.GetBytes(sessionData[5]);
                    user.picture = bytes;
                }

                return user;
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return user;
            }
           
        }
   

        public void open(Form form)
        {
            form.ShowDialog();
        }
        public void redirect(Form from, Form to)
        {
            from.Hide();
            to.ShowDialog();
            from.Close();
        }

        public bool isAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public int genetareNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        public string generateId(int size, bool lowerCase = true)
        {
            var builder = new StringBuilder(size);
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26;

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }
            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        public void showError(string message)
        {
            MessageBox.Show(message, "Smart Sales", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void showWarning(string message)
        {
            MessageBox.Show(message, "Smart Sales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void showSuccess(string message)
        {
            MessageBox.Show(message, "Smart Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public  void clearNotification(Label label)
        {
            if(label.InvokeRequired)
                label.Invoke(new Action(() =>
                {
                    label.Text = "";
                }));
           
        }
        public void notifyTo(Label label, string message, string type)
        {
            label.Text = message;
            if (type == "success")
                label.ForeColor = Color.Green;
            if (type == "warning")
                label.ForeColor = Color.DarkGoldenrod;
            if (type == "error")
                label.ForeColor = Color.Red;

       
            var task = Task.Run(() => clearNotification(label));
            task.Wait(TimeSpan.FromSeconds(2));

        }

    }
}
