using DecoratorAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment.CondimentDecorators
{
    public class Mocha : CondimentDecorator
    {
        public string Description { get; set; } = ", Mocha";
        public decimal Price { get; set; } = 0.20M;

        public Mocha(Beverage beverage) 
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
