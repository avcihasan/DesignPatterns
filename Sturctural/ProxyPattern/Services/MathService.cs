using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Services
{
    public class MathService : MathBase
    {
        public override double GetPi()
        {
            Thread.Sleep(5000);
            return 3.14;
        }
    }
}
