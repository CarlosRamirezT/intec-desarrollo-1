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
    public partial class vatras : Form
    {

        private Product product;

        public vatras()
        {
            InitializeComponent();
        }

        public vatras(Product product)
        {
            InitializeComponent();
            this.product = product;
            loadValues();
        }

        private void loadValues()
        {
            textboxName.Text = product.Name;
            textboxCodigo.Text = product.Code;
            textboxType.Text = product.Type;
            textboxPurchasePrice.Text = product.Purchase_price.ToString();
            textBoxSalePrice.Text = product.Sales_price.ToString();
            labelCantidadAvailable.Text = product.Available_qty.ToString();
            labelCantidadForecasted.Text = product.Forecasted_qty.ToString();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product(
                textboxName.Text.ToString(),
                textboxType.Text.ToString(),
                textboxCodigo.Text.ToString(),
                double.Parse(textBoxSalePrice.Text.ToString()),
                double.Parse(textboxPurchasePrice.Text.ToString())
            );
            if (product.Id >= 0)
            {
                newProduct.Id = product.Id;
                newProduct.Write();
                ProductFormInformation productFormInformation = new ProductFormInformation(newProduct);
                productFormInformation.Show();
                this.Visible = false;
            }
            else
            {
                ProductsListView productsListView = new ProductsListView();
                productsListView.Show();
                this.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductsListView productsListView = new ProductsListView();
            productsListView.Show();
            this.Visible = false;
        }

    }
}
