using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSales_v1
{
    class App
    {
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
