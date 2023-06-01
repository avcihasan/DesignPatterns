using StatePattern.Contexts;
using StatePattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Services.Concretes
{
    public class DeletedState : IState
    {
        public string State { get; set; }

        public void DoAction(Context context)
        {
            State = "Deleted";
            context.SetState(this);
            Console.WriteLine("State : Deleted");
        }
    }
}
