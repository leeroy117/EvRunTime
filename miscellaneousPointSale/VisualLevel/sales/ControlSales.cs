using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel.sales
{
    class ControlSales : Display
    {
        TextBox txtId = new TextBox();
        TextBox txtProduct = new TextBox();
        TextBox txtSubtotal = new TextBox();
        TextBox txtTotal = new TextBox();
        TextBox txtQuantity = new TextBox();
        Label[] lblNew = new Label[5];
        Button btn = new Button();

        public TextBox TxtId { get => txtId; set => txtId = value; }
        public TextBox TxtProduct { get => txtProduct; set => txtProduct = value; }
        public TextBox TxtSubtotal { get => txtSubtotal; set => txtSubtotal = value; }
        public TextBox TxtTotal { get => txtTotal; set => txtTotal = value; }
        public TextBox TxtQuantity { get => txtQuantity; set => txtQuantity = value; }
        public Button Btn { get => btn; set => btn = value; }

        public ControlSales()
        {

            //label ID
            lblNew[0] = new Label();
            lblNew[0].Text = "ID:";
            lblNew[0].Location = new System.Drawing.Point(10, 20);
            lblNew[0].Width = 50;

            //label name of product
            lblNew[1] = new Label();
            lblNew[1].Text = "Product:";
            lblNew[1].Location = new System.Drawing.Point(10, 50);
            lblNew[1].Width = 50;

            //label quantity of product
            lblNew[2] = new Label();
            lblNew[2].Text = "Quantity:";
            lblNew[2].Location = new System.Drawing.Point(10, 80);
            lblNew[2].Width = 50;

            //label subtotal of product
            lblNew[3] = new Label();
            lblNew[3].Text = "Subtotal:";
            lblNew[3].Location = new System.Drawing.Point(10, 110);
            lblNew[3].Width = 50;

            //label total of product
            lblNew[4] = new Label();
            lblNew[4].Text = "Total:";
            lblNew[4].Location = new System.Drawing.Point(10, 140);
            lblNew[4].Width = 50;

            //txt ID of product

            txtId.Name = "txtID";
            txtId.Size = new System.Drawing.Size(50, 20);
            txtId.Location = new System.Drawing.Point(60, 20);

            //txt name of product

            txtProduct.Name = "txtProduct";
            txtProduct.Size = new System.Drawing.Size(150, 30);
            txtProduct.Location = new System.Drawing.Point(60, 50);

            //txt quantity of product
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(70, 30);
            txtQuantity.Location = new System.Drawing.Point(60, 80);

            //txt subtotal of product
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new System.Drawing.Size(70, 30);
            txtSubtotal.Location = new System.Drawing.Point(60, 110);

            //txt total of product
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(70, 30);
            txtTotal.Location = new System.Drawing.Point(60, 140);

            btn.Location = new System.Drawing.Point(100, 170);

            //add control here
            //add labels
            this.Controls.Add(lblNew[0]); //label id
            this.Controls.Add(lblNew[1]); //label product
            this.Controls.Add(lblNew[2]); //label quantity
            this.Controls.Add(lblNew[3]); //label subtotal
            this.Controls.Add(lblNew[4]); //label total


            //add textboxes
            this.Controls.Add(txtId); //txt id
            this.Controls.Add(txtProduct); //txt name
            this.Controls.Add(txtSubtotal); //txt subtotal
            this.Controls.Add(txtTotal); //txt total
            this.Controls.Add(txtQuantity); //txt quantity

            //add buttons
            this.Controls.Add(btn); //btn add
        }
    }
}
