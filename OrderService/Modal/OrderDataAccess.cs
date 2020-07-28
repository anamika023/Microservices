using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Modal
{
    public class OrderDataAccess
    {
        public static readonly List<OrderDto> Data = new List<OrderDto>
        {
            new OrderDto
            {
                orderId=1,
                orderAmount=250,
                orderDate=DateTime.Parse("14-Apr-2020")
            },
            new OrderDto
            {
                orderId = 2,
                orderAmount=450,
                orderDate = DateTime.Parse("15-Apr-2020")

            }

        };
    }
}
