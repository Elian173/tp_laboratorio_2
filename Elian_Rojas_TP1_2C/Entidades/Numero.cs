using System;
using System.Collections.Generic;
using System.Text;



namespace Entidades
{
    public class Numero
    {

        private double numero;

        #region Propiedad
        /// <summary>
        /// Propiedad que valida e inicializa un objeto Numero
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa una instancia "Numero" con valor 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Inicializa una instancia "Numero" con valor "numero"
        /// </summary>
        /// <param name="numero">Valor tipo double a asignar al nuevo objeto Numero</param>
        public Numero( double numero )
        {
            this.numero = numero;
        }

        /// <summary>
        /// Inicializa una instancia "Numero" con valor "numero" , valida que sea un valor valido 
        /// </summary>
        /// <param name="numero">Valor tipo string a asignar al nuevo objeto Numero</param>
        public Numero( string numero )
        {
            SetNumero = numero;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Valida que un dato del tipo string sea convertible en un dato del tipo double.Si el string esta
        /// vacio , se le asigna 0
        /// </summary>
        /// <param name="numero">String a validar</param>
        /// <returns>Devuelve el equivalente en formato "double" o 0 si no se puedo convertir</returns>
        private static double ValidarNumero( string numero )
        {

            double validado = new double();

            if (string.IsNullOrEmpty(numero))
            {
                numero = "0";
            }

            if (double.TryParse(numero, out validado))
            {
                return validado;
            }

            return 0;

        }

        /// <summary>
        /// Valida el binario recibido, y lo transforma en su equivalente decimal , se asigna 0 si el string estaba vacio.
        /// </summary>
        /// <param name="binario">El binario a validar y transformar</param>
        /// <returns>Devuelve el equivalente al binario en decimal , o "Valor Invalido" si no se pudo convertir.</returns>
        public static string BinarioDecimal( string binario )
        {

            int conversion;

            if (string.IsNullOrEmpty(binario))
            {
                binario = "0";
            }

            //Validacion

            for (int i = 0; i < binario.Length; i++)
            {

                if (binario[i] != '0' && binario[i] != '1')
                {
                    return "Valor Invalido";
                }

            }

            //Conversion

            conversion = Convert.ToInt32(binario, 2);

            return conversion.ToString();


        }

        /// <summary>
        /// Valida el decimal recibido, y lo transforma en su equivalente binario , se asigna 0 si el string estaba vacio.
        /// </summary>
        /// <param name="numero">El decimal a transformar</param>
        /// <returns>El equivalente binario del decimal , o "Valor Invalido" si no se pudo convertir</returns>
        public static string DecimalBinario( string numero )
        {

            double validado = new double();

            if (string.IsNullOrEmpty(numero))
            {
                validado = -1;
            }

            if (!double.TryParse(numero, out validado))
            {
                validado = -1;
            }

            return DecimalBinario(validado);

        }

        /// <summary>
        /// Valida el decimal recibido, y lo transforma en su equivalente binario.
        /// </summary>
        /// <param name="numero">El decimal a transformar</param>
        /// <returns>El equivalente binario del decimal , o "Valor Invalido" si no se pudo convertir , o 0 si el numero valia 0</returns>
        public static string DecimalBinario( double numero )
        {

            if (numero == -1)
            {
                return "Valor Invalido";
            }

            if (numero == 0)
            {
                return "0";
            }

            Math.Abs(numero);
            int numeroEntero = (int) numero;
            string resultado = string.Empty;

            while (numeroEntero > 0)
            {

                resultado = (numeroEntero % 2) + resultado;
                numeroEntero = (int) numeroEntero / 2;

            }


            return resultado;

        }


        #endregion

        #region Operadores

        /// <summary>
        /// Sobrecarga del operador '+' que suma los atributos "numero" entre dos objetos del tipo "Numero".
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>La suma de ambos numeros</returns>
        public static double operator +( Numero n1, Numero n2 )
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;

        }

        /// <summary>
        /// Sobrecarga del operador '-' que resta los atributos "numero" entre dos objetos del tipo "Numero".
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>La resta de ambos numeros</returns>
        public static double operator -( Numero n1, Numero n2 )
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;

        }

        /// <summary>
        /// Sobrecarga del operador '/' que divide los atributos "numero" entre dos objetos del tipo "Numero".
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>La division entre los 2 numeros , o double.MinValue en caso de que el segundo numero sea 0</returns>
        public static double operator /( Numero n1, Numero n2 )
        {
            double resultado;

            if (n2.numero == 0)
            {
                return double.MinValue;
            }

            resultado = n1.numero / n2.numero;

            return resultado;

        }

        /// <summary>
        /// Sobrecarga del operador '*' que multiplica los atributos "numero" entre dos objetos del tipo "Numero".
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>La multiplicacion entre ambos numeros</returns>
        public static double operator *( Numero n1, Numero n2 )
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;

        }

        #endregion

    }

}







