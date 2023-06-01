using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Entities;

namespace VisitorPattern.Services.Abstracts
{
    public abstract class VisitorBase
    {
        public abstract void Visit(Manager manager);
        public abstract void Visit(Worker worker);
    }
}
