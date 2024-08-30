using BuscaCepApi.Models;

namespace BuscaCepApi.Services.Cep
{
    public interface IViaCepService
    {
        Task<EnderecoModel> BuscarEndereco(int cep);
    }
}
