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
            loadData();
        }

        public ProductFormInformation(Product product)
        {
            InitializeComponent();
            this.product = product;
            loadData();
        }
        private void loadData()
        {
            labelId.Text = product.Id.ToString();
            labelname.Text = product.Name;
            labelcodigo.Text = product.Code;
            labelcantidaddisponible.Text = product.Available_qty.ToString() + " " + product.Unit;
            labelcantidadesperada.Text = product.Forecasted_qty.ToString() + " " + product.Unit;
            labelprecioventa.Text = product.Sales_price.ToString();
            labelpreciocompra.Text = product.Purchase_price.ToString();
            labeltipo.Text = product.Type;
            labelMinQty.Text = product.Min_qty.ToString() + " " + product.Unit;
            labelMaxQty.Text = product.Max_qty.ToString() + " " + product.Unit;
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.product.Unlink();
            ProductsListView vl = new ProductsListView();
            vl.Show();
            this.Visible = false;
        }
    }
}
