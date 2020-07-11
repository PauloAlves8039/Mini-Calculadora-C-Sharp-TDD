using System;

namespace Calculadora.TDD
{
    /// <summary>
    /// Classe responsável por representar a entidade calculadora.
    /// </summary>
    public class Calculadora
    {
        /// <summary>
        /// Representa a proriedade com valor 1.
        /// </summary>
        public int Valor1 { get; set; }

        /// <summary>
        /// Representa a proriedade com valor 2.
        /// </summary>
        public int Valor2 { get; set; }

        /// <summary>
        /// Contrutor responsável pela inicialização das proriedades.
        /// </summary>
        /// <param name="valor1">Recebe a prorriedade com valor 1.</param>
        /// <param name="valor2">Recebe a prorriedade com valor 1.</param>
        public Calculadora(int valor1, int valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        /// <summary>
        /// Construtor vázio adicionado para uso em classe de teste.
        /// </summary>
        public Calculadora()
        {

        }

        /// <summary>
        /// Responsável por somar dois valores.
        /// </summary>
        /// <param name="valor1">Indica o recebimento do primeiro valor.</param>
        /// <param name="valor2">Indica o recebimento do segundo valor.</param>
        /// <returns>A soma do valor 1 com o valor 2.</returns>
        public int Somar(int valor1, int valor2)
        {
            try
            {
                return valor1 + valor2;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Responsável por subtrair dois valores.
        /// </summary>
        /// <param name="valor1">Indica o recebimento do primeiro valor.</param>
        /// <param name="valor2">Indica o recebimento do segundo valor.</param>
        /// <returns>A subtração do valor 1 com o valor 2</returns>
        public int Subtrair(int valor1, int valor2)
        {
            try
            {
                return valor1 - valor2;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Responsável por multiplicar dois valores.
        /// </summary>
        /// <param name="valor1">Indica o recebimento do primeiro valor.</param>
        /// <param name="valor2">Indica o recebimento do segundo valor.</param>
        /// <returns>A multiplicação do valor 1 com o valor 2.</returns>
        public int Multiplicar(int valor1, int valor2)
        {
            try
            {
                return valor1 * valor2;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Responsável por dividir dois valores.
        /// </summary>
        /// <param name="valor1">Indica o recebimento do primeiro valor.</param>
        /// <param name="valor2">Indica o recebimento do segundo valor.</param>
        /// <returns>A divisão do valor 1 com o valor 2.</returns>
        public int Dividir(int valor1, int valor2)
        {
            try
            {
                return valor1 / valor2;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
