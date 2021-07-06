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
    public partial class LocationFormEditable : Form
    {
        private Locations location;
        public LocationFormEditable()
        {
            InitializeComponent();
            this.location = new Locations();
        }
        public LocationFormEditable(Locations location)
        {
            InitializeComponent();
            this.location = location;
            loadData();
        }

        private void loadData()
        {
            textBoxName.Text = location.Name;
            textBoxType.Text = location.Type;
        }

        private void LocationFormEditable_Load(object sender, EventArgs e)
        {
            Locations new_location = new Locations(
                textBoxName.Text,
                textBoxType.Text
            );
            if (location.Id >= 0)
            {
                new_location.Id = location.Id;
                new_location.Write();                
            }
            else
            {
                new_location.Create();
            }
            LocationFormInformation locationFormInformation = new LocationFormInformation(new_location);
            locationFormInformation.Show();
            this.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (location.Id >= 0)
            {
                LocationFormInformation locationFormInformation = new LocationFormInformation(location);
                locationFormInformation.Show();
                this.Visible = false;
            }
            else
            {
                LocationListView locationListView = new LocationListView();
                locationListView.Show();
                this.Visible = false;
            }
            
        }
    }
}
