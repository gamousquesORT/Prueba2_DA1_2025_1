namespace LibraryNonSOLID;

public class OperacionesEstudiante
{
    private BiblioSoftware _biblioSoftware;
    
    public OperacionesEstudiante(BiblioSoftware biblioSoftware)
    {
        _biblioSoftware = biblioSoftware;    
    }
    
    public void PedirPrestadoLibro(string bookId)
    {
        _biblioSoftware.Prestar(bookId);
    }
    
    public void DevolverLibro(string bookId)
    {
        _biblioSoftware.Devolver(bookId);
    }
    
}

public class OperacionesBibliotecario
{
    private BiblioSoftware _biblioSoftware;
    
    public OperacionesBibliotecario(BiblioSoftware biblioSoftware)
    {
        _biblioSoftware = biblioSoftware;    
    }
    public void ComprarLibro(string bookId)
    {
        _biblioSoftware.Comprar(bookId);
    }
    
    public void EliminarLibro(string bookId)
    {
        _biblioSoftware.EliminarLibro(bookId);
    }
    
}