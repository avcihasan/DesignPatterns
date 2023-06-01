using CommandPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Services.Concretes
{
    public class BuyStock : IOrder
    {
        IStockService _stockService;

        public BuyStock(IStockService stockService)
        {
            _stockService = stockService;
        }

        public void Execute()
        {
            _stockService.Buy();
        }
    }
}
