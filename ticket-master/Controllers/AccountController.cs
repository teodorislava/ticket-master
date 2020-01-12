using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ticket_master.Attributes;
using ticket_master.Models;
using ticket_master.ViewModels;
//using ticket_master.Models;

namespace ticket_master.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public AccountController(
            SignInManager<AuthRootTable> signInManager,
            UserManager<AuthRootTable> userManager, 
             TicketMasterDbContext context
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
             _context = context;
        }

         private readonly SignInManager<AuthRootTable> _signInManager;
        private readonly UserManager<AuthRootTable> _userManager;
        private readonly TicketMasterDbContext _context;

        // POST api/account
        [HttpPost("")]
        public async Task<ActionResult> Register([FromBody]CreateAccountVM model)
        {
            var user = new AuthRootTable { UserName = model.Email, Email = model.Email, IsOrganisation = model.IsOrganisation };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);
        
            if(!model.IsOrganisation)
            {
                var tmp = new TicketBuyer()
                {
                       FirstName = model.User.FirstName,
                       LastName = model.User.LastName,
                       Gender = model.User.Gender,
                       Email = model.Email,
                       DateRegistered = DateTime.Now,
                       Birthdate = model.User.Birthdate 
                };
                this._context.AppUsers.Add(tmp);
                user.TicketBuyer = tmp;
                this._context.SaveChanges();
                await _userManager.AddToRoleAsync(user, "client");
            }
            else
            {
                var tmp = new Organisation()
                {
                       Name = model.Organisation.Name,
                       IncorporatedDate = model.Organisation.IncorporatedDate,
                       Description = model.Organisation.Description,
                       DateRegistered = DateTime.Now,
                       PhoneNumber = model.Organisation.PhoneNumber,
                       Email = model.Email,
                       AddressLine1 = model.Organisation.AddressLine1,
                       AddressLine2 = model.Organisation.AddressLine2,
                       AddressLine3 = model.Organisation.AddressLine3,
                       Country = model.Organisation.Country,
                       State = model.Organisation.State,
                       City = model.Organisation.City,
                       ZipCode = model.Organisation.ZipCode,
                       Turnover = 0
                };
                this._context.Organisations.Add(tmp);
                user.Organisation = tmp;
                this._context.SaveChanges();
                await _userManager.AddToRoleAsync(user, "organisation");
            }

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Login([FromBody]LoginVM model)
        {
            var user = _context.AuthRootTable.FirstOrDefault(x=> x.Email == model.Username);
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            return new JsonResult(user.IsOrganisation);
        }
        [HttpGet("isUserOrganisation")]
        public async Task<ActionResult<bool>> IsUserOrganisation(){
            try
            {
                return (await _userManager.FindByNameAsync(User.Identity.Name)).IsOrganisation;
            } 
            catch
            {
                return false;
            }
        }
        

        [HttpDelete]
        [Authorize(Policy = "RequireClient")]
        public List<object> Uvrede(string uvreda){
            
            return new List<object>() {
                User.IsInRole("CLIENT"),
                User.Identity.IsAuthenticated,
                //User.Identity.Name,
                //User
            };
        }
    }
}