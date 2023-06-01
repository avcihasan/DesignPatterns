using NullObjcetPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjcetPattern.Services.Concretes
{
    public class Nlog : ILogger
    {
        public void Log()
        {
            Console.WriteLine("NLog logged");
        }
    }
}
