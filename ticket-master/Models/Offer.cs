using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticket_master.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal FullPrice { get; set; }
        public int Capacity { get; set; }
        public int Current { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ValidFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ValidTo { get; set; }
        public string Description { get; set; }
        public bool Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}