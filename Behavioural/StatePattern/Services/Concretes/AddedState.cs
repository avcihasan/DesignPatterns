﻿using StatePattern.Contexts;
using StatePattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Services.Concretes
{
    public class AddedState : IState
    {
        public string State { get ; set; }

        public void DoAction(Context context)
        {
            State = "Added";
            context.SetState(this);
            Console.WriteLine("State : Added");
        }
    }
}
