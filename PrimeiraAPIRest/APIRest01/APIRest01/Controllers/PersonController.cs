using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRest01.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase {
        

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger) {
            _logger = logger;
        }

        [HttpGet("soma/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Soma(string primeiroNumero, string segundoNumero) {
         
            return BadRequest("Entrada fornecida inválida");
        }  
    }
}
