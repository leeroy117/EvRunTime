using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel.shopping
{
    class TapPageInsertShoppingView : TabPage
    {
        public TapPageInsertShoppingView()
        {
            ControlShopping controlShopping = new ControlShopping();

            this.Text = "Insert";

            controlShopping.TxtId.Enabled = false;
            controlShopping.Btn.Name = "btnInsert";
            controlShopping.Btn.Text = "Insert";

            this.Controls.Add(controlShopping);
        }
    }
}
