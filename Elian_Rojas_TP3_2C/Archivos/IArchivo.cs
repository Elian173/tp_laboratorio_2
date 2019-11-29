namespace Archivos
{
    /// <summary>
    /// Interfaz de archivos
    /// </summary>
    /// <typeparam name="T">Tipo del objeto a guardar o leer en el archivo</typeparam>
    internal interface IArchivo<T>
    {
        bool Guardar( string archivo, T datos );

        bool Leer( string archivo, out T datos );
    }
}