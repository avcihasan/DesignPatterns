using BuilderPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builders
{
    public class LaptopProdcutBuilder : ProductBuilder
    {
        Product product = new();
        public override Product GetInstence()
        {
            return product;
        }

        public override void SetCategoryName()
        {
            product.CategoryName = "Teknoloji";
        }

        public override void SetKDV()
        {
            product.KDV = (decimal)0.99;
        }

        public override void SetName()
        {
            product.Name = "Lenova";
        }

        public override void SetPrice()
        {
            product.Price = 10000;
        }

        public override void SetPriceWithKDV()
        {
            product.PriceWithKDV = product.Price + (product.Price * product.KDV);
        }
    }
}
