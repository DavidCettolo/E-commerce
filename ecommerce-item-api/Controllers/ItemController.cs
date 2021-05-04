using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace ecommerce_item_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ISqlProvider<Item> _itemSqlProvider;

        public ItemController(ISqlProvider<Item> itemSqlProvider) => _itemSqlProvider = itemSqlProvider;

        [HttpGet]
        public IEnumerable<Item> Get() => _itemSqlProvider.GetItems().ToArray();

        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value) => _itemSqlProvider.ModifyQuantity(id, value);

    }
}
