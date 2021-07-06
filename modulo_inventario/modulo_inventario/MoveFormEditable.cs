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
    public partial class MoveFormEditable : Form
    {
        private Moves vInformation;

        public MoveFormEditable()
        {
            InitializeComponent();
        }

        public MoveFormEditable(Moves vData)
        {
            InitializeComponent();
            this.vInformation = vData;
            LoadData();

        }

        private void LoadData()
        {
            textBoxID.Text = vInformation.Id.ToString();
            textBoxTipo.Text = vInformation.Type;
            textBoxFecha.Text = vInformation.Schedule_date.ToString();
            textBoxContacto.Text = vInformation.Contact;
            textBoxOrigen.Text = vInformation.Source_location.Name;
            textBoxDireccion.Text = vInformation.Contact_address;
            textBoxDestino.Text = vInformation.Destination_location.Name;
            LoadGrid();
        }

        private void LoadGrid()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("Source", "Source");
            dataGridView1.Columns.Add("Destination", "Destination");
            dataGridView1.Columns.Add("State", "State");
            MoveLine[] theData = vInformation.Move_lines;

            for (int i = 0; i < theData.Length; i++)
            {
                dataGridView1.Rows.Add(new object[] { theData[i].Id, theData[i].Product, theData[i].Qty, theData[i].Type, theData[i].Souce_location.Name, theData[i].Destination_location.Name, theData[i].State });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Moves vMove = new Moves(
                int.Parse(textBoxID.Text.ToString()), 
                textBoxContacto.Text.ToString(), 
                textBoxDestino.Text.ToString(), 
                textBoxTipo.Text.ToString(),
                Locations.Search(textBoxOrigen.Text.ToString())[0],
                Locations.Search(textBoxDestino.Text.ToString())[0],
                DateTime.Parse(textBoxFecha.Text.ToString()),
                new MoveLine[] { });

            vMove.Write();
            MoveFormInformation vCreate = new MoveFormInformation(vMove);
            vCreate.Show();
            this.Visible = false;


        }
    }
}
