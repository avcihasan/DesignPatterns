using ObserverPattern.Observers.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers.Concretes
{
    public class CustomerObserver : ObserverBase
    {
        public override void Update()
        {
            Console.WriteLine("Mail to Customer : Product updated...");
        }
    }
}
