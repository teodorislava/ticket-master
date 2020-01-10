using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ticket_master.Models
{
    public class TicketMasterDbContext : IdentityDbContext
    {
        public TicketMasterDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Test> Test { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Bought> Bought { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketBuyer> AppUsers { get; set; }
        public DbSet<AuthRootTable> AuthRootTable { get; set; }
    }

    public class Test {
        public int Id { get; set; }
        public int Age { get; set; }
    }
}