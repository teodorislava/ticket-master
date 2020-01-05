using Microsoft.EntityFrameworkCore;

namespace ticket_master.Models
{
    public class TicketMasterDbContext : DbContext
    {
        public TicketMasterDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Test> Test { get; set; }
    }

    public class Test {
        public int Id { get; set; }
        public int Age { get; set; }
    }
}