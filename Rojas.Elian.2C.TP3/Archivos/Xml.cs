using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System;

namespace Archivos
{
    public class Xml<T>: IArchivo<T>
    {
        /// <summary>
        /// Guarda datos en un archivo tipo Xml
        /// </summary>
        /// <param name="archivo">Ruta completa donde se guardara el archivo</param>
        /// <param name="datos">Datos a guardar en el archivo</param>
        /// <returns>True si guarda correctamente , False si no</returns>
        public bool Guardar( string archivo, T datos )
        {

            XmlTextWriter writer = null;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            bool guardado = true;
            try
            {
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                serializer.Serialize(writer, datos);
            }
            catch (Exception)
            {
                guardado = false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }

            return guardado;

        }

        /// <summary>
        /// Lee el contenido de un archivo xml
        /// </summary>
        /// <param name="archivo">Ruta completa donde se encuentra el archivo</param>
        /// <param name="datos">Datos leidos desde el archivo</param>
        /// <returns>True si leyo correctamente , False si no</returns>
        public bool Leer( string archivo, out T datos )
        {
            XmlTextReader reader = null;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            bool leyo = true;
            try
            {
                reader = new XmlTextReader(archivo);
                datos = (T) serializer.Deserialize(reader);
            }
            catch (Exception)
            {
                leyo = false;
                datos = default(T);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return leyo;
        }
    }
}