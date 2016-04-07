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


namespace App.Web.Security
{
    public class BasicAuthAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated) { return; }

            var authHeader = actionContext.Request.Headers.Authorization;

            if (authHeader != null)
            {
                if(authHeader.Scheme.Equals("basic", StringComparison.OrdinalIgnoreCase) &&
                    !string.IsNullOrWhiteSpace(authHeader.Parameter))
                {
                    var rawCredentials = authHeader.Parameter;
                    var encoding = Encoding.GetEncoding("iso-8859-1");
                    var credentials = encoding.GetString(Convert.FromBase64String(rawCredentials));
                    var split = credentials.Split(':');
                    var username = split[0];
                    var password = split[1];

                    // Implement some security to test for valid username and password pair.


                    // if (WebMatrix.WebData.WebSecurity.Login(username, password)) { 
                    // var principal = new GenericPrincipal(new GenericIdentity(username), null);
                    // Thread.CurrentPrincipal = principal;
                        // return; 
                    // }
                }
            }

            HandleUnauthorized(actionContext);
            base.OnAuthorization(actionContext);
        }

        private void HandleUnauthorized(HttpActionContext actionContext)
        {
            var req = actionContext.Request;
            actionContext.Response = req.CreateResponse(HttpStatusCode.Unauthorized);
            actionContext.Response.Headers.Add("WWW-Authenticate", "Basic Scheme='' location=''");

        }
    }
}