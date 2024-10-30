using EsperancaSobreRodasAPI.Models;
using EsperancaSobreRodasAPI.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EsperancaSobreRodasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoristaController : ControllerBase
    {
        private readonly IMotoristaRepository _motoristaRepository;

        public MotoristaController(IMotoristaRepository motoristaRepository)
        {
            _motoristaRepository = motoristaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<MotoristaModel>>> BuscarTodosMotoristas()
        {
            List<MotoristaModel> motoristas = await _motoristaRepository.BuscarTodosMotoristas();
            return Ok(motoristas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MotoristaModel>> BuscarPorId([FromRoute] int id)
        {
            MotoristaModel motorista = await _motoristaRepository.BuscarPorId(id);
            return Ok(motorista);
        }

        [HttpPost]
        public async Task<ActionResult<MotoristaModel>> Cadastrar([FromBody] MotoristaModel motoristaModel)
        {
            MotoristaModel motorista = await _motoristaRepository.Cadastrar(motoristaModel);
            return Ok(motorista);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MotoristaModel>> Atualizar([FromBody] MotoristaModel motoristaModel, int id)
        {
            motoristaModel.Id = id;
            MotoristaModel motorista = await _motoristaRepository.Atualizar(motoristaModel, id);
            return Ok(motorista);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Deletar([FromRoute] int id)
        {
            bool apagado = await _motoristaRepository.Deletar(id);
            return Ok(apagado);
        }
    }
}
