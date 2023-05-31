using ObserverPattern.Observers.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers.Concretes
{
    public class EmployeeObserver : ObserverBase
    {
        public override void Update()
        {
            Console.WriteLine("Mail to employees : Product updated...");
        }
    }
}
