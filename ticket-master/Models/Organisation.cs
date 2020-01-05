using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticket_master.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IncorporatedDate { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateRegistered { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public decimal Turnover { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}