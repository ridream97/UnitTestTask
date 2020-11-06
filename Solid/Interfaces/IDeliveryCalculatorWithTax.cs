using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Services
{
    public interface IDeliveryCalculatorWithTax
    {
        //Opent closed - correct
        int CalculateDelivery(int sum, int tax);
    }
}
