using Clases_Instanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitarios
{
    [TestClass]
    public class TestMetodos
    {
        [TestMethod]
        public void TestValidarNombreApellido()
        {
            string valorEsperado1 = "Elian";
            string valorEsperado2 = string.Empty;
            string valorEsperado3 = string.Empty;
            string valorEsperado4 = string.Empty;
            string valorEsperado5 = string.Empty;

            Alumno prueba1 = new Alumno(1, "Elian", "Rojas", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            Alumno prueba2 = new Alumno(1, "E2324lian", "Rojas", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            Alumno prueba3 = new Alumno(1, " ", "Rojas", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            Alumno prueba4 = new Alumno(1, "aaaaaaaaaaaaaaaaaaaaaaaaaa", "Rojas", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            Alumno prueba5 = new Alumno(1, null, "Rojas", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);

            Assert.AreEqual(valorEsperado1, prueba1.Nombre);
            Assert.AreEqual(valorEsperado2, prueba2.Nombre);
            Assert.AreEqual(valorEsperado3, prueba3.Nombre);
            Assert.AreEqual(valorEsperado4, prueba4.Nombre);
            Assert.AreEqual(valorEsperado5, prueba5.Nombre);
        }

    }
}