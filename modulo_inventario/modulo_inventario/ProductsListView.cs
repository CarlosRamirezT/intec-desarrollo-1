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
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("code", "code");
            dataGridView1.Columns.Add("name", "name");
            dataGridView1.Columns.Add("type", "type");        
            dataGridView1.Columns.Add("Sales_Price", "Sales_Price");
            dataGridView1.Columns.Add("purchase_price;", "purchase_price");
            dataGridView1.Columns.Add("unit;", "Unit");
            llenargrid(Product.Browse());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["ID"].Value.ToString());
                Product product = Product.Browse(id);
                ProductFormInformation vCreate = new ProductFormInformation(product);
                vCreate.Show();
                this.Visible = false;
            }
        }

        private void limpiarGrid()
        {
            dataGridView1.Rows.Clear();
        }

        private void llenargrid(Product[] vy )
        {
            limpiarGrid();
            for (int i = 0; i < vy.Length; i++)
            {
                dataGridView1.Rows.Add(new object[] { vy[i].Id, vy[i].Code, vy[i].Name, vy[i].Type, vy[i].Sales_price, vy[i].Purchase_price, vy[i].Unit});
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vatras vx = new vatras();
            vx.Show();
            this.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 vx = new Form1();
            vx.Show();
            this.Visible = false;
        }
        private void btbuscar_Click(object sender, EventArgs e)
        {
            string vbuscar = txtnom.Text.ToString();
            Product[] vpy;
            if (vbuscar == "")
            {
                vpy = Product.Browse();
            }
            else
            {
                vpy = Product.Search(vbuscar);
            }
            llenargrid(vpy);
        }
    }
}
