using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class CalculadoraController : ControllerBase
    {
         
            
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Somar")]
        public IActionResult somar(double a, double b)
        {
            return Ok(a+ b);    
        }
        [HttpGet("Multiplicar")]
        public IActionResult multiplicar(double a, double b)
        {
            return Ok(a * b);
        }
        [HttpGet("Dividir")]
        public IActionResult dividir(double a, double b)
        {
            return Ok(a / b);
        }
        [HttpGet("Diminuir")]
        public IActionResult diminuir(double a, double b)
        {
            return Ok(a - b);
        }

        [HttpGet("Potencia")]
        public IActionResult potencia(double a, double b)
        {
            return Ok(
             Math.Pow(a, b)
                );
        }
    
        [HttpGet("Raiz Quadrada")]
        public IActionResult RaizQuadrada(double a)
        {
            


                if (a < 0)
                {
                    return BadRequest("Não é possivel declarar raiz quadrada de numero negativo");
                }

                return Ok(Math.Sqrt(a));
                


        }
        [HttpGet("Fatorial")]
        public IActionResult Fatorial(int n)
        {

            if(n < 0)
            {
                return BadRequest("Fatorial não é definido para númros negativos");

            }
            return Ok(FatorialCalc(n));
        }
        private int FatorialCalc(int n)
        {
            if(n ==0 || n == 1)
            {

                return 1;
            }
            return n * FatorialCalc(n - 1);
        }
        

    }
}