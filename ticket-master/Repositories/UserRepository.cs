using ticket_master.Models;
using ticket_master.ViewModels;

namespace ticket_master.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TicketMasterDbContext context;

        public UserRepository(TicketMasterDbContext context) {
            this.context = context;
        }

        public UserVM GetCurrentUser(AuthRootTable user)
        {
            return new UserVM()
            {
                IsOrganisation = user.IsOrganisation,
                Email = user.Email,
                RegisteredOn = user.IsOrganisation ? user.Organisation.DateRegistered : user.TicketBuyer.DateRegistered,
                Organisation = new OrganisationVM()
                {
                    Name = user.Organisation?.Name,
                    IncorporatedDate = user.Organisation?.IncorporatedDate,
                    Description = user.Organisation?.Description,
                    PhoneNumber = user.Organisation?.PhoneNumber,
                    AddressLine1 = user.Organisation?.AddressLine1,
                    AddressLine2 = user.Organisation?.AddressLine2,
                    AddressLine3 = user.Organisation?.AddressLine3,
                    Country = user.Organisation?.Country,
                    State = user.Organisation?.State,
                    City = user.Organisation?.City,
                    ZipCode = user.Organisation?.ZipCode,
                    Turnover = user.Organisation?.Turnover ?? 0,
                    OffersCount = user.Organisation?.Tickets.Count ?? 0
                },
                TicketBuyer = new TicketBuyerVM()
                {
                    FirstName = user.TicketBuyer?.FirstName,
                    LastName = user.TicketBuyer?.LastName,
                    Birthdate = user.TicketBuyer?.Birthdate,
                    Gender = user.TicketBuyer?.Gender,
                    BoughtCount = user.TicketBuyer?.Bought.Count ?? 0
                }
            };
        }
    }
}