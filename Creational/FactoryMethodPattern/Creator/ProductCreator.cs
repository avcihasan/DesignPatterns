using FactoryMethodPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Creator
{
    public class ProductCreator : IProductCreator
    {
        public IProduct GetInstance(string type)
        {
            if (type == "A")
                return new AProduct();
            if (type == "B")
                return new BProduct();
            return new CProduct();
        }
    }
}
