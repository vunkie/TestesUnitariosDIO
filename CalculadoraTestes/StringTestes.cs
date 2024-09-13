
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class StringTestes
    {

        private ValidacoesString _val;

        public StringTestes()
        {
            _val = new ValidacoesString();
        }

        [Fact]
        public void ContarCaracteresTeste()
        {
            // Contar os caracteres de "Teste" e retornar 5
            // Contar os caracteres de "Teste de Software" e retornar 17

            // Arrange
            var texto = "Teste";
            var texto2 = "Teste de Software";

            // Act
            var resultado = _val.ContarCaracteres(texto);
            var resultado2 = _val.ContarCaracteres(texto2);

            // Assert
            Assert.Equal(5, resultado);
            Assert.Equal(17, resultado2);
        }
    }
}