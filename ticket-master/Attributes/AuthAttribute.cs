using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ticket_master.Attributes
{
    public class RoleRequirement : AuthorizationHandler<RoleRequirement>, IAuthorizationRequirement
    {

        public string Role { get; set; }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RoleRequirement requirement)
        {
            if(!context.User.IsInRole(Role))
                context.Fail();
            else
                context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }

    public class AuthFilterAttribute : Attribute, IAuthorizationFilter
    {
        public string Role { get; set; }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
             if (context.Result != null) return; 

            if(!context.HttpContext.User.IsInRole(Role))
            {
                context.Result = new ForbidResult();
            }
        }
    }

}
