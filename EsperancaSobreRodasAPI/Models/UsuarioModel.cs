namespace EsperancaSobreRodasAPI.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? NomePaciente { get; set; } //Caso o responsável se cadastre, saber quem é o paciente 
        public required string TipoUsuario { get; set; } //Informar se é paciente ou responsável
        public required string NomeUsuario { get; set; }
        public required string SenhaUsuario { get; set; }
        public required string TelefoneUsuario { get; set; }

        //public string EnderecoUsuario { get; set; } -> Posteriormente relacionar com a viagem 
    }
}
