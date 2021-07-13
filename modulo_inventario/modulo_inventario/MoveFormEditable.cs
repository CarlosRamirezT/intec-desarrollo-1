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
            prepareView();
            vInformation = new Moves();
        }

        public MoveFormEditable(Moves vData)
        {
            InitializeComponent();
            this.vInformation = vData;
            prepareView();
            MoveLine[] theData = vInformation.Move_lines;
            LoadData();
        }

        private void prepareView()
        {
            
            comboBoxType.Items.Add("receipt");
            comboBoxType.Items.Add("internal");
            comboBoxType.Items.Add("waste");
            comboBoxType.Items.Add("customer");

            Locations[] locations = Locations.Browse();
            foreach (Locations location in locations)
            {
                comboBoxSource.Items.Add(location.Name);
                comboBoxDestination.Items.Add(location.Name);
            }


            comboBoxState.Items.Add("draft");
            comboBoxState.Items.Add("waiting");
            comboBoxState.Items.Add("recerved");
            comboBoxState.Items.Add("delivering");
            comboBoxState.Items.Add("done");

            dataGridView1.Columns.Add("ID", "ID");

            Product[] products = Product.Browse();
            DataGridViewComboBoxColumn comboProduct = new DataGridViewComboBoxColumn();
            comboProduct.HeaderText = "Product";
            comboProduct.Name = "comboProduct";
            foreach (Product product in products)
            {
                comboProduct.Items.Add(product.Name);
            }
            dataGridView1.Columns.Add(comboProduct);

            dataGridView1.Columns.Add("Cantidad", "Cantidad");
        }

        private void LoadData()
        {
            textBoxID.Text = vInformation.Id.ToString();
            comboBoxType.Text = vInformation.Type;
            textBoxFecha.Text = vInformation.Schedule_date.ToString();
            textBoxContacto.Text = vInformation.Contact;
            comboBoxSource.Text = vInformation.Source_location.Name;
            textBoxDireccion.Text = vInformation.Contact_address;
            comboBoxDestination.Text = vInformation.Destination_location.Name;
            comboBoxState.Text = vInformation.State;
            LoadGrid();
        }

        private void LoadGrid()
        {
            limpiarGrid();
            MoveLine[] theData = vInformation.Move_lines;
            for (int i = 0; i < theData.Length; i++)
            {
                dataGridView1.Rows.Add(new object[] { theData[i].Id, theData[i].Product.Name, theData[i].Qty});
            }
        }

        private void limpiarGrid()
        {
            dataGridView1.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(vInformation.Id >= 0)
            {
                MoveFormInformation moveFormInformation = new MoveFormInformation(vInformation);
                moveFormInformation.Show();
                this.Visible = false;
            }
            else
            {
                MoveFormView moveFormView = new MoveFormView();
                moveFormView.Show();
                this.Visible = false;
            }
            
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
                textBoxContacto.Text.ToString(), 
                textBoxDireccion.Text.ToString(),
                comboBoxType.Text.ToString(),
                Locations.Search(comboBoxSource.Text.ToString())[0],
                Locations.Search(comboBoxDestination.Text.ToString())[0],
                DateTime.Parse(textBoxFecha.Text.ToString()),
                comboBoxState.Text.ToString()
            );
            List<MoveLine> move_lines = new List<MoveLine>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    MoveLine move_line = new MoveLine(
                        vMove,
                        Product.Search(row.Cells[1].Value.ToString())[0],
                        double.Parse(row.Cells[2].Value.ToString()),
                        vMove.Type,
                        vMove.Source_location,
                        vMove.Destination_location,
                        vMove.State
                    );
                    if(row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "")
                    {
                        move_line.Id = int.Parse(row.Cells[0].Value.ToString());
                    }
                    move_lines.Add(move_line);
                }
            }
            if (vInformation != null && vInformation.Id > 0){
                vMove.Id = vInformation.Id;
                vMove.Write();
                foreach (MoveLine line in move_lines)
                {
                    line.Move_id = vMove;
                    if (line.Id > 0)
                    {
                        line.Write();
                    }
                    else
                    {
                        line.Create();
                    }
                }
                MoveFormInformation vCreate = new MoveFormInformation(vMove);
                vCreate.Show();
                this.Visible = false;
            }
            else
            {
                int id = vMove.Create();
                vMove.Id = id;
                foreach (MoveLine line in move_lines)
                {
                    line.Move_id = vMove;
                    Console.WriteLine(line.Create());
                }
                MoveFormView moveFormView = new MoveFormView();
                moveFormView.Show();
                this.Visible = false;
            }
        }
    }
}
