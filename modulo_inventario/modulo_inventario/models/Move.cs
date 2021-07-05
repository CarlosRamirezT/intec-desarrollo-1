using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_inventario.models
{
    class Move : Conection
    {
        private static List<Move> moves_table = new List<Move> { 
            new Move(1, "Carlos Ramirez", "Santo Domingo", "receipt", Location.Browse()[3], Location.Browse()[1], DateTime.Now, new MoveLine[]{}),
            new Move(2, "Carlos Ramirez", "Santo Domingo", "internal", Location.Browse()[1], Location.Browse()[0], DateTime.Now, new MoveLine[]{}),
            new Move(3, "Carlos Ramirez", "Santo Domingo", "customer", Location.Browse()[0], Location.Browse()[2], DateTime.Now, new MoveLine[]{}),
        };

        private int _id;
        private string _contact;
        private string _contact_address;
        private string _type;
        private Location _source_location;
        private Location _destination_location;
        private DateTime _schedule_date;
        private MoveLine[] _move_lines;

        public Move()
        {
        }

        public Move(int id, string contact, string contact_address, string type, Location source_location, Location destination_location, DateTime schedule_date, MoveLine[] move_lines)
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
        internal Location Source_location { get => _source_location; set => _source_location = value; }
        internal Location Destination_location { get => _destination_location; set => _destination_location = value; }
        internal MoveLine[] Move_lines { get => _move_lines; set => _move_lines = value; }

        public static Move Browse(int id)
        {
            Move result = new Move();
            foreach(Move move in moves_table)
            {
                if (move.Id == id)
                {
                    result = move;
                    break;
                }
            }
            return result;
        }

        public static Move[] Browse()
        {
            return moves_table.ToArray();
        }

        public override void Create()
        {
            moves_table.Add(this);
        }

        public static Move[] Search(string contact)
        {
            List<Move> result = new List<Move>();
            foreach(Move move in moves_table)
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

    class MoveLine : Conection
    {
        private static List<MoveLine> move_line_table = new List<MoveLine> { 
            new MoveLine(1, Move.Browse()[0], Product.Browse()[0], 2, "receipt", Location.Browse()[3], Location.Browse()[1]),
            new MoveLine(2, Move.Browse()[1], Product.Browse()[1],5, "internal", Location.Browse()[1], Location.Browse()[0]),
            new MoveLine(3, Move.Browse()[2], Product.Browse()[2],3, "customer", Location.Browse()[0], Location.Browse()[2]),
        };

        private int _id;
        private Move _move;
        private Product _product;
        private double _qty;
        private string _type;
        private Location _souce_location;
        private Location _destination_location;
        private string _state;

        public MoveLine()
        {
        }

        public MoveLine(int id, Move move, Product product, double qty, string type, Location souce_location, Location destination_location)
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
        internal Move Move_id { get => _move; set => _move = value; }
        internal Location Souce_location { get => _souce_location; set => _souce_location = value; }
        internal Location Destination_location { get => _destination_location; set => _destination_location = value; }
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
