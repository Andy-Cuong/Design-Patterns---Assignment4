using DecoratorAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment.CondimentDecorators
{
    public class Soy : CondimentDecorator
    {
        public string Description { get; set; } = ", Soy";
        public decimal Price { get; set; } = 0.15M;

        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + Description;
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + Price;
        }
    }
}
