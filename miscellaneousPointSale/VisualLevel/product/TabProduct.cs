using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel
{
    class TabProduct : TabControl
    {
        public TabProduct()
        {
            this.Size = new System.Drawing.Size(300, 350);
            this.Location = new System.Drawing.Point(180, 20);

            this.TabPages.Add(new TabPageInsertProduct());
            this.TabPages.Add(new TabPageModifyProduct());
            this.TabPages.Add(new TabPageDeleteProduct());
        }
    }
}
