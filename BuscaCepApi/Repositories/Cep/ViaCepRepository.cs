using BuscaCepApi.Models;
using System.Text.Json;

namespace BuscaCepApi.Repositories.Cep
{
    public class ViaCepRepository : IViaCepRepository
    {
        private readonly HttpClient _httpClient;
        public ViaCepRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<EnderecoModel> BuscarEndereco(int cep)
        {
            try
            {
                var response = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<EnderecoModel>(jsonResponse);
            }
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException($"Erro ao buscar o CEP {cep}: {ex.Message}", ex);
            }
        }
    }
}
