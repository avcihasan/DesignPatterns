using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Services.Abstracts;

namespace VisitorPattern.Entities
{
    public class Manager : EmployeeBase
    {
        public List<EmployeeBase> Subordinates { get; set; }
        public Manager()
        {
            Subordinates = new List<EmployeeBase>();
        }

        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
            foreach (EmployeeBase employee in Subordinates)
                employee.Accept(visitor);
            
        }
    }
}
