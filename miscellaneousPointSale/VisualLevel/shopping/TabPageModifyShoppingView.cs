using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel.shopping
{
    class TabPageModifyShoppingView : TabPage
    {
        public TabPageModifyShoppingView()
        {
            ControlShopping controlShopping = new ControlShopping();

            this.Text = "Modify";

            controlShopping.TxtId.Enabled = false;

            controlShopping.Btn.Name = "btnModify";
            controlShopping.Btn.Text = "Modify";

            this.Controls.Add(controlShopping);
        }
    }
}
