using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel.sales
{
    class TabPageInsertSalesView : TabPage
    {
        public TabPageInsertSalesView()
        {
            ControlSales controlSales = new ControlSales();

            this.Text = "Insert";

            controlSales.TxtId.Enabled = false;
            controlSales.Btn.Name = "btnInsert";
            controlSales.Btn.Text = "Insert";

            this.Controls.Add(controlSales);
        }
    }
}
