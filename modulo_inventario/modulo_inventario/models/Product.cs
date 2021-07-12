
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace modulo_inventario.models
{
    public class Product : Conection
    {

        private static string _table_name = "products";

        private int _id;
        private string _name;
        private string _type;
        private string _unit;
        private string _code;
        private double _sales_price;
        private double _purchase_price;
        private double _min_qty;
        private double _max_qty;

        public Product()
        {
        }

        public Product(string name, string type, string code, double sales_price, double purchase_price)
        {
            this._name = name;
            this._type = type;
            this._code = code;
            this._sales_price = sales_price;
            this._purchase_price = purchase_price;
        }

        public Product(int id, string name, string type, string unit, string code, double sales_price, double purchase_price, double min_qty, double max_qty)
        {
            this._id = id;
            this._name = name;
            this._type = type;
            this._unit = unit;
            this._code = code;
            this._sales_price = sales_price;
            this._purchase_price = purchase_price;
            this.Min_qty = min_qty;
            this.Max_qty = max_qty;
        }

        public Product(int id, string name, string type, string code, double sales_price, double purchase_price, double min_qty, double max_qty, List<MoveLine> stock_move_lines)
        {
            this._id = id;
            this._name = name;
            this._type = type;
            this._code = code;
            this._sales_price = sales_price;
            this._purchase_price = purchase_price;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public string Code { get => _code; set => _code = value; }
        public double Sales_price { get => _sales_price; set => _sales_price = value; }
        public double Purchase_price { get => _purchase_price; set => _purchase_price = value; }
        public double Available_qty {
            get {
                double result = 0;
                MoveLine[] moveLines = MoveLine.Search(this.Id, new string[2] { "receipt", "customer" });
                foreach(MoveLine line in moveLines)
                {
                    if(line.Type == "receipt")
                    {
                        result += line.Qty;
                    }else if(line.Type == "waste" || line.Type == "customer")
                    {
                        result -= line.Qty;
                    }
                }
                if (result >= this.Max_qty)
                {
                    MessageBox.Show("El producto ha alcanzado la cantidad maxima en inventario, por favor no haga mas pedidos por el momento!");
                }else if(result <= this.Min_qty)
                {
                    MessageBox.Show("El producto ha alcanzado la cantidad minima en inventario, por favor no haga un pedido a su proveedor!");
                }
                return result;
            } 
        }

        public double Forecasted_qty {
            get
            {
                double result = 0;
                MoveLine[] moveLines = MoveLine.Search(this.Id, new string[1] { "receipt"}, "waiting");
                foreach (MoveLine line in moveLines)
                {
                    result += line.Qty;
                }
                return result;
            }
        }

        public List<MoveLine> Stock_move_lines {
            get
            {
                return MoveLine.Search(this.Id).ToList();
            }
        }

        public string Unit { get => _unit; set => _unit = value; }
        public double Min_qty { get => _min_qty; set => _min_qty = value; }
        public double Max_qty { get => _max_qty; set => _max_qty = value; }

        public static Product Browse(int id)
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where id = {id};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            Product product = new Product();
            while (reader.Read())
            {
                product = new Product(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetDouble(5),
                    reader.GetDouble(6),
                    reader.GetDouble(7),
                    reader.GetDouble(8)
                );
            }
            return product;
        }

        public static Product[] Browse()
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetDouble(5),
                    reader.GetDouble(6),
                    reader.GetDouble(7),
                    reader.GetDouble(8)
                );
                products.Add(product);
            }
            return products.ToArray();
        }

        public override void Create()
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"insert into {_table_name}(name, type, unit, code, sales_price, purchase_price, min_qty, max_max)" +
                $"values({this.Name}, {this.Type}, {this.Unit}, {this.Code}, {this.Sales_price}, {this.Purchase_price}, {this.Min_qty}, {this.Max_qty});";
            using var command = new NpgsqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public static Product[] Search(string name)
        {
            NpgsqlConnection connection = Conection.get_connection();
            string query = $"select * from {_table_name} where name = {name} or type = {name} or unit = {name} or code = {name};";
            using var command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetDouble(5),
                    reader.GetDouble(6),
                    reader.GetDouble(7),
                    reader.GetDouble(8)
                );
                products.Add(product);
            }
            return products.ToArray();
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
                $"set name = {this.Name}, type = {this.Type}, unit = {this.Unit}, code = {this.Code}, sales_price = {this.Sales_price}, purchase_price = {this.Purchase_price}, min_qty = {this.Min_qty}, max_qty = {this.Max_qty}" +
                $"where id = {this.Id};";
            using var command = new NpgsqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}
