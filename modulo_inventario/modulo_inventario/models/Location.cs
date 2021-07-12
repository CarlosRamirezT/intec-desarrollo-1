using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace modulo_inventario.models
{
    public class Locations : Conection
    {

        private static string _table_name = "locations";

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

        public Locations(string name, string type)
        {
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
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where id = {id};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            Locations location = new Locations();
            while (reader.Read())
            {
                location = new Locations(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2)
                );
            }
            return location;
        }

        public static Locations[] Browse()
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<Locations> locations = new List<Locations>();
            while (reader.Read())
            {
                Locations location = new Locations(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2)
                );
                locations.Add(location);
            }
            return locations.ToArray();
        }

        public override void Create()
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"insert into {_table_name}(name, type)" +
                $"values({this.Name}, {this.Type});";
            using var command = new NpgsqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public static Locations[] Search(string name)
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where name = {name} or type = {name};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<Locations> locations = new List<Locations>();
            while (reader.Read())
            {
                Locations location = new Locations(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2)
                );
                locations.Add(location);
            }
            return locations.ToArray();
        }

        public override void Unlink()
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"delete from {_table_name} where id = {this.Id};";
            using var command = new NpgsqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public override void Write()
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"update {_table_name}" +
                $"set name = {this.Name}, type = {this.Type}" +
                $"where id = {this.Id};";
            using var command = new NpgsqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}
