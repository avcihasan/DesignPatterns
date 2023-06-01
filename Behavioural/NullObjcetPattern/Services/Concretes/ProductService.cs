using NullObjcetPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjcetPattern.Services.Concretes
{
    public class ProductService : IProductService
    {
        ILogger _logger;

        public ProductService(ILogger logger)
        {
            _logger = logger;
        }

        public void CreateProduct()
        {
            Console.WriteLine("Created product");
            _logger.Log();
        }
    }
}
