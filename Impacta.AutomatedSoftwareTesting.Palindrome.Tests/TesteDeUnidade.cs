using Impacta.AutomatedSoftwareTesting.Palindrome.App;
using Xunit;

namespace Impacta.AutomatedSoftwareTesting.Palindrome.Tests
{
    public class TesteDeUnidade
    {
        [InlineData("Rotator")]
        [InlineData("bob")]
        [InlineData("madam")]
        [InlineData("mAlAyAlam")]
        [InlineData("1")]
        [InlineData("Able was I, ere I saw Elba")]
        [InlineData("Madam I’m Adam")]
        [InlineData("Step on no pets.")]
        [InlineData("Top spot!")]
        [InlineData("02/02/2020")]
        [Theory]
        public void FraseTest_DeveraReceberUmaFrase_EValidarComoPositivoSeEPalindrome(string frase)
        {
            var fraseTeste = new FraseTeste(frase);

            Assert.True(fraseTeste.Resultado); 
        }

        [InlineData("xyz")]
        [InlineData("elephant")]
        [InlineData("Country")]
        [InlineData("Top . post!")]
        [InlineData("Wonderful-fool")]
        [InlineData("Wild imagination!")]
        [Theory]
        public void FraseTest_DeveraReceberUmaFrase_EValidarComoNegativoSeEPalindrome(string frase)
        {
            var fraseTeste = new FraseTeste(frase);

            Assert.False(fraseTeste.Resultado);
        }
    }
}
