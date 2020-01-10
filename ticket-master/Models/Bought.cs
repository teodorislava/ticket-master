using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticket_master.Models
{
    public class Bought
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PurchasedOn { get; set; }
        public string AdditionalInformation1 { get; set; }
        public string AdditionalInformation2 { get; set; }
        public string AdditionalInformation3 { get; set; }
        public TicketBuyer User { get; set; }
        public Ticket Ticket { get; set; }
        
    }
}