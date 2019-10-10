using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel
{
    public class Table : DataGridView
    {
        public Table()
        {
            this.Size = new System.Drawing.Size(350,320);
            this.Location = new System.Drawing.Point(500, 30);
        }
    }
}
