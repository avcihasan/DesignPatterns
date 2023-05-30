using StrategyPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Services.Concretes
{
    public class YapiKrediCreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Yapı Kredi Kredi Hesaplaması");
        }
    }
}
