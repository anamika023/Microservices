using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AggregatorService.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AggregatorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private IOrderDetails _orderDetails;

        public OrderDetailsController(IOrderDetails orderDetails)
        {
            this._orderDetails = orderDetails;
        }

        // GET: api/OrderDetails
        
        [HttpGet("{id}")]
        public string Get(int id)
        
        {
            try
            {
                var result = _orderDetails.GetOrderDetails(id);
                return result;
            }

            catch(Exception e)
            {
                return e.Message;
            }
        }


    }


}