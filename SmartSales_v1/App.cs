using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SmartSales_v1
{
   class App
    {



        private readonly Random _random = new Random();
        public Dictionary<string, string> objects = new Dictionary<string, string>();

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

            }catch(Exception ex)
            {
                this.showError(ex.Message);
            }
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
        public void notifyTo(Label label, string message, string type)
        {
            label.Text = message;
            if (type == "success")
                label.ForeColor =Color.Green;
            if (type == "warning")
                label.ForeColor = Color.Red;
            if (type == "error")
                label.ForeColor = Color.Red;
        }

    }
}
