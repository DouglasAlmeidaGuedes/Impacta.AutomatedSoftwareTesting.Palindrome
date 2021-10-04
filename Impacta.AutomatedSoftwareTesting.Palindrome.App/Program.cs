using System;

namespace Impacta.AutomatedSoftwareTesting.Palindrome.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a frase para testar se é palindrome");
            var frase = Console.ReadLine();

            var fraseTeste = new FraseTeste(frase);
            if (fraseTeste.Resultado)
                Console.WriteLine("É um palindrome");
            else
                Console.WriteLine("Não é um palindrome");

            Console.ReadLine();
        }
    }
}
