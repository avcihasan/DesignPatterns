using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Entities
{
    public class BProduct : IProduct
    {
        public string GetPrice()
        {
            return "B Product fiyatı 20 TL";
        }
    }
}
