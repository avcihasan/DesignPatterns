using CommandPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Services.Concretes
{
    public class StockService : IStockService
    {
        public void Buy()
        {
            Console.WriteLine("Ürün alındı");
        }

        public void Sell()
        {
            Console.WriteLine("Ürün satıldı");
        }
    }
}
