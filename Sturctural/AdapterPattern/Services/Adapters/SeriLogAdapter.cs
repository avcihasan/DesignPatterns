using AdapterPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdapterPattern.Services.Adapters
{
    public class SeriLogAdapter : ILogger
    {
        public void Log(string data)
        {
            SeriLog serilog = new();
            serilog.SeriLogLog(data);
        }
    }

    public class SeriLog
    {
        public void SeriLogLog(string data)
        {
            Console.WriteLine("SeriLog Logged : {0}", data);
        }
    }
}
