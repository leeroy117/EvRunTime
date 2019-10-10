using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel
{
    public abstract class Display : Panel
    {
        
        public Display()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(250,300);
            //this.BackColor = new System.Drawing.Color();
            this.Location = new System.Drawing.Point(20,20);
        }
    }
}
