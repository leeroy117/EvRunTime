using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLevel
{
    public class ControlProduct : Display
    {
        TextBox txtId = new TextBox();
        TextBox txtName = new TextBox();
        TextBox txtPrice = new TextBox();
        TextBox txtQuantity = new TextBox();

        Label[] lblNew = new Label[4];

        Button btn = new Button();

        public TextBox TxtName { get => txtName; set => txtName = value; }
        public TextBox TxtPrice { get => txtPrice; set => txtPrice = value; }
        public TextBox TxtQuantity { get => txtQuantity; set => txtQuantity = value; }
        public TextBox TxtId { get => txtId; set => txtId = value; }
        public Button Btn { get => btn; set => btn = value; }

        public ControlProduct()
        {

            //label ID
            lblNew[3] = new Label();
            lblNew[3].Text = "ID:";
            lblNew[3].Location = new System.Drawing.Point(10,20);
            lblNew[3].Width = 50;

            //label name of product
            lblNew[0] = new Label();

            lblNew[0].Text = "Name:";
            lblNew[0].Location = new System.Drawing.Point(10,50);
            lblNew[0].Width = 50;

            //label price of product
            lblNew[1] = new Label();

            lblNew[1].Text = "Price:";
           
            lblNew[1].Location = new System.Drawing.Point(10,80);
            lblNew[1].Width = 50;

            //label quantity of product
            lblNew[2] = new Label();

            lblNew[2].Text = "Quantity:";
            lblNew[2].Location = new System.Drawing.Point(10, 110);
            lblNew[2].Width = 50;

            //txt ID of product
            //txtNew[3] = new TextBox();

            //txtNew[3].Name = "txtIDProduct";
            //txtNew[3].Size = new System.Drawing.Size(50, 20);
            //txtNew[3].Location = new System.Drawing.Point(60, 20);

            txtId.Name = "txtIDProduct";
            txtId.Size = new System.Drawing.Size(50, 20);
            txtId.Location = new System.Drawing.Point(60, 20);

            //txt name of product
            
            txtName.Name = "txtNameProduct";
            txtName.Size = new System.Drawing.Size(150,30);
            txtName.Location = new System.Drawing.Point(60,50);

            //txt price of product
            txtPrice.Name = "txtPriceProduct";
            txtPrice.Size = new System.Drawing.Size(70, 30);
            txtPrice.Location = new System.Drawing.Point(60, 80);

            //txt quantity of product
            txtQuantity.Name = "txtPriceProduct";
            txtQuantity.Size = new System.Drawing.Size(70, 30);
            txtQuantity.Location = new System.Drawing.Point(60, 110);

            //btn add product
            //btnInsert.Name = "btnAddProduct";
            //btnInsert.Text = "Insert";
            btn.Location = new System.Drawing.Point(100, 130);

            //add control here
            //add labels
            this.Controls.Add(lblNew[3]); //label id
            this.Controls.Add(lblNew[0]); //label name
            this.Controls.Add(lblNew[1]); //label price
            this.Controls.Add(lblNew[2]); //label quantity

            //add textboxes
            this.Controls.Add(txtId); //txt id
            this.Controls.Add(txtName); //txt name
            this.Controls.Add(txtPrice); //txt price
            this.Controls.Add(txtQuantity); //txt quantity

            //add buttons
            this.Controls.Add(btn); //btn add


        }

        
    }
}
