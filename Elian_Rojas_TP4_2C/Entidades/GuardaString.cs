using System;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// Guarda un texto en un archivo en el escritorio
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static bool Guardar( this string texto, string archivo )
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullpath = path + "\\" + archivo;
            StreamWriter writer = null;

            bool append = false;

            try
            {
                if (File.Exists(fullpath))
                {
                    append = true;
                }

                writer = new StreamWriter(fullpath, append);
                writer.WriteLine(texto);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}