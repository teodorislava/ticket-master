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
    public class BoughtController : ControllerBase
    {
        public BoughtController()
        {
        }

        // GET api/bought
        [HttpGet("")]
        public ActionResult<IEnumerable<Bought>> GetBoughts()
        {
            return new List<Bought> { };
        }

        // GET api/bought/5
        [HttpGet("{id}")]
        public ActionResult<Bought> GetBoughtById(int id)
        {
            return null;
        }

        // POST api/bought
        [HttpPost("")]
        public void PostBought(Bought value)
        {
        }

        // PUT api/bought/5
        [HttpPut("{id}")]
        public void PutBought(int id, Bought value)
        {
        }

        // DELETE api/bought/5
        [HttpDelete("{id}")]
        public void DeleteBoughtById(int id)
        {
        }
    }
}