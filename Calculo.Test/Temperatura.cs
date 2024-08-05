using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testes;

namespace Calculo.Test
{
    public class ConversorDeTemperaturaTeste
    {
        [Theory]
        [InlineData(0,32)]
        [InlineData(100,212)]
        [InlineData(-40, -40)]
        [InlineData(10, 50)]

        public void CelsiusFahreinheit(double celsius, double fahreinheit)
        {

            //Act 

            double result = ConverterTemperatura.ConverterCelsiusFahrenheit(celsius); 

            //Assert 
            Assert.Equal(fahreinheit, result, 1e-2);
        }

    }
}
