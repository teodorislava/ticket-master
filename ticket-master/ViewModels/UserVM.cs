using System;

namespace ticket_master.ViewModels
{
    public class UserVM
    {
        public bool IsOrganisation { get; internal set; }
        public string Email { get; set; }
        public DateTime RegisteredOn { get; set; }
        public OrganisationVM Organisation { get; set; }
        public TicketBuyerVM TicketBuyer { get; set; }
    }

    public class OrganisationVM
    {
        public string Name { get; set; }
        public DateTime? IncorporatedDate { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public decimal Turnover { get; set; }
        public int OffersCount { get; set; }
    }

    public class TicketBuyerVM
    {
         public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }
        public int BoughtCount { get; set; }
    }
}