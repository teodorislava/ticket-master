using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ticket_master.Models;
using ticket_master.Repositories;
using ticket_master.ViewModels;

namespace ticket_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly TicketRepository repository;
        private readonly UserManager<AuthRootTable> _userManager;

        public TicketsController(TicketRepository repository, UserManager<AuthRootTable> userManager)
        {
            this.repository = repository;
            _userManager = userManager;
        }

        // GET api/tickets
        [HttpGet("")]
        public ActionResult<IEnumerable<TicketSummaryVM>> GetTickets()
        {
            return this.repository.GetTickets();
        }

        // GET api/tickets/5
        [HttpGet("{id}")]
        public ActionResult<TicketDetailsVM> GetTicketById(int id)
        {
            return this.repository.GetTicketById(id);
        }

        // POST api/tickets
        [HttpPost("")]
        public void PostTicket(Ticket value)
        {
        }

        // PUT api/tickets/5
        [HttpPut("{id}")]
        public async Task<ActionResult<TicketBuyer>> PutTicket(int id, Ticket value)
        {
            int userId = (await _userManager.FindByNameAsync(User.Identity.Name)).TicketBuyerId;
            if(this.repository.BuyTicket(id, userId))
                return Ok();
            else 
                return this.BadRequest();
        }

        // DELETE api/tickets/5
        [HttpDelete("{id}")]
        public void DeleteTicketById(int id)
        {
        }
    }
}