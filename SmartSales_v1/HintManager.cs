using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSales_v1
{
    class Hint
    {
        public void manageHint(TextBox textbox, int eventType, string defaultText)
        {
            string text = textbox.Text;

            if (eventType == 0)
            {
                if (text == "")
                {
                    textbox.Text = defaultText;
                }
            }
            else
            {
                if (text == defaultText)
                {
                    textbox.Clear();
                }
            }

        }
        public void manageComboHint(ComboBox comboBox, int eventType, string defaultText)
        {
            string text = comboBox.Text;

            if (eventType == 0)
            {
                if (text == "")
                {
                    comboBox.Text = defaultText;
                }
            }
            else
            {
                if (text == defaultText)
                {
                    comboBox.Text = "";
                }
            }

        }

    }
       }
