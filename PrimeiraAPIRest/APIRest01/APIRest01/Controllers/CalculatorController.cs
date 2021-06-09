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
        public IActionResult Soma(string primeiroNumero, string segundoNumero) {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero)) {
                var soma = ConverterParaDecimal(primeiroNumero) + ConverterParaDecimal(segundoNumero);
                return Ok(soma.ToString());
            }
            return BadRequest("Entrada fornecida inválida");
        }

        [HttpGet("sub/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Sub(string primeiroNumero, string segundoNumero) {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero)) {
                var sub = ConverterParaDecimal(primeiroNumero) - ConverterParaDecimal(segundoNumero);
                return Ok(sub.ToString());
            }
            return BadRequest("Entrada fornecida inválida");
        }

        [HttpGet("div/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Divisao(string primeiroNumero, string segundoNumero) {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero)) {
                var divisao = ConverterParaDecimal(primeiroNumero) / ConverterParaDecimal(segundoNumero);
                return Ok(divisao.ToString());
            }
            return BadRequest("Entrada fornecida inválida");
        }

        [HttpGet("multi/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Multiplicacao(string primeiroNumero, string segundoNumero) {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero)) {
                var multiplicacao = ConverterParaDecimal(primeiroNumero) * ConverterParaDecimal(segundoNumero);
                return Ok(multiplicacao.ToString());
            }
            return BadRequest("Entrada fornecida inválida");
        }

        [HttpGet("raiz-quadrada/{primeiroNumero}")]
        public IActionResult RaizQuadrada(string primeiroNumero) {
            if (IsNumeric(primeiroNumero)) {
                var raizquadrada = Math.Sqrt((double)ConverterParaDecimal(primeiroNumero));
                return Ok(raizquadrada.ToString());
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
