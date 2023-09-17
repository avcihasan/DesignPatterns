using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Strategy.Services
{
    public class DiscountService
    {
        IDiscountService _discountService;

        public DiscountService(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public DiscountService()
        {
            
        }
        public void SetDiscountService(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        public int AppliedDiscount() => _discountService.GetDiscount();

    }
}
