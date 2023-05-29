using DecoratorPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class SpecialPrice : FootballTeamJerseyDecoratorBase
    {
        readonly FootballTeamJerseyBase _jersey;
        public int DiscountRate { get; set; }
        public SpecialPrice(FootballTeamJerseyBase jersey) : base(jersey)
        {
            _jersey = jersey;
        }

        public override string Size {get;set;}
        public override double KDV { get; set; }
        public override double Price { get; set; }
        public override double PriceWithKdv => _jersey.PriceWithKdv-(_jersey.PriceWithKdv * DiscountRate / 100);
    }
}
