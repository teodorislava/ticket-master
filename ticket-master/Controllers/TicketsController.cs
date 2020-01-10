using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ticket_master.Models;
using ticket_master.Repositories;

namespace ticket_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly TicketRepository repository;
        public TicketsController(TicketRepository repository)
        {
            this.repository = repository;
        }

        // GET api/tickets
        [HttpGet("")]
        public ActionResult<IEnumerable<Ticket>> GetTickets()
        {
            return this.repository.GetTickets();
        }

        // GET api/tickets/5
        [HttpGet("{id}")]
        public ActionResult<Ticket> GetTicketById(int id)
        {
            return null;
        }

        [HttpGet("type/{type}")]
        public ActionResult<List<Ticket>> GetTicketsByType(string type)
        {
            return this.repository.GetTicketsByType(type);
        }

        [HttpGet("price/{price}")]
        public ActionResult<List<Ticket>> GetTicketUnderPrice(decimal price)
        {
            return this.repository.GetTicketsUnderPrice(price);
        }

        [HttpGet("valid")]
        public ActionResult<List<Ticket>> GetValidTickets()
        {
            return this.repository.GetValidTickets();
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