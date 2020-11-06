using Solid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Services
{
    public interface IOrderDelivery 
    {
        OrderStatus DeliverOrder(OrderStatus orderStatus);
    }
}
