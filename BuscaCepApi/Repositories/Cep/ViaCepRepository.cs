using BuscaCepApi.Models;

namespace BuscaCepApi.Repositories.Cep
{
    public class ViaCepRepository : IViaCepRepository
    {
        private readonly HttpClient _httpClient;
        public ViaCepRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<EnderecoModel> BuscarEndereco(int cep)
        {
            throw new NotImplementedException();
        }
    }
}
