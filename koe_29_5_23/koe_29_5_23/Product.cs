using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koe_29_5_23
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }


    public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public decimal CalculateDiscountedPrice(decimal discountPercentage)
        {
            decimal discount = Price * discountPercentage / 100;
            return Price - discount;
        }
    }
}
