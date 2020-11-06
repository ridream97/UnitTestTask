using Microsoft.AspNetCore.Mvc;
using Solid.Models;
using Solid.Services;

namespace Solid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        //Dependency Inversion - wrong

        //private readonly OrderService orderService;
        //public OrdersController()
        //{
        //    orderService = new OrderService();
        //}


        //Dependency Inversion - correct

        private readonly IOrderService orderService;
        private readonly IOrderDelivery orderDelivery;
        public OrdersController(IOrderService orderService, IOrderDelivery orderDelivery)
        {
            this.orderService = orderService;
            this.orderDelivery = orderDelivery;
        }
        [HttpGet]
        public OrderStatus DeliverOrder(OrderStatus orderStatus)
        {
            return orderDelivery.DeliverOrder(orderStatus);
        }
        [HttpPost]
        public OrderStatus PrepairOrder(Order order)
        {
            return orderService.PrepairOrder(order);
        }
    }
}
