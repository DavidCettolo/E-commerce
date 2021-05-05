
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

        public ActionResult Index()
        {
            var itemUrl = $@"http://ecommerce-item-api/Item";
            var items = _apiGet.GetApi(itemUrl);          
            return View(items);
        }
             
    }
}
