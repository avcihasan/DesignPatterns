using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Entities
{
    public class AProduct : IProduct
    {
        public string GetPrice()
        {
            return "A Product fiyatı 10 TL";
        }
    }
}
