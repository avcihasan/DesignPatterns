using StatePattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Contexts
{
    public class Context
    {
        private IState _state;
        public void SetState(IState state)
        {
            _state = state;
        }
        public IState GetState()
        {
            return _state;
        }
    }
}
