using EsperancaSobreRodasAPI.Models;

namespace EsperancaSobreRodasAPI.Repositories.Interface
{
    public interface IUsuarioRepository
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Cadastrar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Deletar(int id);
    }
}
