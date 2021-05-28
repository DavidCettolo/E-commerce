
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_web_app.Controllers
{
    public class ItemController : Controller
    {
        private readonly IApiGet<Item> _apiGet;

        public ItemController(IApiGet<Item> apiGet) => _apiGet = apiGet;

        public async Task<ActionResult> Index()
        {
            var itemUrl = $@"{Environment.GetEnvironmentVariable("ItemApiUrl")}/Item";
            var items = await _apiGet.GetApiAsync(itemUrl);          
            return View(items);
        }
             
    }
}
