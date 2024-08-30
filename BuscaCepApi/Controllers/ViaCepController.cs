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
    }
}
