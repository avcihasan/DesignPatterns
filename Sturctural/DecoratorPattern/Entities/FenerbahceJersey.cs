using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Entities
{
    public class FenerbahceJersey : FootballTeamJerseyBase
    {
        public override string Size { get; set; }
        public override double KDV { get; set ; }
        public override double Price { get ; set; }
        public override double PriceWithKdv => Price + (Price * KDV);
    }
}
