using NullObjcetPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjcetPattern.Services.Concretes
{
    public class StubLog : ILogger
    {
        public static StubLog Instance { get; private set; }
        private StubLog()
        {
        }

        static StubLog()
        {
            Instance = new StubLog();    
        }

        public void Log()
        {
        }
    }
}
