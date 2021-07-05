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
            new Move(1, "Carlos Ramirez", "Santo Domingo", "customer", Location.browse())
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
        private int _id;
        private Move _move_id;
        private double _qty;
        private string _type;

        public int Id { get => _id; set => _id = value; }
        public double Qty { get => _qty; set => _qty = value; }
        public string Type { get => _type; set => _type = value; }
        internal Move Move_id { get => _move_id; set => _move_id = value; }

        public static Conection Browse(int Id)
        {
            throw new NotImplementedException();
        }

        public static Conection[] Browse()
        {
            throw new NotImplementedException();
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public static Conection[] Search(string domain)
        {
            throw new NotImplementedException();
        }

        public override void Unlink()
        {
            throw new NotImplementedException();
        }

        public override void Write()
        {
            throw new NotImplementedException();
        }
    }
}
