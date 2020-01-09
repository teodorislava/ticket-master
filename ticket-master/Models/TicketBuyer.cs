using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticket_master.Models
{
    public class TicketBuyer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateRegistered { get; set; }

        public List<Bought> Bought { get; set; }
    }
}