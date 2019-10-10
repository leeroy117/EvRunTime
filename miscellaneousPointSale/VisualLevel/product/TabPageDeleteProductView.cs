using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel
{
    public class TabPageDeleteProductView : TabPage
    {
        public TabPageDeleteProductView()
        {
            ControlProduct controlProduct = new ControlProduct();

            this.Text = "Delete";

            controlProduct.TxtId.Enabled = true;
            controlProduct.TxtName.Enabled = false;
            controlProduct.TxtPrice.Enabled = false;
            controlProduct.TxtQuantity.Enabled = false;

            controlProduct.Btn.Name = "btnDelete";
            controlProduct.Btn.Text = "Delete";

            this.Controls.Add(controlProduct);
        }
    }
}
