using AdapterPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Services.Concretes
{
    public class CustomLogger : ILogger
    {
        public void Log(string data)
        {
            Console.WriteLine("Custom Logged : {0}",data);
        }
    }
}
