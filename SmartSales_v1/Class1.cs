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
     
    }
       }
