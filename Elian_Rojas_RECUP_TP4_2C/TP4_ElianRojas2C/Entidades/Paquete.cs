using System;
using System.Threading;

/*Paquete
1. Implementar la interfaz IMostrar, siendo su tipo genérico Paquete. 2. MostrarDatos utilizará string.Format con el siguiente formato "{0} para {1}", p.trackingID,
p.direccionEntrega para compilar la información del paquete.
3. La sobrecarga del método ToString retornará la información del paquete.
4. Dos paquetes serán iguales siempre y cuando su Tracking ID sea el mismo.
5. MockCicloDeVida hará que el paquete cambie de estado de la siguiente forma:
a. Colocar una demora de 4 segundos.
b. Pasar al siguiente estado.
c. Informar el estado a través de InformarEstado. EventArgs no tendrá ningún dato extra.
d. Repetir las acciones desde el punto A hasta que el estado sea Entregado.
e. Finalmente guardar los datos del paquete en la base de datos*/

namespace Entidades
{
    public class Paquete: IMostrar<Paquete>
    {
        #region Tipos Anidados

        public delegate void DelegadoEstado( object sende, EventArgs e );

        public delegate void DelegadoException( object sender, Exception errorProducido , Paquete paqueteError);

        public enum EEstado
        {
            Ingresado, EnViaje, Entregado
        }

        #endregion Tipos Anidados

        #region Eventos

        public event DelegadoEstado InformaEstado;

        public event DelegadoException InformaError;

        #endregion Eventos

        #region Atributos

        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        #endregion Atributos

        #region Propiedades

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        #endregion Propiedades

        #region Constructores

        public Paquete( string trackingID, string direccionEntrega )
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }

        #endregion Constructores

        #region Metodos

        /// <summary>
        /// Muesta los datos de un paquete
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos( IMostrar<Paquete> elemento )
        {
            Paquete paquete = (Paquete) elemento;
            string descripcion = string.Format("{0} para {1}", paquete.trackingID, paquete.direccionEntrega);
            return descripcion;
        }

        /// <summary>
        /// Muestra lso datos d eun paquete
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string descripcion = this.MostrarDatos(this);
            return descripcion;
        }

        /// <summary>
        /// Simula el envio de un paquete
        /// </summary>
        public void MockCicloDeVida()
        {
            this.estado = EEstado.Ingresado;

            while (this.estado != EEstado.Entregado)
            {
                Thread.Sleep(4000);
                this.estado++;
                this.InformaEstado(this, null);
            }
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception e)
            {
                this.InformaError(this, e , this);
            }
        }

        #endregion Metodos

        #region Sobrecarga de operadores

        /// <summary>
        /// Compara dos paquetes en base a su tracking Id
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==( Paquete p1, Paquete p2 )
        {
            if (p1.trackingID == p2.trackingID)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Compara dos paquetes en base a su tracking Id
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=( Paquete p1, Paquete p2 )
        {
            if (!(p1 == p2))
            {
                return true;
            }
            return false;
        }

        #endregion Sobrecarga de operadores
    }
}