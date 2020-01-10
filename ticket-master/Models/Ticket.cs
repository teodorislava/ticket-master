using System.Collections.Generic;

namespace ticket_master.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
        public virtual ICollection<Bought> Bought { get; set; }
        public virtual Organisation Organisation { get; set; }

    }
}