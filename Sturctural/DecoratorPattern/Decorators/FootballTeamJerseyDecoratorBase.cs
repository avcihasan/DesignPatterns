using DecoratorPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public abstract class FootballTeamJerseyDecoratorBase : FootballTeamJerseyBase
    {
        private FootballTeamJerseyBase _jersey;

        public FootballTeamJerseyDecoratorBase(FootballTeamJerseyBase jersey)
        {
            _jersey = jersey;
        }

    }
}
