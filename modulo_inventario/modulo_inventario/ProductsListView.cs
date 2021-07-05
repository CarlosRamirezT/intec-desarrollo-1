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
    public partial class ProductsListView : Form
    {
        public ProductsListView()
        {
            InitializeComponent();
            llenargrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void llenargrid()
        {
            Product[] vy = Product.Browse();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("name", "name");
            dataGridView1.Columns.Add("type", "type");
            dataGridView1.Columns.Add("code", "code");
            dataGridView1.Columns.Add("Sales_Price", "Sales_Price");
            dataGridView1.Columns.Add("purchase_price;", "purchase_price;");

            for (int i = 0; i < vy.Length; i++)
            {
                dataGridView1.Rows.Add(new object[] { vy[i].Id,vy[i].Name, vy[i].Type, vy[i].Code, vy[i].Sales_price, vy[i].Purchase_price});
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 vx = new Form1();
            vx.Show();
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
