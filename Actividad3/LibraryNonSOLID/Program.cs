
namespace LibraryNonSOLID;

    class Program
    {
        static void Main(string[] args)
        {
            BiblioSoftware biblioSoftware = new BiblioSoftware();

            OperacionesEstudiante operacionesEstudiante = new OperacionesEstudiante(biblioSoftware);
            OperacionesBibliotecario librero = new OperacionesBibliotecario(biblioSoftware);

            // Example usage
            operacionesEstudiante.PedirPrestadoLibro("book123");
            operacionesEstudiante.DevolverLibro("book123");

            librero.ComprarLibro("book456");
            librero.EliminarLibro("book456");

            // Generate report
            biblioSoftware.ReporteCompras();
        }
    }
