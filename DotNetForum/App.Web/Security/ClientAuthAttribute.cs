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
using System.Web.Http;

namespace App.Web.Security
{
    public class ClientAuthAttribute : AuthorizationFilterAttribute
    {
        private const string BKA_SCHEME = "bka_token";
        private const string BKA_TOKEN = "QmthQXBpS2V5fEJrYVNlY3VyaXR5fEJLQTE1MDAwM3wyfDUwNXwzLzEwLzIwMTUgMjoxMzowMSBBTQ==";
        private const string BKA_API_KEY = "BkaApiKey";
        private const string BKA_API_KEY_VALUE = "BkaSecurity";
        private const string BKA_USER_ID = "BKA";
        //  LinkVehicle:BKA150003
        public override void OnAuthorization(HttpActionContext actionContext)
        {
#if DEBUG
            var identity = new GenericIdentity("2", "ClientId");
            string[] roles = { "ApiClient" };
            actionContext.RequestContext.Principal = new GenericPrincipal(identity, roles);

            return;
#endif
            var authHeader = actionContext.Request.Headers.Authorization;
            if (authHeader != null)
            {
                if (authHeader.Scheme == BKA_SCHEME)
                {
                    var rawCredentials = authHeader.Parameter;
                    if (CheckCredentials(rawCredentials))
                    {
                        actionContext.RequestContext.Principal = GetClientPrincipal(rawCredentials);
                        ((ApiController)actionContext.ControllerContext.Controller).User = actionContext.RequestContext.Principal;
                        return;
                    }
                }
            }

            if (actionContext.Request.Headers.Contains(BKA_SCHEME))
            {
                var flHeader = actionContext.Request.Headers.Where(m => m.Key == BKA_SCHEME).FirstOrDefault();
                var rawCredentials = flHeader.Value.FirstOrDefault();
                if (CheckCredentials(rawCredentials))
                {
                    actionContext.RequestContext.Principal = GetClientPrincipal(rawCredentials);
                    ((ApiController)actionContext.ControllerContext.Controller).User = actionContext.RequestContext.Principal;
                    return;
                }
            }
                    
            HandleUnauthorized(actionContext);
        }

        private void HandleUnauthorized(HttpActionContext actionContext)
        {
            var req = actionContext.Request;
            actionContext.Response = req.CreateResponse(HttpStatusCode.Unauthorized);
            actionContext.Response.Headers.Add("WWW-Authenticate", "token Scheme='" + BKA_SCHEME + "' ");
        }


        public static bool CheckCredentials(string rawCredentials)
        {
            try
            {
                var encoding = Encoding.GetEncoding("iso-8859-1");
                var credentials = encoding.GetString(Convert.FromBase64String(rawCredentials)); //BkaApiKey|BkaSecurity|BKA150003|2  // mobiletony@msn.com|1|1854|7/25/2014 11:06:50 PM
                var split = credentials.Split('|');
                var apiKey = split[0];
                var keyValue = split[1];

                if (apiKey != BKA_API_KEY || keyValue != BKA_API_KEY_VALUE)
                {
                    return false;
                }

                var username = split[2];
                var uid = split[3];
                var secretNumber = split[4];

                var clientId = Convert.ToInt32(uid);
                var checkSecretNumber = SecretNumber(username, clientId);
                if (secretNumber != checkSecretNumber)
                {
                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                // failed.
            }

            return false;
        }

        // Use this to generate the token.
        public static string GetCredentials(string username, int userId)
        {
            var encoding = Encoding.GetEncoding("iso-8859-1");
            var credentials = BKA_API_KEY + "|" + BKA_API_KEY_VALUE + "|" + username + "|" + userId + "|" + SecretNumber(username, userId) + "|" + DateTime.Now.Add(new TimeSpan(6, 0, 0));
            var credentialsBytes = encoding.GetBytes(credentials);
            var tokenized = Convert.ToBase64String(credentialsBytes);
            return tokenized;
        }

        public static IPrincipal GetClientPrincipal(string rawCredentials)
        {
            var encoding = Encoding.GetEncoding("iso-8859-1");
            var credentials = encoding.GetString(Convert.FromBase64String(rawCredentials)); //BkaApiKey|BkaSecurity|BKA150003|2  // mobiletony@msn.com|1|1854|7/25/2014 11:06:50 PM
            var split = credentials.Split('|');
            var username = split[2];
            var uid = split[3];
            var clientId = Convert.ToInt32(uid);

            var identity = new GenericIdentity(uid, "ClientId");
            string[] roles = {"ApiClient"};
                        
            return new GenericPrincipal(identity, roles);
        }

        private static string SecretNumber(string username, int userId)
        {
            var firstPart = StringToInt(username);
            var secretNumber = firstPart + userId;
            return secretNumber.ToString();
        }
        private static int StringToInt(string incoming)
        {
            var charray = incoming.ToCharArray();
            var intArray = charray.Select(m => (int)m);
            return intArray.Sum();
        }
    }
}