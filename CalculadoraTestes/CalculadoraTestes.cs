using System.Runtime.CompilerServices;
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImplementacao _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImplementacao();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;
        //Act
        var resultado = _calc.Somar(num1, num2);
        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void VerificaSeEhPar()
    {
        // Given
        int par = 2;
        // When
        var resultadoPar = _calc.EhPar(par);
        // Then
        Assert.True(resultadoPar);
    }

    [Fact]
    public void VerificaSeEhImpar()
    {
        // Given
        int impar = 1;
        // When
        var resultadoImpar = _calc.EhPar(impar);
        // Then
        Assert.False(resultadoImpar);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarNumerosParesERetornarTrue(int[] numeros)
    {
        // foreach (var numero in numeros)
        // {
        //     bool resultado = _calc.EhPar(numero);
        //     Assert.True(resultado);
        // }
        Assert.All(numeros, numero => Assert.True(_calc.EhPar(numero)));
    }
}