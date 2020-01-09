using System;

namespace ticket_master.ViewModels
{
    public class CreateAccountOrganisationVM
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
    }

    public class CreateAccountUserVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }

    }

    public class CreateAccountVM
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsOrganisation { get; set;}

        public CreateAccountUserVM User { get; set; }
        public CreateAccountOrganisationVM Organisation { get; set; }
    }
}