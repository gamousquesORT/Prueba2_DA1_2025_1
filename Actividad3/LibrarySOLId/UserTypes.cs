namespace LibrarySOLID;

public class RolEstudiante
{
    private IBiblioAppEstudiante _biblioApp;
    
    public RolEstudiante(IBiblioAppEstudiante biblioApp)
    {
        _biblioApp = biblioApp;    
    }
    
    public void PedirPrestadoLibro(string bookId)
    {
        _biblioApp.Prestar(bookId);
    }

    public void DevolverLibro(string bookId)
    {
        _biblioApp.Devolver(bookId);
    }
}


public class RolBibliotecario
{
    private IBiblioAppBibliotecario _biblioApp;
    
    public RolBibliotecario(IBiblioAppBibliotecario biblioApp)
    {
        _biblioApp = biblioApp;    
    }
    public void ComprarLibro(string bookId)
    {
        _biblioApp.Comprar(bookId);
    }
    
    public void EliminarLibro(string bookId)
    {
        _biblioApp.EliminarLibro(bookId);
    }
    
}