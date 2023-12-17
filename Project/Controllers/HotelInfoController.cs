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
    public class HotelInfoController : ApiController
    {
        [CustomAuth]
        [Route("api/HotelInfo/All")]
        [HttpGet]

        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, HotelInfoService.GetAll());
        }
        [Route("api/HotelInfo/DeleteHotelInfo/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            bool sucess = HotelInfoService.Delete(id);
            return Request.CreateResponse(sucess ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }


        [Route("api/HotelInfo/EditHotelinfo")]
        [HttpPost]
        public HttpResponseMessage Edit(HotelModel e)
        {
            bool sucess = HotelInfoService.Edit(e);

            return Request.CreateResponse(sucess ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }


        [Route("api/HotelInfo/AddHotelInfo")]
        [HttpPost]
        public HttpResponseMessage Add(HotelModel e)
        {
            bool sucess = HotelInfoService.Add(e);
            return Request.CreateResponse(sucess ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }


        [Route("api/HotelInfo/GetHotel/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, HotelInfoService.Get(id));
        }
    }
}
