using System;

namespace Odev4_Online_Shopping
{
    public class Product
    {
        public Product(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }
            public decimal Price { get; set; }
    }
}
