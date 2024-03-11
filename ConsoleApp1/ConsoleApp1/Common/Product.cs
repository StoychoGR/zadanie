using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Common
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Decimal Price { get; set; }
        public int Stock { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, decimal price, int stock)
        {
            ID = id;
            Name = name;
            Price = price;
            Stock = stock;
        }
 
    }
}
