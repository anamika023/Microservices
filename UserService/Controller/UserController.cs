using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UserSvc.Modal;

namespace UserSvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserData _userdata;

        public UserController(IUserData userdata)
        {
            this._userdata = userdata;
        }
       

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(_userdata.GetById(id));
        }

       
    }
}
