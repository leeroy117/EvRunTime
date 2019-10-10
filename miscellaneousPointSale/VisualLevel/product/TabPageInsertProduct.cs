using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel
{
    class TabPageInsertProduct : TabPage
    {
        public TabPageInsertProduct()
        {
            ControlProduct product = new ControlProduct();

            this.Text = "Insert";

            product.TxtId.Enabled = false;

            product.Btn.Name = "btnInsert";
            product.Btn.Text = "Insert";
            
            this.Controls.Add(product);
        }
    }
}
