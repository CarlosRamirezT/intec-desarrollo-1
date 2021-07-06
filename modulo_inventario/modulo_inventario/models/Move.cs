using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_inventario.models
{
    public class Moves : Conection
    {
        private static List<Moves> moves_table = new List<Moves> { 
            new Moves(1, "Carlos Ramirez", "Santo Domingo", "receipt", Locations.Browse()[3], Locations.Browse()[1], DateTime.Now, new MoveLine[]{}),
            new Moves(2, "Carlos Ramirez", "Santo Domingo", "internal", Locations.Browse()[1], Locations.Browse()[0], DateTime.Now, new MoveLine[]{}),
            new Moves(3, "Carlos Ramirez", "Santo Domingo", "customer", Locations.Browse()[0], Locations.Browse()[2], DateTime.Now, new MoveLine[]{}),
        };

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

        public Moves(int id, string contact, string contact_address, string type, Locations source_location, Locations destination_location, DateTime schedule_date, MoveLine[] move_lines)
        {
            this._id = id;
            this._contact = contact;
            this._contact_address = contact_address;
            this._type = type;
            this._source_location = source_location;
            this._destination_location = destination_location;
            this._schedule_date = schedule_date;
            this._move_lines = move_lines;
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
            Moves result = new Moves();
            foreach(Moves move in moves_table)
            {
                if (move.Id == id)
                {
                    result = move;
                    break;
                }
            }
            return result;
        }

        public static Moves[] Browse()
        {
            return moves_table.ToArray();
        }

        public override void Create()
        {
            moves_table.Add(this);
        }

        public static Moves[] Search(string contact)
        {
            List<Moves> result = new List<Moves>();
            foreach(Moves move in moves_table)
            {
                if(move.Contact == contact)
                {
                    result.Add(move);
                }
            }
            return result.ToArray();
        }

        public override void Unlink()
        {
            moves_table.Remove(this);
        }

        public override void Write()
        {
            int index = moves_table.FindIndex(a => a.Id == this.Id);
            moves_table[index] = this;
        }
    }

    public class MoveLine : Conection
    {
        private static List<MoveLine> move_line_table = new List<MoveLine> { 
            new MoveLine(1, Moves.Browse()[0], Product.Browse()[0], 2, "receipt", Locations.Browse()[3], Locations.Browse()[1]),
            new MoveLine(2, Moves.Browse()[1], Product.Browse()[1],5, "internal", Locations.Browse()[1], Locations.Browse()[0]),
            new MoveLine(3, Moves.Browse()[2], Product.Browse()[2],3, "customer", Locations.Browse()[0], Locations.Browse()[2]),
        };

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

        public MoveLine(int id, Moves move, Product product, double qty, string type, Locations souce_location, Locations destination_location)
        {
            this._id = id;
            this._move = move;
            this._product = product;
            this._qty = qty;
            this._type = type;
            this._souce_location = souce_location;
            this._destination_location = destination_location;
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
            MoveLine result = new MoveLine();
            foreach (MoveLine line in move_line_table)
            {
                if(line.Id == id)
                {
                    result = line;
                    break;
                }
            }
            return result;
        }

        public static MoveLine[] Browse()
        {
            return move_line_table.ToArray();
        }

        public override void Create()
        {
            move_line_table.Add(this);
        }

        public static MoveLine[] Search(string name)
        {
            List<MoveLine> result = new List<MoveLine>();
            foreach (MoveLine line in move_line_table)
            {
                if (line.Product.Name == name || line.Souce_location.Name == name || line.Destination_location.Name == name || line.Type == name)
                {
                    result.Add(line);
                }
            }
            return result.ToArray();
        }

        public static MoveLine[] Search(int product_id, string[] types)
        {
            List<MoveLine> result = new List<MoveLine>();
            foreach (MoveLine line in move_line_table)
            {
                if (line.Product.Id == product_id && Array.Exists(types, element => element == line.Type))
                {
                    result.Add(line);
                }
            }
            return result.ToArray();
        }

        public static MoveLine[] Search(int product_id, string[] types, string state)
        {
            List<MoveLine> result = new List<MoveLine>();
            foreach (MoveLine line in move_line_table)
            {
                if (line.Product.Id == product_id && Array.Exists(types, element => element == line.Type) && line.State == state)
                {
                    result.Add(line);
                }
            }
            return result.ToArray();
        }

        public static MoveLine[] Search(int product_id)
        {
            List<MoveLine> result = new List<MoveLine>();
            foreach (MoveLine line in move_line_table)
            {
                if (line.Product.Id == product_id)
                {
                    result.Add(line);
                }
            }
            return result.ToArray();
        }

        public static MoveLine[] Search(Locations location)
        {
            List<MoveLine> result = new List<MoveLine>();
            foreach (MoveLine line in move_line_table)
            {
                if (line.Souce_location.Id == location.Id || line.Destination_location.Id == location.Id)
                {
                    result.Add(line);
                }
            }
            return result.ToArray();
        }

        public override void Unlink()
        {
            move_line_table.Remove(this);
        }

        public override void Write()
        {
            int index = move_line_table.FindIndex(a => a.Id == this.Id);
            move_line_table[index] = this;
        }
    }
}
