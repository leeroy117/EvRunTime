﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualLevel;

namespace VisualLevel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(new Table());
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            this.Controls.Add(new TabProductView());
        }

        private void BtnShopping_Click(object sender, EventArgs e)
        {
            this.Controls.Add(new TabShoppingView());
        }
    }
}
