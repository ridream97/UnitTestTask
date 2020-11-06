using Solid.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.Models
{
    public enum State
    {
        Pending,
        Delivered,
        InWork
    }
    public class OrderStatus
    {
        public int OrderNumber { get; set; }
        public int OrderSum { get; set; }
        public int DeliverySum { get; set; }
        public State State { get; set; }
    }
}
