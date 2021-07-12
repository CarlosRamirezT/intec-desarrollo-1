using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace modulo_inventario.models
{
    public class Moves : Conection
    {

        private static string _table_name = "moves";

        private int _id;
        private string _contact;
        private string _contact_address;
        private string _type;
        private Locations _source_location;
        private Locations _destination_location;
        private DateTime _schedule_date;
        private MoveLine[] _move_lines;

        public Moves()
        {
        }

        public Moves(int id, string contact, string contact_address, string type, Locations source_location, Locations destination_location, DateTime schedule_date)
        {
            this._id = id;
            this._contact = contact;
            this._contact_address = contact_address;
            this._type = type;
            this._source_location = source_location;
            this._destination_location = destination_location;
            this._schedule_date = schedule_date;
        }

        public int Id { get => _id; set => _id = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Contact_address { get => _contact_address; set => _contact_address = value; }
        public string Type { get => _type; set => _type = value; }
        public DateTime Schedule_date { get => _schedule_date; set => _schedule_date = value; }
        internal Locations Source_location { get => _source_location; set => _source_location = value; }
        internal Locations Destination_location { get => _destination_location; set => _destination_location = value; }
        internal MoveLine[] Move_lines { get => _move_lines; set => _move_lines = value; }

        public static Moves Browse(int id)
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where id = {id};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            Moves move = new Moves();
            while (reader.Read())
            {
                move = new Moves(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    Locations.Browse(reader.GetInt32(4)),
                    Locations.Browse(reader.GetInt32(5)),
                    reader.GetDateTime(6)
                );
            }
            return move;
        }

        public static Moves[] Browse()
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<Moves> moves = new List<Moves>();
            while (reader.Read())
            {
                Moves move = new Moves(
                   reader.GetInt32(0),
                   reader.GetString(1),
                   reader.GetString(2),
                   reader.GetString(3),
                   Locations.Browse(reader.GetInt32(4)),
                   Locations.Browse(reader.GetInt32(5)),
                   reader.GetDateTime(6)
               );
                moves.Add(move);
            }
            return moves.ToArray();
        }

        public override void Create()
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"insert into {_table_name}(contact, contact_address, type, source_location_id, destination_location_id, schedule_date)" +
                $"values({this.Contact}, {this.Contact_address}, {this.Type}, {this.Source_location.Id}, {this.Destination_location.Id}, {this.Schedule_date.Date});";
            using var command = new NpgsqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public static Moves[] Search(string contact)
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where contact = {contact} or contact_address = {contact} or type = {contact} or date = {contact};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<Moves> moves = new List<Moves>();
            while (reader.Read())
            {
                Moves move = new Moves(
                   reader.GetInt32(0),
                   reader.GetString(1),
                   reader.GetString(2),
                   reader.GetString(3),
                   Locations.Browse(reader.GetInt32(4)),
                   Locations.Browse(reader.GetInt32(5)),
                   reader.GetDateTime(6)
               );
                moves.Add(move);
            }
            return moves.ToArray();
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
                $"set contact = {this.Contact}, contact_address = {this.Contact_address}, type = {this.Type}, source_location_id = {this.Source_location.Id}, destination_location_id = {this.Destination_location.Id}, schedule_date = {this.Schedule_date.Date}" +
                $"where id = {this.Id};";
            using var command = new NpgsqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }

    public class MoveLine : Conection
    {
        private static string _table_name = "move_lines";

        private int _id;
        private Moves _move;
        private Product _product;
        private double _qty;
        private string _type;
        private Locations _souce_location;
        private Locations _destination_location;
        private string _state;

        public MoveLine()
        {
        }

        public MoveLine(int id, Moves move, Product product, double qty, string type, Locations souce_location, Locations destination_location, string state)
        {
            this._id = id;
            this._move = move;
            this._product = product;
            this._qty = qty;
            this._type = type;
            this._souce_location = souce_location;
            this._destination_location = destination_location;
            this._state = state;
        }

        public int Id { get => _id; set => _id = value; }
        public double Qty { get => _qty; set => _qty = value; }
        public string Type { get => _type; set => _type = value; }
        internal Moves Move_id { get => _move; set => _move = value; }
        internal Locations Souce_location { get => _souce_location; set => _souce_location = value; }
        internal Locations Destination_location { get => _destination_location; set => _destination_location = value; }
        internal Product Product { get => _product; set => _product = value; }
        public string State { get => _state; set => _state = value; }

        public static MoveLine Browse(int id)
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where id = {id};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            MoveLine move_line = new MoveLine();
            while (reader.Read())
            {
                move_line = new MoveLine(
                    reader.GetInt32(0),
                    Moves.Browse(reader.GetInt32(1)),
                    Product.Browse(reader.GetInt32(2)),
                    reader.GetDouble(3),
                    reader.GetString(4),
                    Locations.Browse(reader.GetInt32(5)),
                    Locations.Browse(reader.GetInt32(6))
                );
            }
            return move_line;
        }

        public static MoveLine[] Browse()
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<MoveLine> move_lines = new List<MoveLine>();
            while (reader.Read())
            {
                MoveLine move_line = new MoveLine(
                    reader.GetInt32(0),
                    Moves.Browse(reader.GetInt32(1)),
                    Product.Browse(reader.GetInt32(2)),
                    reader.GetDouble(3),
                    reader.GetString(4),
                    Locations.Browse(reader.GetInt32(5)),
                    Locations.Browse(reader.GetInt32(6)),
                    reader.GetString(7)
                );
                move_lines.Add(move_line);
            }
            return move_lines.ToArray();
        }

        public override void Create()
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"insert into {_table_name}(move_id, product_id, qty, type, source_location_id, destination_location_id)" +
                $"values({this.Move_id.Id}, {this.Product.Id}, {this.Qty}, {this.Type}, {this.Souce_location.Id}, {this.Destination_location.Id});";
            using var command = new NpgsqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public static MoveLine[] Search(string name)
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where qty = {name} or type = {name};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<MoveLine> move_lines = new List<MoveLine>();
            while (reader.Read())
            {
                MoveLine move_line = new MoveLine(
                    reader.GetInt32(0),
                    Moves.Browse(reader.GetInt32(1)),
                    Product.Browse(reader.GetInt32(2)),
                    reader.GetDouble(3),
                    reader.GetString(4),
                    Locations.Browse(reader.GetInt32(5)),
                    Locations.Browse(reader.GetInt32(6)),
                    reader.GetString(7)
                );
                move_lines.Add(move_line);
            }
            return move_lines.ToArray();
        }

        public static MoveLine[] Search(int product_id, string[] types)
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where product_id = {product_id} and type in ({String.Join(", ", types)});";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<MoveLine> move_lines = new List<MoveLine>();
            while (reader.Read())
            {
                MoveLine move_line = new MoveLine(
                    reader.GetInt32(0),
                    Moves.Browse(reader.GetInt32(1)),
                    Product.Browse(reader.GetInt32(2)),
                    reader.GetDouble(3),
                    reader.GetString(4),
                    Locations.Browse(reader.GetInt32(5)),
                    Locations.Browse(reader.GetInt32(6)),
                    reader.GetString(7)
                );
                move_lines.Add(move_line);
            }
            return move_lines.ToArray();
        }

        public static MoveLine[] Search(int product_id, string[] types, string state)
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where product_id = {product_id} and type in ({String.Join(", ", types)}) and state = {state};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<MoveLine> move_lines = new List<MoveLine>();
            while (reader.Read())
            {
                MoveLine move_line = new MoveLine(
                    reader.GetInt32(0),
                    Moves.Browse(reader.GetInt32(1)),
                    Product.Browse(reader.GetInt32(2)),
                    reader.GetDouble(3),
                    reader.GetString(4),
                    Locations.Browse(reader.GetInt32(5)),
                    Locations.Browse(reader.GetInt32(6)),
                    reader.GetString(7)
                );
                move_lines.Add(move_line);
            }
            return move_lines.ToArray();
        }

        public static MoveLine[] Search(int product_id)
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where product_id = {product_id};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<MoveLine> move_lines = new List<MoveLine>();
            while (reader.Read())
            {
                MoveLine move_line = new MoveLine(
                    reader.GetInt32(0),
                    Moves.Browse(reader.GetInt32(1)),
                    Product.Browse(reader.GetInt32(2)),
                    reader.GetDouble(3),
                    reader.GetString(4),
                    Locations.Browse(reader.GetInt32(5)),
                    Locations.Browse(reader.GetInt32(6)),
                    reader.GetString(7)
                );
                move_lines.Add(move_line);
            }
            return move_lines.ToArray();
        }

        public static MoveLine[] Search(Locations location)
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where source_location_id = {location.Id} or destination_location_id = {location.Id};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<MoveLine> move_lines = new List<MoveLine>();
            while (reader.Read())
            {
                MoveLine move_line = new MoveLine(
                    reader.GetInt32(0),
                    Moves.Browse(reader.GetInt32(1)),
                    Product.Browse(reader.GetInt32(2)),
                    reader.GetDouble(3),
                    reader.GetString(4),
                    Locations.Browse(reader.GetInt32(5)),
                    Locations.Browse(reader.GetInt32(6)),
                    reader.GetString(7)
                );
                move_lines.Add(move_line);
            }
            return move_lines.ToArray();
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
                $"set move_id = {this.Move_id.Id}, product_id = {this.Product.Id}, qty = {this.Qty}, type = {this.Type}, source_location_id = {this.Souce_location.Id}, destination_location_id = {this.Destination_location.Id}, state = {this.State}" +
                $"where id = {this.Id};";
            using var command = new NpgsqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}
