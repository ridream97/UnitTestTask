using Solid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Services
{
    public class OrderDelivery : IOrderDelivery
    {
        //Single responcebility - correct
        public OrderStatus DeliverOrder(OrderStatus orderStatus)
        {
            orderStatus.State = State.Delivered;
            return orderStatus;
        }
    }
}
