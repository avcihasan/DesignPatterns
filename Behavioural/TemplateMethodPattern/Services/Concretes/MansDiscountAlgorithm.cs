using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Services.Abstracts;

namespace TemplateMethodPattern.Services.Concretes
{
    public class MansDiscountAlgorithm : DiscountAlgorithm
    {
        protected override decimal CalculateAgeDiscount(int age)
        {
            return (decimal)(age * 0.15);
        }

        protected override decimal CalculateAmountDiscount(int amount)
        {
            return amount * 2;
        }

        protected override decimal CalculatePrice(decimal price, decimal amountDiscount, decimal ageDiscount)
        {
            return price - amountDiscount - ageDiscount;
        }
    }
}
