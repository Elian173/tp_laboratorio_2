using Clases_Instanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitarios
{
    [TestClass]
    public class TestExcepciones
    {
        [TestMethod]
        public void TestNacionaildadInvalidaEx()
        {
            bool argentinoValido = true;
            bool extranjeroValido = true;

            try
            {
                Alumno pruebaArg = new Alumno(1, "a", "a", "99999999", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            }
            catch (NacionalidadInvalidaException)
            {
                argentinoValido = false;
            }

            try
            {
                Alumno pruebaExt = new Alumno(2, "e", "e", "11111111", EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            }
            catch (NacionalidadInvalidaException)
            {
                extranjeroValido = false;
            }

            Assert.IsFalse(argentinoValido);
            Assert.IsFalse(extranjeroValido);
        }

        [TestMethod]
        public void TestAlumnoRepetidoEx()
        {
            bool dniIguales = false;
            bool legajosIguales = false;
            bool tipoDiferente = true;

            Universidad uni = new Universidad();

            Alumno mismoDni1 = new Alumno(10, "a", "a", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            Alumno mismoDni2 = new Alumno(11, "José", "Gutierrez", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);

            Alumno mismoLegajo1 = new Alumno(1, "a", "a", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            Alumno mismoLegajo2 = new Alumno(1, "a", "a", "55555555", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);

            Profesor tipoDiferenteMismoDni = new Profesor(30, "a", "a", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino);
            Profesor tipoDiferenteMismoLegajo = new Profesor(1, "a", "a", "44444444", EntidadesAbstractas.Persona.ENacionalidad.Argentino);

            //Compara dni
            try
            {
                uni += mismoDni1;
                uni += mismoDni2;
            }
            catch (AlumnoRepetidoException)
            {
                dniIguales = true;
            }

            //Compara legajos
            try
            {
                uni += mismoLegajo1;
                uni += mismoLegajo1;
            }
            catch (AlumnoRepetidoException)
            {
                legajosIguales = true;
            }

            //Diferencia profesores de alumnos
            try
            {
                uni += tipoDiferenteMismoDni;
                uni += tipoDiferenteMismoLegajo;
            }
            catch (AlumnoRepetidoException)
            {
                tipoDiferente = false;
            }

            Assert.IsTrue(dniIguales);
            Assert.IsTrue(legajosIguales);
            Assert.IsTrue(tipoDiferente);
        }
    }
}