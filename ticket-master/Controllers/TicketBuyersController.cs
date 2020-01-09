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
    public class TicketBuyersController : ControllerBase
    {
        public TicketBuyersController()
        {
        }

        // GET api/users
        [HttpGet("")]
        public ActionResult<IEnumerable<TicketBuyer>> GetUsers()
        {
            return new List<TicketBuyer> { };
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<TicketBuyer> GetUserById(int id)
        {
            return null;
        }

        // POST api/users
        [HttpPost("")]
        public void PostUser(TicketBuyer value)
        {
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void PutUser(int id, TicketBuyer value)
        {
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void DeleteUserById(int id)
        {
        }
    }
}