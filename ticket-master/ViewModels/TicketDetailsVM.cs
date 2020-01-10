using System;

namespace ticket_master.ViewModels
{
    public class TicketDetailsVM
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public string OrganisationName { get; set; }
        public decimal Price { get; set; }
        public decimal FullPrice { get; set; }
        public decimal Discount { get; set; }
        public int NumberSold { get; set; }
        public int NumberLeft { get; set; }
        public DateTime ValidTo { get; set; }
        public DateTime ValidFrom { get; set; }
    }
}