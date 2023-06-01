using CommandPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Services.Concretes
{
    public class SellStock : IOrder
    {
        IStockService _stockService;

        public SellStock(IStockService stockService)
        {
            _stockService = stockService;
        }

        public void Execute()
        {
            _stockService.Sell();
        }
    }
}
