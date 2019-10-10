using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel
{
    public class TabPageModifyProductView : TabPage
    {
        public TabPageModifyProductView()
        {
            ControlProduct product = new ControlProduct();

            this.Text = "Modify";

            product.TxtId.Enabled = false;

            product.Btn.Name = "btnModify";
            product.Btn.Text = "Modify";

            this.Controls.Add(product);
        }
    }
}
