using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Services
{
    public class DeliveryCalculatorWithTax : IDeliveryCalculatorWithTax
    {
        //Opent closed - correct

        public int CalculateDelivery(int sum, int tax)
        {
            return sum + tax;
        }
    }
}
