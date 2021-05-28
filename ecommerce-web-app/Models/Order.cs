using System;

namespace ecommerce_web_app.Models
{
    public class Order
    {
        public int Userid { get; set; }

        public string C8 { get; set; }

        public int Quantity { get; set; }

        public DateTime Date => DateTime.Now;
    }


}

