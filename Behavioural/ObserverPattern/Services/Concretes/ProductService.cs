using ObserverPattern.Observers.Abstracts;
using ObserverPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Services.Concretes
{
    public class ProductService : IProductService
    {
        List<ObserverBase> _observes = new();
        public void UpdateProduct()
        {
            Console.WriteLine("Product Updated...");
            Notify();
        }

        public void Attach(ObserverBase observer)
        {
            _observes.Add(observer);
        }
        public void Detach(ObserverBase observer)
        {
            _observes.Remove(observer);
        }

        private void Notify()
        {
            foreach (var item in _observes)
                item.Update();
        }
    }
}
