using Excepciones;
using System;
using System.IO;

namespace Archivos
{
    public class Texto: IArchivo<string>
    {
        /// <summary>
        /// Guarda un archivo en formato texto
        /// </summary>
        /// <param name="archivo">Ruta completa donde se guarda el archivo archivo</param>
        /// <param name="texto">Texto que contendra ese archivo</param>
        /// <returns>True si se guarda correctamente , false si hubo un problema</returns>
        public bool Guardar( string archivo, string texto )
        {
            StreamWriter writer = null;
            bool guardado = true;
            try
            {
                writer = new StreamWriter(archivo, false);
                writer.Write(texto);
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
        /// Lee el contenido de un archivo de texto
        /// </summary>
        /// <param name="archivo">Ruta completa donde se guarda el archivo de texto</param>
        /// <param name="texto">Parametro que guardara el texto que contenia el archivo</param>
        /// <returns>True si se lee correctamente , false si hubo un problema</returns>
        public bool Leer( string archivo, out string texto )
        {
            StreamReader reader = null;
            bool leyo = true;
            try
            {
                if (!(File.Exists(archivo)))
                {
                    leyo = false;
                    throw new ArchivosException(new FileNotFoundException());
                }
                else
                {
                    reader = new StreamReader(archivo);
                    texto = reader.ReadToEnd();
                }
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