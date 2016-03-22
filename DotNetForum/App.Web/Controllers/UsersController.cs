using App.Models;
using App.Services;
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
        private UserService userService;

        public UsersController()
        {
            userService = new UserService();
        }

        [Route("api/users")]
        [HttpGet]
        public List<User> Get()
        {
            var users = userService.GetUsers();
            return users;
        }

        [Route("api/users/{userId}")]
        [HttpGet]
        public User GetUserById(int userId)
        {
            var user = userService.GetUserById(userId);
            return user;
        }

        [Route("api/users")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]User user)
        {
            var userName = user.FirstName + "@ldschurch.org";
            return Ok(userName);
        }
    }
}
