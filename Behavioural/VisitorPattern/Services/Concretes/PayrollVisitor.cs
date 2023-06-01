using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Entities;
using VisitorPattern.Services.Abstracts;

namespace VisitorPattern.Services.Concretes
{
    public class PayrollVisitor : VisitorBase
    {
        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} (manager), {1} tl maaş aldı",manager.Name,manager.Salary);
        }

        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} (worker), {1} tl maaş aldı", worker.Name, worker.Salary);
        }
    }
}
