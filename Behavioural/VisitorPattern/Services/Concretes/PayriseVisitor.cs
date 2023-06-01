using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Entities;
using VisitorPattern.Services.Abstracts;

namespace VisitorPattern.Services.Concretes
{
    public class PayriseVisitor : VisitorBase
    {
        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} (manager), yüzde {1} zam aldı",manager.Name, (int)((((manager.Salary + 200) / manager.Salary) - 1) * 100));
        }

        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} (worker), yüzde {1} zam aldı", worker.Name,(int)((((worker.Salary + 200) / worker.Salary) - 1) * 100));

        }
    }
}
