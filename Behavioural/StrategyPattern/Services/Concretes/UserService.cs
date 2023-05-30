using StrategyPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Services.Concretes
{
    public class UserService : IUserService
    {
        public CreditCalculatorBase CreditCalculator { get; set; }
        public UserService(CreditCalculatorBase calculator)
        {
            CreditCalculator = calculator;
        }
        public void SaveCredit()
        {
            CreditCalculator.Calculate();
            Console.WriteLine("Kredi Verildi");
        }
    }
}
