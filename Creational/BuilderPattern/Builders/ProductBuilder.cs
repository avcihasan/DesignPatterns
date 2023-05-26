using BuilderPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builders
{
    public abstract class ProductBuilder
    {
        public abstract void SetName();
        public abstract void SetCategoryName();
        public abstract void SetPrice();
        public abstract void SetKDV();
        public abstract void SetPriceWithKDV(); 
        public abstract Product GetInstence();

    }
}
