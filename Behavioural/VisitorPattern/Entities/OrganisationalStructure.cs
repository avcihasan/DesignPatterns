using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Services.Abstracts;

namespace VisitorPattern.Entities
{
    public class OrganisationalStructure
    {
        public EmployeeBase Employee;

        public OrganisationalStructure(EmployeeBase employee)
        {
            Employee = employee;
        }
        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }
    }
}
