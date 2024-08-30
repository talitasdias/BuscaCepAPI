using BuscaCepApi.Repositories.Cep;
using BuscaCepApi.Services.Cep;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViaCepController : ControllerBase
    {
        private readonly IViaCepService _viaCepService;
        public ViaCepController(IViaCepService viaCepService)
        {
            _viaCepService = viaCepService;
        }

        [HttpGet("{cep}")]
        public async Task<IActionResult> BuscarEndereco(int cep)
        {
            try
            {
                var endereco = await _viaCepService.BuscarEndereco(cep);

                if (endereco == null)
                {
                    return BadRequest(new { message = "CEP inválido. O CEP deve ter 8 dígitos." });
                }

                return Ok(endereco);
            }
            catch
            (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = "Ocorreu um erro inesperado. Tente novamente mais tarde." });

            }
        }
    }
}
