using DecoratorAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment.BeverageComponents
{
    public class Decaf : Beverage
    {
        public string Description { get; set; } = "Decaf Coffee";
        public decimal Price { get; set; } = 1.05M;

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
