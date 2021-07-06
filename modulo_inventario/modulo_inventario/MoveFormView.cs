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
    public partial class MoveFormView : Form
    {
        public MoveFormView()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Contacto", "Contacto");
            dataGridView1.Columns.Add("Fecha", "Fecha");
            dataGridView1.Columns.Add("Source", "Source");
            dataGridView1.Columns.Add("Destination", "Destination");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            LoadGrid(Moves.Browse());
        }

        private void LoadGrid(Moves[] moves)
        {


            for (int i = 0; i < moves.Length; i++)
            {
                dataGridView1.Rows.Add(new object[] { moves[i].Id, moves[i].Contact, moves[i].Schedule_date, moves[i].Source_location, moves[i].Destination_location.Name, moves[i].Type });
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form1 vInicio = new Form1();
            vInicio.Show();
            this.Visible = false;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            MoveFormEditable vCreate = new MoveFormEditable();
            vCreate.Show();
            this.Visible = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string vBarra = textBoxSearchBar.Text.ToString();
            Moves[] moves = Moves.Search(vBarra);
            LoadGrid(moves);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["ID"].Value.ToString());
                Moves move = Moves.Browse(id);
                MoveFormInformation vCreate = new MoveFormInformation(move);
                vCreate.Show();
                this.Visible = false;


            }
        }
    }
}
