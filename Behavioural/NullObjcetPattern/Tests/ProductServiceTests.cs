using NullObjcetPattern.Services.Abstracts;
using NullObjcetPattern.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjcetPattern.Tests
{
    public class ProductServiceTests
    {

        public void CreateProductTest()
        {
            IProductService productService = new ProductService(StubLog.Instance);
            productService.CreateProduct();
        }
    }
}
