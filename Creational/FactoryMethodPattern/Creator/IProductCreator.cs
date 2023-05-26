using FactoryMethodPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Creator
{
    public interface IProductCreator
    {
        IProduct GetInstance(string type);
    }
}
