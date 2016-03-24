using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Security.Principal;
using System.Threading;
using App.Core.Security;
using System.Web.Http;

namespace App.Web.Security
{
    public class AuthAttribute : AuthorizationFilterAttribute
    {
        private const string SCHEME = "Bearer";
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var authHeader = actionContext.Request.Headers.Authorization;
            if (authHeader != null)
            {
                if (authHeader.Scheme == SCHEME)
                {
                    var rawCredentials = authHeader.Parameter;
                    if (AuthHelper.CheckCredentials(rawCredentials))
                    {
                        Thread.CurrentPrincipal = GetClientPrincipal(rawCredentials);
                        ((ApiController)actionContext.ControllerContext.Controller).User = Thread.CurrentPrincipal;
                        return;
                    }
                }
            }
                    
            HandleUnauthorized(actionContext);
        }

        private void HandleUnauthorized(HttpActionContext actionContext)
        {
            var req = actionContext.Request;
            actionContext.Response = req.CreateResponse(HttpStatusCode.Unauthorized);
            // actionContext.Response.Headers.Add("WWW-Authenticate", "token Scheme='" + SCHEME + "' ");
        }


        private static IPrincipal GetClientPrincipal(string rawCredentials)
        {
            var encoding = Encoding.GetEncoding("iso-8859-1");
            var credentials = encoding.GetString(Convert.FromBase64String(rawCredentials));  // mobiletony@msn.com|1|1854|7/25/2014 11:06:50 PM
            var split = credentials.Split('|');
            var username = split[0];
            var uid = split[1];
            var clientId = Convert.ToInt32(uid);

            var identity = new GenericIdentity(uid, "UserId");
            string[] roles = { "User" };

            return new GenericPrincipal(identity, roles);
        }

    }
}