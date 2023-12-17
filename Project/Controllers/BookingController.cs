using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.Controllers
{
    public class BookingController : ApiController
    {
        [Route("api/BookingInfo/All")]
        [HttpGet]

        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, BookingService.GetAll());
        }
    }
}
