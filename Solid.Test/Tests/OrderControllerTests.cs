using NUnit.Framework;
using Solid.Models;
using Solid.Services;
using System;

namespace Solid.Test.Tests
{
    public enum State
    {
        Pending,
        Delivered,
        InWork
    }
    [TestFixture]
    public class OrderControllerTests
    {
        private static IDeliveryCalculator deliveryCalculator = new DeliveryCalculator();
        private static IOrderService orderService = new OrderService(deliveryCalculator);
        private static IOrderDelivery orderDelivery = new OrderDelivery();

        [Test]
        public void PrepairOrderTest()
        {
            var order = new Order()
            { 
                Customer = new Client(),
                Product = "Test Product",
                Count = 1,
                Price = 100
            };
            var orderStatus = orderService.PrepairOrder(order);
            Assert.AreEqual(State.InWork.ToString(), orderStatus.State.ToString());
        }

        [Test]
        public void DeliverOrderTest()
        {
            var orderStatus = new OrderStatus()
            {
                State = Models.State.InWork
            };
            var finalOrderStatus = orderDelivery.DeliverOrder(orderStatus);
            Assert.AreEqual(State.Delivered.ToString(), finalOrderStatus.State.ToString());
        }
    }
}
