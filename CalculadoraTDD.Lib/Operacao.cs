namespace CalculadoraTDD.Lib
{
    /// <summary>
    /// Representa uma operacionar realizada pela calculadora.
    /// </summary>
    public class Operacao
    {
        /// <summary>
        /// Primeiro número da operação.
        /// </summary>
        public decimal Numero1 { get; set; }

        /// <summary>
        /// Segundo número da operação (opcional para raíz quadrada).
        /// </summary>
        public decimal? Numero2 { get; set; }

        /// <summary>
        /// Síbolo do operador (+, -, *, /, √).
        /// </summary>
        public string? Operador { get; set; }

        /// <summary>
        /// Resultado da operação.
        /// </summary>
        public decimal Resultado { get; set; }

        /// <summary>
        /// Data e hora da operação.
        /// </summary>
        public DateTime DataOperacao { get; set; } = DateTime.Now;

        /// <summary>
        /// Retorna uma representação em string da operação.
        /// </summary>
        public override string ToString()
        {
            if (Numero2.HasValue)
                return $"{Numero1} {Operador} {Numero2} = {Resultado}";
            else
                return $"{Operador}({Numero1}) = {Resultado}";
        }
    }
}
