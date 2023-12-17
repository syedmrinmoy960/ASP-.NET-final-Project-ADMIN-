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
    public class EmployeeInfoController : ApiController
    {
        [Route("api/EmployeeInfo/All")]
        [HttpGet]

        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, EmployeeService.GetAll());
        }


        [Route("api/EmployeeInfo/DeleteEmployeeInfo/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            bool sucess = EmployeeService.Delete(id);
            return Request.CreateResponse(sucess ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }


        [Route("api/EmployeeInfo/EditEmployeeinfo")]
        [HttpPost]
        public HttpResponseMessage Edit(EmployeeModel e)
        {
            bool sucess = EmployeeService.Edit(e);

            return Request.CreateResponse(sucess ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }


        [Route("api/EmployeeInfo/AddEmployeeInfo")]
        [HttpPost]
        public HttpResponseMessage Add(EmployeeModel e)
        {
            bool sucess = EmployeeService.Add(e);
            return Request.CreateResponse(sucess ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }


        [Route("api/EmployeeInfo/GetEmployee/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, EmployeeService.Get(id));
        }
    }
}
