using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace Entidades
{
    public static class Calculadora
    {
        #region Metodos

        /// <summary>
        /// Recibe un operador en formato String , lo valida , de ser valido realiza esa operacion entre numeroA y numeroB
        /// </summary>
        /// <param name="numeroA">primer numero a operar</param>
        /// <param name="numeroB">segundo numero a operar</param>
        /// <param name="operador">operacion a realizar</param>
        /// <returns>Retorna el resultado de la operacion , devuelve la suma en caso de que el operador fuera invalido </returns>
        public static double Operar( Numero numeroA, Numero numeroB, string operador )
        {

            double resultado = 0;

            operador = ValidarOperador(operador);

            switch (operador)
            {
                case "-":
                resultado = numeroA - numeroB;
                break;

                case "/":
                resultado = numeroA / numeroB;
                break;

                case "*":
                resultado = numeroA * numeroB;
                break;

                case "+":
                resultado = numeroA + numeroB;
                break;

                default:
                break;

            }

            return resultado;

        }

        /// <summary>
        /// Recibe un operador en formato String , valida que sea + , - . * o / , caso contrario devuelve +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>"operador" o "+" si el operador fuera invalido</returns>
        private static string ValidarOperador( string operador )
        {

            if (string.IsNullOrEmpty(operador))
            {
                operador = "+";
            }

            switch (operador)
            {
                case "-":
                break;

                case "/":
                break;

                case "*":
                break;

                case "+":
                break;

                default:
                operador = "+";
                break;
            }

            return operador;

        }
        #endregion
    }
}
