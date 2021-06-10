using APIRest01.Model;
using APIRest01.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRest01.Controllers {
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiversion}")]
    public class PersonController : ControllerBase {
        

        private readonly ILogger<PersonController> _logger;
        private IpersonServices _personService;

        public PersonController(ILogger<PersonController> logger, IpersonServices personService) {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get() {
         
            return Ok(  _personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id) {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();
            return Ok();
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Person person) {
            if (person == null) return BadRequest();
            return Ok(_personService.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person) {
            if (person == null) return BadRequest();
            return Ok(_personService.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id) {
            _personService.Delete(id);
            return NoContent();
        }



    }
}
