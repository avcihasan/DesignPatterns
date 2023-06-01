using DependencInjectionPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencInjectionPattern.Services.Concretes
{
    public class ProductService : IProductService
    {
        IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void GetProducts()
        {
            _productDal.GetAllProducts();
        }
    }
}
