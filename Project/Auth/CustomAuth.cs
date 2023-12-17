using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Project.Auth
{
    public class CustomAuth: AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var authHeader = actionContext.Request.Headers.Authorization;
            if (authHeader == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.NotFound, "sorry not log in or wrong ");
            }
            else
            {
                string tok = authHeader.ToString();
                string mm = authHeader.Parameter.ToString();
                var re = AuthService.CheckValidityToken(mm);
                if (!re)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "unauthore");
                }
            }
            base.OnAuthorization(actionContext);
        }
    }
}