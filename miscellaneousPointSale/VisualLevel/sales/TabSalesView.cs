using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualLevel.sales;

namespace VisualLevel
{
    class TabSalesView : TabControl
    {
        public TabSalesView()
        {
            this.Size = new System.Drawing.Size(300, 350);
            this.Location = new System.Drawing.Point(180, 20);

            this.TabPages.Add(new TabPageInsertSalesView());
            this.TabPages.Add(new TabPageModifySalesView());
            this.TabPages.Add(new TabPageDeleteSalesView());
        }
    }
}
