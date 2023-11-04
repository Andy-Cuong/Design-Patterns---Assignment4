using DecoratorAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment.CondimentDecorators
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage { get; set; } = default(Beverage)!;

        public abstract string GetDescription();

        public abstract decimal Cost();
    }
}
