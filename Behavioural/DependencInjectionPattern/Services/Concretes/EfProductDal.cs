using DependencInjectionPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencInjectionPattern.Services.Concretes
{
    public class EfProductDal : IProductDal
    {
        public void GetAllProducts()
        {
            Console.WriteLine("Ef Core ile ürünler getirildi");
        }
    }
}
