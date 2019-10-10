using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel.shopping
{
    class TabPageDeleteShoppingView : TabPage
    {
        public TabPageDeleteShoppingView()
        {
            ControlShopping controlShopping = new ControlShopping();

            this.Text = "Delete";

            controlShopping.TxtId.Enabled = false;
            controlShopping.TxtProduct.Enabled = false;
            controlShopping.TxtQuantity.Enabled = false;
            controlShopping.TxtSubtotal.Enabled = false;
            controlShopping.TxtTotal.Enabled = false;

            controlShopping.Btn.Name = "btnDelete";
            controlShopping.Btn.Text = "Delete";

            this.Controls.Add(controlShopping);
        }


    }
}
