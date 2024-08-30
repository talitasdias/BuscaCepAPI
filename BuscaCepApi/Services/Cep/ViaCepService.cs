using BuscaCepApi.Models;
using BuscaCepApi.Repositories.Cep;

namespace BuscaCepApi.Services.Cep
{
    public class ViaCepService : IViaCepService
    {
        private readonly IViaCepRepository _viaCepRepository;
        public ViaCepService(IViaCepRepository viaCepRepository)
        {
            _viaCepRepository = viaCepRepository;
        }
        public async Task<EnderecoModel> BuscarEndereco(int cep)
        {
            if (cep.ToString().Length != 8)
            {
                return null;
            }

            return await _viaCepRepository.BuscarEndereco(cep);
        }
    }
}
