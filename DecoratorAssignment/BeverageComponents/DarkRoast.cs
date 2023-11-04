using DecoratorAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment.BeverageComponents
{
    public class DarkRoast : Beverage
    {
        public string Description { get; set; } = "Dark Roast Coffee";
        public decimal Price { get; set; } = 0.99M;

        public string GetDescription()
        {
            return Description;
        }

        public decimal Cost()
        {
            return Price;
        }
    }
}
