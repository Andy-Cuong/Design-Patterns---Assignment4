using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssignment.Interfaces
{
    public interface Beverage
    {
        public string GetDescription();

        public decimal Cost();
    }
}
