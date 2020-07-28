using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Modal;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET: api/Orders
        [HttpGet]
        public IEnumerable<OrderDto> Get()
        {

            var result = OrderDataAccess.Data;

            return result;
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public IEnumerable<OrderDto> Get(int id)
        {
            var result = OrderDataAccess.Data.Where(x => x.orderId == id);
            return result;
        }

       
    }
}
