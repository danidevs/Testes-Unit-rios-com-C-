
using Calculadora.Services;


namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void  DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;
        
        // Act
        int resultado = _calc.Somar(num1, num2);
        
        //Assert
        Assert.Equal (15, resultado);
    }

     [Fact]
    public void  DeveverificarSe4EParERetornaVerdade()
    {
        //Arrange
        int numero = 4;
        
        // Act
        bool resulatdo = _calc.EhPar(numero);
        
        //Assert
        Assert.True ( resulatdo);
    }

    [Theory]

    [InlineData (2)]
    [InlineData (4)]
    [InlineData (6)]
    [InlineData (8)]
    [InlineData (10)]
    
        public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro (int nurmero)

        {
            // act
            bool resultado = _calc.EhPar (nurmero);

            // Assert
            Assert.True (resultado);
        }

        

}




  