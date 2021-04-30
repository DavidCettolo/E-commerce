using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {       

        private readonly SqlProvider _context;

        public TestController()
        {
            _context = new SqlProvider();
        }


        [HttpGet]
        public string Get()
        {
            return _context.Get();
        }
    }
        
}
