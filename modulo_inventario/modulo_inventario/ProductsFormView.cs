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
        public vatras()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ProductsFormView_Load(object sender, EventArgs e)
        {

        }
        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            txtcantidad.Text = "";
            txtcodigo.Text = "";
            
            btsave.Enabled = true;
  
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            Form1 vVolver = new Form1();
            vVolver.Show();
            this.Visible = false;
        }

        private void vatras_Load(object sender, EventArgs e)
        {

        }
    }
}
