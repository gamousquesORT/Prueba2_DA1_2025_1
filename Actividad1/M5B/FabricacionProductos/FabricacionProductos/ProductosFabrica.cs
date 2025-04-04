namespace FabricacionProductos;
public interface IListable
{
    string GetNumeroSerie();
}
public class Fabrica
{
    private List<Producto> _productos;
    public string Nombre { get; set; }
    public List<Producto> Productos => _productos;
    public Fabrica()
    {
        Nombre = string.Empty;
        _productos = new List<Producto>();
    }
    public void CrearProducto()
    {
        Producto producto = new Producto(Nombre);
        Productos.Add(producto);
    }
}

public class Producto : IListable
{
    private static long _siguienteNumeroDeSerie = 0;
    private long _numeroDeSerie;
    public string Nombre { get; set; }
    public Producto(string nombreFabrica)
    {
        _numeroDeSerie = ++_siguienteNumeroDeSerie;
        Nombre = nombreFabrica + "__"+ _numeroDeSerie.ToString();
    }
    public string GetNumeroSerie()
    {
        return Nombre;
    }
}

