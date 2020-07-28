using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Modal
{
    public class OrderDto
    {
        public int orderId { get; set; }
        public int orderAmount { get; set; }

        public DateTime orderDate { get; set; }
    }
}
