
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_inventario.models
{
    public class Product : Conection
    {

        private static List<Product> product_table = new List<Product>{
            new Product(1, "Pan", "Almacenable", "PRDCT 001", 10, 5, 100, 25),
            new Product(2, "Leche", "Almacenable", "PRDCT 002", 75, 30, 25, 15),
            new Product(3, "Arroz", "Almacenable", "PRDCT 003", 35, 20, 50, 20),
            new Product(4, "Huevo", "Almacenable", "PRDCT 004", 7, 3, 50, 25),
            new Product(5, "Queso", "Almacenable", "PRDCT 005", 130, 90, 20, 40),
        };

        private int _id;
        private string _name;
        private string _type;
        private string _code;
        private double _sales_price;
        private double _purchase_price;
        private double _available_qty;
        private double _forecasted_qty;
        private List<MoveLine> _stock_move_lines;

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

        public Product(int id, string name, string type, string code, double sales_price, double purchase_price, double available_qty, double forecasted_qty)
        {
            this._id = id;
            this._name = name;
            this._type = type;
            this._code = code;
            this._sales_price = sales_price;
            this._purchase_price = purchase_price;
            this._available_qty = available_qty;
            this._forecasted_qty = forecasted_qty;
        }

        public Product(int id, string name, string type, string code, double sales_price, double purchase_price, double available_qty, double forecasted_qty, List<MoveLine> stock_move_lines)
        {
            this._id = id;
            this._name = name;
            this._type = type;
            this._code = code;
            this._sales_price = sales_price;
            this._purchase_price = purchase_price;
            this._available_qty = available_qty;
            this._forecasted_qty = forecasted_qty;
            this._stock_move_lines = stock_move_lines;
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
                return result;
            } 
            set => _available_qty = value; 
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
            set => _forecasted_qty = value; 
        }

        public List<MoveLine> Stock_move_lines {
            get
            {
                return MoveLine.Search(this.Id).ToList();
            }
            set => _stock_move_lines = value; 
        }

        public static Product Browse(int id)
        {
            Product result = new Product();
            foreach(Product product in product_table){
                if (product.Id == id) {
                    result = product;
                    break;
                }
            }
            return result;
        }

        public static Product[] Browse()
        {
            return product_table.ToArray();
        }

        public override void Create()
        {
            product_table.Add(this);
        }

        public static Product[] Search(string name)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in product_table)
            {
                if (product.Name == name)
                {
                    result.Add(product);
                }
            }
            return result.ToArray();
        }

        public override void Unlink()
        {
            product_table.Remove(this);
        }

        public override void Write()
        {
            int index = product_table.FindIndex(a => a.Id == this.Id);
            product_table[index] = this;
        }
    }
}
