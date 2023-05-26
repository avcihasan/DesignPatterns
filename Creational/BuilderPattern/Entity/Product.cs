using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Entity
{
    public class Product
    {
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public decimal KDV { get; set; }
        public decimal PriceWithKDV { get; set; }
    }
}
