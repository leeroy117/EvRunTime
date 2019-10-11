using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualLevel.shopping;

namespace VisualLevel
{
    class TabShoppingView : TabControl
    {
        public TabShoppingView()
        {
            this.Size = new System.Drawing.Size(300, 350);
            this.Location = new System.Drawing.Point(180, 20);

            this.TabPages.Add(new TabPageInsertShoppingView());
            this.TabPages.Add(new TabPageModifyShoppingView());
            this.TabPages.Add(new TabPageDeleteShoppingView());            
        }
    
    }
}