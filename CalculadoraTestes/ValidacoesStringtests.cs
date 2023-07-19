using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;


namespace CalculadoraTestes
{
    public class ValidacoesStringtests
    {
        private ValidacoesString _Validacoes;

        public ValidacoesStringtests()
        {
            _Validacoes = new ValidacoesString();
        }
        
        [Fact]
        public void DeveContar3CaracteresERetornar3()
        {
            // Arrange
            string texto = "ola";

            //Act
            int resultado = _Validacoes.ContarCaracteres(texto);

            // Assert
            Assert.Equal(3, resultado);
        }
        

    }
}