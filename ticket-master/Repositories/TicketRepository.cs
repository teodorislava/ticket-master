using System.Collections.Generic;
using System.Linq;
using ticket_master.Models;
using ticket_master.ViewModels;

namespace ticket_master.Repositories
{
    public class TicketRepository: ITicketRepository
    {
        private readonly TicketMasterDbContext context;

        public TicketRepository(TicketMasterDbContext context) {
            this.context = context;
        }

        public bool BuyTicket(int ticketId, int userId)
        {
            
            var offer = this.context.Tickets.Where(x=> x.Id == ticketId).Select(x=> x.Offers.FirstOrDefault())
                .FirstOrDefault();
            
            if(offer.Current == offer.Capacity)
                return false;
            offer.Current++;
            offer.Ticket.Organisation.Turnover += offer.FullPrice * (1 - offer.DiscountAmount); 
            this.context.Bought.Add(new Bought() {
                Ticket = this.context.Tickets.FirstOrDefault(t => t.Id == ticketId),
                User = this.context.AppUsers.FirstOrDefault(u => u.Id == userId),
                Price = this.context.Offers.Select(o => new { 
                    Price = o.FullPrice * (1 - o.DiscountAmount),
                    Ticket = o.Ticket
                }).FirstOrDefault(o => o.Ticket.Id == ticketId).Price,
                PurchasedOn = System.DateTime.Now
            });
            this.context.SaveChanges();
            return true;
        }

        public TicketDetailsVM GetTicketById(int id)
        {
            return this.context.Offers.Where(o => o.Ticket.Id == id).Select(o => new TicketDetailsVM() {
                Name = o.Ticket.Name,
                Type = o.Ticket.Type,
                Note = o.Ticket.Note,
                OrganisationName = o.Ticket.Organisation.Name,
                Price = o.FullPrice * ((decimal)1.0 - o.DiscountAmount),
                FullPrice = o.FullPrice,
                Discount = o.DiscountAmount,
                NumberSold = o.Current,
                NumberLeft = o.Capacity - o.Current,
                ValidTo = o.ValidTo,
                ValidFrom = o.ValidFrom
            }).FirstOrDefault();
        }

        public List<TicketSummaryVM> GetTickets() 
        {
            return this.context.Tickets.Select(t => new TicketSummaryVM() {
                OrganisationName = t.Organisation.Name,
                Name = t.Name,
                Type = t.Type,
                Note = t.Note,
                Id = t.Id
            }).ToList();
        }
        public List<TicketSummaryVM> GetTicketsByType(string type)
        {
            return this.context.Tickets.Where(t => t.Type == type).Select(t => new TicketSummaryVM() {
                OrganisationName = t.Organisation.Name,
                Name = t.Name,
                Type = t.Type,
                Note = t.Note,
                Id = t.Id
            }).ToList();
        }

        public List<TicketSummaryVM> GetTicketsUnderPrice(decimal price)
        {
            return this.context.Offers.Where(o => o.FullPrice * (1-o.DiscountAmount) < price).Select(o => new TicketSummaryVM() {
                OrganisationName = o.Ticket.Organisation.Name,
                Name = o.Ticket.Name,
                Type = o.Ticket.Type,
                Note = o.Ticket.Note,
                Id = o.Ticket.Id
            }).ToList();
        }

        public List<TicketSummaryVM> GetValidTickets()
        {
            return this.context.Offers.Where(o => o.ValidTo > System.DateTime.Now).Select(o => new TicketSummaryVM() {
                OrganisationName = o.Ticket.Organisation.Name,
                Name = o.Ticket.Name,
                Type = o.Ticket.Type,
                Note = o.Ticket.Note,
                Id = o.Ticket.Id
            }).ToList();
        }
    }
}