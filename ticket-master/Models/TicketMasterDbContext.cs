using Microsoft.EntityFrameworkCore;

namespace ticket_master.Models
{
    public class TicketMasterDbContext : DbContext
    {
        public TicketMasterDbContext(DbContextOptions options) : base(options)
        {
        }

          protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Entity<Offer>()
            .Property(x=> x.ValidFrom)
            .HasColumnType("datetime");

            builder.Entity<Offer>()
            .Property(x=> x.ValidTo)
            .HasColumnType("datetime");
    }

        public DbSet<Test> Test { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Bought> Bought { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
    }

    public class Test {
        public int Id { get; set; }
        public int Age { get; set; }
    }
}