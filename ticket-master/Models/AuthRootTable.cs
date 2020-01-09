using Microsoft.AspNetCore.Identity;

namespace ticket_master.Models
{
    public class AuthRootTable : IdentityUser
    {
        public TicketBuyer TicketBuyer { get; set; }
        public Organisation Organisation { get; set; }
        public bool IsOrganisation { get; set; }
    }
}