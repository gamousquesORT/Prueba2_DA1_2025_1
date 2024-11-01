using Console = System.Console;

namespace LibrarySOLID;

public interface IBiblioAppEstudiante
{
    public void Prestar(string bookId);
    public void Devolver(string bookId);
}

public interface IBiblioAppBibliotecario
{
    public void Comprar(string bookId);
    public void EliminarLibro(string bookId);
    public void ReporteCompras();
}

public class BiblioApp : IBiblioAppEstudiante, IBiblioAppBibliotecario
{
    public void Prestar(string bookId)
    {
        Console.WriteLine("Código para retirar un libro en préstamo");
    }

    public void Devolver(string bookId)
    {
        Console.WriteLine("Código para devolver un libro prestado");
    }

    public void Comprar(string bookId)
    {
        Console.WriteLine("Código para comprar un libro");
    }

    public void EliminarLibro(string bookId)
    {
        Console.WriteLine("Código para sacar un libro del catalogo de la biblioteca");
    }

    public void ReporteCompras()
    {
        Console.WriteLine("Código para generar un reporte de compras de libros");

    }
}