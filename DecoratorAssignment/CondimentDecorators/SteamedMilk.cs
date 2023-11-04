using DecoratorAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment.CondimentDecorators
{
    public class SteamedMilk : CondimentDecorator
    {
        public string Description { get; set; } = ", Milk";
        public decimal Price { get; set; } = 0.10M;

        public SteamedMilk(Beverage beverage) 
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
