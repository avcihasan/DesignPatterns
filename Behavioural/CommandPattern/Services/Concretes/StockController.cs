using CommandPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Services.Concretes
{
    public class StockController
    {
        List<IOrder> _orders = new();

        public void TakeOrder(IOrder order)
        {
            _orders.Add(order);
        }
        public void PlaceOrder()
        {
            foreach (IOrder order in _orders)
                order.Execute();
            _orders.Clear();
        }
    }
}
