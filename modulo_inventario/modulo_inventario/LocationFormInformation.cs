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
    public partial class LocationFormInformation : Form
    {
        private Locations location;
        public LocationFormInformation()
        {
            InitializeComponent();
        }
        public LocationFormInformation(Locations location)
        {
            InitializeComponent();
            this.location = location;
            loadData();
        }

        private void loadData()
        {
            labelID.Text = location.Id.ToString();
            labelNameContent.Text = location.Name;
            labelType.Text = location.Type;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            LocationFormEditable locationFormEditable = new LocationFormEditable(location);
            locationFormEditable.Show();
            this.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            LocationListView locationListView = new LocationListView();
            locationListView.Show();
            this.Visible = false;
        }
    }
}
