using System.ComponentModel.DataAnnotations;
using System.Text;
using GeradorSenhasMVC.Core;
using GeradorSenhasMVC.Models;

namespace GeradorSenhasMVC.Services
{
    public class SenhaService : ISenhaService
    {
        public string GerarSenha(SenhaModel regrasSenha)
        {
            if (regrasSenha.Tamanho < 12 || regrasSenha.Tamanho > 50) throw new ValidationException("O tamanho da senha deve ser em 12 e 50 caracteres.");
            if (!regrasSenha.LetrasMaiusculas &&
                !regrasSenha.LetrasMinusculas &&
                !regrasSenha.Numeros &&
                !regrasSenha.CaracteresEspeciais) throw new ValidationException("Pelo menos uma opção deve ser selecionada.");

            string stringBase = MountStringBase(regrasSenha);

            string senha = GeneratePassword(regrasSenha.Tamanho, stringBase);

            return senha;
        }

        private string GeneratePassword(int tamanho, string stringBase)
        {
            if (string.IsNullOrEmpty(stringBase) || stringBase.Length == 0)
                return string.Empty;

            Random random = new Random();
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < tamanho; i++)
            {
                char caractereAleatorio = stringBase[random.Next(stringBase.Length)];
                resultado.Append(caractereAleatorio);
            }

            return resultado.ToString();
        }

        private static string MountStringBase(SenhaModel regrasSenha)
        {
            var stringBase = string.Empty;

            stringBase = regrasSenha.LetrasMaiusculas ? stringBase += PasswordConstants.Maiusculas : stringBase;
            stringBase = regrasSenha.LetrasMinusculas ? stringBase += PasswordConstants.Minusculas : stringBase;
            stringBase = regrasSenha.Numeros ? stringBase += PasswordConstants.Numeros : stringBase;
            stringBase = regrasSenha.CaracteresEspeciais ? stringBase += PasswordConstants.Especiais : stringBase;
            return stringBase;
        }
    }
}