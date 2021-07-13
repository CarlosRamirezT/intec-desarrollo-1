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
        private Moves vInformation;

        public MoveFormInformation()
        {
            InitializeComponent();
            vInformation = new Moves();
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("Source", "Source");
            dataGridView1.Columns.Add("Destination", "Destination");
            dataGridView1.Columns.Add("State", "State");
            LoadData();
        }

        public MoveFormInformation(Moves vData)
        {
            InitializeComponent();
            this.vInformation = vData;
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("Source", "Source");
            dataGridView1.Columns.Add("Destination", "Destination");
            dataGridView1.Columns.Add("State", "State");
            LoadData();
        }

        private void LoadGrid()
        {
            limpiarGrid();
            MoveLine[] theData = vInformation.Move_lines;

            for (int i = 0; i < theData.Length; i++)
            {
                dataGridView1.Rows.Add(new object[] { theData[i].Id, theData[i].Product.Name, theData[i].Qty, theData[i].Type, theData[i].Souce_location.Name, theData[i].Destination_location.Name, theData[i].State });
            }
        }

        private void limpiarGrid()
        {
            dataGridView1.DataSource = null;
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
            labelStatus.Text = vInformation.State;
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MoveFormView moveFormView = new MoveFormView();
            moveFormView.Show();
            this.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.vInformation.Unlink();
            MoveFormView moveFormView = new MoveFormView();
            moveFormView.Show();
            this.Visible = false;
        }
    }
}
