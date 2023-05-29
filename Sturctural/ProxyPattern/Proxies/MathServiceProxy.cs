using ProxyPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Proxies
{
    public class MathServiceProxy : MathBase
    {
        MathService service;
        double pi;
        public override double GetPi()
        {
            if (service is null)
            {
                service = new MathService();
                pi = service.GetPi();
            }

            return pi;
        }
    }
}
