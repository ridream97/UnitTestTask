using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Services
{
    public class DeliveryCalculator : IDeliveryCalculator
    {
        public int CalculateDelivery(int sum)
        {
            return sum + 50;
        }

        //Interface Segregation - wrong

        //public int CalculateDeliveryWithTax(int sum, int tax)
        //{
        //    return sum + tax;
        //}

    }
}
