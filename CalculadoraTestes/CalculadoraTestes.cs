using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{

    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }


    [Fact]
    public void SomarTeste()
    {
        // Somar 5 com 10 e retornar 15
        // Somar 20 com 30 e retornar 50

        // Arrange
        var num1 = 5;
        var num2 = 10;
        var num3 = 20;
        var num4 = 30;

        // Act
        var resultado = _calc.Somar(num1, num2);
        var resultado2 = _calc.Somar(num3, num4);

        // Assert
        Assert.Equal(15, resultado);
        Assert.Equal(50, resultado2);
    }

    [Fact]
    public void SubtrairTeste()
    {
        // Subtrair 10 de 5 e retornar -5

        // Arrange
        var num1 = 10;
        var num2 = 5;

        // Act
        var resultado = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void MultiplicarTeste()
    {
        // Multiplicar 5 por 10 e retornar 50

        // Arrange
        var num1 = 5;
        var num2 = 10;

        // Act
        var resultado = _calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(50, resultado);
    }

    [Fact]
    public void DividirTeste()
    {
        // Dividir 10 por 5 e retornar 2

        // Arrange
        var num1 = 10;
        var num2 = 5;

        // Act
        var resultado = _calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void RestoDivisaoTeste()
    {
        // Calcular o resto da divisão de 10 por 5 e retornar 0

        // Arrange
        var num1 = 10;
        var num2 = 5;

        // Act
        var resultado = _calc.RestoDivisao(num1, num2);

        // Assert
        Assert.Equal(0, resultado);
    }

    [Fact]
    public void PotenciaTeste()
    {
        // Calcular 5 elevado a 2 e retornar 25

        // Arrange
        var num1 = 5;
        var num2 = 2;

        // Act
        var resultado = _calc.Potencia(num1, num2);

        // Assert
        Assert.Equal(25, resultado);
    }

    [Fact]
    public void RaizQuadradaTeste()
    {
        // Calcular a raiz quadrada de 25 e retornar 5

        // Arrange
        var num1 = 25;

        // Act
        var resultado = _calc.RaizQuadrada(num1);

        // Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void RaizCubicaTeste()
    {
        // Calcular a raiz cúbica de 27 e retornar 3

        // Arrange
        var num1 = 27;

        // Act
        var resultado = _calc.RaizCubica(num1);

        // Assert
        Assert.Equal(3, resultado);
    }

    [Fact]
    public void LogaritmoBase10Teste()
    {
        // Calcular o logaritmo de 1000 na base 10 e retornar 3

        // Arrange
        var num1 = 1000;

        // Act
        var resultado = _calc.LogaritmoBase10(num1);

        // Assert
        Assert.Equal(3, resultado);
    }

    [Fact]
    public void LogaritmoNaturalTeste()
    {
        // Calcular o logaritmo natural de 1000 e retornar 6.907755278982137

        // Arrange
        var num1 = 1000;

        // Act
        var resultado = _calc.LogaritmoNatural(num1);

        // Assert
        Assert.Equal(6.907755278982137, resultado);
    }

    [Fact]
    public void FatorialTeste()
    {
        // Calcular o fatorial de 5 e retornar 120

        // Arrange
        var num1 = 5;

        // Act
        var resultado = _calc.Fatorial(num1);

        // Assert
        Assert.Equal(120, resultado);
    }

    [Fact]
    public void FibonacciTeste()
    {
        // Calcular o 5º número da sequência de Fibonacci e retornar 5

        // Arrange
        var num1 = 5;

        // Act
        var resultado = _calc.Fibonacci(num1);

        // Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void EhParTeste()
    {
        // Verificar se 5 é par e retornar false
        // Verificar se 10 é par e retornar true

        // Arrange
        var num1 = 5;
        var num2 = 10;

        // Act
        var resultado = _calc.EhPar(num1);
        var resultado2 = _calc.EhPar(num2);

        // Assert
        Assert.False(resultado);
        Assert.True(resultado2);
    }

}