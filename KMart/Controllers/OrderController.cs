using KMart.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KMart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly KMartDBContext db;

        public OrderController()
        {
            db = new KMartDBContext();
        }

        [HttpGet]
        [Route("GetOrders")]
        public List<Order> GetOrders()
        {
            List<Order> orders = db.Orders.ToList();
            return orders;
        }


        [HttpGet]
        [Route("GetOrder/{id}")]
        public Order GetOrder(int id)
        {
            Order ord = db.Orders.SingleOrDefault(o => o.OrderId == id);
            return ord;
        }

        [HttpPost]
        [Route("AddOrder")]
        public string AddOrder(Order o)
        {
            db.Orders.Add(o);
            db.SaveChanges();

            return "Order added";
        }


        [HttpPut]
        [Route("UpdateOrder")]
        public string EditOrder(Order o)
        {
            db.Orders.Update(o);
            db.SaveChanges();
            return "Order updated";
        }


    }
}
