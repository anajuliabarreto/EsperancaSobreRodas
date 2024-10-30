using EsperancaSobreRodasAPI.Data;
using EsperancaSobreRodasAPI.Models;
using EsperancaSobreRodasAPI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EsperancaSobreRodasAPI.Repositories
{  
        public class UsuarioRepository : IUsuarioRepository
        {

            private readonly EsperancaSobreRodasDBContext _dbContext;
            public UsuarioRepository(EsperancaSobreRodasDBContext esperancaSobreRodasDBContext)
            {
                _dbContext = esperancaSobreRodasDBContext;
            }

            public async Task<UsuarioModel> BuscarPorId(int id)
            {
                return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            }

            public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
            {
                return await _dbContext.Usuarios.ToListAsync();
            }

            public async Task<UsuarioModel> Cadastrar(UsuarioModel usuario)
            {
                await _dbContext.Usuarios.AddAsync(usuario);
                await _dbContext.SaveChangesAsync();

                return usuario;
            }
            public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
            {
                UsuarioModel usuarioPorId = await BuscarPorId(id);

                if (usuarioPorId == null)
                {
                    throw new Exception($"Usuário referente ao ID: {id} não foi encontrado");
                }

                usuarioPorId.NomeUsuario = usuario.NomeUsuario;
                usuarioPorId.TipoUsuario = usuario.TipoUsuario;
                usuarioPorId.NomePaciente = usuario.NomePaciente;
                usuarioPorId.SenhaUsuario = usuario.SenhaUsuario;
                usuarioPorId.TelefoneUsuario = usuario.TelefoneUsuario;

                _dbContext.Usuarios.Update(usuarioPorId);
                await _dbContext.SaveChangesAsync();

                return usuarioPorId;
            }

            public async Task<bool> Deletar(int id)
            {
                UsuarioModel usuarioPorId = await BuscarPorId(id);

                if (usuarioPorId == null)
                {
                    throw new Exception($"Usuário referente ao ID: {id} não foi encontrado");
                }

                _dbContext.Usuarios.Remove(usuarioPorId);
                await _dbContext.SaveChangesAsync();

                return true;
            }
        }
}

