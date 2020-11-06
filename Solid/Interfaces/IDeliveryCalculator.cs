using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Services
{
    public interface IDeliveryCalculator
    {
        int CalculateDelivery(int sum);

        //Interface Segregation - wrong

        //int CalculateDeliveryWithTax(int sum, int tax);
    }
}
