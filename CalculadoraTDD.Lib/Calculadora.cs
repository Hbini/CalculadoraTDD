using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraTDD.Lib
{
    /// <summary>
    /// Classe Calculadora que implementa operações matemáticas básicas com suporte a histórico.
    /// </summary>
    public class Calculadora
    {
        private readonly List<Operacao> _historico = new();

        /// <summary>
        /// Soma dois números.
        /// </summary>
        public decimal Somar(decimal numero1, decimal numero2)
        {
            var resultado = numero1 + numero2;
            _historico.Add(new Operacao { Numero1 = numero1, Numero2 = numero2, Operador = "+", Resultado = resultado });
            return resultado;
        }

        /// <summary>
        /// Subtrai dois números.
        /// </summary>
        public decimal Subtrair(decimal numero1, decimal numero2)
        {
            var resultado = numero1 - numero2;
            _historico.Add(new Operacao { Numero1 = numero1, Numero2 = numero2, Operador = "-", Resultado = resultado });
            return resultado;
        }

        /// <summary>
        /// Multiplica dois números.
        /// </summary>
        public decimal Multiplicar(decimal numero1, decimal numero2)
        {
            var resultado = numero1 * numero2;
            _historico.Add(new Operacao { Numero1 = numero1, Numero2 = numero2, Operador = "*", Resultado = resultado });
            return resultado;
        }

        /// <summary>
        /// Divide dois números.
        /// </summary>
        /// <exception cref="ArgumentException">Lançada quando divisor é zero.</exception>
        public decimal Dividir(decimal numero1, decimal numero2)
        {
            if (numero2 == 0)
                throw new ArgumentException("Não é possível dividir por zero", nameof(numero2));

            var resultado = numero1 / numero2;
            _historico.Add(new Operacao { Numero1 = numero1, Numero2 = numero2, Operador = "/", Resultado = resultado });
            return resultado;
        }

        /// <summary>
        /// Calcula a raíz quadrada de um número.
        /// </summary>
        /// <exception cref="ArgumentException">Lançada quando número é negativo.</exception>
        public decimal RaizQuadrada(decimal numero)
        {
            if (numero < 0)
                throw new ArgumentException("Não é possível calcular raiz quadrada de número negativo", nameof(numero));

            var resultado = (decimal)Math.Sqrt((double)numero);
            _historico.Add(new Operacao { Numero1 = numero, Operador = "√", Resultado = resultado });
            return resultado;
        }

        /// <summary>
        /// Retorna o histórico de operações.
        /// </summary>
        public IEnumerable<Operacao> ObterHistorico() => _historico.AsReadOnly();

        /// <summary>
        /// Limpa o histórico de operações.
        /// </summary>
        public void LimparHistorico() => _historico.Clear();
    }
}
