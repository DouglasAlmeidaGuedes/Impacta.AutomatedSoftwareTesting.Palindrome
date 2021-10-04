using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Impacta.AutomatedSoftwareTesting.Palindrome.App
{
    public class FraseTeste
    {
        public string Frase { get; private set; }
        public bool Resultado { get; private set; }


        public FraseTeste(string frase)
        {
            Frase = frase;

            var fraseSemAcentos = RemoverAcentos(frase);

            Resultado = fraseSemAcentos.ToUpper().SequenceEqual(fraseSemAcentos.ToUpper().Reverse());
        }

        private string RemoverAcentos(string frase)
        {
            string result = Regex.Replace(frase, @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s’/]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5));
            return Regex.Replace(result, @"[^\w\.@-]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5));
        }
    }
}
