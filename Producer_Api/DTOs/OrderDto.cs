using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producer_Api.DTOs
{
    public class OrderDto
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
