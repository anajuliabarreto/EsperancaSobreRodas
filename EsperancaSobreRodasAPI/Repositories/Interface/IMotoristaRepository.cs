using EsperancaSobreRodasAPI.Models;

namespace EsperancaSobreRodasAPI.Repositories.Interface
{
    public interface IMotoristaRepository
    {
        Task<MotoristaModel> BuscarPorId(int id);
        Task<List<MotoristaModel>> BuscarTodosMotoristas();
        //Task<UsuarioModel> BuscarPeloNome(string nomeUsuario);
        Task<MotoristaModel> Cadastrar(MotoristaModel motorista);
        Task<MotoristaModel> Atualizar(MotoristaModel motorista, int id);
        Task<bool> Deletar(int id);
    }
}
