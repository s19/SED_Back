using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Controllers.Admin
{
    [EnableCors("AnotherPolicy")]
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        [Route("GetAdminData")]
        [Authorize]
        //[Authorize(Policy = Policies.Admin)]
        public IActionResult GetAdminData()
        {
            //var u = User.Identity;
            return Ok("This is a response from Admin method");
        }
    }
}
