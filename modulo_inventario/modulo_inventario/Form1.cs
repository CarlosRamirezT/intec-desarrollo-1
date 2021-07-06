using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modulo_inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            ProductsListView productsListView = new ProductsListView();
            productsListView.Show();
            this.Visible = false;
        }

        private void buttonLocations_Click(object sender, EventArgs e)
        {
            LocationListView locationListView = new LocationListView();
            locationListView.Show();
            this.Visible = false;
        }

        private void buttonMoves_Click(object sender, EventArgs e)
        {
            MoveFormView moveFormView = new MoveFormView();
            moveFormView.Show();
            this.Visible = false;
        }
    }
}
