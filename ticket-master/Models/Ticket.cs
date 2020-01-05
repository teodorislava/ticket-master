using System.Collections.Generic;

namespace ticket_master.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }

        public List<Offer> Offers { get; set; }
        public List<Bought> Bought { get; set; }
        public Organisation Organisation { get; set; }

    }
}