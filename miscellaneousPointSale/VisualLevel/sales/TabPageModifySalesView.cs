using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualLevel.shopping;

namespace VisualLevel.sales
{
    class TabPageModifySalesView : TabPage
    {
        public TabPageModifySalesView()
        {
            ControlSales controlSales = new ControlSales();

            this.Text = "Modify";

            controlSales.TxtId.Enabled = false;

            controlSales.Btn.Name = "btnModify";
            controlSales.Btn.Text = "Modify";

            this.Controls.Add(controlSales);
        }
    }
}
