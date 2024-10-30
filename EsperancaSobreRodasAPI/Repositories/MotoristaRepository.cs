using EsperancaSobreRodasAPI.Data;
using EsperancaSobreRodasAPI.Models;
using EsperancaSobreRodasAPI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace EsperancaSobreRodasAPI.Repositories
{
    public class MotoristaRepository : IMotoristaRepository
    {
        private readonly EsperancaSobreRodasDBContext _dbContext;
        public MotoristaRepository(EsperancaSobreRodasDBContext espSobreRodasDBContext)
        {
            _dbContext = espSobreRodasDBContext;
        }


        public async Task<MotoristaModel> BuscarPorId(int id)
        {
            return await _dbContext.Motoristas.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<MotoristaModel>> BuscarTodosMotoristas()
        {
            return await _dbContext.Motoristas.ToListAsync();
        }
        public async Task<MotoristaModel> Cadastrar(MotoristaModel motorista)
        {
            await _dbContext.Motoristas.AddAsync(motorista);
            await _dbContext.SaveChangesAsync();

            return motorista;
        }

        public async Task<MotoristaModel> Atualizar(MotoristaModel motorista, int id)
        {
            MotoristaModel motoristaPorId = await BuscarPorId(id);

            if (motoristaPorId == null)
            {
                throw new Exception($"Usuário referente ao ID: {id} não foi encontrado");
            }

            motoristaPorId.NomeMotorista = motorista.NomeMotorista;
            motoristaPorId.NumeroPlaca = motorista.NumeroPlaca;
            motoristaPorId.SenhaMotorista = motorista.SenhaMotorista;
            motoristaPorId.TelefoneMotorista = motorista.TelefoneMotorista;
            motoristaPorId.NumeroDocumentoMotorista = motorista.NumeroDocumentoMotorista;

            _dbContext.Motoristas.Update(motoristaPorId);
            await _dbContext.SaveChangesAsync();

            return motoristaPorId;
        }

        public async Task<bool> Deletar(int id)
        {
            MotoristaModel motoristaPorId = await BuscarPorId(id);

            if (motoristaPorId == null)
            {
                throw new Exception($"Usuário referente ao ID: {id} não foi encontrado");
            }

            _dbContext.Motoristas.Remove(motoristaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
