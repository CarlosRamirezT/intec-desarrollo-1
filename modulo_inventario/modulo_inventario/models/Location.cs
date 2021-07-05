using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_inventario.models
{
    class Location : Conection
    {

        private static List<Location> locations_table = new List<Location>() { 
            new Location(1, "Stock Location", "Internal"),
            new Location(2, "Scrap Location", "Waste"),
            new Location(3, "Customer Location", "Customer"),
            new Location(4, "Supplier Location", "Supplier"),
        };

        private int _id;
        private string _name;
        private string _type;
        private string _current_stock;

        public Location()
        {
        }

        public Location(int id, string name, string type)
        {
            this._id = id;
            this._name = name;
            this._type = type;
        }

        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        // TODO: implement
        public string Current_stock { get => _current_stock; set => _current_stock = value; }
        public int Id { get => _id; set => _id = value; }

        public static Location Browse(int id)
        {
            Location result = new Location();
            foreach (Location location in locations_table)
            {
                if (location.Id == id)
                {
                    result = location;
                    break;
                }
            }
            return result;
        }

        public static Location[] Browse()
        {
            return locations_table.ToArray();
        }

        public override void Create()
        {
            locations_table.Add(this);
        }

        public static Location[] Search(string name)
        {
            List<Location> result = new List<Location>();
            foreach (Location location in locations_table)
            {
                if (location.Name == name)
                {
                    result.Add(location);
                }
            }
            return result.ToArray();
        }

        public override void Unlink()
        {
            locations_table.Remove(this);
        }

        public override void Write()
        {
            int index = locations_table.FindIndex(a => a.Id == this.Id);
            locations_table[index] = this;
        }
    }
}
