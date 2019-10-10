using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel
{
    class TabPageInsertProductView : TabPage
    {
        public TabPageInsertProductView()
        {
            ControlProduct controlProduct = new ControlProduct();

            this.Text = "Insert";

            controlProduct.TxtId.Enabled = false;
            controlProduct.Btn.Name = "btnInsert";
            controlProduct.Btn.Text = "Insert";
            
            this.Controls.Add(controlProduct);
        }
    }
}
