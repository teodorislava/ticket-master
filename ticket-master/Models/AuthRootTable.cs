using Microsoft.AspNetCore.Identity;

namespace ticket_master.Models
{
    public class AuthRootTable : IdentityUser
    {
        public virtual TicketBuyer TicketBuyer { get; set; }
        public int TicketBuyerId {get;set;}
        public virtual Organisation Organisation { get; set; }
        public bool IsOrganisation { get; set; }
    }
}