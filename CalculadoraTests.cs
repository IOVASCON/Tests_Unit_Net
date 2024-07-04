using Xunit;
using ExemploTDD;

namespace ExemploTDD.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Adicionar_DeveRetornarSoma()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Adicionar(2, 3);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Subtrair_DeveRetornarDiferenca()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Subtrair(5, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Multiplicar_DeveRetornarProduto()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Multiplicar(2, 3);
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void Dividir_DeveRetornarQuociente()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(6, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Dividir_DeveLancarExcecaoParaDivisaoPorZero()
        {
            var calculadora = new Calculadora();
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(6, 0));
        }
    }
}
