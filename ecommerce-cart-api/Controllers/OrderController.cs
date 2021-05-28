using Microsoft.AspNetCore.Mvc;

namespace ecommerce_cart_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ISqlProvider<Order> _orderSqlProvider;

        private readonly ISqlProvider<Order> _orderSqlProvider;

        public OrderController(ISqlProvider<Order> orderSqlProvider) => _orderSqlProvider = orderSqlProvider;

        [HttpPost]
        public void Post([FromBody] Order order)
        {

            _orderSqlProvider.Insert(order);
        }
    }
}

/*var order = new Order() { C8 = c8, Quantity = 1, Userid = 1111 };
                var client = new MongoClient(connectionString);
                var database = server.GetDatabase("test"); // "test" is the name of the database
                var collection = database.GetCollection<Entity>("entities");
                var entity = new Entity { Name = "Tom" };
                collection.Insert(entity);
                var id = entity.Id; // Insert will set the Id if necessary (as it was in this example)*/
