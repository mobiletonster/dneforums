using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.Web.Controllers
{
    public class UsersController : ApiController
    {
        public string Get()
        {
            return "Tony Spencer";
        }
    }
}
