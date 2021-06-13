using APIRest01.Model;
using APIRest01.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIRest01.Data.Vo;
using APIRest01.Hypermidia.Filter;

namespace APIRest01.Controllers {
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiversion}")]
    public class PersonController : ControllerBase {
        

        private readonly ILogger<PersonController> _logger;
        private IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness) {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<PersonVo>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMidiaFilter))]
        public IActionResult Get() {
         
            return Ok(_personBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(PersonVo))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMidiaFilter))]
        public IActionResult Get(long id) {
            var person = _personBusiness.FindById(id);
            if (person == null) return NotFound();
            return Ok();
        }
        
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(PersonVo))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMidiaFilter))]
        public IActionResult Post([FromBody] PersonVo person) {
            if (person == null) return BadRequest();
            return Ok(_personBusiness.Create(person));
        }

        [HttpPut]
        [ProducesResponseType((200), Type = typeof(PersonVo))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMidiaFilter))]
        public IActionResult Put([FromBody] PersonVo person) {
            if (person == null) return BadRequest();
            return Ok(_personBusiness.Update(person));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id) {
            _personBusiness.Delete(id);
            return NoContent();
        }



    }
}
