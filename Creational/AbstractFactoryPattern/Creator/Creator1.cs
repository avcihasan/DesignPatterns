using AbstractFactoryPattern.Cache;
using AbstractFactoryPattern.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Creator
{
    public class Creator1 : AbstractCreator
    {
        public override Caching CacheCreate()
        {
            return new RedisCache();
        }

        public override Logging LogCreate()
        {
            return new SeriLog();
        }
    }
}
