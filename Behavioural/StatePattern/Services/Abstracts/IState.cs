using StatePattern.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Services.Abstracts
{
    public interface IState
    {
        public string State { get; set; }
        void DoAction(Context context);
    }
}
