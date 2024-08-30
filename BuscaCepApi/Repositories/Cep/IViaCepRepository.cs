using BuscaCepApi.Models;

namespace BuscaCepApi.Repositories.Cep
{
    public interface IViaCepRepository
    {
        Task<EnderecoModel> BuscarEndereco(int cep);
    }
}
