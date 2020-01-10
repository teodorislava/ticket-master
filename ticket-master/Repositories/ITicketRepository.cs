using System.Collections.Generic;
using ticket_master.Models;
using ticket_master.ViewModels;

namespace ticket_master.Repositories
{
    public interface ITicketRepository
    {
        List<TicketSummaryVM> GetTickets();
        List<TicketSummaryVM> GetValidTickets();
        List<TicketSummaryVM> GetTicketsByType(string type);
        List<TicketSummaryVM> GetTicketsUnderPrice(decimal price);
        TicketDetailsVM GetTicketById(int id);
        bool BuyTicket(int ticketId, int userId);
        bool CreateTicket(TicketCreationVM model, Organisation org);
    }
}