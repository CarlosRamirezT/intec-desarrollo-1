using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_inventario.models
{
    public class Locations : Conection
    {

        private static List<Locations> Locationss_table = new List<Locations>() { 
            new Locations(1, "Stock Locations", "Internal"),
            new Locations(2, "Scrap Locations", "Waste"),
            new Locations(3, "Customer Locations", "Customer"),
            new Locations(4, "Supplier Locations", "Supplier"),
        };

        private int _id;
        private string _name;
        private string _type;

        public Locations()
        {
        }

        public Locations(int id, string name, string type)
        {
            this._id = id;
            this._name = name;
            this._type = type;
        }

        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }

        public double Current_stock {
            get {
                MoveLine[] lines = MoveLine.Search(this);
                double result = 0;
                foreach(MoveLine line in lines)
                {
                    if(line.Destination_location.Id == this.Id)
                    {
                        result += line.Qty;
                    }
                    else if(line.Souce_location.Id == this.Id)
                    {
                        result -= line.Qty;
                    }
                }
                return result;
            }
        }
        public int Id { get => _id; set => _id = value; }

        public static Locations Browse(int id)
        {
            Locations result = new Locations();
            foreach (Locations Locations in Locationss_table)
            {
                if (Locations.Id == id)
                {
                    result = Locations;
                    break;
                }
            }
            return result;
        }

        public static Locations[] Browse()
        {
            return Locationss_table.ToArray();
        }

        public override void Create()
        {
            Locationss_table.Add(this);
        }

        public static Locations[] Search(string name)
        {
            List<Locations> result = new List<Locations>();
            foreach (Locations Locations in Locationss_table)
            {
                if (Locations.Name == name)
                {
                    result.Add(Locations);
                }
            }
            return result.ToArray();
        }

        public override void Unlink()
        {
            Locationss_table.Remove(this);
        }

        public override void Write()
        {
            int index = Locationss_table.FindIndex(a => a.Id == this.Id);
            Locationss_table[index] = this;
        }
    }
}
