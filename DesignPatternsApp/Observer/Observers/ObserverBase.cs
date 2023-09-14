using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Observer.Observers
{
    public abstract class ObserverBase
    {
        public string Name { get; set; }
        public abstract void Update();
    }
}
