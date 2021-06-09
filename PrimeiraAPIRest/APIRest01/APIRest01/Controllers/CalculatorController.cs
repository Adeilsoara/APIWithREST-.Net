using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRest01.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase {
        

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger) {
            _logger = logger;
        }

        [HttpGet("soma/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Get(string primeiroNumero, string segundoNumero) {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero)) {
                var soma = ConverterParaDecimal(primeiroNumero) + ConverterParaDecimal(segundoNumero);
                return Ok(soma.ToString());
            }
            return BadRequest("Entrada fornecida inválida");
        }


        private bool IsNumeric(string strNumero) {

            double numero;

            bool isNumber = double.TryParse(
               strNumero,
               System.Globalization.NumberStyles.Any,
               System.Globalization.NumberFormatInfo.InvariantInfo,
               out numero );
            return isNumber;
        }

        private decimal ConverterParaDecimal(string strNumero) {
            decimal decimalValor;
            if (decimal.TryParse(strNumero, out decimalValor)) {
                return decimalValor;
            }
            return 0;
        }

        
    }
}
