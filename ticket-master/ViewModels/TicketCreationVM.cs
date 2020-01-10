using System;

namespace ticket_master.ViewModels
{
    public class TicketCreationVM
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public decimal FullPrice { get; set; }
        public int Capacity { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string Description { get; set; }
        public decimal Discount { get; set; }
    }
}