using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Entities
{
    public abstract class FootballTeamJerseyBase
    {
        public abstract string Size { get; set; } 
        public abstract double KDV { get; set; } 
        public abstract double Price { get; set; }
        public abstract double PriceWithKdv { get; }
    }
}
