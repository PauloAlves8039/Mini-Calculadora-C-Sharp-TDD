using Xunit;

namespace Calculadora.TDD.xUnit
{
    /// <summary>
    /// Responsável por realizar testes de unidade referentes a classe Calculadora.
    /// </summary>
    public class CalculadoraTest
    {
        /// <summary>
        /// Instância da classe Calculadora.
        /// </summary>
        Calculadora _calc = new Calculadora();

        /// <summary>
        /// Testa o resultado da soma entre dois valores inteiros.
        /// </summary>
        [Fact]
        public void SomarTest()
        {
            Assert.Equal(8, _calc.Somar(4, 4));
        }

        /// <summary>
        /// Testa o resultado da subtração entre dois valores inteiros.
        /// </summary>
        [Fact]
        public void SubtrairTest()
        {
            Assert.Equal(3, _calc.Subtrair(6, 3));
        }

        /// <summary>
        /// Testa o resultado da multiplicação entre dois valores inteiros.
        /// </summary>
        [Fact]
        public void MultiplicarTest()
        {
            Assert.Equal(10, _calc.Multiplicar(5, 2));
        }

        /// <summary>
        /// Testa o resultado da divisão entre dois valores inteiros.
        /// </summary>
        [Fact]
        public void DividirTest()
        {
            Assert.Equal(2, _calc.Dividir(4, 2));
        }
    }
}
