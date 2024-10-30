namespace EsperancaSobreRodasAPI.Models
{
    public class MotoristaModel
    {
        public required int Id { get; set; }
        public required string NumeroPlaca { get; set; }
        public required string NomeMotorista { get; set; }
        public required string SenhaMotorista { get; set; }
        public required string TelefoneMotorista { get; set; }
        public required string NumeroDocumentoMotorista { get; set; } //CNH ou outro documento que comprove a qualificação

        //public int Status { get; set; } // Disponibilidade ou status ativo/inativo posteriormente
    }
}
