using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;


namespace Test_unitarios
{
    [TestClass]
    public class TestCorreo
    {
        /// <summary>
        ///  verifica que la lista de Paquetes del Correo esté instanciada.
        /// </summary>
        [TestMethod]
        public void TestCorreoInstanciado()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }

        /// <summary>
        /// verifica que no se puedan cargar dos Paquetes con el mismo Tracking ID.*/
        /// </summary>
        [TestMethod]
        public void TestCargaPaquetesIguales()
        {
            Correo correo = new Correo();
            Paquete paquete1 = new Paquete("123", "x");
            Paquete paquete2 = new Paquete("123", "x");
            bool ok = false;

            try
            {
                correo += paquete1;
                correo += paquete2;
            }
            catch (TrackingIdRepetidoException)
            {
                ok = true;
            }

            Assert.IsTrue(ok);

        }

    }
}
