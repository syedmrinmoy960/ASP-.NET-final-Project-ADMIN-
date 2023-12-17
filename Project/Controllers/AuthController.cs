using BEL;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.Controllers
{
    public class AuthController : ApiController
    {
        [Route("api/logout")]
        [HttpGet]
        public HttpResponseMessage Logout()
        {
            var token = Request.Headers.Authorization.Parameter.ToString();
           
            if (token != null)
            {
                var rs = AuthService.Logout(token);
                if (rs)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.OK, "sucess full");
                }



            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "sorry didnt log in yet");
        }
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Auth(AdminModel admin)
        {
            var data = AuthService.Auth(admin);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);



            }



            return Request.CreateResponse(HttpStatusCode.NotFound, "Admin the pro");
        }
    }
}
