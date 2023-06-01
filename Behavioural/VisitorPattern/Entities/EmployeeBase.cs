using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Services.Abstracts;

namespace VisitorPattern.Entities
{
    public abstract class EmployeeBase
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public abstract void Accept(VisitorBase visitor);
    }
}
