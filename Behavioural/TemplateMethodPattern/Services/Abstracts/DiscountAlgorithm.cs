using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Services.Abstracts
{
    public abstract class DiscountAlgorithm
    {
        public decimal GeneratePrice(int age, int amount, decimal price)
        {
            decimal ageDiscount = CalculateAgeDiscount(age);
            decimal amountDiscount = CalculateAmountDiscount(amount);
            return CalculatePrice(price,amountDiscount,ageDiscount);
        }

        protected abstract decimal CalculatePrice(decimal price, decimal amountDiscount, decimal ageDiscount);
        protected abstract decimal CalculateAmountDiscount(int amount);
        protected abstract decimal CalculateAgeDiscount(int age);
    }
}
