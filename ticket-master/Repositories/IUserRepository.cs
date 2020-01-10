using ticket_master.Models;
using ticket_master.ViewModels;

namespace ticket_master.Repositories
{
    public interface IUserRepository
    {
         UserVM GetCurrentUser(AuthRootTable user);
    }
}