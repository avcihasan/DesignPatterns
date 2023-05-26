using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Entities
{
    public class CProduct : IProduct
    {
        public string GetPrice()
        {
            return "C Product fiyatı 30 TL";
        }
    }
}
