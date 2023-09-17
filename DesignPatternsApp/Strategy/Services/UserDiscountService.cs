using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Strategy.Services
{
    public class UserDiscountService : IDiscountService
    {
        public int GetDiscount() => 10;
    }
}
