using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ecommerce_cart_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ISqlProvider<Order> _orderSqlProvider;

        public OrderController(ISqlProvider<Order> orderSqlProvider) => _orderSqlProvider = orderSqlProvider;

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] Order order) => _orderSqlProvider.Insert(order);

    }
}
