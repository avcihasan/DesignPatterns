using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Observer.Observers
{
    public class StudentObserver : ObserverBase
    {
        public override void Update()
        {
            MessageBox.Show($"{Name} StudentObserver bilgilendirildi");
        }
    }
}
