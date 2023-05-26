using AbstractFactoryPattern.Cache;
using AbstractFactoryPattern.Log;

namespace AbstractFactoryPattern.Creator
{
    public abstract class AbstractCreator
    {
        public abstract Logging LogCreate();
        public abstract Caching CacheCreate();
    }
}
    