using Xunit;
using CalculadoraTDD.Lib;

namespace CalculadoraTDD.Tests
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora = new();

        [Fact]
        public void Somar_DoisNumeros_RetornaResultadoCorreto()
        {
            // Arrange & Act
            var resultado = _calculadora.Somar(5, 3);

            // Assert
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void Subtrair_DoisNumeros_RetornaResultadoCorreto()
        {
            // Arrange & Act
            var resultado = _calculadora.Subtrair(10, 4);

            // Assert
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void Multiplicar_DoisNumeros_RetornaResultadoCorreto()
        {
            // Arrange & Act
            var resultado = _calculadora.Multiplicar(6, 7);

            // Assert
            Assert.Equal(42, resultado);
        }

        [Fact]
        public void Dividir_DoisNumeros_RetornaResultadoCorreto()
        {
            // Arrange & Act
            var resultado = _calculadora.Dividir(20, 4);

            // Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Dividir_PorZero_LancaArgumentException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => _calculadora.Dividir(10, 0));
        }

        [Fact]
        public void RaizQuadrada_NumeroPositivo_RetornaResultadoCorreto()
        {
            // Arrange & Act
            var resultado = _calculadora.RaizQuadrada(16);

            // Assert
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void RaizQuadrada_NumeroNegativo_LancaArgumentException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => _calculadora.RaizQuadrada(-4));
        }

        [Fact]
        public void ObterHistorico_AposOperacoes_RetornaOperacoes()
        {
            // Arrange
            _calculadora.Somar(5, 3);
            _calculadora.Subtrair(10, 4);

            // Act
            var historico = _calculadora.ObterHistorico().ToList();

            // Assert
            Assert.Equal(2, historico.Count);
            Assert.Equal("+", historico[0].Operador);
            Assert.Equal("-", historico[1].Operador);
        }

        [Fact]
        public void LimparHistorico_AposOperacoes_LimpaOHistorico()
        {
            // Arrange
            _calculadora.Somar(5, 3);

            // Act
            _calculadora.LimparHistorico();
            var historico = _calculadora.ObterHistorico().ToList();

            // Assert
            Assert.Empty(historico);
        }
    }
}
