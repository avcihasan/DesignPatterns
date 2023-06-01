using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultitonPattern.Entities
{
    public class Brand
    {
        public Guid Id { get; set; } 
        private static Dictionary<string, Brand> _brands;

        private Brand()
        {
            Id=Guid.NewGuid();
        }
        static Brand()
        {
            _brands=new Dictionary<string, Brand>();
        }

        public static Brand GetBrand(string brand)
        {
            if (!_brands.ContainsKey(brand))
                _brands.Add(brand, new Brand());
            return _brands[brand];
        }
    }
}
