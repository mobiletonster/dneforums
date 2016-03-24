using App.Models;
using App.Models.ViewModels;
using App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

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
        [ResponseType(typeof(List<UserVM>))]
        public IHttpActionResult Get()
        {
            var users = userService.GetUsers().Select(m => new UserVM(m)).ToList();
            return Ok(users);
        }

        [Route("api/users/{userId}")]
        [HttpGet]
        public User GetUserById(int userId)
        {
            var user = userService.GetUserById(userId);
            return user;
        }

        [ApiExplorerSettings(IgnoreApi =true)]
        [Route("api/users")]
        [HttpPost]
        [ResponseType(typeof(UserVM))]
        public IHttpActionResult CreateUser([FromBody]User user)
        {
            var newUser = userService.CreateUser(user);
            var userVM = new UserVM(newUser);
            return Created("/api/users", userVM);
        }
    }
}
