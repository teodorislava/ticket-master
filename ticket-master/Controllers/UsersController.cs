using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ticket_master.Models;

namespace ticket_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
        }

        // GET api/users
        [HttpGet("")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return new List<User> { };
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            return null;
        }

        // POST api/users
        [HttpPost("")]
        public void PostUser(User value)
        {
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void PutUser(int id, User value)
        {
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void DeleteUserById(int id)
        {
        }
    }
}