using System.Collections.Generic;
using ticket_master.Models;
using System.Linq;

namespace ticket_master.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly TicketMasterDbContext context;

        public TicketRepository(TicketMasterDbContext context) {
            this.context = context;
        }

        public List<Ticket> GetTickets() 
        {
            return this.context.Tickets.ToList();
        }
        public List<Ticket> GetTicketsByType(string type)
        {
            return this.context.Tickets.Where(t => t.Type == type).ToList();
        }

        public List<Ticket> GetTicketsUnderPrice(decimal price)
        {
            return this.context.Offers.Where(o => o.FullPrice * (1-o.DiscountAmount) < price).Select(o => o.Ticket).ToList();
        }

        public List<Ticket> GetValidTickets()
        {
            return this.context.Offers.Where(o => o.ValidTo > System.DateTime.Now).Select(o => o.Ticket).ToList();
        }
    }
}