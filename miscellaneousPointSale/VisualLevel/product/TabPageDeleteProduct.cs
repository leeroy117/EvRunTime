using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel
{
    public class TabPageDeleteProduct : TabPage
    {
        public TabPageDeleteProduct()
        {
            ControlProduct product = new ControlProduct();

            this.Text = "Delete";

            product.TxtId.Enabled = true;
            product.TxtName.Enabled = false;
            product.TxtPrice.Enabled = false;
            product.TxtQuantity.Enabled = false;

            product.Btn.Name = "btnDelete";
            product.Btn.Text = "Delete";

            this.Controls.Add(product);
        }
    }
}
