using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        private readonly ITicketRepository repository;
        private readonly UserManager<AuthRootTable> _userManager;

        public TicketsController(ITicketRepository repository, UserManager<AuthRootTable> userManager)
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
        [Authorize(Policy = "RequireOrganisation")]
        public async Task<ActionResult> PostTicket(TicketCreationVM value)
        {
            try
            {
                var org = (await _userManager.FindByNameAsync(User.Identity.Name)).Organisation;
                repository.CreateTicket(value, org);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }

        // PUT api/tickets/5
        [HttpPut("{id}")]
        [Authorize(Policy = "RequireClient")]
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