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
    public class TicketsController : ControllerBase
    {
        public TicketsController()
        {
        }

        // GET api/tickets
        [HttpGet("")]
        public ActionResult<IEnumerable<Ticket>> GetTickets()
        {
            return new List<Ticket> { };
        }

        // GET api/tickets/5
        [HttpGet("{id}")]
        public ActionResult<Ticket> GetTicketById(int id)
        {
            return null;
        }

        // POST api/tickets
        [HttpPost("")]
        public void PostTicket(Ticket value)
        {
        }

        // PUT api/tickets/5
        [HttpPut("{id}")]
        public void PutTicket(int id, Ticket value)
        {
        }

        // DELETE api/tickets/5
        [HttpDelete("{id}")]
        public void DeleteTicketById(int id)
        {
        }
    }
}