using FabricacionProductos;

namespace FabricacionProductos; 

public class Program
{
    public static void Main(string[] args)
    {
        Fabrica fabrica = new Fabrica();
        fabrica.Nombre = "Ferrari";

        LoadPiezas(fabrica);

        IterateThroughProductos(fabrica);
        
        AnotherIterateThroughtProducts(fabrica);
    }

    private static void LoadPiezas(Fabrica fabricante)
    {
        for (int i = 1; i <= 5; i++)
        {
            fabricante.CrearProducto();
        }
    }

    public static void IterateThroughProductos(Fabrica fabrica)
    {
        foreach (IListable prd in fabrica.Productos)
        {
            Console.WriteLine($"Serie: {prd.GetNumeroSerie()}");
        }
    }

    public static void AnotherIterateThroughtProducts(Fabrica fabrica)
    {
        foreach (Producto prd in fabrica.Productos)
        {
            Console.WriteLine($"Serie: {prd.GetNumeroSerie()}");
        }
    }
}