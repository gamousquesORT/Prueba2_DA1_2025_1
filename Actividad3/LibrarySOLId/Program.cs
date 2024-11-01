
namespace LibrarySOLID;

    class Program
    {
        static void Main(string[] args)
        {
            BiblioApp biblioApp = new BiblioApp();

            RolEstudiante estudiante = new RolEstudiante(biblioApp);
            RolBibliotecario librero = new RolBibliotecario(biblioApp);

            // Example usage
            estudiante.PedirPrestadoLibro("book123");
            estudiante.DevolverLibro("book123");

            librero.ComprarLibro("book456");
            librero.EliminarLibro("book456");

            // Generate report
            biblioApp.ReporteCompras();
        }
    }
