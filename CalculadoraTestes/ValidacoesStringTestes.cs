using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTestes
    {
        private ValidacoesString _validaString;
        public ValidacoesStringTestes()
        {
            _validaString = new ValidacoesString();
        }

        [Fact]
        public void DeveReceberStringTesteERetornar5()
        {
            //Arrange
            string teste = "teste";

            //Act
            var resultado = _validaString.ContaCaracteres(teste);

            //Assert
            Assert.Equal(5, resultado);
        }
    }
}