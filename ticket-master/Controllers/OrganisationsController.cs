using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ticket_master.Models;

namespace ticket_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationsController : ControllerBase
    {
        public OrganisationsController()
        {
        }

        // GET api/organisations
        [HttpGet("")]
        public ActionResult<IEnumerable<Organisation>> GetOrganisations()
        {
            return new List<Organisation> { };
        }

        // GET api/organisations/5
        [HttpGet("{id}")]
        public ActionResult<Organisation> GetOrganisationById(int id)
        {
            return null;
        }

        // POST api/organisations
        [HttpPost("")]
        public void PostOrganisation(Organisation value)
        {
        }

        // PUT api/organisations/5
        [HttpPut("{id}")]
        public void PutOrganisation(int id, Organisation value)
        {
        }

        // DELETE api/organisations/5
        [HttpDelete("{id}")]
        public void DeleteOrganisationById(int id)
        {
        }
    }
}