using System.Collections.Generic;
using ticket_master.Models;

namespace ticket_master.Repositories
{
    public interface ITicketRepository
    {
        List<Ticket> GetTickets();
        List<Ticket> GetValidTickets();
        List<Ticket> GetTicketsByType(string type);
        List<Ticket> GetTicketsUnderPrice(decimal price);
    }
}