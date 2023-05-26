using BuilderPattern.Builders;
using BuilderPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Director
{
    public class ProductDirector
    {
        public Product GenerateProduct(ProductBuilder productBuilder)
        {
            productBuilder.SetName();
            productBuilder.SetCategoryName();
            productBuilder.SetPrice();
            productBuilder.SetKDV();
            productBuilder.SetPriceWithKDV();

           return productBuilder.GetInstence();
        }
    }
}
