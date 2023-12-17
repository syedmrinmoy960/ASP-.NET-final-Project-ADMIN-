using BEL;
using BLL.Services;
using Project.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.Controllers
{
    public class UserController : ApiController
    {
        [CustomAuth]
        [Route("api/User/All")]
        [HttpGet]

        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, UserService.GetAll());
        }


        [Route("api/User/DeleteUser/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            bool sucess = UserService.Delete(id);
            return Request.CreateResponse(sucess ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }


        [Route("api/User/EditUser")]
        [HttpPost]
        public HttpResponseMessage Edit(UserModel e)
        {
            bool sucess = UserService.Edit(e);

            return Request.CreateResponse(sucess ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }


        [Route("api/User/AddUser")]
        [HttpPost]
        public HttpResponseMessage Add(UserModel e)
        {
            bool sucess = UserService.Add(e);
            return Request.CreateResponse(sucess ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }


        [Route("api/User/GetUser/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, UserService.Get(id));
        }
    }
}
