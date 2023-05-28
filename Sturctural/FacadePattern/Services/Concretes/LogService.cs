using FacadePattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Services.Concretes
{
    public class LogService : ILogService
    {
        public void Log()
        {
            Console.WriteLine("Logging");
        }
    }
}
