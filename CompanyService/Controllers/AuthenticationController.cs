using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CompanyService.Controllers
{
    [RoutePrefix("api/Authentication")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AuthenticationController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
      
        public IHttpActionResult ValidateUser([FromBody]Models.UserDto userDto)
        {
            if(userDto.UserName.Equals("uday.denduluri") && userDto.Password.Equals("password1"))
            {
                return Ok(new { ValidUser = true, Reason = "Validated" });
            }
            return Ok(new { ValidUser = false, Reason = "Invalid User" });
        }

        [HttpPost]
        public IHttpActionResult Logout(string userName)
        {
            return Ok();
        }
    }
}
