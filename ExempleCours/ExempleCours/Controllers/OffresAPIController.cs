using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExempleCours.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExempleCours.Controllers
{
    [Route("api/[controller]")]
    public class OffresAPIController : Controller
    {
        private IOffreRepo repo;

        public OffresAPIController(IOffreRepo repo)
        {
            this.repo = repo;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<OffreEntite> Get()
        {
            return repo.All;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<OffreEntite> Get(int id)
        {
            try
            {
                return repo.GetById(id);
            }
            catch(InvalidOperationException e)
            {
                return NotFound("Offre introuvable");
            }
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]OffreEntite value)
        {
            repo.Save(value); //TODO : corriger Save pour qu'il intitialise Id
            return Created($"api/OffresAPI/{value.Id}", value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]OffreEntite value)
        {
            value.Id = id;
            repo.Save(value);
            // TODO : retourner 404 si inexistant
        }
    }
}
