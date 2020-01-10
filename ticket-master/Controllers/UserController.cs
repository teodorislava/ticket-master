using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ticket_master.Models;
using ticket_master.Repositories;
using ticket_master.ViewModels;

namespace ticket_master.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository repository;
        private readonly UserManager<AuthRootTable> _userManager;

        public UserController(IUserRepository repository, UserManager<AuthRootTable> userManager)
        {
            this.repository = repository;
            this._userManager = userManager;
        }

        // GET api/user
        [HttpGet("")]
        public async Task<ActionResult<UserVM>> GetUser()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            return this.repository.GetCurrentUser(user);
        }
    }
}