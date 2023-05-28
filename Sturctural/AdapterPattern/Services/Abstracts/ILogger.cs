using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Services.Abstracts
{
    public interface ILogger
    {
        void Log(string data);
    }
}
