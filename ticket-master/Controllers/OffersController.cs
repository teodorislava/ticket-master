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
    public class OffersController : ControllerBase
    {
        public OffersController()
        {
        }

        // GET api/offers
        [HttpGet("")]
        public ActionResult<IEnumerable<Offer>> GetOffers()
        {
            return new List<Offer> { };
        }

        // GET api/offers/5
        [HttpGet("{id}")]
        public ActionResult<Offer> GetOfferById(int id)
        {
            return null;
        }

        // POST api/offers
        [HttpPost("")]
        public void PostOffer(Offer value)
        {
        }

        // PUT api/offers/5
        [HttpPut("{id}")]
        public void PutOffer(int id, Offer value)
        {
        }

        // DELETE api/offers/5
        [HttpDelete("{id}")]
        public void DeleteOfferById(int id)
        {
        }
    }
}