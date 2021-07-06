using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modulo_inventario.models;

namespace modulo_inventario
{
    public partial class ProductFormInformation : Form
    {
        private Product product;

        public ProductFormInformation()
        {
            InitializeComponent();
        }
        public ProductFormInformation(Product product)
        {
            InitializeComponent();
            this.product = product;

        }
        private void loiddata()
        {
            labelname.Text = product.Name;
            labelidcontenido.Text = product.Id.ToString();
            labelcodigo.Text = product.Code;
            labelcantidad.Text = product.Available_qty.ToString();
            labelprecioventa.Text = product.Sales_price.ToString();
            labelpreciocompra.Text = product.Purchase_price.ToString();

        }


        private void ProductFormInformation_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vatras vtr = new vatras();
            vtr.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductsListView vl = new ProductsListView();
            vl.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vatras vtr = new vatras(product);
            vtr.Show();
            this.Visible = false;
        }
    }
}
