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
    public partial class MoveFormInformation : Form
    {
        private Move vInformation;

        public MoveFormInformation()
        {
            InitializeComponent();
            LoadData();
        }

        public MoveFormInformation(Move vData)
        {
            InitializeComponent();
            this.vInformation = vData;
            LoadData();
            
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

        private void LoadData()
        {
            labelNombreContent.Text = vInformation.Id.ToString();
            labelTipoContent.Text = vInformation.Type;
            labelFechaContent.Text = vInformation.Schedule_date.ToString();
            labelContactoContent.Text = vInformation.Contact;
            labelOrigenContent.Text = vInformation.Source_location.Name;
            labelDireccionContent.Text = vInformation.Contact_address;
            labelDestinoContent.Text = vInformation.Destination_location.Name;
            LoadGrid();
        }

       

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            MoveFormEditable vCreate = new MoveFormEditable();
            vCreate.Show();
            this.Visible = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MoveFormEditable vCreate = new MoveFormEditable(vInformation);
            vCreate.Show();
            this.Visible = false;
        }

        
    }
}
