namespace GeradorSenhasMVC.Models
{
    public class SenhaModel
    {
        public bool LetrasMinusculas { get; set; }
        public bool LetrasMaiusculas { get; set; }
        public bool Numeros { get; set; }
        public bool CaracteresEspeciais { get; set; }
        public int Tamanho { get; set; } = 12;
        public string? SenhaGerada { get; set; }
    }
}