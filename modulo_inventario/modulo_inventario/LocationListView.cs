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
    public partial class LocationListView : Form
    {
        public LocationListView()
        {
            InitializeComponent();
            loadGrid();
        }

        private void loadGrid()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Type", "Type");
            Locations[] locations = Locations.Browse();
            for (int i = 0; i < locations.Length; i++)
            {
                dataGridView1.Rows.Add(new object[] { locations[i].Id, locations[i].Name, locations[i].Type });
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            LocationFormEditable locationFormEditable = new LocationFormEditable();
            locationFormEditable.Show();
            this.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["ID"].Value.ToString());
                Locations location = Locations.Browse(id);
                LocationFormInformation vCreate = new LocationFormInformation(location);
                vCreate.Show();
                this.Visible = false;
            }
        }
    }
}
