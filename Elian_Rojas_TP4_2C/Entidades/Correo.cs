using System.Collections.Generic;
using System.Threading;

namespace Entidades
{
    public class Correo: IMostrar<List<Paquete>>
    {
        #region Atributos
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        #endregion

        #region Constructores

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        #endregion Constructores

        #region Propiedades

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        #endregion Propiedades

        #region Metodos

        //interfaz
        /// <summary>
        /// Retorna los datos de todos los paquetes
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos( IMostrar<List<Paquete>> elementos )
        {
            string descripcion = string.Empty;

            foreach (Paquete paquete in ((Correo) elementos).Paquetes)
            {
                descripcion += string.Format("{0} para {1} ({2}) \n", paquete.TrackingID, paquete.DireccionEntrega, paquete.Estado.ToString());
            }
            return descripcion;
        }

        /// <summary>
        /// Termina con la ejecucion de todos los hilos
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread hilo in this.mockPaquetes)
            {
                if (hilo != null && hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }

        #endregion Metodos

        #region Sobrecarga operadores

        /// <summary>
        /// Agrega un paquete a la lista de Correo , verificando que no sea repetido
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +( Correo c, Paquete p )
        {
            foreach (Paquete paquete in c.paquetes)
            {
                if (paquete == p)
                {
                    throw new TrackingIdRepetidoException("El paquete con ID:" + paquete.TrackingID + " ya esta cargado");
                }
            }

            c.paquetes.Add(p);

            Thread hilo = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hilo);
            hilo.Start();

            return c;
        }

        #endregion Sobrecarga operadores
    }
}