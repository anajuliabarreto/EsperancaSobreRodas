using EsperancaSobreRodasAPI.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EsperancaSobreRodasAPI.Services
{
    public class TokenService
    {
        public static string GenerateToken(UsuarioModel usuario)
        {
            var key = Encoding.ASCII.GetBytes(Key.SecretKey); //chamando minha chave privada
            var tokenConfig = new SecurityTokenDescriptor //configura da maneira com que deseja
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    new Claim("Id", usuario.Id.ToString()),
                    //new Claim("NomeUsuario", usuario.NomeUsuario.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(8),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);

            return tokenHandler.WriteToken(token);
        }
    }
}
