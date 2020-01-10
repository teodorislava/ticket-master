using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ticket_master.Models;
using ticket_master.ViewModels;

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
        public ActionResult<IEnumerable<TicketSummaryVM>> GetTickets()
        {
            return new List<TicketSummaryVM>
             {
                 new TicketSummaryVM()
                 {
                     Id = 1,
                     Name = "Ticket 1",
                     Type = "Avio",
                     Note = "OO weee",
                     OrganisationName = "The Flyers"
                 },
                 new TicketSummaryVM()
                 {
                     Id = 2,
                     Name = "Ticket 2",
                     Type = "Concert",
                     Note = "OO weee 2",
                     OrganisationName = "The Singers"
                 },
                 new TicketSummaryVM()
                 {
                     Id = 3,
                     Name = "Ticket 3",
                     Type = "Scuba",
                     Note = "OO weee 3",
                     OrganisationName = "The Swimmers"
                 },
            };
        }

        // GET api/tickets/5
        [HttpGet("{id}")]
        public ActionResult<TicketDetailsVM> GetTicketById(int id)
        {
            return new TicketDetailsVM()
            {
                Name = "Ticket 1",
                Type = "Avio",
                Note = "OO weee",
                OrganisationName = "The Flyers",
                Price = 1500,
                FullPrice = 2500,
                Discount = ((decimal)1500)/2500,
                NumberSold = 15,
                NumberLeft = 150,
                ValidFrom = DateTime.Now.AddDays(-1),
                ValidTo = DateTime.Now.AddDays(1)
            };
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